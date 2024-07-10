#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.Etc](DevFast.Net.Extensions.Etc.md 'DevFast.Net.Extensions.Etc')

## Lambdas Class

Extension methods to execute lambdas.

```csharp
public static class Lambdas
```
- *Methods*
  - **[Execute(this Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute(thisSystem.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute(this System.Action)')**
  - **[Execute(this Action, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute(thisSystem.Action,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute(this System.Action, System.Action)')**
  - **[Execute&lt;T&gt;(this Func&lt;T&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<T>)')**
  - **[Execute&lt;TError&gt;(this Action, Action&lt;ExceptionDispatchInfo,TError&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action)')**
  - **[Execute&lt;TOut,TError&gt;(this Func&lt;TOut&gt;, Func&lt;ExceptionDispatchInfo,TError,TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action)')**
  - **[Execute&lt;TOut&gt;(this Func&lt;TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut_(thisSystem.Func_TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut>(this System.Func<TOut>, System.Action)')**
  - **[Execute&lt;TState,TError&gt;(this Action&lt;TState&gt;, TState, Action&lt;ExceptionDispatchInfo,TError,TState&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action)')**
  - **[Execute&lt;TState,TError&gt;(this Action&lt;TState&gt;, TState, Action&lt;ExceptionDispatchInfo,TError,TState&gt;, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>)')**
  - **[Execute&lt;TState,TOut,TError&gt;(this Func&lt;TState,TOut&gt;, TState, Func&lt;ExceptionDispatchInfo,TError,TState,TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action)')**
  - **[Execute&lt;TState,TOut,TError&gt;(this Func&lt;TState,TOut&gt;, TState, Func&lt;ExceptionDispatchInfo,TError,TState,TOut&gt;, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>)')**
  - **[Execute&lt;TState,TOut&gt;(this Func&lt;TState,TOut&gt;, TState)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState)')**
  - **[Execute&lt;TState,TOut&gt;(this Func&lt;TState,TOut&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action)')**
  - **[Execute&lt;TState,TOut&gt;(this Func&lt;TState,TOut&gt;, TState, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>)')**
  - **[Execute&lt;TState&gt;(this Action&lt;TState&gt;, TState)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState)')**
  - **[Execute&lt;TState&gt;(this Action&lt;TState&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState, System.Action)')**
  - **[Execute&lt;TState&gt;(this Action&lt;TState&gt;, TState, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState, System.Action<TState>)')**
  - **[ExecuteAsync(this Func&lt;Task&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.Task_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.Tasks.Task>)')**
  - **[ExecuteAsync(this Func&lt;Task&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.Tasks.Task>, System.Action)')**
  - **[ExecuteAsync&lt;TError&gt;(this Func&lt;Task&gt;, Action&lt;ExceptionDispatchInfo,TError&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action)')**
  - **[ExecuteAsync&lt;TOut,TError&gt;(this Func&lt;Task&lt;TOut&gt;&gt;, Func&lt;ExceptionDispatchInfo,TError,TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action)')**
  - **[ExecuteAsync&lt;TOut&gt;(this Func&lt;Task&lt;TOut&gt;&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>)')**
  - **[ExecuteAsync&lt;TOut&gt;(this Func&lt;Task&lt;TOut&gt;&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Action)')**
  - **[ExecuteAsync&lt;TState,TError&gt;(this Func&lt;TState,Task&gt;, TState, Action&lt;ExceptionDispatchInfo,TError,TState&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action)')**
  - **[ExecuteAsync&lt;TState,TError&gt;(this Func&lt;TState,Task&gt;, TState, Action&lt;ExceptionDispatchInfo,TError,TState&gt;, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>)')**
  - **[ExecuteAsync&lt;TState,TOut,TError&gt;(this Func&lt;TState,Task&lt;TOut&gt;&gt;, TState, Func&lt;ExceptionDispatchInfo,TError,TState,TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action)')**
  - **[ExecuteAsync&lt;TState,TOut,TError&gt;(this Func&lt;TState,Task&lt;TOut&gt;&gt;, TState, Func&lt;ExceptionDispatchInfo,TError,TState,TOut&gt;, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>)')**
  - **[ExecuteAsync&lt;TState,TOut&gt;(this Func&lt;TState,Task&lt;TOut&gt;&gt;, TState)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState)')**
  - **[ExecuteAsync&lt;TState,TOut&gt;(this Func&lt;TState,Task&lt;TOut&gt;&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action)')**
  - **[ExecuteAsync&lt;TState,TOut&gt;(this Func&lt;TState,Task&lt;TOut&gt;&gt;, TState, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>)')**
  - **[ExecuteAsync&lt;TState&gt;(this Func&lt;TState,Task&gt;, TState)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState)')**
  - **[ExecuteAsync&lt;TState&gt;(this Func&lt;TState,Task&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action)')**
  - **[ExecuteAsync&lt;TState&gt;(this Func&lt;TState,Task&gt;, TState, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>)')**

## Lambdas Class

Extension methods to execute lambdas.

```csharp
public static class Lambdas
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Lambdas
### Methods

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute(thisSystem.Action)'></a>

## Lambdas.Execute(this Action) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute(thisSystem.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute(this System.Action).lambda').

```csharp
public static void Execute(this System.Action lambda);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute(thisSystem.Action).lambda'></a>

`lambda` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute(thisSystem.Action,System.Action)'></a>

## Lambdas.Execute(this Action, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute(thisSystem.Action,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute(this System.Action, System.Action).lambda') inside try block and
excutes [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute(thisSystem.Action,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute(this System.Action, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static void Execute(this System.Action lambda, System.Action finallyClause);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute(thisSystem.Action,System.Action).lambda'></a>

`lambda` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute(thisSystem.Action,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_)'></a>

## Lambdas.Execute<T>(this Func<T>) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<T>).lambda') and returns its results.

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

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action)'></a>

## Lambdas.Execute<TError>(this Action, Action<ExceptionDispatchInfo,TError>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).lambda') inside try block.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).TError') (or
its derived types) occurs during [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).errorHandler').
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static void Execute<TError>(this System.Action lambda, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).lambda'></a>

`lambda` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).TError')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action)'></a>

## Lambdas.Execute<TOut,TError>(this Func<TOut>, Func<ExceptionDispatchInfo,TError,TOut>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).lambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TError') (or
its derived types) occurs during [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static TOut Execute<TOut,TError>(this System.Func<TOut> lambda, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut_(thisSystem.Func_TOut_,System.Action)'></a>

## Lambdas.Execute<TOut>(this Func<TOut>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut_(thisSystem.Func_TOut_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut>(this System.Func<TOut>, System.Action).lambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut_(thisSystem.Func_TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut>(this System.Func<TOut>, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static TOut Execute<TOut>(this System.Func<TOut> lambda, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut_(thisSystem.Func_TOut_,System.Action).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut_(thisSystem.Func_TOut_,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut_(thisSystem.Func_TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut>(this System.Func<TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut_(thisSystem.Func_TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TOut_(thisSystem.Func_TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TOut>(this System.Func<TOut>, System.Action).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action)'></a>

## Lambdas.Execute<TState,TError>(this Action<TState>, TState, Action<ExceptionDispatchInfo,TError,TState>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).lambda') inside try block.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TError') (or
its derived types) occurs during [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).errorHandler').
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static void Execute<TState,TError>(this System.Action<TState> lambda, TState state, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_)'></a>

## Lambdas.Execute<TState,TError>(this Action<TState>, TState, Action<ExceptionDispatchInfo,TError,TState>, Action<TState>) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).lambda') inside try block.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TError') (or
its derived types) occurs during [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).errorHandler').
And, [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).finallyClause') will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static void Execute<TState,TError>(this System.Action<TState> lambda, TState state, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState> errorHandler, System.Action<TState> finallyClause)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action)'></a>

## Lambdas.Execute<TState,TOut,TError>(this Func<TState,TOut>, TState, Func<ExceptionDispatchInfo,TError,TState,TOut>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).lambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TError') (or
its derived types) occurs during [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static TOut Execute<TState,TOut,TError>(this System.Func<TState,TOut> lambda, TState state, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_)'></a>

## Lambdas.Execute<TState,TOut,TError>(this Func<TState,TOut>, TState, Func<ExceptionDispatchInfo,TError,TState,TOut>, Action<TState>) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).lambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TError') (or
its derived types) occurs during [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).errorHandler')
to obtain the return value.
And, [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).finallyClause') will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static TOut Execute<TState,TOut,TError>(this System.Func<TState,TOut> lambda, TState state, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut> errorHandler, System.Action<TState> finallyClause)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TError 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState)'></a>

## Lambdas.Execute<TState,TOut>(this Func<TState,TOut>, TState) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState).lambda') and returns its results.

```csharp
public static TOut Execute<TState,TOut>(this System.Func<TState,TOut> lambda, TState state);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState).TOut'></a>

`TOut`

Output type of the lambda
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState).TState')

Lambda state

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action)'></a>

## Lambdas.Execute<TState,TOut>(this Func<TState,TOut>, TState, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).lambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static TOut Execute<TState,TOut>(this System.Func<TState,TOut> lambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_)'></a>

## Lambdas.Execute<TState,TOut>(this Func<TState,TOut>, TState, Action<TState>) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).lambda') inside try block and returns its value
after executing [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static TOut Execute<TState,TOut>(this System.Func<TState,TOut> lambda, TState state, System.Action<TState> finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState)'></a>

## Lambdas.Execute<TState>(this Action<TState>, TState) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState).lambda').

```csharp
public static void Execute<TState>(this System.Action<TState> lambda, TState state);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action)'></a>

## Lambdas.Execute<TState>(this Action<TState>, TState, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState, System.Action).lambda') inside try block and
excutes [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static void Execute<TState>(this System.Action<TState> lambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState, System.Action).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action_TState_)'></a>

## Lambdas.Execute<TState>(this Action<TState>, TState, Action<TState>) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState, System.Action<TState>).lambda') inside try block and
executes [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState, System.Action<TState>).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static void Execute<TState>(this System.Action<TState> lambda, TState state, System.Action<TState> finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.Task_)'></a>

## Lambdas.ExecuteAsync(this Func<Task>) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.Task_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.Tasks.Task>).lambda') asynchronously.

```csharp
public static System.Threading.Tasks.Task ExecuteAsync(this System.Func<System.Threading.Tasks.Task> lambda);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.Task_).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action)'></a>

## Lambdas.ExecuteAsync(this Func<Task>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.Tasks.Task>, System.Action).asyncLambda') inside try block and returns
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.Tasks.Task>, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task ExecuteAsync(this System.Func<System.Threading.Tasks.Task> asyncLambda, System.Action finallyClause);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action)'></a>

## Lambdas.ExecuteAsync<TError>(this Func<Task>, Action<ExceptionDispatchInfo,TError>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).asyncLambda') inside try block.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).errorHandler').
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.Task ExecuteAsync<TError>(this System.Func<System.Threading.Tasks.Task> asyncLambda, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).TError')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action)'></a>

## Lambdas.ExecuteAsync<TOut,TError>(this Func<Task<TOut>>, Func<ExceptionDispatchInfo,TError,TOut>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>> asyncLambda, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__)'></a>

## Lambdas.ExecuteAsync<TOut>(this Func<Task<TOut>>) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>).lambda') asynchronously.

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>> lambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action)'></a>

## Lambdas.ExecuteAsync<TOut>(this Func<Task<TOut>>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Action).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>> asyncLambda, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action)'></a>

## Lambdas.ExecuteAsync<TState,TError>(this Func<TState,Task>, TState, Action<ExceptionDispatchInfo,TError,TState>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.Task ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task> asyncLambda, TState state, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_)'></a>

## Lambdas.ExecuteAsync<TState,TError>(this Func<TState,Task>, TState, Action<ExceptionDispatchInfo,TError,TState>, Action<TState>) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).errorHandler')
to obtain the return value.
And, [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).finallyClause') will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.Task ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task> asyncLambda, TState state, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState> errorHandler, System.Action<TState> finallyClause)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action)'></a>

## Lambdas.ExecuteAsync<TState,TOut,TError>(this Func<TState,Task<TOut>>, TState, Func<ExceptionDispatchInfo,TError,TState,TOut>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>> asyncLambda, TState state, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_)'></a>

## Lambdas.ExecuteAsync<TState,TOut,TError>(this Func<TState,Task<TOut>>, TState, Func<ExceptionDispatchInfo,TError,TState,TOut>, Action<TState>) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).errorHandler')
to obtain the return value.
And, [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).finallyClause') will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>> asyncLambda, TState state, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut> errorHandler, System.Action<TState> finallyClause)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState)'></a>

## Lambdas.ExecuteAsync<TState,TOut>(this Func<TState,Task<TOut>>, TState) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState).lambda') asynchronously.

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>> lambda, TState state);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState).TOut'></a>

`TOut`

Output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState).TState')

Lambda state

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action)'></a>

## Lambdas.ExecuteAsync<TState,TOut>(this Func<TState,Task<TOut>>, TState, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>> asyncLambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_)'></a>

## Lambdas.ExecuteAsync<TState,TOut>(this Func<TState,Task<TOut>>, TState, Action<TState>) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>> asyncLambda, TState state, System.Action<TState> finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState)'></a>

## Lambdas.ExecuteAsync<TState>(this Func<TState,Task>, TState) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState).lambda') asynchronously.

```csharp
public static System.Threading.Tasks.Task ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task> lambda, TState state);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState).TState')

Lambda state

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action)'></a>

## Lambdas.ExecuteAsync<TState>(this Func<TState,Task>, TState, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action).asyncLambda') inside try block and returns
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task> asyncLambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_)'></a>

## Lambdas.ExecuteAsync<TState>(this Func<TState,Task>, TState, Action<TState>) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>).asyncLambda') inside try block and returns
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task> asyncLambda, TState state, System.Action<TState> finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')