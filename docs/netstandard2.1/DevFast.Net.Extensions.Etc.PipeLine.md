#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.Etc](DevFast.Net.Extensions.Etc.md 'DevFast.Net.Extensions.Etc')

## PipeLine Class

Extension methods on Lambdas to create a executable Pipeline.

```csharp
public static class PipeLine
```
- *Methods*
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,Task&lt;T&gt;&gt;, Action&lt;T,TTanState&gt;, Func&lt;TTanState,TSrcState&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,Task&lt;T&gt;&gt;, Func&lt;T,TTanState,Task&lt;T&gt;&gt;, Func&lt;TTanState,TSrcState&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,Task&lt;T&gt;&gt;, Func&lt;T,TTanState,Task&gt;, Func&lt;TTanState,TSrcState&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,Task&lt;T&gt;&gt;, Func&lt;T,TTanState,T&gt;, Func&lt;TTanState,TSrcState&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,ValueTask&lt;T&gt;&gt;, Action&lt;T,TTanState&gt;, Func&lt;TTanState,TSrcState&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,ValueTask&lt;T&gt;&gt;, Func&lt;T,TTanState,Task&lt;T&gt;&gt;, Func&lt;TTanState,TSrcState&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,ValueTask&lt;T&gt;&gt;, Func&lt;T,TTanState,Task&gt;, Func&lt;TTanState,TSrcState&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,ValueTask&lt;T&gt;&gt;, Func&lt;T,TTanState,ValueTask&lt;T&gt;&gt;, Func&lt;TTanState,TSrcState&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,ValueTask&lt;T&gt;&gt;, Func&lt;T,TTanState,ValueTask&gt;, Func&lt;TTanState,TSrcState&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,ValueTask&lt;T&gt;&gt;, Func&lt;T,TTanState,T&gt;, Func&lt;TTanState,TSrcState&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,T&gt;, Action&lt;T,TTanState&gt;, Func&lt;TTanState,TSrcState&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,T&gt;, Func&lt;T,TTanState,Task&lt;T&gt;&gt;, Func&lt;TTanState,TSrcState&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,T&gt;, Func&lt;T,TTanState,Task&gt;, Func&lt;TTanState,TSrcState&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,T&gt;, Func&lt;T,TTanState,ValueTask&gt;, Func&lt;TTanState,TSrcState&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>)')**
  - **[Pipe&lt;T,TSrcState,TTanState&gt;(this Func&lt;TSrcState,T&gt;, Func&lt;T,TTanState,T&gt;, Func&lt;TTanState,TSrcState&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;Task&lt;T&gt;&gt;, Func&lt;T,TState,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;ValueTask&lt;T&gt;&gt;, Func&lt;T,TState,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;ValueTask&lt;T&gt;&gt;, Func&lt;T,TState,ValueTask&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;T&gt;, Func&lt;T,TState,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_T_,System.Func_T,TState,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<T>, System.Func<T,TState,T>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,Task&lt;T&gt;&gt;, Action&lt;T,TState&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<T,TState>)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,Task&lt;T&gt;&gt;, Func&lt;T,TState,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,Task&lt;T&gt;&gt;, Func&lt;T,TState,Task&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task>)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,Task&lt;T&gt;&gt;, Func&lt;T,TState,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,ValueTask&lt;T&gt;&gt;, Action&lt;T,TState&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TState>)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,ValueTask&lt;T&gt;&gt;, Func&lt;T,TState,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,ValueTask&lt;T&gt;&gt;, Func&lt;T,TState,Task&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task>)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,ValueTask&lt;T&gt;&gt;, Func&lt;T,TState,ValueTask&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,ValueTask&lt;T&gt;&gt;, Func&lt;T,TState,ValueTask&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask>)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,ValueTask&lt;T&gt;&gt;, Func&lt;T,TState,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,T&gt;, Action&lt;T,TState&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Action<T,TState>)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,T&gt;, Func&lt;T,TState,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,T&gt;, Func&lt;T,TState,Task&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task>)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,T&gt;, Func&lt;T,TState,ValueTask&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.ValueTask>)')**
  - **[Pipe&lt;T,TState&gt;(this Func&lt;TState,T&gt;, Func&lt;T,TState,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,T>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this Task&lt;T&gt;, Func&lt;T,TState,Task&lt;T&gt;&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Threading.Tasks.Task_T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Threading.Tasks.Task<T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool)')**
  - **[Pipe&lt;T,TState&gt;(this T, Func&lt;T,TState,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisT,System.Func_T,TState,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this T, System.Func<T,TState,T>, bool)')**
  - **[Pipe&lt;T&gt;(this T, Func&lt;T,T&gt;, bool)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T_(thisT,System.Func_T,T_,bool) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T>(this T, System.Func<T,T>, bool)')**
  - **[Pipe&lt;TIn,TOut&gt;(this TIn, Func&lt;TIn,TOut&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TOut_(thisTIn,System.Func_TIn,TOut_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TOut>(this TIn, System.Func<TIn,TOut>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Func&lt;Task&lt;TIn&gt;&gt;, Func&lt;TIn,TState,Task&lt;TOut&gt;&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Func&lt;ValueTask&lt;TIn&gt;&gt;, Func&lt;TIn,TState,Task&lt;TOut&gt;&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Func&lt;ValueTask&lt;TIn&gt;&gt;, Func&lt;TIn,TState,ValueTask&lt;TOut&gt;&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Func&lt;TIn&gt;, Func&lt;TIn,TState,TOut&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TIn>, System.Func<TIn,TState,TOut>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Func&lt;TState,Task&lt;TIn&gt;&gt;, Func&lt;TIn,TState,Task&lt;TOut&gt;&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Func&lt;TState,Task&lt;TIn&gt;&gt;, Func&lt;TIn,TState,TOut&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,TOut>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Func&lt;TState,ValueTask&lt;TIn&gt;&gt;, Func&lt;TIn,TState,Task&lt;TOut&gt;&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Func&lt;TState,ValueTask&lt;TIn&gt;&gt;, Func&lt;TIn,TState,ValueTask&lt;TOut&gt;&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Func&lt;TState,ValueTask&lt;TIn&gt;&gt;, Func&lt;TIn,TState,TOut&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,TOut>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Func&lt;TState,TIn&gt;, Func&lt;TIn,TState,Task&lt;TOut&gt;&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Func&lt;TState,TIn&gt;, Func&lt;TIn,TState,TOut&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,TOut>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this Task&lt;TIn&gt;, Func&lt;TIn,TState,Task&lt;TOut&gt;&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>)')**
  - **[Pipe&lt;TIn,TState,TOut&gt;(this TIn, Func&lt;TIn,TState,TOut&gt;)](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_) 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this TIn, System.Func<TIn,TState,TOut>)')**

## PipeLine Class

Extension methods on Lambdas to create a executable Pipeline.

```csharp
public static class PipeLine
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PipeLine
### Methods

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,Task<T>>, Action<T,TTanState>, Func<TTanState,TSrcState>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).tandemLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.Task> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>> sourceLambda, System.Action<T,TTanState> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).tandemLambda'></a>

`tandemLambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TTanState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,Task<T>>, Func<T,TTanState,Task<T>>, Func<TTanState,TSrcState>, bool) Method

Provides a conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.Task<T>> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>> sourceLambda, System.Func<T,TTanState,System.Threading.Tasks.Task<T>> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,Task<T>>, Func<T,TTanState,Task>, Func<TTanState,TSrcState>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).tandemLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.Task> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>> sourceLambda, System.Func<T,TTanState,System.Threading.Tasks.Task> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,Task<T>>, Func<T,TTanState,T>, Func<TTanState,TSrcState>, bool) Method

Provides a conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.Task<T>> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>> sourceLambda, System.Func<T,TTanState,T> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.Task_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.Task<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,ValueTask<T>>, Action<T,TTanState>, Func<TTanState,TSrcState>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).tandemLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.ValueTask> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Action<T,TTanState> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).tandemLambda'></a>

`tandemLambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TTanState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,ValueTask<T>>, Func<T,TTanState,Task<T>>, Func<TTanState,TSrcState>, bool) Method

Provides a conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.Task<T>> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TTanState,System.Threading.Tasks.Task<T>> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,ValueTask<T>>, Func<T,TTanState,Task>, Func<TTanState,TSrcState>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).tandemLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.Task> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TTanState,System.Threading.Tasks.Task> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,ValueTask<T>>, Func<T,TTanState,ValueTask<T>>, Func<TTanState,TSrcState>, bool) Method

Provides a conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.ValueTask<T>> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,ValueTask<T>>, Func<T,TTanState,ValueTask>, Func<TTanState,TSrcState>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).tandemLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.ValueTask> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TTanState,System.Threading.Tasks.ValueTask> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,ValueTask<T>>, Func<T,TTanState,T>, Func<TTanState,TSrcState>, bool) Method

Provides a conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.ValueTask<T>> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TTanState,T> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,T>, Action<T,TTanState>, Func<TTanState,TSrcState>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).tandemLambda').

```csharp
public static System.Action<TTanState> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T> sourceLambda, System.Action<T,TTanState> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).tandemLambda'></a>

`tandemLambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TTanState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

#### Returns
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Action_T,TTanState_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Action<T,TTanState>, System.Func<TTanState,TSrcState>).TTanState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,T>, Func<T,TTanState,Task<T>>, Func<TTanState,TSrcState>, bool) Method

Provides a conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.Task<T>> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T> sourceLambda, System.Func<T,TTanState,System.Threading.Tasks.Task<T>> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_T__,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task<T>>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,T>, Func<T,TTanState,Task>, Func<TTanState,TSrcState>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).tandemLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.Task> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T> sourceLambda, System.Func<T,TTanState,System.Threading.Tasks.Task> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.Task_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.Task>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,T>, Func<T,TTanState,ValueTask>, Func<TTanState,TSrcState>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).tandemLambda').

```csharp
public static System.Func<TTanState,System.Threading.Tasks.ValueTask> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T> sourceLambda, System.Func<T,TTanState,System.Threading.Tasks.ValueTask> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,System.Threading.Tasks.ValueTask_,System.Func_TTanState,TSrcState_).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,System.Threading.Tasks.ValueTask>, System.Func<TTanState,TSrcState>).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool)'></a>

## PipeLine.Pipe<T,TSrcState,TTanState>(this Func<TSrcState,T>, Func<T,TTanState,T>, Func<TTanState,TSrcState>, bool) Method

Provides a conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

```csharp
public static System.Func<TTanState,T> Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T> sourceLambda, System.Func<T,TTanState,T> tandemLambda, System.Func<TTanState,TSrcState> stateAdapter, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TSrcState'></a>

`TSrcState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState'></a>

`TTanState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TSrcState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).stateAdapter'></a>

`stateAdapter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TSrcState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TSrcState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TSrcState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Lambda for state manipulation.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TTanState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).TTanState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).TTanState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TSrcState,TTanState_(thisSystem.Func_TSrcState,T_,System.Func_T,TTanState,T_,System.Func_TTanState,TSrcState_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TSrcState,TTanState>(this System.Func<TSrcState,T>, System.Func<T,TTanState,T>, System.Func<TTanState,TSrcState>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

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

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool)'></a>

## PipeLine.Pipe<T,TState>(this Func<ValueTask<T>>, Func<T,TState,Task<T>>, bool) Method

Provides a conditional asynchronous lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<T>> Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TState,System.Threading.Tasks.Task<T>> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

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

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,Task<T>>, Action<T,TState>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<T,TState>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<T,TState>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task> Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>> sourceLambda, System.Action<T,TState> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<T,TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<T,TState>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).tandemLambda'></a>

`tandemLambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<T,TState>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<T,TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<T,TState>).sourceLambda').

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Action_T,TState_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Action<T,TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

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

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,Task<T>>, Func<T,TState,Task>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task> Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>> sourceLambda, System.Func<T,TState,System.Threading.Tasks.Task> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).sourceLambda').

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,System.Threading.Tasks.Task_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,Task<T>>, Func<T,TState,T>, bool) Method

Provides a conditional asynchronous lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).sourceLambda')'s [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).tandemLambda')
and returns a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') containing the output of [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
containing the output of the original [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).sourceLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<T>> Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>> sourceLambda, System.Func<T,TState,T> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).sourceLambda')'s [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.Task_T__,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.Task<T>>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,ValueTask<T>>, Action<T,TState>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TState>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TState>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.ValueTask> Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Action<T,TState> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TState>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).tandemLambda'></a>

`tandemLambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TState>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TState>).sourceLambda').

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Action_T,TState_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Action<T,TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,ValueTask<T>>, Func<T,TState,Task<T>>, bool) Method

Provides a conditional asynchronous lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda')'s [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda')
and returns a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') containing the output of [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
containing the output of the original [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<T>> Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TState,System.Threading.Tasks.Task<T>> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda')'s [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,ValueTask<T>>, Func<T,TState,Task>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task> Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TState,System.Threading.Tasks.Task> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).sourceLambda').

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.Task_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.Task>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

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

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,ValueTask<T>>, Func<T,TState,ValueTask>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.ValueTask> Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TState,System.Threading.Tasks.ValueTask> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).sourceLambda').

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,System.Threading.Tasks.ValueTask_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,ValueTask<T>>, Func<T,TState,T>, bool) Method

Provides a conditional asynchronous lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).sourceLambda')'s [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).tandemLambda')
and returns a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') containing the output of [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')
containing the output of the original [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).sourceLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.ValueTask<T>> Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>> sourceLambda, System.Func<T,TState,T> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).sourceLambda')'s [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_T__,System.Func_T,TState,T_,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,System.Threading.Tasks.ValueTask<T>>, System.Func<T,TState,T>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,T>, Action<T,TState>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Action<T,TState>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Action<T,TState>).tandemLambda').

```csharp
public static System.Action<TState> Pipe<T,TState>(this System.Func<TState,T> sourceLambda, System.Action<T,TState> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Action<T,TState>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Action<T,TState>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).tandemLambda'></a>

`tandemLambda` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Action<T,TState>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Action<T,TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Action<T,TState>).sourceLambda').

#### Returns
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Action_T,TState_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Action<T,TState>).TState')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,T>, Func<T,TState,Task<T>>, bool) Method

Provides a conditional lambda, which upon execution:

1. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda').
2. If [flag](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), returns the output of the original
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<T>> Pipe<T,TState>(this System.Func<TState,T> sourceLambda, System.Func<T,TState,System.Threading.Tasks.Task<T>> tandemLambda, bool flag);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).sourceLambda').

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Conditional flag dictating whether [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).tandemLambda') should be applied or not

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_T__,bool).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task<T>>, bool).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,T>, Func<T,TState,Task>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task> Pipe<T,TState>(this System.Func<TState,T> sourceLambda, System.Func<T,TState,System.Threading.Tasks.Task> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task>).sourceLambda').

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.Task_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.Task>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_)'></a>

## PipeLine.Pipe<T,TState>(this Func<TState,T>, Func<T,TState,ValueTask>) Method

Provides a lambda, which upon execution, feeds the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).sourceLambda')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.ValueTask> Pipe<T,TState>(this System.Func<TState,T> sourceLambda, System.Func<T,TState,System.Threading.Tasks.ValueTask> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).T'></a>

`T`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).TState'></a>

`TState`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).T 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the output of [sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).sourceLambda').

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_T,TState_(thisSystem.Func_TState,T_,System.Func_T,TState,System.Threading.Tasks.ValueTask_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<T,TState>(this System.Func<TState,T>, System.Func<T,TState,System.Threading.Tasks.ValueTask>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

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

Task to which the tandem operation would be applied.

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

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Func<Task<TIn>>, Func<TIn,TState,Task<TOut>>) Method

Provides a lambda, which upon execution, feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<TOut>> Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.Task<TIn>> sourceLambda, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Func<ValueTask<TIn>>, Func<TIn,TState,Task<TOut>>) Method

Provides a lambda, which upon execution, feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<TOut>> Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>> sourceLambda, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Func<ValueTask<TIn>>, Func<TIn,TState,ValueTask<TOut>>) Method

Provides a lambda, which upon execution, feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.ValueTask<TOut>> Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>> sourceLambda, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Func<TIn>, Func<TIn,TState,TOut>) Method

Provides a lambda, which upon execution, feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TIn>, System.Func<TIn,TState,TOut>).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TIn>, System.Func<TIn,TState,TOut>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TIn>, System.Func<TIn,TState,TOut>).tandemLambda').

```csharp
public static System.Func<TState,TOut> Pipe<TIn,TState,TOut>(this System.Func<TIn> sourceLambda, System.Func<TIn,TState,TOut> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TIn>, System.Func<TIn,TState,TOut>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TIn>, System.Func<TIn,TState,TOut>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TIn>, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TIn>, System.Func<TIn,TState,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TIn>, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TIn_,System.Func_TIn,TState,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TIn>, System.Func<TIn,TState,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Func<TState,Task<TIn>>, Func<TIn,TState,Task<TOut>>) Method

Provides a lambda, which upon execution, feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<TOut>> Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>> sourceLambda, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Func<TState,Task<TIn>>, Func<TIn,TState,TOut>) Method

Provides a lambda, which upon execution, feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,TOut>).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,TOut>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,TOut>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<TOut>> Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>> sourceLambda, System.Func<TIn,TState,TOut> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,TOut>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,TOut>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.Task_TIn__,System.Func_TIn,TState,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.Task<TIn>>, System.Func<TIn,TState,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Func<TState,ValueTask<TIn>>, Func<TIn,TState,Task<TOut>>) Method

Provides a lambda, which upon execution, feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<TOut>> Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>> sourceLambda, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Func<TState,ValueTask<TIn>>, Func<TIn,TState,ValueTask<TOut>>) Method

Provides a lambda, which upon execution, feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.ValueTask<TOut>> Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>> sourceLambda, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,System.Threading.Tasks.ValueTask_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,System.Threading.Tasks.ValueTask<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Func<TState,ValueTask<TIn>>, Func<TIn,TState,TOut>) Method

Provides a lambda, which upon execution, feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,TOut>).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,TOut>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,TOut>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.ValueTask<TOut>> Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>> sourceLambda, System.Func<TIn,TState,TOut> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,TOut>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,TOut>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,System.Threading.Tasks.ValueTask_TIn__,System.Func_TIn,TState,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,System.Threading.Tasks.ValueTask<TIn>>, System.Func<TIn,TState,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Func<TState,TIn>, Func<TIn,TState,Task<TOut>>) Method

Provides a lambda, which upon execution, feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<TOut>> Pipe<TIn,TState,TOut>(this System.Func<TState,TIn> sourceLambda, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Func<TState,TIn>, Func<TIn,TState,TOut>) Method

Provides a lambda, which upon execution, feeds the output of
[sourceLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).sourceLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,TOut>).sourceLambda') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,TOut>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,TOut>).tandemLambda').

```csharp
public static System.Func<TState,TOut> Pipe<TIn,TState,TOut>(this System.Func<TState,TIn> sourceLambda, System.Func<TIn,TState,TOut> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).sourceLambda'></a>

`sourceLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,TOut>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Source lambda to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,TOut>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Func_TState,TIn_,System.Func_TIn,TState,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Func<TState,TIn>, System.Func<TIn,TState,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this Task<TIn>, Func<TIn,TState,Task<TOut>>) Method

Provides a lambda, which upon execution, feeds the output of
[task](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).task 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).task') to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda') and returns the output obtained
from [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).tandemLambda').

```csharp
public static System.Func<TState,System.Threading.Tasks.Task<TOut>> Pipe<TIn,TState,TOut>(this System.Threading.Tasks.Task<TIn> task, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

Task to which the tandem operation would be applied.

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisSystem.Threading.Tasks.Task_TIn_,System.Func_TIn,TState,System.Threading.Tasks.Task_TOut__).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this System.Threading.Tasks.Task<TIn>, System.Func<TIn,TState,System.Threading.Tasks.Task<TOut>>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_)'></a>

## PipeLine.Pipe<TIn,TState,TOut>(this TIn, Func<TIn,TState,TOut>) Method

Provides a lambda, which upon execution, feeds [value](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).value 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this TIn, System.Func<TIn,TState,TOut>).value')
to the [tandemLambda](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).tandemLambda 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this TIn, System.Func<TIn,TState,TOut>).tandemLambda') and returns its output.

```csharp
public static System.Func<TState,TOut> Pipe<TIn,TState,TOut>(this TIn value, System.Func<TIn,TState,TOut> tandemLambda);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).TIn'></a>

`TIn`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).TState'></a>

`TState`

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).TOut'></a>

`TOut`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).value'></a>

`value` [TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this TIn, System.Func<TIn,TState,TOut>).TIn')

Value to feed

<a name='DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).tandemLambda'></a>

`tandemLambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).TIn 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this TIn, System.Func<TIn,TState,TOut>).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this TIn, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this TIn, System.Func<TIn,TState,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Tandem lambda that would consume the value.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TState](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).TState 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this TIn, System.Func<TIn,TState,TOut>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TOut](DevFast.Net.Extensions.Etc.PipeLine.md#DevFast.Net.Extensions.Etc.PipeLine.Pipe_TIn,TState,TOut_(thisTIn,System.Func_TIn,TState,TOut_).TOut 'DevFast.Net.Extensions.Etc.PipeLine.Pipe<TIn,TState,TOut>(this TIn, System.Func<TIn,TState,TOut>).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')