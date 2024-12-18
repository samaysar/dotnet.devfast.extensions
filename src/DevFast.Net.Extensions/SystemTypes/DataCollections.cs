using DevFast.Net.Extensions.Etc;

namespace DevFast.Net.Extensions.SystemTypes;

/// <summary>
/// Extension methods on various data-collection e.g. <see cref="IList{T}"/>.
/// </summary>
public static class DataCollections
{
    /// <summary>
    /// Splits the elements of given <paramref name="list"/> into chunks of <paramref name="maxSize"/>
    /// WITHOUT re-allocating the memory while observing the provided <paramref name="token"/>.
    /// </summary>
    /// <param name="list">Collection on which chunks will be created.</param>
    /// <param name="maxSize">Maximum size of a given chunk</param>
    /// <param name="token">Cancellation token to observe.</param>
    /// <param name="observeTokenInChunkEnumeration">When <see langword="true"/> token cancellation is observed during chunk enumeration (may slow-down enumeration)</param>
    public static IEnumerable<IEnumerable<T>> ToChunks<T>(this IList<T> list,
        int maxSize,
        Token token,
        bool observeTokenInChunkEnumeration = false)
    {
        if (list.Count.Equals(0))
        {
            yield break;
        }

        if (list.Count <= maxSize.ThrowArgumentExceptionOnPredicateFail(static x => x >= 1, nameof(maxSize), $"{nameof(maxSize)} >= 1"))
        {
            yield return list;
            yield break;
        }

        int i = 0;
        while (i < list.Count)
        {
            token.ThrowIfCancellationRequested();
            yield return new ListChunkEnumerable<T>(list, i, maxSize, observeTokenInChunkEnumeration ? token : Token.None);
            i += maxSize;
        }
    }

    private sealed class ListChunkEnumerable<T>(IList<T> list, int start, int maxSize, Token token) : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            return token.CanBeCanceled
                ? new CancellableListChunkEnumerator(
                list,
                start.ThrowArgumentExceptionOnPredicateFail(
                    x => x < list.Count,
                    nameof(start),
                    $"{nameof(start)} < {nameof(list)}.{nameof(list.Count)}"
                ),
                Math.Min(list.Count, start + maxSize),
                token
            ) : new ListChunkEnumerator(
                list,
                start.ThrowArgumentExceptionOnPredicateFail(
                    x => x < list.Count,
                    nameof(start),
                    $"{nameof(start)} < {nameof(list)}.{nameof(list.Count)}"
                ),
                Math.Min(list.Count, start + maxSize)
            );
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private sealed class CancellableListChunkEnumerator : IEnumerator<T>
        {
            private int _idx;
            private readonly int _beginIncl;
            private readonly int _endExcl;
            private readonly Token _token;
            private IList<T>? _list;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
            public CancellableListChunkEnumerator(IList<T> list, int beginIncl, int endExcl, Token token)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
            {
                _list = list;
                _idx = beginIncl;
                _beginIncl = beginIncl;
                _endExcl = endExcl;
                _token = token;
            }

            public T Current { get; private set; }

#pragma warning disable CS8603 // Possible null reference return.
            object System.Collections.IEnumerator.Current => Current;
#pragma warning restore CS8603 // Possible null reference return.

            public void Dispose()
            {
                _list = null;
            }

            public bool MoveNext()
            {
                _token.ThrowIfCancellationRequested();
                if (_idx < _endExcl)
                {
                    Current = _list![_idx++];
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                _idx = _beginIncl;
            }
        }

        private sealed class ListChunkEnumerator : IEnumerator<T>
        {
            private int _idx;
            private readonly int _beginIncl;
            private readonly int _endExcl;
            private IList<T>? _list;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
            public ListChunkEnumerator(IList<T> list, int beginIncl, int endExcl)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
            {
                _list = list;
                _idx = beginIncl;
                _beginIncl = beginIncl;
                _endExcl = endExcl;
            }

            public T Current { get; private set; }

#pragma warning disable CS8603 // Possible null reference return.
            object System.Collections.IEnumerator.Current => Current;
#pragma warning restore CS8603 // Possible null reference return.

            public void Dispose()
            {
                _list = null;
            }

            public bool MoveNext()
            {
                if (_idx < _endExcl)
                {
                    Current = _list![_idx++];
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                _idx = _beginIncl;
            }
        }
    }
}
