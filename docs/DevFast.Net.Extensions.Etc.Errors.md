#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.Etc](DevFast.Net.Extensions.Etc.md 'DevFast.Net.Extensions.Etc')

## Errors Class

Extension methods to throw or consume various kind of exceptions.

```csharp
public static class Errors
```
- *Methods*
  - **[Catch&lt;T,TError&gt;(this Func&lt;Task&lt;T&gt;&gt;, Func&lt;ExceptionDispatchInfo,TError,T&gt;, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action)')**
  - **[Catch&lt;T,TError&gt;(this Func&lt;ValueTask&lt;T&gt;&gt;, Func&lt;ExceptionDispatchInfo,TError,T&gt;, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action)')**
  - **[Catch&lt;T,TError&gt;(this Func&lt;T&gt;, Func&lt;ExceptionDispatchInfo,TError,T&gt;, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action)')**
  - **[Catch&lt;T&gt;(this Action, Action&lt;ExceptionDispatchInfo,T&gt;, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Catch<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action)')**
  - **[Finally(this Action, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally(thisSystem.Action,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Finally(this System.Action, System.Action)')**
  - **[Finally&lt;T,TFinal&gt;(this Action&lt;T&gt;, T, Action&lt;TFinal&gt;, TFinal)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal) 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TFinal>(this System.Action<T>, T, System.Action<TFinal>, TFinal)')**
  - **[Finally&lt;T,TState,TFinal&gt;(this Func&lt;TState,Task&lt;T&gt;&gt;, TState, Action&lt;TFinal&gt;, TFinal)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal) 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action<TFinal>, TFinal)')**
  - **[Finally&lt;T,TState,TFinal&gt;(this Func&lt;TState,ValueTask&lt;T&gt;&gt;, TState, Action&lt;TFinal&gt;, TFinal)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal) 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action<TFinal>, TFinal)')**
  - **[Finally&lt;T,TState,TFinal&gt;(this Func&lt;TState,T&gt;, TState, Action&lt;TFinal&gt;, TFinal)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal) 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,T>, TState, System.Action<TFinal>, TFinal)')**
  - **[Finally&lt;T,TState&gt;(this Func&lt;TState,Task&lt;T&gt;&gt;, Action&lt;TState&gt;, TState)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState) 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<TState>, TState)')**
  - **[Finally&lt;T,TState&gt;(this Func&lt;TState,Task&lt;T&gt;&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action)')**
  - **[Finally&lt;T,TState&gt;(this Func&lt;TState,ValueTask&lt;T&gt;&gt;, Action&lt;TState&gt;, TState)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState) 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<TState>, TState)')**
  - **[Finally&lt;T,TState&gt;(this Func&lt;TState,ValueTask&lt;T&gt;&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action)')**
  - **[Finally&lt;T,TState&gt;(this Func&lt;TState,T&gt;, Action&lt;TState&gt;, TState)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState) 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, System.Action<TState>, TState)')**
  - **[Finally&lt;T,TState&gt;(this Func&lt;TState,T&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, TState, System.Action)')**
  - **[Finally&lt;T&gt;(this Action&lt;T&gt;, Action&lt;T&gt;, T)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,System.Action_T_,T) 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Action<T>, System.Action<T>, T)')**
  - **[Finally&lt;T&gt;(this Action&lt;T&gt;, T, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,T,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Action<T>, T, System.Action)')**
  - **[Finally&lt;T&gt;(this Func&lt;Task&lt;T&gt;&gt;, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<System.Threading.Tasks.Task<T>>, System.Action)')**
  - **[Finally&lt;T&gt;(this Func&lt;ValueTask&lt;T&gt;&gt;, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Action)')**
  - **[Finally&lt;T&gt;(this Func&lt;T&gt;, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_T_,System.Action) 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<T>, System.Action)')**
  - **[ThrowArgumentExceptionForNull&lt;T&gt;(this T, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception)')**
  - **[ThrowArgumentExceptionForNullOrOnPredicateFail&lt;T&gt;(this T, Func&lt;T,bool&gt;, string, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception)')**
  - **[ThrowArgumentExceptionForNullOrOnPredicateSuccess&lt;T&gt;(this T, Func&lt;T,bool&gt;, string, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception)')**
  - **[ThrowArgumentExceptionOnPredicateFail&lt;T&gt;(this T, Func&lt;T,bool&gt;, string, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception)')**
  - **[ThrowArgumentExceptionOnPredicateSuccess&lt;T&gt;(this T, Func&lt;T,bool&gt;, string, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception)')**
  - **[ThrowInvalidOperationExceptionIfFalse(this bool, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(this bool, string, System.Exception)')**
  - **[ThrowInvalidOperationExceptionIfTrue(this bool, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(this bool, string, System.Exception)')**

## Errors Class

Extension methods to throw or consume various kind of exceptions.

```csharp
public static class Errors
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Errors
### Methods

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action)'></a>

## Errors.Catch<T,TError>(this Func<Task<T>>, Func<ExceptionDispatchInfo,TError,T>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).TError') (or
derived from [TError](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).TError')) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).errorHandler') may itself re-throw those, if needed.

```csharp
public static System.Threading.Tasks.Task<T> Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>> asyncLambda, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TError](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action)'></a>

## Errors.Catch<T,TError>(this Func<ValueTask<T>>, Func<ExceptionDispatchInfo,TError,T>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).TError') (or
derived from [TError](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).TError')) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).errorHandler') may itself re-throw those, if needed.

```csharp
public static System.Threading.Tasks.ValueTask<T> Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>> asyncLambda, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TError](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action)'></a>

## Errors.Catch<T,TError>(this Func<T>, Func<ExceptionDispatchInfo,TError,T>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).lambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).TError') (or
derived from [TError](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).TError')) occurs during [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).errorHandler') may itself re-throw those, if needed.

```csharp
public static T Catch<T,TError>(this System.Func<T> lambda, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TError](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action)'></a>

## Errors.Catch<T>(this Action, Action<ExceptionDispatchInfo,T>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Errors.Catch<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).lambda') inside try block.
If any exception of type [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).T') (or
derived from [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).T')) occurs during [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Errors.Catch<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Errors.Catch<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).errorHandler').
If any [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Catch<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Errors.Catch<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).errorHandler') may itself re-throw those, if needed.

```csharp
public static void Catch<T>(this System.Action lambda, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T> errorHandler, System.Action? finallyClause=null)
    where T : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).T'></a>

`T`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).lambda'></a>

`lambda` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Catch<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Errors.Catch_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally(thisSystem.Action,System.Action)'></a>

## Errors.Finally(this Action, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally(thisSystem.Action,System.Action).lambda 'DevFast.Net.Extensions.Etc.Errors.Finally(this System.Action, System.Action).lambda') inside try block and
excutes [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally(thisSystem.Action,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally(this System.Action, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static void Finally(this System.Action lambda, System.Action finallyClause);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally(thisSystem.Action,System.Action).lambda'></a>

`lambda` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally(thisSystem.Action,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal)'></a>

## Errors.Finally<T,TFinal>(this Action<T>, T, Action<TFinal>, TFinal) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).lambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TFinal>(this System.Action<T>, T, System.Action<TFinal>, TFinal).lambda') inside try block and
excutes [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TFinal>(this System.Action<T>, T, System.Action<TFinal>, TFinal).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static void Finally<T,TFinal>(this System.Action<T> lambda, T state, System.Action<TFinal> finallyClause, TFinal finallyState);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).TFinal'></a>

`TFinal`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TFinal>(this System.Action<T>, T, System.Action<TFinal>, TFinal).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).state'></a>

`state` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TFinal>(this System.Action<T>, T, System.Action<TFinal>, TFinal).T')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TFinal](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).TFinal 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TFinal>(this System.Action<T>, T, System.Action<TFinal>, TFinal).TFinal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).finallyState'></a>

`finallyState` [TFinal](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TFinal_(thisSystem.Action_T_,T,System.Action_TFinal_,TFinal).TFinal 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TFinal>(this System.Action<T>, T, System.Action<TFinal>, TFinal).TFinal')

Finally clause state

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal)'></a>

## Errors.Finally<T,TState,TFinal>(this Func<TState,Task<T>>, TState, Action<TFinal>, TFinal) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action<TFinal>, TFinal).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action<TFinal>, TFinal).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task<T> Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.Task<T>> asyncLambda, TState state, System.Action<TFinal> finallyClause, TFinal finallyState);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).TFinal'></a>

`TFinal`

Finally clause state type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action<TFinal>, TFinal).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action<TFinal>, TFinal).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action<TFinal>, TFinal).TState')

Lambda as well as finally clause state

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TFinal](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).TFinal 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action<TFinal>, TFinal).TFinal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).finallyState'></a>

`finallyState` [TFinal](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).TFinal 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action<TFinal>, TFinal).TFinal')

finally clause state

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action_TFinal_,TFinal).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action<TFinal>, TFinal).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal)'></a>

## Errors.Finally<T,TState,TFinal>(this Func<TState,ValueTask<T>>, TState, Action<TFinal>, TFinal) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action<TFinal>, TFinal).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action<TFinal>, TFinal).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.ValueTask<T> Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>> asyncLambda, TState state, System.Action<TFinal> finallyClause, TFinal finallyState);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).TFinal'></a>

`TFinal`

Finally clause state type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action<TFinal>, TFinal).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action<TFinal>, TFinal).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action<TFinal>, TFinal).TState')

Lambda as well as finally clause state

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TFinal](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).TFinal 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action<TFinal>, TFinal).TFinal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).finallyState'></a>

`finallyState` [TFinal](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).TFinal 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action<TFinal>, TFinal).TFinal')

finally clause state

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action_TFinal_,TFinal).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action<TFinal>, TFinal).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal)'></a>

## Errors.Finally<T,TState,TFinal>(this Func<TState,T>, TState, Action<TFinal>, TFinal) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).lambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,T>, TState, System.Action<TFinal>, TFinal).lambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,T>, TState, System.Action<TFinal>, TFinal).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static T Finally<T,TState,TFinal>(this System.Func<TState,T> lambda, TState state, System.Action<TFinal> finallyClause, TFinal finallyState);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).TState'></a>

`TState`

Lambda State type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).TFinal'></a>

`TFinal`

Finally clause state type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,T>, TState, System.Action<TFinal>, TFinal).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,T>, TState, System.Action<TFinal>, TFinal).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,T>, TState, System.Action<TFinal>, TFinal).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TFinal](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).TFinal 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,T>, TState, System.Action<TFinal>, TFinal).TFinal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).finallyState'></a>

`finallyState` [TFinal](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).TFinal 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,T>, TState, System.Action<TFinal>, TFinal).TFinal')

finally clause state

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState,TFinal_(thisSystem.Func_TState,T_,TState,System.Action_TFinal_,TFinal).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState,TFinal>(this System.Func<TState,T>, TState, System.Action<TFinal>, TFinal).T')

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState)'></a>

## Errors.Finally<T,TState>(this Func<TState,Task<T>>, Action<TState>, TState) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<TState>, TState).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<TState>, TState).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task<T> Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>> asyncLambda, System.Action<TState> finallyClause, TState state);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<TState>, TState).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<TState>, TState).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<TState>, TState).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<TState>, TState).TState')

Lambda as well as finally clause state

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_TState_,TState).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<TState>, TState).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action)'></a>

## Errors.Finally<T,TState>(this Func<TState,Task<T>>, TState, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task<T> Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>> asyncLambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,TState,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, TState, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState)'></a>

## Errors.Finally<T,TState>(this Func<TState,ValueTask<T>>, Action<TState>, TState) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<TState>, TState).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<TState>, TState).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.ValueTask<T> Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>> asyncLambda, System.Action<TState> finallyClause, TState state);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<TState>, TState).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<TState>, TState).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<TState>, TState).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<TState>, TState).TState')

Lambda as well as finally clause state

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_TState_,TState).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<TState>, TState).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action)'></a>

## Errors.Finally<T,TState>(this Func<TState,ValueTask<T>>, TState, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.ValueTask<T> Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>> asyncLambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,TState,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, TState, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState)'></a>

## Errors.Finally<T,TState>(this Func<TState,T>, Action<TState>, TState) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).lambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, System.Action<TState>, TState).lambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, System.Action<TState>, TState).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static T Finally<T,TState>(this System.Func<TState,T> lambda, System.Action<TState> finallyClause, TState state);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, System.Action<TState>, TState).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, System.Action<TState>, TState).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, System.Action<TState>, TState).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, System.Action<TState>, TState).TState')

Lambda as well as finally clause state

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,System.Action_TState_,TState).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, System.Action<TState>, TState).T')

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action)'></a>

## Errors.Finally<T,TState>(this Func<TState,T>, TState, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action).lambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, TState, System.Action).lambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static T Finally<T,TState>(this System.Func<TState,T> lambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action).T'></a>

`T`

Return type

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, TState, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, TState, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T,TState_(thisSystem.Func_TState,T_,TState,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T,TState>(this System.Func<TState,T>, TState, System.Action).T')

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,System.Action_T_,T)'></a>

## Errors.Finally<T>(this Action<T>, Action<T>, T) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,System.Action_T_,T).lambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Action<T>, System.Action<T>, T).lambda') inside try block and
excutes [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,System.Action_T_,T).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Action<T>, System.Action<T>, T).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static void Finally<T>(this System.Action<T> lambda, System.Action<T> finallyClause, T state);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,System.Action_T_,T).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,System.Action_T_,T).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,System.Action_T_,T).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Action<T>, System.Action<T>, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,System.Action_T_,T).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,System.Action_T_,T).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Action<T>, System.Action<T>, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,System.Action_T_,T).state'></a>

`state` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,System.Action_T_,T).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Action<T>, System.Action<T>, T).T')

Lambda as well as final clause state

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,T,System.Action)'></a>

## Errors.Finally<T>(this Action<T>, T, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,T,System.Action).lambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Action<T>, T, System.Action).lambda') inside try block and
excutes [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,T,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Action<T>, T, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static void Finally<T>(this System.Action<T> lambda, T state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,T,System.Action).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,T,System.Action).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,T,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Action<T>, T, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,T,System.Action).state'></a>

`state` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,T,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Action<T>, T, System.Action).T')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Action_T_,T,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Action)'></a>

## Errors.Finally<T>(this Func<Task<T>>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<System.Threading.Tasks.Task<T>>, System.Action).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<System.Threading.Tasks.Task<T>>, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task<T> Finally<T>(this System.Func<System.Threading.Tasks.Task<T>> asyncLambda, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Action).T'></a>

`T`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<System.Threading.Tasks.Task<T>>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<System.Threading.Tasks.Task<T>>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Action)'></a>

## Errors.Finally<T>(this Func<ValueTask<T>>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Action).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.ValueTask<T> Finally<T>(this System.Func<System.Threading.Tasks.ValueTask<T>> asyncLambda, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Action).T'></a>

`T`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_T_,System.Action)'></a>

## Errors.Finally<T>(this Func<T>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_T_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<T>, System.Action).lambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_T_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<T>, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static T Finally<T>(this System.Func<T> lambda, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_T_,System.Action).T'></a>

`T`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_T_,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_T_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.Finally_T_(thisSystem.Func_T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.Finally<T>(this System.Func<T>, System.Action).T')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception)'></a>

## Errors.ThrowArgumentExceptionForNull<T>(this T, string, Exception) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception).value') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
Otherwise, returns the [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception).value') for chaining purpose.

NOTE: If [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') is thrown, the message will be '{argumentName} was null.',
thus, a well-formed [argumentName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).argumentName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception).argumentName') will make more sense during debugging or log-analysis.

```csharp
public static T ThrowArgumentExceptionForNull<T>(this T? value, string argumentName, System.Exception? innerException=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception).T')

Value to check

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).argumentName'></a>

`argumentName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the argument supplied as value

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception).T')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception)'></a>

## Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, Func<T,bool>, string, string, Exception) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null')
or if the [predicate](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicate') evaluates to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, returns the [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') for chaining purpose.

NOTE: If [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') is thrown, the message will be
'{argumentName} does not satisfy {predicateName ?? predicate}.',
thus, a well-formed [argumentName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).argumentName') and/or [predicateName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicateName')
will make more sense during debugging or log-analysis.

```csharp
public static T ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T? value, System.Func<T,bool> predicate, string argumentName, string? predicateName=null, System.Exception? innerException=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

Value to check

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Predicate to evaluate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName'></a>

`argumentName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the argument supplied as value

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName'></a>

`predicateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the predicate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception)'></a>

## Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, Func<T,bool>, string, string, Exception) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null')
or if the [predicate](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicate') evaluates to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, returns the [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') for chaining purpose.

NOTE: If [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') is thrown, the message will be
'{argumentName} satisfied {predicateName ?? predicate}.',
thus, a well-formed [argumentName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).argumentName') and/or [predicateName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicateName')
will make more sense during debugging or log-analysis.

```csharp
public static T ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T? value, System.Func<T,bool> predicate, string argumentName, string? predicateName=null, System.Exception? innerException=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

Value to check

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Predicate to evaluate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName'></a>

`argumentName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the argument supplied as value

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName'></a>

`predicateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the predicate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception)'></a>

## Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, Func<T,bool>, string, string, Exception) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if [predicate](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicate') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, always returns [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') for chaining purpose.

NOTE: If [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') is thrown, the message will be
'{argumentName} does not satisfy {predicateName ?? predicate}.',
thus, a well-formed [argumentName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).argumentName') and [predicateName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicateName')
will make more sense during debugging or log-analysis.

```csharp
public static T ThrowArgumentExceptionOnPredicateFail<T>(this T value, System.Func<T,bool> predicate, string argumentName, string? predicateName=null, System.Exception? innerException=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

Value to evaluate predicate on

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Predicate lambda

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName'></a>

`argumentName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the argument

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName'></a>

`predicateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the predicate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception)'></a>

## Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, Func<T,bool>, string, string, Exception) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if [predicate](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicate') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, always returns [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') for chaining purpose.

NOTE: If [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') is thrown, the message will be
'{argumentName} satisfied {predicateName ?? predicate}.',
thus, a well-formed [argumentName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).argumentName') and [predicateName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicateName')
will make more sense during debugging or log-analysis.

```csharp
public static T ThrowArgumentExceptionOnPredicateSuccess<T>(this T value, System.Func<T,bool> predicate, string argumentName, string? predicateName=null, System.Exception? innerException=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

Value to evaluate predicate on

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Predicate lambda

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName'></a>

`argumentName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the argument

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName'></a>

`predicateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the predicate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception)'></a>

## Errors.ThrowInvalidOperationExceptionIfFalse(this bool, string, Exception) Method

Throws an [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException') if [flag](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception).flag 'DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(this bool, string, System.Exception).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, always returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') for chaining purpose.

```csharp
public static bool ThrowInvalidOperationExceptionIfFalse(this bool flag, string message, System.Exception? innerException=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Flag value to check

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Message of the [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception)'></a>

## Errors.ThrowInvalidOperationExceptionIfTrue(this bool, string, Exception) Method

Throws an [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException') if [flag](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception).flag 'DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(this bool, string, System.Exception).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, always returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') for chaining purpose.

```csharp
public static bool ThrowInvalidOperationExceptionIfTrue(this bool flag, string message, System.Exception? innerException=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Flag value to check

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Message of the [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')