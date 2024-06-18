#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.Etc](DevFast.Net.Extensions.Etc.md 'DevFast.Net.Extensions.Etc')

## Lambdas Class

Extension methods on the lambdas.

```csharp
public static class Lambdas
```
- *Methods*
  - **[Apply&lt;T&gt;(this Func&lt;CancellationToken,T&gt;, Func&lt;Func&lt;CancellationToken,T&gt;,Func&lt;CancellationToken,T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<System.Func<System.Threading.CancellationToken,T>,System.Func<System.Threading.CancellationToken,T>>, bool)')**
  - **[Apply&lt;T&gt;(this Func&lt;T&gt;, Func&lt;Func&lt;T&gt;,Func&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<T>, System.Func<System.Func<T>,System.Func<T>>, bool)')**
  - **[Apply&lt;TSource,TTransformed&gt;(this Func&lt;CancellationToken,TSource&gt;, Func&lt;Func&lt;CancellationToken,TSource&gt;,Func&lt;CancellationToken,TTransformed&gt;&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__) 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<System.Func<System.Threading.CancellationToken,TSource>,System.Func<System.Threading.CancellationToken,TTransformed>>)')**
  - **[Apply&lt;TSource,TTransformed&gt;(this Func&lt;TSource&gt;, Func&lt;Func&lt;TSource&gt;,Func&lt;TTransformed&gt;&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__) 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<TSource>, System.Func<System.Func<TSource>,System.Func<TTransformed>>)')**
  - **[AsAsyncLambda&lt;T&gt;(this Task&lt;T&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_) 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>)')**
  - **[AsAsyncLambda&lt;T&gt;(this ValueTask&lt;T&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_) 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T>)')**
  - **[AsCancellableAsyncLambda&lt;T&gt;(this Task&lt;T&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_) 'DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda<T>(this System.Threading.Tasks.Task<T>)')**
  - **[AsCancellableLambda&lt;T&gt;(this T)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsCancellableLambda_T_(thisT) 'DevFast.Net.Extensions.Etc.Lambdas.AsCancellableLambda<T>(this T)')**
  - **[AsLambda&lt;T&gt;(this T)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsLambda_T_(thisT) 'DevFast.Net.Extensions.Etc.Lambdas.AsLambda<T>(this T)')**
  - **[Execute&lt;T&gt;(this Func&lt;CancellationToken,T&gt;, CancellationToken)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<System.Threading.CancellationToken,T>, System.Threading.CancellationToken)')**
  - **[Execute&lt;T&gt;(this Func&lt;T&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<T>)')**
  - **[ExecuteAsync(this Func&lt;CancellationToken,Task&gt;, CancellationToken)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,System.Threading.CancellationToken) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task>, System.Threading.CancellationToken)')**
  - **[ExecuteAsync(this Func&lt;CancellationToken,ValueTask&gt;, CancellationToken)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_,System.Threading.CancellationToken) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask>, System.Threading.CancellationToken)')**
  - **[ExecuteAsync&lt;T&gt;(this Func&lt;CancellationToken,Task&lt;T&gt;&gt;, CancellationToken)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Threading.CancellationToken) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Threading.CancellationToken)')**
  - **[ExecuteAsync&lt;T&gt;(this Func&lt;CancellationToken,ValueTask&lt;T&gt;&gt;, CancellationToken)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Threading.CancellationToken) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Threading.CancellationToken)')**
  - **[Pipe&lt;T&gt;(this Func&lt;CancellationToken,Task&lt;T&gt;&gt;, Func&lt;T,CancellationToken,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T&gt;(this Func&lt;CancellationToken,ValueTask&lt;T&gt;&gt;, Func&lt;T,CancellationToken,ValueTask&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool)')**
  - **[Pipe&lt;T&gt;(this Func&lt;CancellationToken,T&gt;, Func&lt;T,CancellationToken,T&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool)')**
  - **[Pipe&lt;T&gt;(this Func&lt;T&gt;, Func&lt;T,T&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool)')**
  - **[Pipe&lt;TSource,TTandem&gt;(this Func&lt;CancellationToken,Task&lt;TSource&gt;&gt;, Func&lt;TSource,CancellationToken,Task&lt;TTandem&gt;&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>)')**
  - **[Pipe&lt;TSource,TTandem&gt;(this Func&lt;CancellationToken,ValueTask&lt;TSource&gt;&gt;, Func&lt;TSource,CancellationToken,ValueTask&lt;TTandem&gt;&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>)')**
  - **[Pipe&lt;TSource,TTandem&gt;(this Func&lt;CancellationToken,TSource&gt;, Func&lt;TSource,CancellationToken,TTandem&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<TSource,System.Threading.CancellationToken,TTandem>)')**
  - **[Pipe&lt;TSource,TTandem&gt;(this Func&lt;TSource&gt;, Func&lt;TSource,TTandem&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<TSource>, System.Func<TSource,TTandem>)')**

## Lambdas Class

Extension methods on the lambdas.

```csharp
public static class Lambdas
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Lambdas
### Methods

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool)'></a>

## Lambdas.Apply<T>(this Func<CancellationToken,T>, Func<Func<CancellationToken,T>,Func<CancellationToken,T>>, bool) Method

Conditionally applies [transformation](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).transformation 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<System.Func<System.Threading.CancellationToken,T>,System.Func<System.Threading.CancellationToken,T>>, bool).transformation') on the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<System.Func<System.Threading.CancellationToken,T>,System.Func<System.Threading.CancellationToken,T>>, bool).sourceLambda').
Returns transformed lambda (when [iff](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).iff 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<System.Func<System.Threading.CancellationToken,T>,System.Func<System.Threading.CancellationToken,T>>, bool).iff') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'));
otherwise, returns back the origin [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<System.Func<System.Threading.CancellationToken,T>,System.Func<System.Threading.CancellationToken,T>>, bool).sourceLambda').

```csharp
public static System.Func<System.Threading.CancellationToken,T> Apply<T>(this System.Func<System.Threading.CancellationToken,T> sourceLambda, System.Func<System.Func<System.Threading.CancellationToken,T>,System.Func<System.Threading.CancellationToken,T>> transformation, bool iff);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).T'></a>

`T`

Lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<System.Func<System.Threading.CancellationToken,T>,System.Func<System.Threading.CancellationToken,T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda on which the transformation is applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).transformation'></a>

`transformation` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<System.Func<System.Threading.CancellationToken,T>,System.Func<System.Threading.CancellationToken,T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<System.Func<System.Threading.CancellationToken,T>,System.Func<System.Threading.CancellationToken,T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Transformation lambda

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).iff'></a>

`iff` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating where the transformation should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_System.Func_System.Threading.CancellationToken,T_,System.Func_System.Threading.CancellationToken,T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<System.Func<System.Threading.CancellationToken,T>,System.Func<System.Threading.CancellationToken,T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool)'></a>

## Lambdas.Apply<T>(this Func<T>, Func<Func<T>,Func<T>>, bool) Method

Conditionally applies [transformation](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).transformation 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<T>, System.Func<System.Func<T>,System.Func<T>>, bool).transformation') on the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<T>, System.Func<System.Func<T>,System.Func<T>>, bool).sourceLambda').
Returns transformed lambda (when [iff](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).iff 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<T>, System.Func<System.Func<T>,System.Func<T>>, bool).iff') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'));
otherwise, returns back the origin [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<T>, System.Func<System.Func<T>,System.Func<T>>, bool).sourceLambda').

```csharp
public static System.Func<T> Apply<T>(this System.Func<T> sourceLambda, System.Func<System.Func<T>,System.Func<T>> transformation, bool iff);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).T'></a>

`T`

Lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<T>, System.Func<System.Func<T>,System.Func<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda on which the transformation is applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).transformation'></a>

`transformation` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<T>, System.Func<System.Func<T>,System.Func<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<T>, System.Func<System.Func<T>,System.Func<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Transformation lambda

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).iff'></a>

`iff` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating where the transformation should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_T_(thisSystem.Func_T_,System.Func_System.Func_T_,System.Func_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Apply<T>(this System.Func<T>, System.Func<System.Func<T>,System.Func<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__)'></a>

## Lambdas.Apply<TSource,TTransformed>(this Func<CancellationToken,TSource>, Func<Func<CancellationToken,TSource>,Func<CancellationToken,TTransformed>>) Method

Applies [transformation](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__).transformation 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<System.Func<System.Threading.CancellationToken,TSource>,System.Func<System.Threading.CancellationToken,TTransformed>>).transformation') on the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<System.Func<System.Threading.CancellationToken,TSource>,System.Func<System.Threading.CancellationToken,TTransformed>>).sourceLambda').

```csharp
public static System.Func<System.Threading.CancellationToken,TTransformed> Apply<TSource,TTransformed>(this System.Func<System.Threading.CancellationToken,TSource> sourceLambda, System.Func<System.Func<System.Threading.CancellationToken,TSource>,System.Func<System.Threading.CancellationToken,TTransformed>> transformation);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__).TSource'></a>

`TSource`

Source lambda output type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__).TTransformed'></a>

`TTransformed`

Transformed lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<System.Func<System.Threading.CancellationToken,TSource>,System.Func<System.Threading.CancellationToken,TTransformed>>).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda on which the transformation is applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__).transformation'></a>

`transformation` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<System.Func<System.Threading.CancellationToken,TSource>,System.Func<System.Threading.CancellationToken,TTransformed>>).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTransformed](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__).TTransformed 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<System.Func<System.Threading.CancellationToken,TSource>,System.Func<System.Threading.CancellationToken,TTransformed>>).TTransformed')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Transformation lambda

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTransformed](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Func_System.Threading.CancellationToken,TSource_,System.Func_System.Threading.CancellationToken,TTransformed__).TTransformed 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<System.Func<System.Threading.CancellationToken,TSource>,System.Func<System.Threading.CancellationToken,TTransformed>>).TTransformed')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__)'></a>

## Lambdas.Apply<TSource,TTransformed>(this Func<TSource>, Func<Func<TSource>,Func<TTransformed>>) Method

Applies [transformation](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__).transformation 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<TSource>, System.Func<System.Func<TSource>,System.Func<TTransformed>>).transformation') on the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<TSource>, System.Func<System.Func<TSource>,System.Func<TTransformed>>).sourceLambda').

```csharp
public static System.Func<TTransformed> Apply<TSource,TTransformed>(this System.Func<TSource> sourceLambda, System.Func<System.Func<TSource>,System.Func<TTransformed>> transformation);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__).TSource'></a>

`TSource`

Source lambda output type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__).TTransformed'></a>

`TTransformed`

Transformed lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<TSource>, System.Func<System.Func<TSource>,System.Func<TTransformed>>).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda on which the transformation is applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__).transformation'></a>

`transformation` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<TSource>, System.Func<System.Func<TSource>,System.Func<TTransformed>>).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TTransformed](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__).TTransformed 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<TSource>, System.Func<System.Func<TSource>,System.Func<TTransformed>>).TTransformed')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Transformation lambda

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TTransformed](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Apply_TSource,TTransformed_(thisSystem.Func_TSource_,System.Func_System.Func_TSource_,System.Func_TTransformed__).TTransformed 'DevFast.Net.Extensions.Etc.Lambdas.Apply<TSource,TTransformed>(this System.Func<TSource>, System.Func<System.Func<TSource>,System.Func<TTransformed>>).TTransformed')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_)'></a>

## Lambdas.AsAsyncLambda<T>(this Task<T>) Method

Creates a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') based lambda. Such a lambda upon execution
will first start the [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>).task') (if not already running),
and, then asynchronously execute the task and return its value.

Normally, once should just create a Task without actually running it,
so that the actual run takes place upon the lambda execution.

```csharp
public static System.Func<System.Threading.Tasks.Task<T>> AsAsyncLambda<T>(this System.Threading.Tasks.Task<T> task);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).T'></a>

`T`

Type of task
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

Task to await when lambda is executed

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_)'></a>

## Lambdas.AsAsyncLambda<T>(this ValueTask<T>) Method

Creates a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') based lambda. Such a lambda upon execution
will first start the [valueTask](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).valueTask 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T>).valueTask') (if not already running),
and, then asynchronously execute the task and return its value.

Normally, once should just create a Task without actually running it,
so that the actual run takes place upon the lambda execution.

```csharp
public static System.Func<System.Threading.Tasks.ValueTask<T>> AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T> valueTask);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).T'></a>

`T`

Type of task
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).valueTask'></a>

`valueTask` [System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

Task to await when lambda is executed

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_)'></a>

## Lambdas.AsCancellableAsyncLambda<T>(this Task<T>) Method

Creates a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') based lambda.
Such lambda would throw [System.OperationCanceledException](https://docs.microsoft.com/en-us/dotnet/api/System.OperationCanceledException 'System.OperationCanceledException') when
supplied [System.Threading.CancellationToken.IsCancellationRequested](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken.IsCancellationRequested 'System.Threading.CancellationToken.IsCancellationRequested') evaluates to
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'); otherwise, first start the [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task 'DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda<T>(this System.Threading.Tasks.Task<T>).task')
if not already running), and, then asynchronously execute the task and return its value.

Normally, once should just create a Task without actually running it,
so that the actual run takes place upon the lambda execution.

NOTE: [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') injected to the lambda would be
checked for cancellation only once before executing the [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task 'DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda<T>(this System.Threading.Tasks.Task<T>).task');
currently, it is NOT possible to inject the token into the task.
Thus, if the provided [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task 'DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda<T>(this System.Threading.Tasks.Task<T>).task') itself is cancellable, one must
provide the token to such [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task 'DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda<T>(this System.Threading.Tasks.Task<T>).task') by other means.

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> AsCancellableAsyncLambda<T>(this System.Threading.Tasks.Task<T> task);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).T'></a>

`T`

Type of task
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda<T>(this System.Threading.Tasks.Task<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

Task to await when lambda is executed

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.AsCancellableAsyncLambda<T>(this System.Threading.Tasks.Task<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsCancellableLambda_T_(thisT)'></a>

## Lambdas.AsCancellableLambda<T>(this T) Method

Creates a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') based lambda.
Such lambda would throw [System.OperationCanceledException](https://docs.microsoft.com/en-us/dotnet/api/System.OperationCanceledException 'System.OperationCanceledException') when
supplied [System.Threading.CancellationToken.IsCancellationRequested](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken.IsCancellationRequested 'System.Threading.CancellationToken.IsCancellationRequested') evaluates to
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'); otherwise, returns the [value](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsCancellableLambda_T_(thisT).value 'DevFast.Net.Extensions.Etc.Lambdas.AsCancellableLambda<T>(this T).value').

```csharp
public static System.Func<System.Threading.CancellationToken,T> AsCancellableLambda<T>(this T value);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsCancellableLambda_T_(thisT).T'></a>

`T`

Type of value
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsCancellableLambda_T_(thisT).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsCancellableLambda_T_(thisT).T 'DevFast.Net.Extensions.Etc.Lambdas.AsCancellableLambda<T>(this T).T')

Value to return when lambda is executed

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsCancellableLambda_T_(thisT).T 'DevFast.Net.Extensions.Etc.Lambdas.AsCancellableLambda<T>(this T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsLambda_T_(thisT)'></a>

## Lambdas.AsLambda<T>(this T) Method

Creates a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1') based lambda that returns the [value](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsLambda_T_(thisT).value 'DevFast.Net.Extensions.Etc.Lambdas.AsLambda<T>(this T).value') upon execution.

```csharp
public static System.Func<T> AsLambda<T>(this T value);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsLambda_T_(thisT).T'></a>

`T`

Type of value
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsLambda_T_(thisT).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsLambda_T_(thisT).T 'DevFast.Net.Extensions.Etc.Lambdas.AsLambda<T>(this T).T')

Value to return when lambda is executed

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsLambda_T_(thisT).T 'DevFast.Net.Extensions.Etc.Lambdas.AsLambda<T>(this T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken)'></a>

## Lambdas.Execute<T>(this Func<CancellationToken,T>, CancellationToken) Method

Simply executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<System.Threading.CancellationToken,T>, System.Threading.CancellationToken).lambda') and returns its results.

```csharp
public static T Execute<T>(this System.Func<System.Threading.CancellationToken,T> lambda, System.Threading.CancellationToken token);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken).T'></a>

`T`

Output type of the lambda
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken).T 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<System.Threading.CancellationToken,T>, System.Threading.CancellationToken).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token

#### Returns
[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken).T 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<System.Threading.CancellationToken,T>, System.Threading.CancellationToken).T')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_)'></a>

## Lambdas.Execute<T>(this Func<T>) Method

Simply executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<T>).lambda') and returns its results.

```csharp
public static T Execute<T>(this System.Func<T> lambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_).T'></a>

`T`

Output type of the lambda
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute.

#### Returns
[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<T>).T')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,System.Threading.CancellationToken)'></a>

## Lambdas.ExecuteAsync(this Func<CancellationToken,Task>, CancellationToken) Method

Asynchronously executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,System.Threading.CancellationToken).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task>, System.Threading.CancellationToken).lambda').

```csharp
public static System.Threading.Tasks.Task ExecuteAsync(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task> lambda, System.Threading.CancellationToken token);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,System.Threading.CancellationToken).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,System.Threading.CancellationToken).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_,System.Threading.CancellationToken)'></a>

## Lambdas.ExecuteAsync(this Func<CancellationToken,ValueTask>, CancellationToken) Method

Asynchronously executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_,System.Threading.CancellationToken).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask>, System.Threading.CancellationToken).lambda').

```csharp
public static System.Threading.Tasks.ValueTask ExecuteAsync(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask> lambda, System.Threading.CancellationToken token);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_,System.Threading.CancellationToken).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_,System.Threading.CancellationToken).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token

#### Returns
[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Threading.CancellationToken)'></a>

## Lambdas.ExecuteAsync<T>(this Func<CancellationToken,Task<T>>, CancellationToken) Method

Asynchronously executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Threading.CancellationToken).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Threading.CancellationToken).lambda').

```csharp
public static System.Threading.Tasks.Task<T> ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> lambda, System.Threading.CancellationToken token);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Threading.CancellationToken).T'></a>

`T`

Output type of the resultant task
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Threading.CancellationToken).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Threading.CancellationToken).T 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Threading.CancellationToken).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Threading.CancellationToken).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Threading.CancellationToken).T 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Threading.CancellationToken).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Threading.CancellationToken)'></a>

## Lambdas.ExecuteAsync<T>(this Func<CancellationToken,ValueTask<T>>, CancellationToken) Method

Asynchronously executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Threading.CancellationToken).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Threading.CancellationToken).lambda').

```csharp
public static System.Threading.Tasks.ValueTask<T> ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>> lambda, System.Threading.CancellationToken token);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Threading.CancellationToken).T'></a>

`T`

Output type of the resultant task
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Threading.CancellationToken).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Threading.CancellationToken).T 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Threading.CancellationToken).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Threading.CancellationToken).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Threading.CancellationToken).T 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Threading.CancellationToken).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool)'></a>

## Lambdas.Pipe<T>(this Func<CancellationToken,Task<T>>, Func<T,CancellationToken,Task<T>>, bool) Method

Conditionally merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).tandemLambda') lambda.

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> sourceLambda, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> tandemLambda, bool iff);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).T'></a>

`T`

Lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of the source lambda.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).iff'></a>

`iff` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating where the transformation should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool)'></a>

## Lambdas.Pipe<T>(this Func<CancellationToken,ValueTask<T>>, Func<T,CancellationToken,ValueTask<T>>, bool) Method

Conditionally merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda') lambda.

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>> Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>> tandemLambda, bool iff);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).T'></a>

`T`

Lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of the source lambda.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).iff'></a>

`iff` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating where the transformation should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool)'></a>

## Lambdas.Pipe<T>(this Func<CancellationToken,T>, Func<T,CancellationToken,T>, bool) Method

Conditionally merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda') lambda.

```csharp
public static System.Func<System.Threading.CancellationToken,T> Pipe<T>(this System.Func<System.Threading.CancellationToken,T> sourceLambda, System.Func<T,System.Threading.CancellationToken,T> tandemLambda, bool iff);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).T'></a>

`T`

Lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of the source lambda.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).iff'></a>

`iff` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating where the transformation should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool)'></a>

## Lambdas.Pipe<T>(this Func<T>, Func<T,T>, bool) Method

Conditionally merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).tandemLambda') lambda.

```csharp
public static System.Func<T> Pipe<T>(this System.Func<T> sourceLambda, System.Func<T,T> tandemLambda, bool iff);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).T'></a>

`T`

Lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Tandem lambda that would consume the output of the source lambda.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).iff'></a>

`iff` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating where the transformation should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__)'></a>

## Lambdas.Pipe<TSource,TTandem>(this Func<CancellationToken,Task<TSource>>, Func<TSource,CancellationToken,Task<TTandem>>) Method

Conditionally merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).tandemLambda') lambda.

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>> Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TSource>> sourceLambda, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TSource'></a>

`TSource`

Source lambda output type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TTandem'></a>

`TTandem`

Tandem lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of the source lambda.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__)'></a>

## Lambdas.Pipe<TSource,TTandem>(this Func<CancellationToken,ValueTask<TSource>>, Func<TSource,CancellationToken,ValueTask<TTandem>>) Method

Conditionally merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).tandemLambda') lambda.

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>> Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TSource>> sourceLambda, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TSource'></a>

`TSource`

Source lambda output type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TTandem'></a>

`TTandem`

Tandem lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of the source lambda.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TSource__,System.Func_TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TSource>>, System.Func<TSource,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_)'></a>

## Lambdas.Pipe<TSource,TTandem>(this Func<CancellationToken,TSource>, Func<TSource,CancellationToken,TTandem>) Method

Conditionally merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<TSource,System.Threading.CancellationToken,TTandem>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<TSource,System.Threading.CancellationToken,TTandem>).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<TSource,System.Threading.CancellationToken,TTandem>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<TSource,System.Threading.CancellationToken,TTandem>).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<TSource,System.Threading.CancellationToken,TTandem>).tandemLambda') lambda.

```csharp
public static System.Func<System.Threading.CancellationToken,TTandem> Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,TSource> sourceLambda, System.Func<TSource,System.Threading.CancellationToken,TTandem> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).TSource'></a>

`TSource`

Source lambda output type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).TTandem'></a>

`TTandem`

Tandem lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<TSource,System.Threading.CancellationToken,TTandem>).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<TSource,System.Threading.CancellationToken,TTandem>).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<TSource,System.Threading.CancellationToken,TTandem>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of the source lambda.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TSource_,System.Func_TSource,System.Threading.CancellationToken,TTandem_).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<System.Threading.CancellationToken,TSource>, System.Func<TSource,System.Threading.CancellationToken,TTandem>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_)'></a>

## Lambdas.Pipe<TSource,TTandem>(this Func<TSource>, Func<TSource,TTandem>) Method

Merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<TSource>, System.Func<TSource,TTandem>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<TSource>, System.Func<TSource,TTandem>).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<TSource>, System.Func<TSource,TTandem>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<TSource>, System.Func<TSource,TTandem>).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<TSource>, System.Func<TSource,TTandem>).tandemLambda') lambda.

```csharp
public static System.Func<TTandem> Pipe<TSource,TTandem>(this System.Func<TSource> sourceLambda, System.Func<TSource,TTandem> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).TSource'></a>

`TSource`

Source lambda output type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).TTandem'></a>

`TTandem`

Tandem lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<TSource>, System.Func<TSource,TTandem>).TSource')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSource](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).TSource 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<TSource>, System.Func<TSource,TTandem>).TSource')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<TSource>, System.Func<TSource,TTandem>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Tandem lambda that would consume the output of the source lambda.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TSource,TTandem_(thisSystem.Func_TSource_,System.Func_TSource,TTandem_).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TSource,TTandem>(this System.Func<TSource>, System.Func<TSource,TTandem>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')