#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.SystemTypes](DevFast.Net.Extensions.SystemTypes.md 'DevFast.Net.Extensions.SystemTypes')

## DataCollections Class

Extension methods on various data-collection e.g. [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').

```csharp
public static class DataCollections
```
- *Methods*
  - **[Chunk&lt;T&gt;(this IList&lt;T&gt;, int, CancellationToken, bool)](DevFast.Net.Extensions.SystemTypes.DataCollections.md#DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool) 'DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk<T>(this System.Collections.Generic.IList<T>, int, System.Threading.CancellationToken, bool)')**

## DataCollections Class

Extension methods on various data-collection e.g. [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').

```csharp
public static class DataCollections
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DataCollections
### Methods

<a name='DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool)'></a>

## DataCollections.Chunk<T>(this IList<T>, int, CancellationToken, bool) Method

Splits the elements of given [list](DevFast.Net.Extensions.SystemTypes.DataCollections.md#DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool).list 'DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk<T>(this System.Collections.Generic.IList<T>, int, System.Threading.CancellationToken, bool).list') into chunks of [maxSize](DevFast.Net.Extensions.SystemTypes.DataCollections.md#DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool).maxSize 'DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk<T>(this System.Collections.Generic.IList<T>, int, System.Threading.CancellationToken, bool).maxSize')
WITHOUT re-allocating the memory while observing the provided [token](DevFast.Net.Extensions.SystemTypes.DataCollections.md#DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool).token 'DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk<T>(this System.Collections.Generic.IList<T>, int, System.Threading.CancellationToken, bool).token').

```csharp
public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> Chunk<T>(this System.Collections.Generic.IList<T> list, int maxSize, System.Threading.CancellationToken token, bool observeTokenInChunkEnumeration=false);
```
#### Type parameters

<a name='DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool).list'></a>

`list` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](DevFast.Net.Extensions.SystemTypes.DataCollections.md#DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool).T 'DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk<T>(this System.Collections.Generic.IList<T>, int, System.Threading.CancellationToken, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

Collection on which chunks will be created.

<a name='DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool).maxSize'></a>

`maxSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Maximum size of a given chunk

<a name='DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token to observe.

<a name='DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool).observeTokenInChunkEnumeration'></a>

`observeTokenInChunkEnumeration` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') token cancellation is observed during chunk enumeration (may slow-down enumeration)

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Extensions.SystemTypes.DataCollections.md#DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk_T_(thisSystem.Collections.Generic.IList_T_,int,System.Threading.CancellationToken,bool).T 'DevFast.Net.Extensions.SystemTypes.DataCollections.Chunk<T>(this System.Collections.Generic.IList<T>, int, System.Threading.CancellationToken, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')