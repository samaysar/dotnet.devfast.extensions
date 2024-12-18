namespace DevFast.Net.Extensions.Tests.SystemTypes
{
    [TestFixture]
    public class DataCollectionsTests
    {
        [Test]
        public void IList_Chunk_WorksWell_On_Empty_List()
        {
            List<int> l = new(0);
            That(l.Chunk(1, Token.None).Count(), Is.EqualTo(0));
        }

        [Test]
        public void IList_Chunk_WorksWell_On_Shorter_List_Compared_To_Chunk_Size()
        {
            List<int> l = new(1) { 1 };
            That(l.Chunk(1, Token.None).Count(), Is.EqualTo(1));
            That(l.Chunk(1, Token.None).First().Count(), Is.EqualTo(1));
            l = Enumerable.Range(0, 10).ToList();
            That(l.Chunk(10, Token.None).Count(), Is.EqualTo(1));
            That(l.Chunk(10, Token.None).First().Count(), Is.EqualTo(10));
            l = Enumerable.Range(0, 10).ToList();
            That(l.Chunk(20, Token.None).Count(), Is.EqualTo(1));
            That(l.Chunk(20, Token.None).First().Count(), Is.EqualTo(10));
        }

        [Test]
        public void IList_Chunk_WorksWell_On_Larger_List_Compared_To_Chunk_Size()
        {
            List<int> l = Enumerable.Range(0, 10).ToList();
            That(l.Chunk(1, Token.None).Count(), Is.EqualTo(10));
            l.Chunk(1, Token.None).ForEach((x, _) => That(x.Count(), Is.EqualTo(1)));
            That(l.Chunk(2, Token.None).Count(), Is.EqualTo(5));
            l.Chunk(2, Token.None).ForEach((x, _) => That(x.Count(), Is.EqualTo(2)));
            That(l.Chunk(5, Token.None).Count(), Is.EqualTo(2));
            l.Chunk(5, Token.None).ForEach((x, _) => That(x.Count(), Is.EqualTo(5)));
            That(l.Chunk(3, Token.None).Count(), Is.EqualTo(4));
            l.Chunk(3, Token.None).ForEach((x, _) => That(x.Count().Equals(3) || x.Count().Equals(1), Is.True));
            That(l.Chunk(7, Token.None).Count(), Is.EqualTo(2));
            l.Chunk(7, Token.None).ForEach((x, _) => That(x.Count().Equals(7) || x.Count().Equals(3), Is.True));
            That(l.Chunk(9, Token.None).Count(), Is.EqualTo(2));
            l.Chunk(9, Token.None).ForEach((x, _) => That(x.Count().Equals(9) || x.Count().Equals(1), Is.True));
        }

        [Test]
        public void IList_Chunk_Works_With_Reset()
        {
            using Cts cts = new();
            IEnumerable<int> l = Enumerable.Range(0, 10).ToList().Chunk(3, cts.Token).Skip(1).First();
            int start = 3;
            using IEnumerator<int> le = l.GetEnumerator();
            while (le.MoveNext())
            {
                That(le.Current, Is.EqualTo(start++));
            }
            le.Reset();
            That(start, Is.EqualTo(6));
            start = 3;
            while (le.MoveNext())
            {
                That(le.Current, Is.EqualTo(start++));
            }
            That(start, Is.EqualTo(6));
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void IList_Chunk_Correctly_Uses_CancellationToken_During_Chunk_Enumeration(bool useTokenInChunkEnumeration)
        {
            using Cts cts = new();
            System.Collections.IEnumerable l = Enumerable.Range(0, 10).ToList().Chunk(3, cts.Token, useTokenInChunkEnumeration).Skip(1).First();
            System.Collections.IEnumerator le = l.GetEnumerator();
            int start = 3;
            if (useTokenInChunkEnumeration)
            {
                OperationCanceledException? e = Throws<OperationCanceledException>(() =>
                {
                    while (le.MoveNext())
                    {
                        That(le.Current, Is.EqualTo(start++));
                        cts.Cancel();
                    }
                });
                That(start, Is.EqualTo(4));
                That(e, Is.Not.Null);
            }
            else
            {
                while (le.MoveNext())
                {
                    That(le.Current, Is.EqualTo(start++));
                    cts.Cancel();
                }
                That(start, Is.EqualTo(6));
            }
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void IList_Chunk_Correctly_Uses_CancellationToken_During_Chunk_Creation(bool useTokenInChunkEnumeration)
        {
            using Cts cts = new();
            IEnumerable<IEnumerable<int>> l = Enumerable.Range(0, 10).ToList().Chunk(3, cts.Token, useTokenInChunkEnumeration);
            using IEnumerator<IEnumerable<int>> le = l.GetEnumerator();
            int start = 0;
            OperationCanceledException? e = Throws<OperationCanceledException>(() =>
            {
                while (le.MoveNext())
                {
                    IEnumerable<int> chunk = le.Current;
                    using IEnumerator<int> chunkEnum = chunk.GetEnumerator();
                    while (chunkEnum.MoveNext())
                    {
                        That(chunkEnum.Current, Is.EqualTo(start++));
                    }
                    start = 0;
                    chunkEnum.Reset();
                    while (chunkEnum.MoveNext())
                    {
                        That(chunkEnum.Current, Is.EqualTo(start++));
                    }
                    cts.Cancel();
                }
            });
            That(e, Is.Not.Null);
            That(start, Is.EqualTo(3));
        }
    }
}
