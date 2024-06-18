using System.Runtime.ExceptionServices;

namespace DevFast.Net.Extensions.Etc;

/// <summary>
/// Extension methods on the lambdas.
/// </summary>
public static class Lambdas
{
    private static Func<Func<Token, Task<TIn>>, Func<Token, Task<TOut>>> Adapter<TIn, TOut>(
        this Func<TIn, Token, Task<TOut>> tandem)
    {
        return src => async state => await tandem(await src(state).Run().ConfigureAwait(false), state).Run().ConfigureAwait(false);
    }

    private static Func<Func<Token, ValueTask<TIn>>, Func<Token, ValueTask<TOut>>> Adapter<TIn, TOut>(
        this Func<TIn, Token, ValueTask<TOut>> tandem)
    {
        return src => async state => await tandem(await src(state).ConfigureAwait(false), state).ConfigureAwait(false);
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
    /// to the <paramref name="tandemLambda"/> upon execution.
    /// </summary>
    /// <typeparam name="TIn">Source lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    public static Action Pipe<TIn>(this Func<TIn> sourceLambda,
        Action<TIn> tandemLambda)
    {
        return () => tandemLambda(sourceLambda());
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
    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/> upon execution.
    /// </summary>
    /// <typeparam name="TIn">Source lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    public static Action<Token> Pipe<TIn>(this Func<Token, TIn> sourceLambda,
        Action<TIn, Token> tandemLambda)
    {
        return t => tandemLambda(sourceLambda(t), t);
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
    public static Func<Token, TTandem> Pipe<TIn, TTandem>(this Func<Token, TIn> sourceLambda,
        Func<TIn, Token, TTandem> tandemLambda)
    {
        return sourceLambda.Adapt<Func<Token, TIn>, Func<Token, TTandem>>(src => t => tandemLambda(src(t), t));
    }

    /// <summary>
    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed Asynchronous lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/> upon execution.
    /// </summary>
    /// <typeparam name="TIn">Source lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    public static Func<Token, Task> Pipe<TIn>(this Func<Token, Task<TIn>> sourceLambda,
        Func<TIn, Token, Task> tandemLambda)
    {
        return async t => await tandemLambda(await sourceLambda(t).Run().ConfigureAwait(false), t).Run().ConfigureAwait(false);
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
    public static Func<Token, Task<TTandem>> Pipe<TIn, TTandem>(this Func<Token, Task<TIn>> sourceLambda,
        Func<TIn, Token, Task<TTandem>> tandemLambda)
    {
        return sourceLambda.Adapt(tandemLambda.Adapter());
    }

    /// <summary>
    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
    /// Returns a newly formed Asynchronous lambda which will feed the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/> upon execution.
    /// </summary>
    /// <typeparam name="TIn">Source lambda output type</typeparam>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
    public static Func<Token, ValueTask> Pipe<TIn>(this Func<Token, ValueTask<TIn>> sourceLambda,
        Func<TIn, Token, ValueTask> tandemLambda)
    {
        return async t => await tandemLambda(await sourceLambda(t).ConfigureAwait(false), t).ConfigureAwait(false);
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
    public static Func<Token, ValueTask<TTandem>> Pipe<TIn, TTandem>(this Func<Token, ValueTask<TIn>> sourceLambda,
        Func<TIn, Token, ValueTask<TTandem>> tandemLambda)
    {
        return sourceLambda.Adapt(tandemLambda.Adapter());
    }

    // ----------->

    /// <summary>
    /// Executes the given <paramref name="lambda"/> inside try block of try-catch construct and
    /// returns its results. In case, an <see cref="Exception"/> of <typeparamref name="TError"/>
    /// type (or its derived types) occurs it is caught; then <paramref name="errorHandler"/>
    /// is invoked with relevant arguments and executed inside catch block and its
    /// output is returned.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// If <paramref name="finallyClause"/> is provided, <paramref name="lambda"/>
    /// executes inside try block and <paramref name="finallyClause"/> executes
    /// inside finally block of the try-finally construct.
    /// </summary>
    /// <typeparam name="T">Output type of the lambda</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="errorHandler">Exception handler</param>
    /// <param name="finallyClause">Code to execute in finally block of try-finally (if any)</param>
    public static T PipeCatch<T, TError>(this Func<T> lambda,
        Func<ExceptionDispatchInfo, TError, T> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        return lambda.Catch(errorHandler, finallyClause);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    public static void Execute(this Action lambda)
    {
        lambda();
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> and returns its results.
    /// </summary>
    /// <typeparam name="T">Output type of the lambda</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    public static T Execute<T>(this Func<T> lambda)
    {
        return lambda();
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static void Execute<TState>(this Action<TState> lambda,
        TState state)
    {
        lambda(state);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> and returns its results.
    /// </summary>
    /// <typeparam name="TOut">Output type of the lambda</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static TOut Execute<TState, TOut>(this Func<TState, TOut> lambda,
        TState state)
    {
        return lambda(state);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    public static async Task ExecuteAsync(this Func<Task> lambda)
    {
        await lambda().Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    public static async ValueTask ExecuteAsync(this Func<ValueTask> lambda)
    {
        await lambda().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static async Task ExecuteAsync<TState>(this Func<TState, Task> lambda,
        TState state)
    {
        await lambda(state).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static async ValueTask ExecuteAsync<TState>(this Func<TState, ValueTask> lambda,
        TState state)
    {
        await lambda(state).ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    public static async Task<TOut> ExecuteAsync<TOut>(this Func<Task<TOut>> lambda)
    {
        return await lambda().Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    public static async ValueTask<TOut> ExecuteAsync<TOut>(this Func<ValueTask<TOut>> lambda)
    {
        return await lambda().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TOut">Output type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static async Task<TOut> ExecuteAsync<TState, TOut>(this Func<TState, Task<TOut>> lambda,
        TState state)
    {
        return await lambda(state).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TOut">Output type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static async ValueTask<TOut> ExecuteAsync<TState, TOut>(this Func<TState, ValueTask<TOut>> lambda,
        TState state)
    {
        return await lambda(state).ConfigureAwait(false);
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="lambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void ExecuteWithCatch<TError>(this Action lambda,
        Action<ExceptionDispatchInfo, TError> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            lambda();
        }
        catch (TError e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="lambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static TOut ExecuteWithCatch<TOut, TError>(this Func<TOut> lambda,
        Func<ExceptionDispatchInfo, TError, TOut> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return lambda();
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="lambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void ExecuteWithCatch<TState, TError>(this Action<TState> lambda,
        TState state,
        Action<ExceptionDispatchInfo, TError, TState> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            lambda(state);
        }
        catch (TError e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="lambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static TOut ExecuteWithCatch<TState, TOut, TError>(this Func<TState, TOut> lambda,
        TState state,
        Func<ExceptionDispatchInfo, TError, TState, TOut> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return lambda(state);
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task ExecuteWithCatchAsync<TError>(this Func<Task> asyncLambda,
        Action<ExceptionDispatchInfo, TError> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            await asyncLambda().Run().ConfigureAwait(false);
        }
        catch (TError e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask ExecuteWithCatchAsync<TError>(this Func<ValueTask> asyncLambda,
        Action<ExceptionDispatchInfo, TError> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            await asyncLambda().ConfigureAwait(false);
        }
        catch (TError e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task ExecuteWithCatchAsync<TState, TError>(this Func<TState, Task> asyncLambda,
        TState state,
        Action<ExceptionDispatchInfo, TError, TState> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            await asyncLambda(state).Run().ConfigureAwait(false);
        }
        catch (TError e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask ExecuteWithCatchAsync<TState, TError>(this Func<TState, ValueTask> asyncLambda,
        TState state,
        Action<ExceptionDispatchInfo, TError, TState> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            await asyncLambda(state).ConfigureAwait(false);
        }
        catch (TError e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<TOut> ExecuteWithCatchAsync<TOut, TError>(this Func<Task<TOut>> asyncLambda,
        Func<ExceptionDispatchInfo, TError, TOut> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return await asyncLambda().Run().ConfigureAwait(false);
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<TOut> ExecuteWithCatchAsync<TOut, TError>(this Func<ValueTask<TOut>> asyncLambda,
        Func<ExceptionDispatchInfo, TError, TOut> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return await asyncLambda().ConfigureAwait(false);
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<TOut> ExecuteWithCatchAsync<TState, TOut, TError>(this Func<TState, Task<TOut>> asyncLambda,
        TState state,
        Func<ExceptionDispatchInfo, TError, TState, TOut> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return await asyncLambda(state).Run().ConfigureAwait(false);
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<TOut> ExecuteWithCatchAsync<TState, TOut, TError>(this Func<TState, ValueTask<TOut>> asyncLambda,
        TState state,
        Func<ExceptionDispatchInfo, TError, TState, TOut> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return await asyncLambda(state).ConfigureAwait(false);
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and
    /// excutes <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void ExecuteWithFinally(this Action lambda,
        Action finallyClause)
    {
        try
        {
            lambda();
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static TOut ExecuteWithFinally<TOut>(this Func<TOut> lambda,
        Action finallyClause)
    {
        try
        {
            return lambda();
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and
    /// excutes <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void ExecuteWithFinally<TState>(this Action<TState> lambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            lambda(state);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static TOut ExecuteWithFinally<TState, TOut>(this Func<TState, TOut> lambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            return lambda(state);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and
    /// excutes <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void ExecuteWithFinally<TState>(this Action<TState> lambda,
        TState state,
        Action<TState> finallyClause)
    {
        try
        {
            lambda(state);
        }
        finally
        {
            finallyClause(state);
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static TOut ExecuteWithFinally<TState, TOut>(this Func<TState, TOut> lambda,
        TState state,
        Action<TState> finallyClause)
    {
        try
        {
            return lambda(state);
        }
        finally
        {
            finallyClause(state);
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task ExecuteWithFinallyAsync(this Func<Task> asyncLambda,
        Action finallyClause)
    {
        try
        {
            await asyncLambda().Run().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask ExecuteWithFinallyAsync(this Func<ValueTask> asyncLambda,
        Action finallyClause)
    {
        try
        {
            await asyncLambda().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task ExecuteWithFinallyAsync<TState, TOut>(this Func<TState, Task> asyncLambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            await asyncLambda(state).Run().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask ExecuteWithFinallyAsync<TState>(this Func<TState, ValueTask> asyncLambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            await asyncLambda(state).ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task ExecuteWithFinallyAsync<TState>(this Func<TState, Task> asyncLambda,
        TState state,
        Action<TState> finallyClause)
    {
        try
        {
            await asyncLambda(state).Run().ConfigureAwait(false);
        }
        finally
        {
            finallyClause(state);
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask ExecuteWithFinallyAsync<TState>(this Func<TState, ValueTask> asyncLambda,
        TState state,
        Action<TState> finallyClause)
    {
        try
        {
            await asyncLambda(state).ConfigureAwait(false);
        }
        finally
        {
            finallyClause(state);
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<TOut> ExecuteWithFinallyAsync<TOut>(this Func<Task<TOut>> asyncLambda,
        Action finallyClause)
    {
        try
        {
            return await asyncLambda().Run().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<TOut> ExecuteWithFinallyAsync<TOut>(this Func<ValueTask<TOut>> asyncLambda,
        Action finallyClause)
    {
        try
        {
            return await asyncLambda().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<TOut> ExecuteWithFinallyAsync<TState, TOut>(this Func<TState, Task<TOut>> asyncLambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            return await asyncLambda(state).Run().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<TOut> ExecuteWithFinallyAsync<TState, TOut>(this Func<TState, ValueTask<TOut>> asyncLambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            return await asyncLambda(state).ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<TOut> ExecuteWithFinallyAsync<TState, TOut>(this Func<TState, Task<TOut>> asyncLambda,
        TState state,
        Action<TState> finallyClause)
    {
        try
        {
            return await asyncLambda(state).Run().ConfigureAwait(false);
        }
        finally
        {
            finallyClause(state);
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<TOut> ExecuteWithFinallyAsync<TState, TOut>(this Func<TState, ValueTask<TOut>> asyncLambda,
        TState state,
        Action<TState> finallyClause)
    {
        try
        {
            return await asyncLambda(state).ConfigureAwait(false);
        }
        finally
        {
            finallyClause(state);
        }
    }
}