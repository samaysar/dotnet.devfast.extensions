#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.Etc](DevFast.Net.Extensions.Etc.md 'DevFast.Net.Extensions.Etc')

## PipeLine Class

Extension methods on Lambdas to create a executable Pipeline.

```csharp
public static class PipeLine
```
- *Methods*
  - **[Pipe&lt;T,TState&gt;(this Func&lt;T&gt;, Func&lt;T,TState,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,T&gt;, Func&lt;T,TState,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool)')**
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