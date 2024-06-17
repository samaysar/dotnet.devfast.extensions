namespace DevFast.Net.Extensions.Etc;

/// <summary>
/// 
/// </summary>
public static class Tasks
{
    /// <summary>
    /// Starts the given task if not already started. Returns it back after starting for chaining or awaiting.
    /// </summary>
    /// <param name="task">Task to start</param>
    public static T StartIfNeeded<T>(this T task)
        where T : Task
    {
        if (task.Status == TaskStatus.Created)
        {
            task.Start();
        }

        return task;
    }
}
