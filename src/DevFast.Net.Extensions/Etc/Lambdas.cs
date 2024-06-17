using DevFast.Net.Extensions.SystemTypes;

namespace DevFast.Net.Extensions.Etc;

/// <summary>
/// Extension methods on the lambdas.
/// </summary>
public static class Lambdas
{
    /// <summary>
    /// Applies <paramref name="transformation"/> on the <paramref name="sourceLambda"/>.
    /// </summary>
    /// <typeparam name="TSource">Source lambda output type</typeparam>
    /// <typeparam name="TTransformed">Transformed lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda on which the transformation is applied.</param>
    /// <param name="transformation">Transformation lambda</param>
    public static Func<TTransformed> Apply<TSource, TTransformed>(this Func<TSource> sourceLambda,
        Func<Func<TSource>, Func<TTransformed>> transformation)
    {
        return transformation.ThrowArgumentExceptionForNull($"Inside {nameof(Apply)}, {nameof(transformation)}")(sourceLambda.ThrowArgumentExceptionForNull($"Inside {nameof(Apply)}, {nameof(sourceLambda)}"));
    }

    /// <summary>
    /// Applies <paramref name="transformation"/> on the <paramref name="sourceLambda"/>.
    /// </summary>
    /// <typeparam name="TSource">Source lambda output type</typeparam>
    /// <typeparam name="TTransformed">Transformed lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda on which the transformation is applied.</param>
    /// <param name="transformation">Transformation lambda</param>
    public static Func<CancellationToken, TTransformed> Apply<TSource, TTransformed>(this Func<CancellationToken, TSource> sourceLambda,
        Func<Func<CancellationToken, TSource>, Func<CancellationToken, TTransformed>> transformation)
    {
        return transformation.ThrowArgumentExceptionForNull($"Inside {nameof(Apply)}, {nameof(transformation)}")(sourceLambda.ThrowArgumentExceptionForNull($"Inside {nameof(Apply)}, {nameof(sourceLambda)}"));
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
    public static Func<T> Apply<T>(this Func<T> sourceLambda,
        Func<Func<T>, Func<T>> transformation,
        bool iff)
    {
        return iff ? sourceLambda.Apply(transformation) : sourceLambda;
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
        return iff ? sourceLambda.Apply(transformation) : sourceLambda;
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
        _ = tandemLambda.ThrowArgumentExceptionForNull($"Inside {nameof(Pipe)}, {nameof(tandemLambda)}");
        return sourceLambda.Apply(src => () => tandemLambda(src()), iff);
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
        _ = tandemLambda.ThrowArgumentExceptionForNull($"Inside {nameof(Pipe)}, {nameof(tandemLambda)}");
        return sourceLambda.Apply(src => t => tandemLambda(src(t), t), iff);
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
    public static Func<CancellationToken, Task<T>> Pipe<T>(this Func<CancellationToken, Task<T>> sourceLambda,
        Func<T, CancellationToken, Task<T>> tandemLambda,
        bool iff)
    {
        _ = tandemLambda.ThrowArgumentExceptionForNull($"Inside {nameof(Pipe)}, {nameof(tandemLambda)}");
        return sourceLambda.Apply(src => async t => await tandemLambda(await src(t).StartIfNeeded().ConfigureAwait(false), t).StartIfNeeded().ConfigureAwait(false), iff);
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
    public static Func<CancellationToken, ValueTask<T>> Pipe<T>(this Func<CancellationToken, ValueTask<T>> sourceLambda,
        Func<T, CancellationToken, ValueTask<T>> tandemLambda,
        bool iff)
    {
        _ = tandemLambda.ThrowArgumentExceptionForNull($"Inside {nameof(Pipe)}, {nameof(tandemLambda)}");
        return sourceLambda.Apply(src => async t => await tandemLambda(await src(t).ConfigureAwait(false), t).ConfigureAwait(false), iff);
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
        _ = tandemLambda.ThrowArgumentExceptionForNull($"Inside {nameof(Pipe)}, {nameof(tandemLambda)}");
        return sourceLambda.Apply<TSource, TTandem>(src => () => tandemLambda(src()));
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
        _ = tandemLambda.ThrowArgumentExceptionForNull($"Inside {nameof(Pipe)}, {nameof(tandemLambda)}");
        return sourceLambda.Apply<TSource, TTandem>(src => t => tandemLambda(src(t), t));
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
    public static Func<CancellationToken, Task<TTandem>> Pipe<TSource, TTandem>(this Func<CancellationToken, Task<TSource>> sourceLambda,
        Func<TSource, CancellationToken, Task<TTandem>> tandemLambda)
    {
        _ = tandemLambda.ThrowArgumentExceptionForNull($"Inside {nameof(Pipe)}, {nameof(tandemLambda)}");
        return sourceLambda.Apply<Task<TSource>, Task<TTandem>>(src => async t => await tandemLambda(await src(t).StartIfNeeded().ConfigureAwait(false), t).StartIfNeeded().ConfigureAwait(false));
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
    public static Func<CancellationToken, ValueTask<TTandem>> Pipe<TSource, TTandem>(this Func<CancellationToken, ValueTask<TSource>> sourceLambda,
        Func<TSource, CancellationToken, ValueTask<TTandem>> tandemLambda)
    {
        _ = tandemLambda.ThrowArgumentExceptionForNull($"Inside {nameof(Pipe)}, {nameof(tandemLambda)}");
        return sourceLambda.Apply<ValueTask<TSource>, ValueTask<TTandem>>(src => async t => await tandemLambda(await src(t).ConfigureAwait(false), t).ConfigureAwait(false));
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
        await lambda(token).StartIfNeeded().ConfigureAwait(false);
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
        return await lambda(token).StartIfNeeded().ConfigureAwait(false);
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
    public static Func<CancellationToken, Task<T>> AsCancellableAsyncLambda<T>(this Task<T> task)
    {
        return async t =>
        {
            t.ThrowIfCancellationRequested();
            return await task.StartIfNeeded().ConfigureAwait(false);
        };
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