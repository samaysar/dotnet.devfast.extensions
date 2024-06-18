namespace DevFast.Net.Extensions.Etc;

/// <summary>
/// Extension methods on the lambdas.
/// </summary>
public static class Lambdas
{
    private static Func<Func<Token, Task<TIn>>, Func<Token, Task<TOut>>> Adapter<TIn, TOut>(
        this Func<TIn, Token, Task<TOut>> tandem)
    {
        return src => async t => await tandem(await src(t).Run().ConfigureAwait(false), t).Run().ConfigureAwait(false);
    }

    private static Func<Func<Token, ValueTask<TIn>>, Func<Token, ValueTask<TOut>>> Adapter<TIn, TOut>(
        this Func<TIn, Token, ValueTask<TOut>> tandem)
    {
        return src => async t => await tandem(await src(t).ConfigureAwait(false), t).ConfigureAwait(false);
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
    /// Creates a <see cref="Func{Token, T}"/> based lambda.
    /// Such lambda would throw <see cref="OperationCanceledException"/> when
    /// supplied <see cref="Token.IsCancellationRequested"/> evaluates to
    /// <see langword="true"/>; otherwise, returns the <paramref name="value"/>.
    /// </summary>
    /// <typeparam name="T">Type of value</typeparam>
    /// <param name="value">Value to return when lambda is executed</param>
    public static Func<Token, T> AsLambdaWithCancellation<T>(this T value)
    {
        return t =>
        {
            t.ThrowIfCancellationRequested();
            return value;
        };
    }

    /// <summary>
    /// Creates a <see cref="Func{Token, T}"/> based lambda.
    /// Such lambda would throw <see cref="OperationCanceledException"/> when
    /// supplied <see cref="Token.IsCancellationRequested"/> evaluates to
    /// <see langword="true"/>; otherwise, it starts the task (if not already running) and
    /// returns the value of the <paramref name="task"/>.
    /// <para>
    /// NOTE: <see cref="Token"/> is checked once before awaiting on the <paramref name="task"/>.
    /// If the task itself can be canceled, one should find a way to pass
    /// the <see cref="Token"/> to such <paramref name="task"/>.
    /// </para>
    /// Purpose of such method is to lazily start the <paramref name="task"/>,
    /// thus, one should avoid (though possible) passing already running <paramref name="task"/>
    /// created using <see cref="TaskFactory"/> or by other means.
    /// </summary>
    /// <typeparam name="T">Type of value</typeparam>
    /// <param name="task">Value to return when lambda is executed</param>
    public static Func<Token, Task<T>> AsAsyncLambda<T>(this Task<T> task)
    {
        return async t =>
        {
            t.ThrowIfCancellationRequested();
            return await task.Run().ConfigureAwait(false);
        };
    }

    /// <summary>
    /// Creates a <see cref="Func{Token, T}"/> based lambda.
    /// Such lambda would throw <see cref="OperationCanceledException"/> when
    /// supplied <see cref="Token.IsCancellationRequested"/> evaluates to
    /// <see langword="true"/>; otherwise, it returns the value of the <paramref name="valueTask"/>.
    /// <para>
    /// NOTE: <see cref="Token"/> is checked once before awaiting on the <paramref name="valueTask"/>.
    /// If the task itself can be canceled, one should find a way to pass
    /// the <see cref="Token"/> to such <paramref name="valueTask"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Type of value</typeparam>
    /// <param name="valueTask">Value to return when lambda is executed</param>
    public static Func<Token, ValueTask<T>> AsAsyncLambda<T>(this ValueTask<T> valueTask)
    {
        return async t =>
        {
            t.ThrowIfCancellationRequested();
            return await valueTask.ConfigureAwait(false);
        };
    }

    /// <summary>
    /// Applies <paramref name="adapter"/> on the <paramref name="input"/>
    /// and returns the results.
    /// </summary>
    /// <typeparam name="TIn">Input type</typeparam>
    /// <typeparam name="TOut">Output type</typeparam>
    /// <param name="input">Source on which the adapter is applied.</param>
    /// <param name="adapter">Adapter lambda</param>
    public static TOut Adapt<TIn, TOut>(this TIn input,
        Func<TIn, TOut> adapter)
    {
        return adapter(input);
    }

    /// <summary>
    /// Applies <paramref name="adapter"/> on the <paramref name="input"/>
    /// when <paramref name="iff"/> is <see langword="true"/> and returns the result;
    /// otherwise, returns back the original <paramref name="input"/>.
    /// </summary>
    /// <typeparam name="T">Adapter type</typeparam>
    /// <param name="input">Source on which the adapter is applied.</param>
    /// <param name="adapter">Adapter lambda</param>
    /// <param name="iff">Conditional flag dictating where the adapter should be applied or not</param>
    public static T Adapt<T>(this T input,
        Func<T, T> adapter,
        bool iff)
    {
        return iff ? input.Adapt(adapter) : input;
    }

    /// <summary>
    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>. Such a resultant lambda, upon execution,
    /// would return the output of the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <typeparam name="T">Lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    /// <param name="iff">Conditional flag dictating where the adapter should be applied or not</param>
    public static Func<T> Pipe<T>(this Func<T> sourceLambda,
        Func<T, T> tandemLambda,
        bool iff)
    {
        return sourceLambda.Adapt(src => () => tandemLambda(src()), iff);
    }

    /// <summary>
    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>. Such a resultant lambda, upon execution,
    /// would return the output of the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <typeparam name="T">Lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    /// <param name="iff">Conditional flag dictating where the adapter should be applied or not</param>
    public static Func<Token, T> Pipe<T>(this Func<Token, T> sourceLambda,
        Func<T, Token, T> tandemLambda,
        bool iff)
    {
        return sourceLambda.Adapt(src => t => tandemLambda(src(t), t), iff);
    }

    /// <summary>
    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>. Such a resultant lambda, upon execution,
    /// would return the output of the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <typeparam name="T">Lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    /// <param name="iff">Conditional flag dictating where the adapter should be applied or not</param>
    public static Func<Token, Task<T>> Pipe<T>(this Func<Token, Task<T>> sourceLambda,
        Func<T, Token, Task<T>> tandemLambda,
        bool iff)
    {
        return sourceLambda.Adapt(tandemLambda.Adapter(), iff);
    }

    /// <summary>
    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>. Such a resultant lambda, upon execution,
    /// would return the output of the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <typeparam name="T">Lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    /// <param name="iff">Conditional flag dictating where the adapter should be applied or not</param>
    public static Func<Token, ValueTask<T>> Pipe<T>(this Func<Token, ValueTask<T>> sourceLambda,
        Func<T, Token, ValueTask<T>> tandemLambda,
        bool iff)
    {
        return sourceLambda.Adapt(tandemLambda.Adapter(), iff);
    }

    /// <summary>
    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
    /// the <paramref name="tandemLambda"/> lambda.
    /// </summary>
    /// <typeparam name="TIn">Source lambda output type</typeparam>
    /// <typeparam name="TTandem">Tandem lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    public static Func<TTandem> Pipe<TIn, TTandem>(this Func<TIn> sourceLambda,
        Func<TIn, TTandem> tandemLambda)
    {
        return sourceLambda.Adapt<Func<TIn>, Func<TTandem>>(src => () => tandemLambda(src()));
    }

    /// <summary>
    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
    /// the <paramref name="tandemLambda"/> lambda.
    /// </summary>
    /// <typeparam name="TIn">Source lambda output type</typeparam>
    /// <typeparam name="TTandem">Tandem lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    public static Func<Token, TTandem> Pipe<TIn, TTandem>(this Func<Token, TIn> sourceLambda,
        Func<TIn, Token, TTandem> tandemLambda)
    {
        return sourceLambda.Adapt<Func<Token, TIn>, Func<Token, TTandem>>(src => t => tandemLambda(src(t), t));
    }

    /// <summary>
    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
    /// the <paramref name="tandemLambda"/> lambda.
    /// </summary>
    /// <typeparam name="TIn">Source lambda output type</typeparam>
    /// <typeparam name="TTandem">Tandem lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    public static Func<Token, Task<TTandem>> Pipe<TIn, TTandem>(this Func<Token, Task<TIn>> sourceLambda,
        Func<TIn, Token, Task<TTandem>> tandemLambda)
    {
        return sourceLambda.Adapt(tandemLambda.Adapter());
    }

    /// <summary>
    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
    /// the <paramref name="tandemLambda"/> lambda.
    /// </summary>
    /// <typeparam name="TIn">Source lambda output type</typeparam>
    /// <typeparam name="TTandem">Tandem lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    public static Func<Token, ValueTask<TTandem>> Pipe<TIn, TTandem>(this Func<Token, ValueTask<TIn>> sourceLambda,
        Func<TIn, Token, ValueTask<TTandem>> tandemLambda)
    {
        return sourceLambda.Adapt(tandemLambda.Adapter());
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
    public static T Execute<T>(this Func<Token, T> lambda,
        Token token,
        Action? finallyClause = null)
    {
        return finallyClause == null ? lambda(token) : lambda.Finally(token, finallyClause);
    }

    /// <summary>
    /// Asynchronously executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="token">Cancellation token</param>
    public static async Task ExecuteAsync(this Func<Token, Task> lambda,
        Token token)
    {
        await lambda(token).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <typeparam name="T">Output type of the resultant task</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="token">Cancellation token</param>
    public static async Task<T> ExecuteAsync<T>(this Func<Token, Task<T>> lambda,
        Token token)
    {
        return await lambda(token).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="token">Cancellation token</param>
    public static async ValueTask ExecuteAsync(this Func<Token, ValueTask> lambda,
        Token token)
    {
        await lambda(token).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <typeparam name="T">Output type of the resultant task</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="token">Cancellation token</param>
    public static async ValueTask<T> ExecuteAsync<T>(this Func<Token, ValueTask<T>> lambda,
        Token token)
    {
        return await lambda(token).ConfigureAwait(false);
    }
}