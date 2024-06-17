namespace DevFast.Net.Extensions.Etc;

/// <summary>
/// Extension methods on the lambdas.
/// </summary>
public static class Lambdas
{
    /// <summary>
    /// Conditionally applies <paramref name="transformation"/> on the <paramref name="sourceLambda"/>.
    /// Returns transformed lambda (when <paramref name="iff"/> is <see langword="true"/>);
    /// otherwise, returns back the origin <paramref name="sourceLambda"/>.
    /// </summary>
    /// <typeparam name="T">Lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda on which the transformation is applied.</param>
    /// <param name="transformation">Transformation lambda</param>
    /// <param name="iff">Conditional flag dictating where the transformation should be applied or not</param>
    public static Func<T> Apply<T>(this Func<T> sourceLambda,
        Func<Func<T>, Func<T>> transformation,
        bool iff)
    {
        return iff ? transformation(sourceLambda) : sourceLambda;
    }

    /// <summary>
    /// Conditionally applies <paramref name="transformation"/> on the <paramref name="sourceLambda"/>.
    /// Returns transformed lambda (when <paramref name="iff"/> is <see langword="true"/>);
    /// otherwise, returns back the origin <paramref name="sourceLambda"/>.
    /// </summary>
    /// <typeparam name="T">Lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda on which the transformation is applied.</param>
    /// <param name="transformation">Transformation lambda</param>
    /// <param name="iff">Conditional flag dictating where the transformation should be applied or not</param>
    public static Func<CancellationToken, T> Apply<T>(this Func<CancellationToken, T> sourceLambda,
        Func<Func<CancellationToken, T>, Func<CancellationToken, T>> transformation,
        bool iff)
    {
        return iff ? transformation(sourceLambda) : sourceLambda;
    }

    /// <summary>
    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
    /// the <paramref name="tandemLambda"/> lambda.
    /// </summary>
    /// <typeparam name="T">Lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the source lambda.</param>
    /// <param name="iff">Conditional flag dictating where the transformation should be applied or not</param>
    public static Func<T> Pipe<T>(this Func<T> sourceLambda,
        Func<T, T> tandemLambda,
        bool iff)
    {
        return sourceLambda.Apply(l => () => tandemLambda(l()), iff);
    }

    /// <summary>
    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
    /// the <paramref name="tandemLambda"/> lambda.
    /// </summary>
    /// <typeparam name="T">Lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the source lambda.</param>
    /// <param name="iff">Conditional flag dictating where the transformation should be applied or not</param>
    public static Func<CancellationToken, T> Pipe<T>(this Func<CancellationToken, T> sourceLambda,
        Func<T, CancellationToken, T> tandemLambda,
        bool iff)
    {
        return sourceLambda.Apply(l => t => tandemLambda(l(t), t), iff);
    }

    /// <summary>
    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
    /// the <paramref name="tandemLambda"/> lambda.
    /// </summary>
    /// <typeparam name="TSource">Source lambda output type</typeparam>
    /// <typeparam name="TTandem">Tandem lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the source lambda.</param>
    public static Func<TTandem> Pipe<TSource, TTandem>(this Func<TSource> sourceLambda,
        Func<TSource, TTandem> tandemLambda)
    {
        return () => tandemLambda(sourceLambda());
    }

    /// <summary>
    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
    /// the <paramref name="tandemLambda"/> lambda.
    /// </summary>
    /// <typeparam name="TSource">Source lambda output type</typeparam>
    /// <typeparam name="TTandem">Tandem lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the source lambda.</param>
    public static Func<CancellationToken, TTandem> Pipe<TSource, TTandem>(this Func<CancellationToken, TSource> sourceLambda,
        Func<TSource, CancellationToken, TTandem> tandemLambda)
    {
        return t => tandemLambda(sourceLambda(t), t);
    }

    /// <summary>
    /// Simply executes the given <paramref name="lambda"/> and returns its results.
    /// </summary>
    /// <typeparam name="T">Output type of the lambda</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    public static T Execute<T>(this Func<T> lambda)
    {
        return lambda();
    }

    /// <summary>
    /// Simply executes the given <paramref name="lambda"/> and returns its results.
    /// </summary>
    /// <typeparam name="T">Output type of the lambda</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="token">Cancellation token</param>
    public static T Execute<T>(this Func<CancellationToken, T> lambda,
        CancellationToken token)
    {
        return lambda(token);
    }

    /// <summary>
    /// Asynchronously executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="token">Cancellation token</param>
    public static async Task ExecuteAsync(this Func<CancellationToken, Task> lambda,
        CancellationToken token)
    {
        await lambda(token).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <typeparam name="T">Output type of the resultant task</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="token">Cancellation token</param>
    public static async Task<T> ExecuteAsync<T>(this Func<CancellationToken, Task<T>> lambda,
        CancellationToken token)
    {
        return await lambda(token).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="token">Cancellation token</param>
    public static async ValueTask ExecuteAsync(this Func<CancellationToken, ValueTask> lambda,
        CancellationToken token)
    {
        await lambda(token).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <typeparam name="T">Output type of the resultant task</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="token">Cancellation token</param>
    public static async ValueTask<T> ExecuteAsync<T>(this Func<CancellationToken, ValueTask<T>> lambda,
        CancellationToken token)
    {
        return await lambda(token).ConfigureAwait(false);
    }

    /// <summary>
    /// Creates a <see cref="Func{T}"/> based lambda that returns the <paramref name="value"/> upon execution.
    /// </summary>
    /// <typeparam name="T">Type of value</typeparam>
    /// <param name="value">Value to return when lambda is executed</param>
    public static Func<T> AsLambda<T>(this T value)
    {
        return () => value;
    }

    /// <summary>
    /// Creates a <see cref="Func{CancellationToken, T}"/> based lambda.
    /// Such lambda would throw <see cref="OperationCanceledException"/> when
    /// supplied <see cref="CancellationToken.IsCancellationRequested"/> evaluates to
    /// <see langword="true"/>; otherwise, returns the <paramref name="value"/>.
    /// </summary>
    /// <typeparam name="T">Type of value</typeparam>
    /// <param name="value">Value to return when lambda is executed</param>
    public static Func<CancellationToken, T> AsCancellableLambda<T>(this T value)
    {
        return t =>
        {
            t.ThrowIfCancellationRequested();
            return value;
        };
    }

    /// <summary>
    /// Creates a <see cref="Func{Task}"/> based lambda. Such a lambda upon execution
    /// will first start the <paramref name="task"/> (if not already running),
    /// and, then asynchronously execute the task and return its value.
    /// <para>
    /// Normally, once should just create a Task without actually running it,
    /// so that the actual run takes place upon the lambda execution.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Type of task</typeparam>
    /// <param name="task">Task to await when lambda is executed</param>
    public static Func<Task<T>> AsAsyncLambda<T>(this Task<T> task)
    {
        return async () => await task.StartIfNeeded().ConfigureAwait(false);
    }

    /// <summary>
    /// Creates a <see cref="Func{CancellationToken, T}"/> based lambda.
    /// Such lambda would throw <see cref="OperationCanceledException"/> when
    /// supplied <see cref="CancellationToken.IsCancellationRequested"/> evaluates to
    /// <see langword="true"/>; otherwise, first start the <paramref name="task"/>
    /// if not already running), and, then asynchronously execute the task and return its value.
    /// <para>
    /// Normally, once should just create a Task without actually running it,
    /// so that the actual run takes place upon the lambda execution.
    /// </para>
    /// <para>
    /// NOTE: <see cref="CancellationToken"/> injected to the lambda would be
    /// checked for cancellation only once before executing the <paramref name="task"/>;
    /// currently, it is NOT possible to inject the token into the task.
    /// Thus, if the provided <paramref name="task"/> itself is cancellable, one must
    /// provide the token to such <paramref name="task"/> by other means.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Type of task</typeparam>
    /// <param name="task">Task to await when lambda is executed</param>
    public static Func<CancellationToken, Task<T>> AsCancellableLambda<T>(this Task<T> task)
    {
        return async t =>
        {
            t.ThrowIfCancellationRequested();
            return await task.ConfigureAwait(false);
        };
    }

    /// <summary>
    /// Creates a <see cref="Func{Task}"/> based lambda. Such a lambda upon execution
    /// will first start the <paramref name="valueTask"/> (if not already running),
    /// and, then asynchronously execute the task and return its value.
    /// <para>
    /// Normally, once should just create a Task without actually running it,
    /// so that the actual run takes place upon the lambda execution.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Type of task</typeparam>
    /// <param name="valueTask">Task to await when lambda is executed</param>
    public static Func<ValueTask<T>> AsAsyncLambda<T>(this ValueTask<T> valueTask)
    {
        return async () => await valueTask.ConfigureAwait(false);
    }

    /// <summary>
    /// Creates a <see cref="Func{CancellationToken, T}"/> based lambda.
    /// Such lambda would throw <see cref="OperationCanceledException"/> when
    /// supplied <see cref="CancellationToken.IsCancellationRequested"/> evaluates to
    /// <see langword="true"/>; otherwise, first start the <paramref name="valueTask"/>
    /// if not already running), and, then asynchronously execute the task and return its value.
    /// <para>
    /// Normally, once should just create a Task without actually running it,
    /// so that the actual run takes place upon the lambda execution.
    /// </para>
    /// <para>
    /// NOTE: <see cref="CancellationToken"/> injected to the lambda would be
    /// checked for cancellation only once before executing the <paramref name="valueTask"/>;
    /// currently, it is NOT possible to inject the token into the task.
    /// Thus, if the provided <paramref name="valueTask"/> itself is cancellable, one must
    /// provide the token to such <paramref name="valueTask"/> by other means.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Type of task</typeparam>
    /// <param name="valueTask">Task to await when lambda is executed</param>
    public static Func<CancellationToken, ValueTask<T>> AsCancellableLambda<T>(this ValueTask<T> valueTask)
    {
        return async t =>
        {
            t.ThrowIfCancellationRequested();
            return await valueTask.ConfigureAwait(false);
        };
    }
}