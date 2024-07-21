namespace DevFast.Net.Extensions.Etc;

/// <summary>
/// Extension methods on the <see cref="Task"/>, <see cref="ValueTask"/>.
/// </summary>
public static class Asynchro
{
    /// <summary>
    /// Starts the given task if not already started. Returns it back after starting for chaining or awaiting.
    /// </summary>
    /// <param name="task">Task to start</param>
    public static T Run<T>(this T task)
        where T : Task
    {
        if (task.Status == TaskStatus.Created)
        {
            task.Start();
        }

        return task;
    }

    /// <summary>
    /// Gets a task that has already completed successfully.
    /// </summary>
#if NETSTANDARD2_0_OR_GREATER
    public static ValueTask CompletedTask => default;
#else
    public static ValueTask CompletedTask => ValueTask.CompletedTask;
#endif

    /// <summary>Creates a <see cref="ValueTask{TResult}"/> that's completed successfully with the specified result.</summary>
    /// <typeparam name="TResult">The type of the result returned by the task.</typeparam>
    /// <param name="result">The result to store into the completed task.</param>
    /// <returns>The successfully completed task.</returns>
    public static ValueTask<TResult> FromResult<TResult>(TResult result)
    {
        return new(result);
    }
}
