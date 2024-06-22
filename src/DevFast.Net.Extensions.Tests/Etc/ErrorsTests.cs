using DevFast.Net.Extensions.Etc;

namespace DevFast.Net.Extensions.Tests.Etc;

[TestFixture]
public class ErrorsTests
{
    [Test]
    public void TryExecute_Catch_Exception_From_Generic_Type()
    {
        TaskCompletionSource<object> tcs = new();
        Task<object> t = tcs.Task;
        C.WriteLine(t.Status);
        t.Start();
        C.WriteLine(t.Run().Status);
        //int count = 0;
        //Action action = static void () => throw new OperationCanceledException("Testing");
        //action.TryExecute<OperationCanceledException>((__, e) =>
        //{
        //    _ = Interlocked.Increment(ref count);
        //    That(e is not null, Is.True);
        //});
        //action = static void () => throw new TaskCanceledException("Task");
        //action.TryExecute<OperationCanceledException>((__, e) =>
        //{
        //    _ = Interlocked.Increment(ref count);
        //    That(e is TaskCanceledException, Is.True);
        //});
        //action = static void () => throw new InvalidOperationException("Op");
        //InvalidOperationException? ex = Throws<InvalidOperationException>(() => action.TryExecute<OperationCanceledException>((_, e) => Console.WriteLine(e)));
        //Multiple(() =>
        //{
        //    That(count, Is.EqualTo(2));
        //    That(ex, Is.Not.Null);
        //    That(ex.Message, Is.EqualTo("Op"));
        //});
    }
}
