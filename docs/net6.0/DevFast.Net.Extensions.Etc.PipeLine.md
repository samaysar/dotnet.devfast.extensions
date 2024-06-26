#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.Etc](DevFast.Net.Extensions.Etc.md 'DevFast.Net.Extensions.Etc')

## PipeLine Class

Extension methods on Lambdas to create a executable Pipeline.

```csharp
public static class PipeLine
```
- *Methods*
  - **[Pipe&lt;T,TState&gt;(this Func&lt;Task&lt;T&gt;&gt;, Func&lt;T,TState,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;ValueTask&lt;T&gt;&gt;, Func&lt;T,TState,ValueTask&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;T&gt;, Func&lt;T,TState,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,Task&lt;T&gt;&gt;, Func&lt;T,TState,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,ValueTask&lt;T&gt;&gt;, Func&lt;T,TState,ValueTask&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,T&gt;, Func&lt;T,TState,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Task&lt;T&gt;, Func&lt;T,TState,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this T, Func&lt;T,TState,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool)')**
  - **[Pipe&lt;T&gt;(this T, Func&lt;T,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T>(this T, System.Func<T,T>, bool)')**
  - **[Pipe&lt;TIn,TOut&gt;(this TIn, Func&lt;TIn,TOut&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TOut>(this TIn, System.Func<TIn,TOut>)')**

## PipeLine Class

Extension methods on Lambdas to create a executable Pipeline.

```csharp
public static class PipeLine
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PipeLine
### Methods

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool)'></a>

## PipeLine.Pipe<T,TState>(this Func<Task<T>>, Func<T,TState,Task<T>>, bool) Method

Provides a conditional asynchronous lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<T>> Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>> sourceLambda, System.Func<T,TState,System.Threading.Tasks.Task<T>> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool)'></a>

## PipeLine.Pipe<T,TState>(this Func<ValueTask<T>>, Func<T,TState,ValueTask<T>>, bool) Method

Provides a conditional asynchronous lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).sourceLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.ValueTask<T>> Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool)'></a>

## PipeLine.Pipe<T,TState>(this Func<T>, Func<T,TState,T>, bool) Method

Provides a conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).sourceLambda').

```csharp
public static System.Func<TState,T> Pipe<T,TState>(this System.Func<T> sourceLambda, System.Func<T,TState,T> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,Task<T>>, Func<T,TState,Task<T>>, bool) Method

Provides a conditional asynchronous lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda')'s [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda') 
and returns a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') containing the output of [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') 
containing the output of the original [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<T>> Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>> sourceLambda, System.Func<T,TState,System.Threading.Tasks.Task<T>> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda')'s [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,ValueTask<T>>, Func<T,TState,ValueTask<T>>, bool) Method

Provides a conditional asynchronous lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).sourceLambda')'s [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda') 
and returns a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') containing the output of [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') 
containing the output of the original [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).sourceLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.ValueTask<T>> Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).sourceLambda')'s [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,T>, Func<T,TState,T>, bool) Method

Provides a conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).sourceLambda').

```csharp
public static System.Func<TState,T> Pipe<T,TState>(this System.Func<TState,T> sourceLambda, System.Func<T,TState,T> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool)'></a>

## PipeLine.Pipe<T,TState>(this Task<T>, Func<T,TState,Task<T>>, bool) Method

Provides a conditional asynchronous lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[task](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).task 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).task') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[task](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).task 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).task').

IMPLEMENTATION NOTE: As the purpose of pipelines is to executes everything as lazily as possible,
calling this method on a non-running [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') is advisable, though NOT necessary.
Irrespective to the state of the [task](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).task 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).task') outcome would be identical.

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<T>> Pipe<T,TState>(this System.Threading.Tasks.Task<T> task, System.Func<T,TState,System.Threading.Tasks.Task<T>> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [task](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).task 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).task').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool)'></a>

## PipeLine.Pipe<T,TState>(this T, Func<T,TState,T>, bool) Method

Provides a conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds [value](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).value 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).value')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the original
[value](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).value 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).value').

```csharp
public static System.Func<TState,T> Pipe<T,TState>(this T value, System.Func<T,TState,T> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).T')

Value to feed

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool)'></a>

## PipeLine.Pipe<T>(this T, Func<T,T>, bool) Method

Applies [adapter](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).adapter 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T>(this T, System.Func<T,T>, bool).adapter') on the [input](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).input 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T>(this T, System.Func<T,T>, bool).input')
when [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T>(this T, System.Func<T,T>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') and returns the result;
otherwise, returns back the original [input](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).input 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T>(this T, System.Func<T,T>, bool).input').

```csharp
public static T Pipe<T>(this T input, System.Func<T,T> adapter, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).input'></a>

`input` [T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T>(this T, System.Func<T,T>, bool).T')

Source on which the adapter is applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).adapter'></a>

`adapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T>(this T, System.Func<T,T>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T>(this T, System.Func<T,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Adapter lambda

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Flag dictating whether should be applied or not

#### Returns
[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T>(this T, System.Func<T,T>, bool).T')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_)'></a>

## PipeLine.Pipe<TIn,TOut>(this TIn, Func<TIn,TOut>) Method

Applies [adapter](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).adapter 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TOut>(this TIn, System.Func<TIn,TOut>).adapter') on the [input](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).input 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TOut>(this TIn, System.Func<TIn,TOut>).input')
and returns the results.

```csharp
public static TOut Pipe<TIn,TOut>(this TIn input, System.Func<TIn,TOut> adapter);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).input'></a>

`input` [TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TOut>(this TIn, System.Func<TIn,TOut>).TIn')

Source on which the adapter is applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).adapter'></a>

`adapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TOut>(this TIn, System.Func<TIn,TOut>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TOut>(this TIn, System.Func<TIn,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Adapter lambda

#### Returns
[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TOut>(this TIn, System.Func<TIn,TOut>).TOut')