#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.Etc](DevFast.Net.Extensions.Etc.md 'DevFast.Net.Extensions.Etc')

## Lambdas Class

Extension methods on the lambdas.

```csharp
public static class Lambdas
```
- *Methods*
  - **[Adapt&lt;T&gt;(this T, Func&lt;T,T&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<T>(this T, System.Func<T,T>, bool)')**
  - **[Adapt&lt;TIn,TOut&gt;(this TIn, Func&lt;TIn,TOut&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_) 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<TIn,TOut>(this TIn, System.Func<TIn,TOut>)')**
  - **[AsAsyncLambda&lt;T&gt;(this Task&lt;T&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_) 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>)')**
  - **[AsAsyncLambda&lt;T&gt;(this ValueTask&lt;T&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_) 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T>)')**
  - **[AsLambda&lt;T&gt;(this T)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsLambda_T_(thisT) 'DevFast.Net.Extensions.Etc.Lambdas.AsLambda<T>(this T)')**
  - **[AsLambdaWithCancellation&lt;T&gt;(this T)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsLambdaWithCancellation_T_(thisT) 'DevFast.Net.Extensions.Etc.Lambdas.AsLambdaWithCancellation<T>(this T)')**
  - **[Execute&lt;T&gt;(this Func&lt;CancellationToken,T&gt;, CancellationToken, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<System.Threading.CancellationToken,T>, System.Threading.CancellationToken, System.Action)')**
  - **[Execute&lt;T&gt;(this Func&lt;T&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<T>, System.Action)')**
  - **[ExecuteAsync(this Func&lt;CancellationToken,Task&gt;, CancellationToken)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_,System.Threading.CancellationToken) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task>, System.Threading.CancellationToken)')**
  - **[ExecuteAsync(this Func&lt;CancellationToken,ValueTask&gt;, CancellationToken)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_,System.Threading.CancellationToken) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask>, System.Threading.CancellationToken)')**
  - **[ExecuteAsync&lt;T&gt;(this Func&lt;CancellationToken,Task&lt;T&gt;&gt;, CancellationToken)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Threading.CancellationToken) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Threading.CancellationToken)')**
  - **[ExecuteAsync&lt;T&gt;(this Func&lt;CancellationToken,ValueTask&lt;T&gt;&gt;, CancellationToken)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Threading.CancellationToken) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Threading.CancellationToken)')**
  - **[Pipe&lt;T&gt;(this Func&lt;CancellationToken,Task&lt;T&gt;&gt;, Func&lt;T,CancellationToken,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T&gt;(this Func&lt;CancellationToken,ValueTask&lt;T&gt;&gt;, Func&lt;T,CancellationToken,ValueTask&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool)')**
  - **[Pipe&lt;T&gt;(this Func&lt;CancellationToken,T&gt;, Func&lt;T,CancellationToken,T&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool)')**
  - **[Pipe&lt;T&gt;(this Func&lt;T&gt;, Func&lt;T,T&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool)')**
  - **[Pipe&lt;TIn,TTandem&gt;(this Func&lt;CancellationToken,Task&lt;TIn&gt;&gt;, Func&lt;TIn,CancellationToken,Task&lt;TTandem&gt;&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>)')**
  - **[Pipe&lt;TIn,TTandem&gt;(this Func&lt;CancellationToken,ValueTask&lt;TIn&gt;&gt;, Func&lt;TIn,CancellationToken,ValueTask&lt;TTandem&gt;&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>)')**
  - **[Pipe&lt;TIn,TTandem&gt;(this Func&lt;CancellationToken,TIn&gt;, Func&lt;TIn,CancellationToken,TTandem&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn>, System.Func<TIn,System.Threading.CancellationToken,TTandem>)')**
  - **[Pipe&lt;TIn,TTandem&gt;(this Func&lt;TIn&gt;, Func&lt;TIn,TTandem&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<TIn>, System.Func<TIn,TTandem>)')**

## Lambdas Class

Extension methods on the lambdas.

```csharp
public static class Lambdas
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Lambdas
### Methods

<a name='DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool)'></a>

## Lambdas.Adapt<T>(this T, Func<T,T>, bool) Method

Applies [adapter](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).adapter 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<T>(this T, System.Func<T,T>, bool).adapter') on the [input](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).input 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<T>(this T, System.Func<T,T>, bool).input')
when [iff](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).iff 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<T>(this T, System.Func<T,T>, bool).iff') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') and returns the result;
otherwise, returns back the original [input](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).input 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<T>(this T, System.Func<T,T>, bool).input').

```csharp
public static T Adapt<T>(this T input, System.Func<T,T> adapter, bool iff);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).T'></a>

`T`

Adapter type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).input'></a>

`input` [T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<T>(this T, System.Func<T,T>, bool).T')

Source on which the adapter is applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).adapter'></a>

`adapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<T>(this T, System.Func<T,T>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<T>(this T, System.Func<T,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Adapter lambda

<a name='DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).iff'></a>

`iff` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating where the adapter should be applied or not

#### Returns
[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_T_(thisT,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<T>(this T, System.Func<T,T>, bool).T')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_)'></a>

## Lambdas.Adapt<TIn,TOut>(this TIn, Func<TIn,TOut>) Method

Applies [adapter](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).adapter 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<TIn,TOut>(this TIn, System.Func<TIn,TOut>).adapter') on the [input](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).input 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<TIn,TOut>(this TIn, System.Func<TIn,TOut>).input')
and returns the results.

```csharp
public static TOut Adapt<TIn,TOut>(this TIn input, System.Func<TIn,TOut> adapter);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TIn'></a>

`TIn`

Input type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TOut'></a>

`TOut`

Output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).input'></a>

`input` [TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<TIn,TOut>(this TIn, System.Func<TIn,TOut>).TIn')

Source on which the adapter is applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).adapter'></a>

`adapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<TIn,TOut>(this TIn, System.Func<TIn,TOut>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<TIn,TOut>(this TIn, System.Func<TIn,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Adapter lambda

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Adapt_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Adapt<TIn,TOut>(this TIn, System.Func<TIn,TOut>).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_)'></a>

## Lambdas.AsAsyncLambda<T>(this Task<T>) Method

Creates a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') based lambda.
Such lambda would throw [System.OperationCanceledException](https://docs.microsoft.com/en-us/dotnet/api/System.OperationCanceledException 'System.OperationCanceledException') when
supplied [System.Threading.CancellationToken.IsCancellationRequested](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken.IsCancellationRequested 'System.Threading.CancellationToken.IsCancellationRequested') evaluates to
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'); otherwise, it starts the task (if not already running) and
returns the value of the [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>).task').

NOTE: [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') is checked once before awaiting on the [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>).task').
If the task itself can be canceled, one should find a way to pass
the [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') to such [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>).task').
Purpose of such method is to lazily start the [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>).task'),
thus, one should avoid (though possible) passing already running [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>).task')
created using [System.Threading.Tasks.TaskFactory](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.TaskFactory 'System.Threading.Tasks.TaskFactory') or by other means.

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> AsAsyncLambda<T>(this System.Threading.Tasks.Task<T> task);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).T'></a>

`T`

Type of value
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

Value to return when lambda is executed

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.Task_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.Task<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_)'></a>

## Lambdas.AsAsyncLambda<T>(this ValueTask<T>) Method

Creates a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') based lambda.
Such lambda would throw [System.OperationCanceledException](https://docs.microsoft.com/en-us/dotnet/api/System.OperationCanceledException 'System.OperationCanceledException') when
supplied [System.Threading.CancellationToken.IsCancellationRequested](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken.IsCancellationRequested 'System.Threading.CancellationToken.IsCancellationRequested') evaluates to
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'); otherwise, it returns the value of the [valueTask](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).valueTask 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T>).valueTask').

NOTE: [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') is checked once before awaiting on the [valueTask](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).valueTask 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T>).valueTask').
If the task itself can be canceled, one should find a way to pass
the [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') to such [valueTask](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).valueTask 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T>).valueTask').

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>> AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T> valueTask);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).T'></a>

`T`

Type of value
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).valueTask'></a>

`valueTask` [System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

Value to return when lambda is executed

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda_T_(thisSystem.Threading.Tasks.ValueTask_T_).T 'DevFast.Net.Extensions.Etc.Lambdas.AsAsyncLambda<T>(this System.Threading.Tasks.ValueTask<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

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

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsLambdaWithCancellation_T_(thisT)'></a>

## Lambdas.AsLambdaWithCancellation<T>(this T) Method

Creates a [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2') based lambda.
Such lambda would throw [System.OperationCanceledException](https://docs.microsoft.com/en-us/dotnet/api/System.OperationCanceledException 'System.OperationCanceledException') when
supplied [System.Threading.CancellationToken.IsCancellationRequested](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken.IsCancellationRequested 'System.Threading.CancellationToken.IsCancellationRequested') evaluates to
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'); otherwise, returns the [value](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsLambdaWithCancellation_T_(thisT).value 'DevFast.Net.Extensions.Etc.Lambdas.AsLambdaWithCancellation<T>(this T).value').

```csharp
public static System.Func<System.Threading.CancellationToken,T> AsLambdaWithCancellation<T>(this T value);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsLambdaWithCancellation_T_(thisT).T'></a>

`T`

Type of value
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.AsLambdaWithCancellation_T_(thisT).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsLambdaWithCancellation_T_(thisT).T 'DevFast.Net.Extensions.Etc.Lambdas.AsLambdaWithCancellation<T>(this T).T')

Value to return when lambda is executed

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.AsLambdaWithCancellation_T_(thisT).T 'DevFast.Net.Extensions.Etc.Lambdas.AsLambdaWithCancellation<T>(this T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken,System.Action)'></a>

## Lambdas.Execute<T>(this Func<CancellationToken,T>, CancellationToken, Action) Method

Simply executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<System.Threading.CancellationToken,T>, System.Threading.CancellationToken, System.Action).lambda') and returns its results.

```csharp
public static T Execute<T>(this System.Func<System.Threading.CancellationToken,T> lambda, System.Threading.CancellationToken token, System.Action? finallyClause=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken,System.Action).T'></a>

`T`

Output type of the lambda
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken,System.Action).T 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<System.Threading.CancellationToken,T>, System.Threading.CancellationToken, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken,System.Action).token'></a>

`token` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

Cancellation token

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to execute in finally block of try-finally (if any)

#### Returns
[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Threading.CancellationToken,System.Action).T 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<System.Threading.CancellationToken,T>, System.Threading.CancellationToken, System.Action).T')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_,System.Action)'></a>

## Lambdas.Execute<T>(this Func<T>, Action) Method

Simply executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<T>, System.Action).lambda') and returns its results.

```csharp
public static T Execute<T>(this System.Func<T> lambda, System.Action? finallyClause=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_,System.Action).T'></a>

`T`

Output type of the lambda
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_,System.Action).T 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to execute in finally block of try-finally (if any)

#### Returns
[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_,System.Action).T 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<T>, System.Action).T')

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
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).tandemLambda'). Such a resultant lambda, upon execution,
would return the output of the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).tandemLambda').

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

Tandem lambda that would consume the output of the input lambda.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).iff'></a>

`iff` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating where the adapter should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool)'></a>

## Lambdas.Pipe<T>(this Func<CancellationToken,ValueTask<T>>, Func<T,CancellationToken,ValueTask<T>>, bool) Method

Conditionally merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda'). Such a resultant lambda, upon execution,
would return the output of the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda').

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

Tandem lambda that would consume the output of the input lambda.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).iff'></a>

`iff` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating where the adapter should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool)'></a>

## Lambdas.Pipe<T>(this Func<CancellationToken,T>, Func<T,CancellationToken,T>, bool) Method

Conditionally merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda'). Such a resultant lambda, upon execution,
would return the output of the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda').

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

Tandem lambda that would consume the output of the input lambda.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).iff'></a>

`iff` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating where the adapter should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool)'></a>

## Lambdas.Pipe<T>(this Func<T>, Func<T,T>, bool) Method

Conditionally merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).tandemLambda'). Such a resultant lambda, upon execution,
would return the output of the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).tandemLambda').

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

Tandem lambda that would consume the output of the input lambda.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).iff'></a>

`iff` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating where the adapter should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__)'></a>

## Lambdas.Pipe<TIn,TTandem>(this Func<CancellationToken,Task<TIn>>, Func<TIn,CancellationToken,Task<TTandem>>) Method

Merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).tandemLambda') lambda.

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>> Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>> sourceLambda, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TIn'></a>

`TIn`

Source lambda output type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TTandem'></a>

`TTandem`

Tandem lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of the input lambda.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__)'></a>

## Lambdas.Pipe<TIn,TTandem>(this Func<CancellationToken,ValueTask<TIn>>, Func<TIn,CancellationToken,ValueTask<TTandem>>) Method

Merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).tandemLambda') lambda.

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>> Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>> sourceLambda, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TIn'></a>

`TIn`

Source lambda output type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TTandem'></a>

`TTandem`

Tandem lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of the input lambda.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_)'></a>

## Lambdas.Pipe<TIn,TTandem>(this Func<CancellationToken,TIn>, Func<TIn,CancellationToken,TTandem>) Method

Merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn>, System.Func<TIn,System.Threading.CancellationToken,TTandem>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn>, System.Func<TIn,System.Threading.CancellationToken,TTandem>).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn>, System.Func<TIn,System.Threading.CancellationToken,TTandem>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn>, System.Func<TIn,System.Threading.CancellationToken,TTandem>).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn>, System.Func<TIn,System.Threading.CancellationToken,TTandem>).tandemLambda') lambda.

```csharp
public static System.Func<System.Threading.CancellationToken,TTandem> Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn> sourceLambda, System.Func<TIn,System.Threading.CancellationToken,TTandem> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).TIn'></a>

`TIn`

Source lambda output type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).TTandem'></a>

`TTandem`

Tandem lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn>, System.Func<TIn,System.Threading.CancellationToken,TTandem>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn>, System.Func<TIn,System.Threading.CancellationToken,TTandem>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn>, System.Func<TIn,System.Threading.CancellationToken,TTandem>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of the input lambda.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn>, System.Func<TIn,System.Threading.CancellationToken,TTandem>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_)'></a>

## Lambdas.Pipe<TIn,TTandem>(this Func<TIn>, Func<TIn,TTandem>) Method

Merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<TIn>, System.Func<TIn,TTandem>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<TIn>, System.Func<TIn,TTandem>).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<TIn>, System.Func<TIn,TTandem>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<TIn>, System.Func<TIn,TTandem>).tandemLambda') and upon execution it would return the output of
the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<TIn>, System.Func<TIn,TTandem>).tandemLambda') lambda.

```csharp
public static System.Func<TTandem> Pipe<TIn,TTandem>(this System.Func<TIn> sourceLambda, System.Func<TIn,TTandem> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).TIn'></a>

`TIn`

Source lambda output type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).TTandem'></a>

`TTandem`

Tandem lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<TIn>, System.Func<TIn,TTandem>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<TIn>, System.Func<TIn,TTandem>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<TIn>, System.Func<TIn,TTandem>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Tandem lambda that would consume the output of the input lambda.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TTandem](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_).TTandem 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<TIn>, System.Func<TIn,TTandem>).TTandem')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')