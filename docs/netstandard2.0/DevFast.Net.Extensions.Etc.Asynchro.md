#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.Etc](DevFast.Net.Extensions.Etc.md 'DevFast.Net.Extensions.Etc')

## Asynchro Class

Extension methods on the [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task'), [System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask').

```csharp
public static class Asynchro
```
- *Properties*
  - **[CompletedTask](DevFast.Net.Extensions.Etc.Asynchro.md#DevFast.Net.Extensions.Etc.Asynchro.CompletedTask 'DevFast.Net.Extensions.Etc.Asynchro.CompletedTask')**
- *Methods*
  - **[FromResult&lt;TResult&gt;(TResult)](DevFast.Net.Extensions.Etc.Asynchro.md#DevFast.Net.Extensions.Etc.Asynchro.FromResult_TResult_(TResult) 'DevFast.Net.Extensions.Etc.Asynchro.FromResult<TResult>(TResult)')**
  - **[Run&lt;T&gt;(this T)](DevFast.Net.Extensions.Etc.Asynchro.md#DevFast.Net.Extensions.Etc.Asynchro.Run_T_(thisT) 'DevFast.Net.Extensions.Etc.Asynchro.Run<T>(this T)')**

## Asynchro Class

Extension methods on the [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task'), [System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask').

```csharp
public static class Asynchro
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Asynchro
### Properties

<a name='DevFast.Net.Extensions.Etc.Asynchro.CompletedTask'></a>

## Asynchro.CompletedTask Property

Gets a task that has already completed successfully.

```csharp
public static ValueTask CompletedTask { get; }
```

#### Property Value
[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')
### Methods

<a name='DevFast.Net.Extensions.Etc.Asynchro.FromResult_TResult_(TResult)'></a>

## Asynchro.FromResult<TResult>(TResult) Method

Creates a [System.Threading.Tasks.ValueTask&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1') that's completed successfully with the specified result.

```csharp
public static System.Threading.Tasks.ValueTask<TResult> FromResult<TResult>(TResult result);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Asynchro.FromResult_TResult_(TResult).TResult'></a>

`TResult`

The type of the result returned by the task.
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Asynchro.FromResult_TResult_(TResult).result'></a>

`result` [TResult](DevFast.Net.Extensions.Etc.Asynchro.md#DevFast.Net.Extensions.Etc.Asynchro.FromResult_TResult_(TResult).TResult 'DevFast.Net.Extensions.Etc.Asynchro.FromResult<TResult>(TResult).TResult')

The result to store into the completed task.

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TResult](DevFast.Net.Extensions.Etc.Asynchro.md#DevFast.Net.Extensions.Etc.Asynchro.FromResult_TResult_(TResult).TResult 'DevFast.Net.Extensions.Etc.Asynchro.FromResult<TResult>(TResult).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')  
The successfully completed task.

<a name='DevFast.Net.Extensions.Etc.Asynchro.Run_T_(thisT)'></a>

## Asynchro.Run<T>(this T) Method

Starts the given task if not already started. Returns it back after starting for chaining or awaiting.

```csharp
public static T Run<T>(this T task)
    where T : System.Threading.Tasks.Task;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Asynchro.Run_T_(thisT).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Asynchro.Run_T_(thisT).task'></a>

`task` [T](DevFast.Net.Extensions.Etc.Asynchro.md#DevFast.Net.Extensions.Etc.Asynchro.Run_T_(thisT).T 'DevFast.Net.Extensions.Etc.Asynchro.Run<T>(this T).T')

Task to start

#### Returns
[T](DevFast.Net.Extensions.Etc.Asynchro.md#DevFast.Net.Extensions.Etc.Asynchro.Run_T_(thisT).T 'DevFast.Net.Extensions.Etc.Asynchro.Run<T>(this T).T')