#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.Etc](DevFast.Net.Extensions.Etc.md 'DevFast.Net.Extensions.Etc')

## Asynchro Class

Extension methods on the [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task'), [System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask').

```csharp
public static class Asynchro
```
- *Methods*
  - **[Run&lt;T&gt;(this T)](DevFast.Net.Extensions.Etc.Asynchro.md#DevFast.Net.Extensions.Etc.Asynchro.Run_T_(thisT) 'DevFast.Net.Extensions.Etc.Asynchro.Run<T>(this T)')**

## Asynchro Class

Extension methods on the [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task'), [System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask').

```csharp
public static class Asynchro
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Asynchro
### Methods

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