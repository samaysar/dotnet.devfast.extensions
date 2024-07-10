namespace DevFast.Net.Extensions.Etc;

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER
/// <summary>
/// Extension methods on the <see cref="Task"/>, <see cref="ValueTask"/>.
/// </summary>
#else
/// <summary>
/// Extension methods on the <see cref="Task"/>.
/// </summary>
#endif
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
}
