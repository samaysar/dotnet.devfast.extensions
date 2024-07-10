#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.SystemTypes](DevFast.Net.Extensions.SystemTypes.md 'DevFast.Net.Extensions.SystemTypes')

## Enumerables Class

Extension methods on [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').

```csharp
public static class Enumerables
```
- *Methods*
  - **[ForEach&lt;T&gt;(this IEnumerable&lt;T&gt;, Action&lt;T,CancellationToken&gt;, CancellationToken)](DevFast.Net.Extensions.SystemTypes.Enumerables.md#DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken) 'DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T,System.Threading.CancellationToken>, System.Threading.CancellationToken)')**

## Enumerables Class

Extension methods on [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').

```csharp
public static class Enumerables
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Enumerables
### Methods

<a name='DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken)'></a>

## Enumerables.ForEach<T>(this IEnumerable<T>, Action<T,CancellationToken>, CancellationToken) Method

Calls [lambda](DevFast.Net.Extensions.SystemTypes.Enumerables.md#DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken).lambda 'DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T,System.Threading.CancellationToken>, System.Threading.CancellationToken).lambda') for every item in [collection](DevFast.Net.Extensions.SystemTypes.Enumerables.md#DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken).collection 'DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T,System.Threading.CancellationToken>, System.Threading.CancellationToken).collection') with given [token](DevFast.Net.Extensions.SystemTypes.Enumerables.md#DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken).token 'DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T,System.Threading.CancellationToken>, System.Threading.CancellationToken).token').

```csharp
public static void ForEach<T>(this System.Collections.Generic.IEnumerable<T> collection, System.Action<T,System.Threading.CancellationToken> lambda, System.Threading.CancellationToken token=default(System.Threading.CancellationToken));
```
#### Type parameters

<a name='DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken).collection'></a>

`collection` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](DevFast.Net.Extensions.SystemTypes.Enumerables.md#DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken).T 'DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T,System.Threading.CancellationToken>, System.Threading.CancellationToken).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Enumerable items

<a name='DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](DevFast.Net.Extensions.SystemTypes.Enumerables.md#DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken).T 'DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T,System.Threading.CancellationToken>, System.Threading.CancellationToken).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

predicate to apply

<a name='DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token to pass on to the supplied [lambda](DevFast.Net.Extensions.SystemTypes.Enumerables.md#DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T,System.Threading.CancellationToken_,System.Threading.CancellationToken).lambda 'DevFast.Net.Extensions.SystemTypes.Enumerables.ForEach<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T,System.Threading.CancellationToken>, System.Threading.CancellationToken).lambda')