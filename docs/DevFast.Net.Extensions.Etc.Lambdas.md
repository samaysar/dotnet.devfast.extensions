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
  - **[Execute(this Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute(thisSystem.Action) 'DevFast.Net.Extensions.Etc.Lambdas.Execute(this System.Action)')**
  - **[Execute&lt;T&gt;(this Func&lt;T&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_T_(thisSystem.Func_T_) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<T>(this System.Func<T>)')**
  - **[Execute&lt;TState,TOut&gt;(this Func&lt;TState,TOut&gt;, TState)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState,TOut_(thisSystem.Func_TState,TOut_,TState) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState,TOut>(this System.Func<TState,TOut>, TState)')**
  - **[Execute&lt;TState&gt;(this Action&lt;TState&gt;, TState)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Execute_TState_(thisSystem.Action_TState_,TState) 'DevFast.Net.Extensions.Etc.Lambdas.Execute<TState>(this System.Action<TState>, TState)')**
  - **[ExecuteAsync(this Func&lt;Task&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.Task_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.Tasks.Task>)')**
  - **[ExecuteAsync(this Func&lt;ValueTask&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.ValueTask_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.Tasks.ValueTask>)')**
  - **[ExecuteAsync&lt;TOut&gt;(this Func&lt;Task&lt;TOut&gt;&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>)')**
  - **[ExecuteAsync&lt;TOut&gt;(this Func&lt;ValueTask&lt;TOut&gt;&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>)')**
  - **[ExecuteAsync&lt;TState,TOut&gt;(this Func&lt;TState,Task&lt;TOut&gt;&gt;, TState)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState)')**
  - **[ExecuteAsync&lt;TState,TOut&gt;(this Func&lt;TState,ValueTask&lt;TOut&gt;&gt;, TState)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState)')**
  - **[ExecuteAsync&lt;TState&gt;(this Func&lt;TState,Task&gt;, TState)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState)')**
  - **[ExecuteAsync&lt;TState&gt;(this Func&lt;TState,ValueTask&gt;, TState)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState)')**
  - **[ExecuteWithCatch&lt;TError&gt;(this Action, Action&lt;ExceptionDispatchInfo,TError&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action)')**
  - **[ExecuteWithCatch&lt;TOut,TError&gt;(this Func&lt;TOut&gt;, Func&lt;ExceptionDispatchInfo,TError,TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action)')**
  - **[ExecuteWithCatch&lt;TState,TError&gt;(this Action&lt;TState&gt;, TState, Action&lt;ExceptionDispatchInfo,TError,TState&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action)')**
  - **[ExecuteWithCatch&lt;TState,TOut,TError&gt;(this Func&lt;TState,TOut&gt;, TState, Func&lt;ExceptionDispatchInfo,TError,TState,TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action)')**
  - **[ExecuteWithCatchAsync&lt;TError&gt;(this Func&lt;Task&gt;, Action&lt;ExceptionDispatchInfo,TError&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action)')**
  - **[ExecuteWithCatchAsync&lt;TError&gt;(this Func&lt;ValueTask&gt;, Action&lt;ExceptionDispatchInfo,TError&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.ValueTask>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action)')**
  - **[ExecuteWithCatchAsync&lt;TOut,TError&gt;(this Func&lt;Task&lt;TOut&gt;&gt;, Func&lt;ExceptionDispatchInfo,TError,TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action)')**
  - **[ExecuteWithCatchAsync&lt;TOut,TError&gt;(this Func&lt;ValueTask&lt;TOut&gt;&gt;, Func&lt;ExceptionDispatchInfo,TError,TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action)')**
  - **[ExecuteWithCatchAsync&lt;TState,TError&gt;(this Func&lt;TState,Task&gt;, TState, Action&lt;ExceptionDispatchInfo,TError,TState&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action)')**
  - **[ExecuteWithCatchAsync&lt;TState,TError&gt;(this Func&lt;TState,ValueTask&gt;, TState, Action&lt;ExceptionDispatchInfo,TError,TState&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action)')**
  - **[ExecuteWithCatchAsync&lt;TState,TOut,TError&gt;(this Func&lt;TState,Task&lt;TOut&gt;&gt;, TState, Func&lt;ExceptionDispatchInfo,TError,TState,TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action)')**
  - **[ExecuteWithCatchAsync&lt;TState,TOut,TError&gt;(this Func&lt;TState,ValueTask&lt;TOut&gt;&gt;, TState, Func&lt;ExceptionDispatchInfo,TError,TState,TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action)')**
  - **[ExecuteWithFinally(this Action, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally(thisSystem.Action,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally(this System.Action, System.Action)')**
  - **[ExecuteWithFinally&lt;TOut&gt;(this Func&lt;TOut&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TOut_(thisSystem.Func_TOut_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TOut>(this System.Func<TOut>, System.Action)')**
  - **[ExecuteWithFinally&lt;TState,TOut&gt;(this Func&lt;TState,TOut&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action)')**
  - **[ExecuteWithFinally&lt;TState,TOut&gt;(this Func&lt;TState,TOut&gt;, TState, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>)')**
  - **[ExecuteWithFinally&lt;TState&gt;(this Action&lt;TState&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState>(this System.Action<TState>, TState, System.Action)')**
  - **[ExecuteWithFinally&lt;TState&gt;(this Action&lt;TState&gt;, TState, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState>(this System.Action<TState>, TState, System.Action<TState>)')**
  - **[ExecuteWithFinallyAsync(this Func&lt;Task&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(this System.Func<System.Threading.Tasks.Task>, System.Action)')**
  - **[ExecuteWithFinallyAsync(this Func&lt;ValueTask&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(this System.Func<System.Threading.Tasks.ValueTask>, System.Action)')**
  - **[ExecuteWithFinallyAsync&lt;TOut&gt;(this Func&lt;Task&lt;TOut&gt;&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Action)')**
  - **[ExecuteWithFinallyAsync&lt;TOut&gt;(this Func&lt;ValueTask&lt;TOut&gt;&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Action)')**
  - **[ExecuteWithFinallyAsync&lt;TState,TOut&gt;(this Func&lt;TState,Task&lt;TOut&gt;&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action)')**
  - **[ExecuteWithFinallyAsync&lt;TState,TOut&gt;(this Func&lt;TState,Task&lt;TOut&gt;&gt;, TState, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>)')**
  - **[ExecuteWithFinallyAsync&lt;TState,TOut&gt;(this Func&lt;TState,Task&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action)')**
  - **[ExecuteWithFinallyAsync&lt;TState,TOut&gt;(this Func&lt;TState,ValueTask&lt;TOut&gt;&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action)')**
  - **[ExecuteWithFinallyAsync&lt;TState,TOut&gt;(this Func&lt;TState,ValueTask&lt;TOut&gt;&gt;, TState, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action<TState>)')**
  - **[ExecuteWithFinallyAsync&lt;TState&gt;(this Func&lt;TState,Task&gt;, TState, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>)')**
  - **[ExecuteWithFinallyAsync&lt;TState&gt;(this Func&lt;TState,ValueTask&gt;, TState, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action)')**
  - **[ExecuteWithFinallyAsync&lt;TState&gt;(this Func&lt;TState,ValueTask&gt;, TState, Action&lt;TState&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_TState_) 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<TState>)')**
  - **[Pipe&lt;T&gt;(this Func&lt;CancellationToken,Task&lt;T&gt;&gt;, Func&lt;T,CancellationToken,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T&gt;(this Func&lt;CancellationToken,ValueTask&lt;T&gt;&gt;, Func&lt;T,CancellationToken,ValueTask&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_T__,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<T>>, bool)')**
  - **[Pipe&lt;T&gt;(this Func&lt;CancellationToken,T&gt;, Func&lt;T,CancellationToken,T&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_System.Threading.CancellationToken,T_,System.Func_T,System.Threading.CancellationToken,T_,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<System.Threading.CancellationToken,T>, System.Func<T,System.Threading.CancellationToken,T>, bool)')**
  - **[Pipe&lt;T&gt;(this Func&lt;T&gt;, Func&lt;T,CancellationToken,T&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool)')**
  - **[Pipe&lt;T&gt;(this Task&lt;T&gt;, Func&lt;T,CancellationToken,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T&gt;(this T, Func&lt;T,CancellationToken,T&gt;, bool)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool)')**
  - **[Pipe&lt;TIn,TTandem&gt;(this Func&lt;CancellationToken,Task&lt;TIn&gt;&gt;, Func&lt;TIn,CancellationToken,Task&lt;TTandem&gt;&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_TTandem__) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task<TTandem>>)')**
  - **[Pipe&lt;TIn,TTandem&gt;(this Func&lt;CancellationToken,ValueTask&lt;TIn&gt;&gt;, Func&lt;TIn,CancellationToken,ValueTask&lt;TTandem&gt;&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TTandem__) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TTandem>>)')**
  - **[Pipe&lt;TIn,TTandem&gt;(this Func&lt;CancellationToken,TIn&gt;, Func&lt;TIn,CancellationToken,TTandem&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Func_TIn,System.Threading.CancellationToken,TTandem_) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<System.Threading.CancellationToken,TIn>, System.Func<TIn,System.Threading.CancellationToken,TTandem>)')**
  - **[Pipe&lt;TIn,TTandem&gt;(this Func&lt;TIn&gt;, Func&lt;TIn,TTandem&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn,TTandem_(thisSystem.Func_TIn_,System.Func_TIn,TTandem_) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn,TTandem>(this System.Func<TIn>, System.Func<TIn,TTandem>)')**
  - **[Pipe&lt;TIn&gt;(this Func&lt;CancellationToken,Task&lt;TIn&gt;&gt;, Func&lt;TIn,CancellationToken,Task&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task>)')**
  - **[Pipe&lt;TIn&gt;(this Func&lt;CancellationToken,ValueTask&lt;TIn&gt;&gt;, Func&lt;TIn,CancellationToken,ValueTask&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask>)')**
  - **[Pipe&lt;TIn&gt;(this Func&lt;CancellationToken,TIn&gt;, Action&lt;TIn,CancellationToken&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Action_TIn,System.Threading.CancellationToken_) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,TIn>, System.Action<TIn,System.Threading.CancellationToken>)')**
  - **[Pipe&lt;TIn&gt;(this Func&lt;TIn&gt;, Action&lt;TIn&gt;)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_TIn_,System.Action_TIn_) 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<TIn>, System.Action<TIn>)')**
  - **[PipeCatch&lt;T,TError&gt;(this Func&lt;T&gt;, Func&lt;ExceptionDispatchInfo,TError,T&gt;, Action)](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action) 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action)')**

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

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.ValueTask_)'></a>

## Lambdas.ExecuteAsync(this Func<ValueTask>) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.ValueTask_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(this System.Func<System.Threading.Tasks.ValueTask>).lambda') asynchronously.

```csharp
public static System.Threading.Tasks.ValueTask ExecuteAsync(this System.Func<System.Threading.Tasks.ValueTask> lambda);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync(thisSystem.Func_System.Threading.Tasks.ValueTask_).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute.

#### Returns
[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')

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

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__)'></a>

## Lambdas.ExecuteAsync<TOut>(this Func<ValueTask<TOut>>) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>).lambda') asynchronously.

```csharp
public static System.Threading.Tasks.ValueTask<TOut> ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.ValueTask<TOut>> lambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute.

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TOut>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

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

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState)'></a>

## Lambdas.ExecuteAsync<TState,TOut>(this Func<TState,ValueTask<TOut>>, TState) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState).lambda') asynchronously.

```csharp
public static System.Threading.Tasks.ValueTask<TOut> ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>> lambda, TState state);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState).TOut'></a>

`TOut`

Output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState).TState')

Lambda state

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

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

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState)'></a>

## Lambdas.ExecuteAsync<TState>(this Func<TState,ValueTask>, TState) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState).lambda') asynchronously.

```csharp
public static System.Threading.Tasks.ValueTask ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask> lambda, TState state);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState).TState')

Lambda state

#### Returns
[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action)'></a>

## Lambdas.ExecuteWithCatch<TError>(this Action, Action<ExceptionDispatchInfo,TError>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).lambda') inside try block.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).TError') (or
its derived types) occurs during [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).errorHandler').
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static void ExecuteWithCatch<TError>(this System.Action lambda, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).lambda'></a>

`lambda` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TError>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).TError')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TError_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action)'></a>

## Lambdas.ExecuteWithCatch<TOut,TError>(this Func<TOut>, Func<ExceptionDispatchInfo,TError,TOut>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).lambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TError') (or
its derived types) occurs during [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static TOut ExecuteWithCatch<TOut,TError>(this System.Func<TOut> lambda, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TOut,TError_(thisSystem.Func_TOut_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TOut,TError>(this System.Func<TOut>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action)'></a>

## Lambdas.ExecuteWithCatch<TState,TError>(this Action<TState>, TState, Action<ExceptionDispatchInfo,TError,TState>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).lambda') inside try block.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TError') (or
its derived types) occurs during [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).errorHandler').
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static void ExecuteWithCatch<TState,TError>(this System.Action<TState> lambda, TState state, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TError>(this System.Action<TState>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TError_(thisSystem.Action_TState_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action)'></a>

## Lambdas.ExecuteWithCatch<TState,TOut,TError>(this Func<TState,TOut>, TState, Func<ExceptionDispatchInfo,TError,TState,TOut>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).lambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TError') (or
its derived types) occurs during [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static TOut ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut> lambda, TState state, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch_TState,TOut,TError_(thisSystem.Func_TState,TOut_,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatch<TState,TOut,TError>(this System.Func<TState,TOut>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action)'></a>

## Lambdas.ExecuteWithCatchAsync<TError>(this Func<Task>, Action<ExceptionDispatchInfo,TError>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).asyncLambda') inside try block.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).errorHandler').
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.Task ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.Task> asyncLambda, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.Task>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).TError')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.Task_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action)'></a>

## Lambdas.ExecuteWithCatchAsync<TError>(this Func<ValueTask>, Action<ExceptionDispatchInfo,TError>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.ValueTask>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).asyncLambda') inside try block.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.ValueTask>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.ValueTask>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.ValueTask>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).errorHandler').
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.ValueTask>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.ValueTask>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.ValueTask ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.ValueTask> asyncLambda, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TError>(this System.Func<System.Threading.Tasks.ValueTask>, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError>, System.Action).TError')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action)'></a>

## Lambdas.ExecuteWithCatchAsync<TOut,TError>(this Func<Task<TOut>>, Func<ExceptionDispatchInfo,TError,TOut>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>> asyncLambda, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action)'></a>

## Lambdas.ExecuteWithCatchAsync<TOut,TError>(this Func<ValueTask<TOut>>, Func<ExceptionDispatchInfo,TError,TOut>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.ValueTask<TOut> ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>> asyncLambda, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TOut,TError_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TOut,TError>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action)'></a>

## Lambdas.ExecuteWithCatchAsync<TState,TError>(this Func<TState,Task>, TState, Action<ExceptionDispatchInfo,TError,TState>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.Task ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task> asyncLambda, TState state, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action)'></a>

## Lambdas.ExecuteWithCatchAsync<TState,TError>(this Func<TState,ValueTask>, TState, Action<ExceptionDispatchInfo,TError,TState>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.ValueTask ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask> asyncLambda, TState state, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState>, System.Action).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-3 'System.Action`3')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action)'></a>

## Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this Func<TState,Task<TOut>>, TState, Func<ExceptionDispatchInfo,TError,TState,TOut>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>> asyncLambda, TState state, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action)'></a>

## Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this Func<TState,ValueTask<TOut>>, TState, Func<ExceptionDispatchInfo,TError,TState,TOut>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).asyncLambda') inside try block and returns its value.
If any exception of type [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TError') (or
its derived types) occurs during [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).asyncLambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).errorHandler')
to obtain the return value.
If any [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).finallyClause') is provided, it will be executed inside finally.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.

```csharp
public static System.Threading.Tasks.ValueTask<TOut> ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>> asyncLambda, TState state, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut'></a>

`TOut`

Return type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync_TState,TOut,TError_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithCatchAsync<TState,TOut,TError>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,TState,TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally(thisSystem.Action,System.Action)'></a>

## Lambdas.ExecuteWithFinally(this Action, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally(thisSystem.Action,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally(this System.Action, System.Action).lambda') inside try block and
excutes [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally(thisSystem.Action,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally(this System.Action, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static void ExecuteWithFinally(this System.Action lambda, System.Action finallyClause);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally(thisSystem.Action,System.Action).lambda'></a>

`lambda` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally(thisSystem.Action,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TOut_(thisSystem.Func_TOut_,System.Action)'></a>

## Lambdas.ExecuteWithFinally<TOut>(this Func<TOut>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TOut_(thisSystem.Func_TOut_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TOut>(this System.Func<TOut>, System.Action).lambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TOut_(thisSystem.Func_TOut_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TOut>(this System.Func<TOut>, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static TOut ExecuteWithFinally<TOut>(this System.Func<TOut> lambda, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TOut_(thisSystem.Func_TOut_,System.Action).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TOut_(thisSystem.Func_TOut_,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TOut_(thisSystem.Func_TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TOut>(this System.Func<TOut>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TOut_(thisSystem.Func_TOut_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TOut_(thisSystem.Func_TOut_,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TOut>(this System.Func<TOut>, System.Action).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action)'></a>

## Lambdas.ExecuteWithFinally<TState,TOut>(this Func<TState,TOut>, TState, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).lambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static TOut ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut> lambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_)'></a>

## Lambdas.ExecuteWithFinally<TState,TOut>(this Func<TState,TOut>, TState, Action<TState>) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).lambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static TOut ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut> lambda, TState state, System.Action<TState> finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

#### Returns
[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState,TOut_(thisSystem.Func_TState,TOut_,TState,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState,TOut>(this System.Func<TState,TOut>, TState, System.Action<TState>).TOut')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action)'></a>

## Lambdas.ExecuteWithFinally<TState>(this Action<TState>, TState, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState>(this System.Action<TState>, TState, System.Action).lambda') inside try block and
excutes [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState>(this System.Action<TState>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static void ExecuteWithFinally<TState>(this System.Action<TState> lambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState>(this System.Action<TState>, TState, System.Action).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState>(this System.Action<TState>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action_TState_)'></a>

## Lambdas.ExecuteWithFinally<TState>(this Action<TState>, TState, Action<TState>) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).lambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState>(this System.Action<TState>, TState, System.Action<TState>).lambda') inside try block and
excutes [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState>(this System.Action<TState>, TState, System.Action<TState>).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static void ExecuteWithFinally<TState>(this System.Action<TState> lambda, TState state, System.Action<TState> finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).lambda'></a>

`lambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState>(this System.Action<TState>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState>(this System.Action<TState>, TState, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally_TState_(thisSystem.Action_TState_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinally<TState>(this System.Action<TState>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action)'></a>

## Lambdas.ExecuteWithFinallyAsync(this Func<Task>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(this System.Func<System.Threading.Tasks.Task>, System.Action).asyncLambda') inside try block and returns
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(this System.Func<System.Threading.Tasks.Task>, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task ExecuteWithFinallyAsync(this System.Func<System.Threading.Tasks.Task> asyncLambda, System.Action finallyClause);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.Task_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action)'></a>

## Lambdas.ExecuteWithFinallyAsync(this Func<ValueTask>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(this System.Func<System.Threading.Tasks.ValueTask>, System.Action).asyncLambda') inside try block and returns
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(this System.Func<System.Threading.Tasks.ValueTask>, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.ValueTask ExecuteWithFinallyAsync(this System.Func<System.Threading.Tasks.ValueTask> asyncLambda, System.Action finallyClause);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync(thisSystem.Func_System.Threading.Tasks.ValueTask_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action)'></a>

## Lambdas.ExecuteWithFinallyAsync<TOut>(this Func<Task<TOut>>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Action).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>> asyncLambda, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.Task_TOut__,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.Task<TOut>>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Action)'></a>

## Lambdas.ExecuteWithFinallyAsync<TOut>(this Func<ValueTask<TOut>>, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Action).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.ValueTask<TOut> ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.ValueTask<TOut>> asyncLambda, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Action).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TOut__,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TOut>(this System.Func<System.Threading.Tasks.ValueTask<TOut>>, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action)'></a>

## Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this Func<TState,Task<TOut>>, TState, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>> asyncLambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_)'></a>

## Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this Func<TState,Task<TOut>>, TState, Action<TState>) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task<TOut> ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>> asyncLambda, TState state, System.Action<TState> finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TOut__,TState,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TOut>>, TState, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action)'></a>

## Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this Func<TState,Task>, TState, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action).asyncLambda') inside try block and returns
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task> asyncLambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action)'></a>

## Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this Func<TState,ValueTask<TOut>>, TState, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.ValueTask<TOut> ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>> asyncLambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_)'></a>

## Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this Func<TState,ValueTask<TOut>>, TState, Action<TState>) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action<TState>).asyncLambda') inside try block and returns its value
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action<TState>).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.ValueTask<TOut> ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>> asyncLambda, TState state, System.Action<TState> finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).TState'></a>

`TState`

State type

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).TOut'></a>

`TOut`

Return type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TOut__,TState,System.Action_TState_).TOut 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TOut>>, TState, System.Action<TState>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_)'></a>

## Lambdas.ExecuteWithFinallyAsync<TState>(this Func<TState,Task>, TState, Action<TState>) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>).asyncLambda') inside try block and returns
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.Task ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task> asyncLambda, TState state, System.Action<TState> finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.Task>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action)'></a>

## Lambdas.ExecuteWithFinallyAsync<TState>(this Func<TState,ValueTask>, TState, Action) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action).asyncLambda') inside try block and returns
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.ValueTask ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask> asyncLambda, TState state, System.Action finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_TState_)'></a>

## Lambdas.ExecuteWithFinallyAsync<TState>(this Func<TState,ValueTask>, TState, Action<TState>) Method

Asynchronously executes [asyncLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_TState_).asyncLambda 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<TState>).asyncLambda') inside try block and returns
after excuting [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_TState_).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<TState>).finallyClause') inside finally.

NOTE: The code itself will NOT catch any [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').

```csharp
public static System.Threading.Tasks.ValueTask ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask> asyncLambda, TState state, System.Action<TState> finallyClause);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_TState_).TState'></a>

`TState`

State type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_TState_).asyncLambda'></a>

`asyncLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_TState_).state'></a>

`state` [TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<TState>).TState')

Lambda state

<a name='DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_TState_).finallyClause'></a>

`finallyClause` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync_TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_,TState,System.Action_TState_).TState 'DevFast.Net.Extensions.Etc.Lambdas.ExecuteWithFinallyAsync<TState>(this System.Func<TState,System.Threading.Tasks.ValueTask>, TState, System.Action<TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Code to run inside finally clause

#### Returns
[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')

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

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool)'></a>

## Lambdas.Pipe<T>(this Func<T>, Func<T,CancellationToken,T>, bool) Method

Provides a cancellable ([System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') based) conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).flag 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).flag 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).sourceLambda').

```csharp
public static System.Func<System.Threading.CancellationToken,T> Pipe<T>(this System.Func<T> sourceLambda, System.Func<T,System.Threading.CancellationToken,T> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).T'></a>

`T`

Lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Func_T_,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Func<T>, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool)'></a>

## Lambdas.Pipe<T>(this Task<T>, Func<T,CancellationToken,Task<T>>, bool) Method

Provides a cancellable ([System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') based) conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).task 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).task') to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).task 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).task').

IMPLEMENTATION NOTE: Calling this method on a non-running [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') is advisable (though NOT necessary).
As the purpose of pipelines is to executes everything as lazily as possible.
Irrespective to the state of the [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).task 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).task') outcome would be identical.

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> Pipe<T>(this System.Threading.Tasks.Task<T> task, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).T'></a>

`T`

Lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [task](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).task 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).task').

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,System.Threading.CancellationToken,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this System.Threading.Tasks.Task<T>, System.Func<T,System.Threading.CancellationToken,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool)'></a>

## Lambdas.Pipe<T>(this T, Func<T,CancellationToken,T>, bool) Method

Provides a cancellable ([System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken') based) conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).flag 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds [value](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).value 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool).value')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).flag 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the original
[value](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).value 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool).value').

```csharp
public static System.Func<System.Threading.CancellationToken,T> Pipe<T>(this T value, System.Func<T,System.Threading.CancellationToken,T> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).T'></a>

`T`

Lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool).T')

Value to feed

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_T_(thisT,System.Func_T,System.Threading.CancellationToken,T_,bool).T 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<T>(this T, System.Func<T,System.Threading.CancellationToken,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

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

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_)'></a>

## Lambdas.Pipe<TIn>(this Func<CancellationToken,Task<TIn>>, Func<TIn,CancellationToken,Task>) Method

Merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task>).tandemLambda').
Returns a newly formed Asynchronous lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task>).tandemLambda') upon execution.

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task> Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>> sourceLambda, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_).TIn'></a>

`TIn`

Source lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.Task>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of the input lambda.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_)'></a>

## Lambdas.Pipe<TIn>(this Func<CancellationToken,ValueTask<TIn>>, Func<TIn,CancellationToken,ValueTask>) Method

Merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask>).tandemLambda').
Returns a newly formed Asynchronous lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask>).tandemLambda') upon execution.

```csharp
public static System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask> Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>> sourceLambda, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_).TIn'></a>

`TIn`

Source lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of the input lambda.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Action_TIn,System.Threading.CancellationToken_)'></a>

## Lambdas.Pipe<TIn>(this Func<CancellationToken,TIn>, Action<TIn,CancellationToken>) Method

Merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Action_TIn,System.Threading.CancellationToken_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,TIn>, System.Action<TIn,System.Threading.CancellationToken>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Action_TIn,System.Threading.CancellationToken_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,TIn>, System.Action<TIn,System.Threading.CancellationToken>).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Action_TIn,System.Threading.CancellationToken_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,TIn>, System.Action<TIn,System.Threading.CancellationToken>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Action_TIn,System.Threading.CancellationToken_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,TIn>, System.Action<TIn,System.Threading.CancellationToken>).tandemLambda') upon execution.

```csharp
public static System.Action<System.Threading.CancellationToken> Pipe<TIn>(this System.Func<System.Threading.CancellationToken,TIn> sourceLambda, System.Action<TIn,System.Threading.CancellationToken> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Action_TIn,System.Threading.CancellationToken_).TIn'></a>

`TIn`

Source lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Action_TIn,System.Threading.CancellationToken_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Action_TIn,System.Threading.CancellationToken_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,TIn>, System.Action<TIn,System.Threading.CancellationToken>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Action_TIn,System.Threading.CancellationToken_).tandemLambda'></a>

`tandemLambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_System.Threading.CancellationToken,TIn_,System.Action_TIn,System.Threading.CancellationToken_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<System.Threading.CancellationToken,TIn>, System.Action<TIn,System.Threading.CancellationToken>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Tandem lambda that would consume the output of the input lambda.

#### Returns
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_TIn_,System.Action_TIn_)'></a>

## Lambdas.Pipe<TIn>(this Func<TIn>, Action<TIn>) Method

Merges the [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_TIn_,System.Action_TIn_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<TIn>, System.Action<TIn>).sourceLambda') with [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_TIn_,System.Action_TIn_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<TIn>, System.Action<TIn>).tandemLambda').
Returns a newly formed lambda which will feed the output of [sourceLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_TIn_,System.Action_TIn_).sourceLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<TIn>, System.Action<TIn>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_TIn_,System.Action_TIn_).tandemLambda 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<TIn>, System.Action<TIn>).tandemLambda') upon execution.

```csharp
public static System.Action Pipe<TIn>(this System.Func<TIn> sourceLambda, System.Action<TIn> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_TIn_,System.Action_TIn_).TIn'></a>

`TIn`

Source lambda output type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_TIn_,System.Action_TIn_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_TIn_,System.Action_TIn_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<TIn>, System.Action<TIn>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_TIn_,System.Action_TIn_).tandemLambda'></a>

`tandemLambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TIn](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.Pipe_TIn_(thisSystem.Func_TIn_,System.Action_TIn_).TIn 'DevFast.Net.Extensions.Etc.Lambdas.Pipe<TIn>(this System.Func<TIn>, System.Action<TIn>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Tandem lambda that would consume the output of the input lambda.

#### Returns
[System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

<a name='DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action)'></a>

## Lambdas.PipeCatch<T,TError>(this Func<T>, Func<ExceptionDispatchInfo,TError,T>, Action) Method

Executes the given [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).lambda') inside try block of try-catch construct and
returns its results. In case, an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') of [TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).TError')
type (or its derived types) occurs it is caught; then [errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).errorHandler')
is invoked with relevant arguments and executed inside catch block and its
output is returned.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).errorHandler') may itself re-throw those (e.g.
[System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw 'System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw')), if needed.
If [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).finallyClause') is provided, [lambda](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).lambda')
executes inside try block and [finallyClause](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).finallyClause') executes
inside finally block of the try-finally construct.

```csharp
public static T? PipeCatch<T,TError>(this System.Func<T> lambda, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T> errorHandler, System.Action? finallyClause=null)
    where TError : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T'></a>

`T`

Output type of the lambda

<a name='DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError'></a>

`TError`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).lambda'></a>

`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Lambda to execute.

<a name='DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).errorHandler'></a>

`errorHandler` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TError](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).TError 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).TError')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Exception handler

<a name='DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to execute in finally block of try-finally (if any)

#### Returns
[T](DevFast.Net.Extensions.Etc.Lambdas.md#DevFast.Net.Extensions.Etc.Lambdas.PipeCatch_T,TError_(thisSystem.Func_T_,System.Func_System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Lambdas.PipeCatch<T,TError>(this System.Func<T>, System.Func<System.Runtime.ExceptionServices.ExceptionDispatchInfo,TError,T>, System.Action).T')