namespace DevFast.Net.Extensions.Etc;

/// <summary>
/// Extension methods on the lambdas.
/// </summary>
public static class Lambdas
{
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
    public static Func<CancellationToken, T> AsLambdaWithCancellation<T>(this T value)
    {
        return t =>
        {
            t.ThrowIfCancellationRequested();
            return value;
        };
    }

    /// <summary>
    /// Creates a <see cref="Func{CancellationToken, T}"/> based lambda.
    /// Such lambda would throw <see cref="OperationCanceledException"/> when
    /// supplied <see cref="CancellationToken.IsCancellationRequested"/> evaluates to
    /// <see langword="true"/>; otherwise, it starts the task (if not already running) and
    /// returns the value of the <paramref name="task"/>.
    /// <para>
    /// NOTE: <see cref="CancellationToken"/> is checked once before awaiting on the <paramref name="task"/>.
    /// If the task itself can be canceled, one should find a way to pass
    /// the <see cref="CancellationToken"/> to such <paramref name="task"/>.
    /// </para>
    /// Purpose of such method is to lazily start the <paramref name="task"/>,
    /// thus, one should avoid (though possible) passing already running <paramref name="task"/>
    /// created using <see cref="TaskFactory"/> or by other means.
    /// </summary>
    /// <typeparam name="T">Type of value</typeparam>
    /// <param name="task">Value to return when lambda is executed</param>
    public static Func<CancellationToken, Task<T>> AsAsyncLambda<T>(this Task<T> task)
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
    /// <see langword="true"/>; otherwise, it returns the value of the <paramref name="valueTask"/>.
    /// <para>
    /// NOTE: <see cref="CancellationToken"/> is checked once before awaiting on the <paramref name="valueTask"/>.
    /// If the task itself can be canceled, one should find a way to pass
    /// the <see cref="CancellationToken"/> to such <paramref name="valueTask"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Type of value</typeparam>
    /// <param name="valueTask">Value to return when lambda is executed</param>
    public static Func<CancellationToken, ValueTask<T>> AsAsyncLambda<T>(this ValueTask<T> valueTask)
    {
        return async t =>
        {
            t.ThrowIfCancellationRequested();
            return await valueTask.ConfigureAwait(false);
        };
    }

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
        return transformation(sourceLambda);
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
        return transformation(sourceLambda);
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
        return sourceLambda.Apply<ValueTask<TSource>, ValueTask<TTandem>>(src => async t => await tandemLambda(await src(t).ConfigureAwait(false), t).ConfigureAwait(false));
    }

    /// <summary>
    /// Simply executes the given <paramref name="lambda"/> and returns its results.
    /// </summary>
    /// <typeparam name="T">Output type of the lambda</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="finallyClause">Code to execute in finally block of try-finally (if any)</param>
    public static T Execute<T>(this Func<T> lambda,
        Action? finallyClause = null)
    {
        return finallyClause == null ? lambda() : lambda.Finally(finallyClause);
    }

    /// <summary>
    /// Simply executes the given <paramref name="lambda"/> and returns its results.
    /// </summary>
    /// <typeparam name="T">Output type of the lambda</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="token">Cancellation token</param>
    /// <param name="finallyClause">Code to execute in finally block of try-finally (if any)</param>
    public static T Execute<T>(this Func<CancellationToken, T> lambda,
        CancellationToken token,
        Action? finallyClause = null)
    {
        return finallyClause == null ? lambda(token) : lambda.Finally(token, finallyClause);
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
}