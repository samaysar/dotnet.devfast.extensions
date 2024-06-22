//using System.Runtime.ExceptionServices;

//namespace DevFast.Net.Extensions.Etc;

///// <summary>
///// Extension methods on the lambdas.
///// </summary>
//public static class Lambdas
//{
//    private static Func<Func<TStateIn, TIn>, Func<TStateOut, TOut>> Adapter<TIn, TStateIn, TStateOut, TOut>(
//        this Func<TIn, TStateOut, TOut> tandem,
//        Func<TStateOut, TStateIn> stateAdapter)
//    {
//        return src => state => tandem(src(stateAdapter(state)), state);
//    }

//    private static Func<Func<TStateIn, Task<TIn>>, Func<TStateOut, Task<TOut>>> Adapter<TIn, TStateIn, TStateOut, TOut>(
//        this Func<TIn, TStateOut, Task<TOut>> tandem,
//        Func<TStateOut, TStateIn> stateAdapter)
//    {
//        return src => async state => await tandem(await src(stateAdapter(state)).Run().ConfigureAwait(false), state).Run().ConfigureAwait(false);
//    }

//    private static Func<Func<TStateIn, ValueTask<TIn>>, Func<TStateOut, ValueTask<TOut>>> Adapter<TIn, TStateIn, TStateOut, TOut>(
//        this Func<TIn, TStateOut, ValueTask<TOut>> tandem,
//        Func<TStateOut, TStateIn> stateAdapter)
//    {
//        return src => async state => await tandem(await src(stateAdapter(state)).ConfigureAwait(false), state).ConfigureAwait(false);
//    }

//    private static Func<Func<TStateIn, ValueTask<TIn>>, Func<TStateOut, Task<TOut>>> CrossAdapter<TIn, TStateIn, TStateOut, TOut>(
//        this Func<TIn, TStateOut, Task<TOut>> tandem,
//        Func<TStateOut, TStateIn> stateAdapter)
//    {
//        return src => async state => await tandem(await src(stateAdapter(state)).ConfigureAwait(false), state).Run().ConfigureAwait(false);
//    }

//    private static Func<Func<TStateIn, TIn>, Func<TStateOut, TOut>> Adapter<TIn, TStateIn, TStateOut, TOut>(
//        this Func<TIn, TStateOut, TOut> tandem)
//        where TStateOut : TStateIn
//    {
//        return tandem.Adapter<TIn, TStateIn, TStateOut, TOut>(static x => x);
//    }

//    private static Func<Func<TStateIn, Task<TIn>>, Func<TStateOut, Task<TOut>>> Adapter<TIn, TStateIn, TStateOut, TOut>(
//        this Func<TIn, TStateOut, Task<TOut>> tandem)
//        where TStateOut : TStateIn
//    {
//        return tandem.Adapter<TIn, TStateIn, TStateOut, TOut>(static x => x);
//    }

//    private static Func<Func<TStateIn, ValueTask<TIn>>, Func<TStateOut, ValueTask<TOut>>> Adapter<TIn, TStateIn, TStateOut, TOut>(
//        this Func<TIn, TStateOut, ValueTask<TOut>> tandem)
//        where TStateOut : TStateIn
//    {
//        return tandem.Adapter<TIn, TStateIn, TStateOut, TOut>(static x => x);
//    }

//    private static Func<Func<TStateIn, ValueTask<TIn>>, Func<TStateOut, Task<TOut>>> CrossAdapter<TIn, TStateIn, TStateOut, TOut>(
//        this Func<TIn, TStateOut, Task<TOut>> tandem)
//        where TStateOut : TStateIn
//    {
//        return tandem.CrossAdapter<TIn, TStateIn, TStateOut, TOut>(static x => x);
//    }

//    private static Func<Func<TState, TIn>, Func<TState, TOut>> Adapter<TIn, TState, TOut>(
//        this Func<TIn, TState, TOut> tandem)
//    {
//        return tandem.Adapter<TIn, TState, TState, TOut>();
//    }

//    private static Func<Func<TState, Task<TIn>>, Func<TState, Task<TOut>>> Adapter<TIn, TState, TOut>(
//        this Func<TIn, TState, Task<TOut>> tandem)
//    {
//        return tandem.Adapter<TIn, TState, TState, TOut>();
//    }

//    private static Func<Func<TState, ValueTask<TIn>>, Func<TState, ValueTask<TOut>>> Adapter<TIn, TState, TOut>(
//        this Func<TIn, TState, ValueTask<TOut>> tandem)
//    {
//        return tandem.Adapter<TIn, TState, TState, TOut>();
//    }

//    private static Func<Func<TState, ValueTask<TIn>>, Func<TState, Task<TOut>>> CrossAdapter<TIn, TState, TOut>(
//        this Func<TIn, TState, Task<TOut>> tandem)
//    {
//        return tandem.CrossAdapter<TIn, TState, TState, TOut>();
//    }

//    private static Func<TState, T> Adapter<T, TState>(this T value)
//    {
//        return _ => value;
//    }

//    private static Func<TState, T> Adapter<T, TState>(this Func<T> lambda)
//    {
//        return _ => lambda();
//    }

//    private static Func<TState, Task<T>> Adapter<T, TState>(this Task<T> task)
//    {
//        return async _ => await task.Run().ConfigureAwait(false);
//    }

//    private static Func<TStateOut, T> Adapter<T, TStateIn, TStateOut>(this Func<TStateIn, T> lambda)
//        where TStateOut : TStateIn
//    {
//        return state => lambda(state);
//    }

//    private static Func<TStateOut, T> Adapter<T, TStateIn, TStateOut>(this Func<TStateIn, T> lambda,
//        Func<TStateOut, TStateIn> stateAdapter)
//    {
//        return state => lambda(stateAdapter(state));
//    }

//    /// <summary>
//    /// Applies <paramref name="adapter"/> on the <paramref name="input"/>
//    /// and returns the results.
//    /// </summary>
//    /// <param name="input">Source on which the adapter is applied.</param>
//    /// <param name="adapter">Adapter lambda</param>
//    public static TOut Pipe<TIn, TOut>(this TIn input,
//        Func<TIn, TOut> adapter)
//    {
//        return adapter(input);
//    }

//    /// <summary>
//    /// Applies <paramref name="adapter"/> on the <paramref name="input"/>
//    /// when <paramref name="flag"/> is <see langword="true"/> and returns the result;
//    /// otherwise, returns back the original <paramref name="input"/>.
//    /// </summary>
//    /// <param name="input">Source on which the adapter is applied.</param>
//    /// <param name="adapter">Adapter lambda</param>
//    /// <param name="flag">Flag dictating whether should be applied or not</param>
//    public static T Pipe<T>(this T input,
//        Func<T, T> adapter,
//        bool flag)
//    {
//        return flag ? input.Pipe(adapter) : input;
//    }

//    /// <summary>
//    /// Provides a conditional lambda, which upon execution:
//    /// <para>
//    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds <paramref name="value"/>
//    /// to the <paramref name="tandemLambda"/> and returns the output obtained
//    /// from <paramref name="tandemLambda"/>.
//    /// </para>
//    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the original
//    /// <paramref name="value"/>.
//    /// </summary>
//    /// <param name="value">Value to feed</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
//    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
//    public static Func<TState, T> Pipe<T, TState>(this T value,
//        Func<T, TState, T> tandemLambda,
//        bool flag)
//    {
//        return value.Adapter<T, TState>().Pipe(tandemLambda, flag);
//    }

//    /// <summary>
//    /// Provides a conditional lambda, which upon execution:
//    /// <para>
//    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
//    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
//    /// from <paramref name="tandemLambda"/>.
//    /// </para>
//    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
//    /// <paramref name="sourceLambda"/>.
//    /// </summary>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
//    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
//    public static Func<TState, T> Pipe<T, TState>(this Func<T> sourceLambda,
//        Func<T, TState, T> tandemLambda,
//        bool flag)
//    {
//        return sourceLambda.Adapter<T, TState>().Pipe(tandemLambda, flag);
//    }

//    /// <summary>
//    /// Provides a conditional asynchronous lambda, which upon execution:
//    /// <para>
//    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
//    /// <paramref name="task"/> to the <paramref name="tandemLambda"/> and returns the output obtained
//    /// from <paramref name="tandemLambda"/>.
//    /// </para>
//    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
//    /// <paramref name="task"/>.
//    /// <para>
//    /// IMPLEMENTATION NOTE: As the purpose of pipelines is to executes everything as lazily as possible,
//    /// calling this method on a non-running <see cref="Task"/> is advisable, though NOT necessary.
//    /// Irrespective to the state of the <paramref name="task"/> outcome would be identical.
//    /// </para>
//    /// </summary>
//    /// <param name="task">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="task"/>.</param>
//    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
//    public static Func<TState, Task<T>> Pipe<T, TState>(this Task<T> task,
//        Func<T, TState, Task<T>> tandemLambda,
//        bool flag)
//    {
//        return task.Adapter<T, TState>().Pipe(tandemLambda, flag);
//    }

//    /// <summary>
//    /// Provides a conditional lambda, which upon execution:
//    /// <para>
//    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
//    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
//    /// from <paramref name="tandemLambda"/>.
//    /// </para>
//    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
//    /// <paramref name="sourceLambda"/>.
//    /// </summary>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
//    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
//    public static Func<TState, T> Pipe<T, TState>(this Func<TState, T> sourceLambda,
//        Func<T, TState, T> tandemLambda,
//        bool flag)
//    {
//        return sourceLambda.Pipe(tandemLambda.Adapter(), flag);
//    }

//    /// <summary>
//    /// Provides a conditional asynchronous lambda, which upon execution:
//    /// <para>
//    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
//    /// <paramref name="sourceLambda"/>'s <see cref="Task{T}"/> to the <paramref name="tandemLambda"/> 
//    /// and returns a <see cref="Task{T}"/> containing the output of <paramref name="tandemLambda"/>.
//    /// </para>
//    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns a <see cref="Task{T}"/> 
//    /// containing the output of the original <paramref name="sourceLambda"/>.
//    /// </summary>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>'s <see cref="Task{TResult}"/>.</param>
//    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
//    public static Func<TState, Task<T>> Pipe<T, TState>(this Func<TState, Task<T>> sourceLambda,
//        Func<T, TState, Task<T>> tandemLambda,
//        bool flag)
//    {
//        return sourceLambda.Pipe(tandemLambda.Adapter(), flag);
//    }

//    /// <summary>
//    /// Provides a conditional asynchronous lambda, which upon execution:
//    /// <para>
//    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
//    /// <paramref name="sourceLambda"/>'s <see cref="Task{T}"/> to the <paramref name="tandemLambda"/> 
//    /// and returns a <see cref="Task{T}"/> containing the output of <paramref name="tandemLambda"/>.
//    /// </para>
//    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns a <see cref="Task{T}"/> 
//    /// containing the output of the original <paramref name="sourceLambda"/>.
//    /// </summary>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>'s <see cref="Task{TResult}"/>.</param>
//    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
//    public static Func<TState, ValueTask<T>> Pipe<T, TState>(this Func<TState, ValueTask<T>> sourceLambda,
//        Func<T, TState, ValueTask<T>> tandemLambda,
//        bool flag)
//    {
//        return sourceLambda.Pipe(tandemLambda.Adapter(), flag);
//    }

//    /// <summary>
//    /// Provides a conditional asynchronous lambda, which upon execution:
//    /// <para>
//    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
//    /// <paramref name="sourceLambda"/>'s <see cref="Task{T}"/> to the <paramref name="tandemLambda"/> 
//    /// and returns a <see cref="Task{T}"/> containing the output of <paramref name="tandemLambda"/>.
//    /// </para>
//    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns a <see cref="Task{T}"/> 
//    /// containing the output of the original <paramref name="sourceLambda"/>.
//    /// </summary>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>'s <see cref="Task{TResult}"/>.</param>
//    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
//    public static Func<TState, Task<T>> Pipe<T, TState>(this Func<TState, ValueTask<T>> sourceLambda,
//        Func<T, TState, Task<T>> tandemLambda,
//        bool flag)
//    {
//        return sourceLambda.Pipe(tandemLambda.CrossAdapter(), flag);
//    }

//    //-------------------------------------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

//    /// <summary>
//    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
//    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
//    /// to the <paramref name="tandemLambda"/>. Such a resultant lambda, upon execution,
//    /// would return the output of the <paramref name="tandemLambda"/>.
//    /// </summary>
//    /// <typeparam name="T">Lambda output type</typeparam>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
//    /// <param name="flag">Conditional flag dictating where the adapter should be applied or not</param>
//    public static Func<Token, Task<T>> Pipe<T>(this Func<Token, Task<T>> sourceLambda,
//        Func<T, Token, Task<T>> tandemLambda,
//        bool flag)
//    {
//        return sourceLambda.Pipe(tandemLambda.Adapter(), flag);
//    }

//    /// <summary>
//    /// Conditionally merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
//    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
//    /// to the <paramref name="tandemLambda"/>. Such a resultant lambda, upon execution,
//    /// would return the output of the <paramref name="tandemLambda"/>.
//    /// </summary>
//    /// <typeparam name="T">Lambda output type</typeparam>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
//    /// <param name="iff">Conditional flag dictating where the adapter should be applied or not</param>
//    public static Func<Token, ValueTask<T>> Pipe<T>(this Func<Token, ValueTask<T>> sourceLambda,
//        Func<T, Token, ValueTask<T>> tandemLambda,
//        bool iff)
//    {
//        return sourceLambda.Adapt(tandemLambda.Adapter(), iff);
//    }

//    /// <summary>
//    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
//    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
//    /// to the <paramref name="tandemLambda"/> upon execution.
//    /// </summary>
//    /// <typeparam name="TIn">Source lambda output type</typeparam>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
//    public static Action Pipe<TIn>(this Func<TIn> sourceLambda,
//        Action<TIn> tandemLambda)
//    {
//        return () => tandemLambda(sourceLambda());
//    }

//    /// <summary>
//    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
//    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
//    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
//    /// the <paramref name="tandemLambda"/> lambda.
//    /// </summary>
//    /// <typeparam name="TIn">Source lambda output type</typeparam>
//    /// <typeparam name="TTandem">Tandem lambda output type</typeparam>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
//    public static Func<TTandem> Pipe<TIn, TTandem>(this Func<TIn> sourceLambda,
//        Func<TIn, TTandem> tandemLambda)
//    {
//        return sourceLambda.Adapt<Func<TIn>, Func<TTandem>>(src => () => tandemLambda(src()));
//    }

//    /// <summary>
//    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
//    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
//    /// to the <paramref name="tandemLambda"/> upon execution.
//    /// </summary>
//    /// <typeparam name="TIn">Source lambda output type</typeparam>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
//    public static Action<Token> Pipe<TIn>(this Func<Token, TIn> sourceLambda,
//        Action<TIn, Token> tandemLambda)
//    {
//        return t => tandemLambda(sourceLambda(t), t);
//    }

//    /// <summary>
//    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
//    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
//    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
//    /// the <paramref name="tandemLambda"/> lambda.
//    /// </summary>
//    /// <typeparam name="TIn">Source lambda output type</typeparam>
//    /// <typeparam name="TTandem">Tandem lambda output type</typeparam>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
//    public static Func<Token, TTandem> Pipe<TIn, TTandem>(this Func<Token, TIn> sourceLambda,
//        Func<TIn, Token, TTandem> tandemLambda)
//    {
//        return sourceLambda.Adapt<Func<Token, TIn>, Func<Token, TTandem>>(src => t => tandemLambda(src(t), t));
//    }

//    /// <summary>
//    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
//    /// Returns a newly formed Asynchronous lambda which will feed the output of <paramref name="sourceLambda"/>
//    /// to the <paramref name="tandemLambda"/> upon execution.
//    /// </summary>
//    /// <typeparam name="TIn">Source lambda output type</typeparam>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
//    public static Func<Token, Task> Pipe<TIn>(this Func<Token, Task<TIn>> sourceLambda,
//        Func<TIn, Token, Task> tandemLambda)
//    {
//        return async t => await tandemLambda(await sourceLambda(t).Run().ConfigureAwait(false), t).Run().ConfigureAwait(false);
//    }

//    /// <summary>
//    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
//    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
//    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
//    /// the <paramref name="tandemLambda"/> lambda.
//    /// </summary>
//    /// <typeparam name="TIn">Source lambda output type</typeparam>
//    /// <typeparam name="TTandem">Tandem lambda output type</typeparam>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
//    public static Func<Token, Task<TTandem>> Pipe<TIn, TTandem>(this Func<Token, Task<TIn>> sourceLambda,
//        Func<TIn, Token, Task<TTandem>> tandemLambda)
//    {
//        return sourceLambda.Adapt(tandemLambda.Adapter());
//    }

//    /// <summary>
//    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
//    /// Returns a newly formed Asynchronous lambda which will feed the output of <paramref name="sourceLambda"/>
//    /// to the <paramref name="tandemLambda"/> upon execution.
//    /// </summary>
//    /// <typeparam name="TIn">Source lambda output type</typeparam>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
//    public static Func<Token, ValueTask> Pipe<TIn>(this Func<Token, ValueTask<TIn>> sourceLambda,
//        Func<TIn, Token, ValueTask> tandemLambda)
//    {
//        return async t => await tandemLambda(await sourceLambda(t).ConfigureAwait(false), t).ConfigureAwait(false);
//    }

//    /// <summary>
//    /// Merges the <paramref name="sourceLambda"/> with <paramref name="tandemLambda"/>.
//    /// Returns a newly formed lambda which will feed the output of <paramref name="sourceLambda"/>
//    /// to the <paramref name="tandemLambda"/> and upon execution it would return the output of
//    /// the <paramref name="tandemLambda"/> lambda.
//    /// </summary>
//    /// <typeparam name="TIn">Source lambda output type</typeparam>
//    /// <typeparam name="TTandem">Tandem lambda output type</typeparam>
//    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
//    /// <param name="tandemLambda">Tandem lambda that would consume the output of the input lambda.</param>
//    public static Func<Token, ValueTask<TTandem>> Pipe<TIn, TTandem>(this Func<Token, ValueTask<TIn>> sourceLambda,
//        Func<TIn, Token, ValueTask<TTandem>> tandemLambda)
//    {
//        return sourceLambda.Adapt(tandemLambda.Adapter());
//    }

//    // ----------->

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/> inside try block of try-catch construct and
//    /// returns its results. In case, an <see cref="Exception"/> of <typeparamref name="TError"/>
//    /// type (or its derived types) occurs it is caught; then <paramref name="errorHandler"/>
//    /// is invoked with relevant arguments and executed inside catch block and its
//    /// output is returned.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// If <paramref name="finallyClause"/> is provided, <paramref name="lambda"/>
//    /// executes inside try block and <paramref name="finallyClause"/> executes
//    /// inside finally block of the try-finally construct.
//    /// </summary>
//    /// <typeparam name="T">Output type of the lambda</typeparam>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="lambda">Lambda to execute.</param>
//    /// <param name="errorHandler">Exception handler</param>
//    /// <param name="finallyClause">Code to execute in finally block of try-finally (if any)</param>
//    public static T? PipeCatch<T, TError>(this Func<T> lambda,
//        Func<ExceptionDispatchInfo, TError, T> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        return default;
//        //return lambda.Catch(errorHandler, finallyClause);
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/>.
//    /// </summary>
//    /// <param name="lambda">Lambda to execute.</param>
//    public static void Execute(this Action lambda)
//    {
//        lambda();
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/> and returns its results.
//    /// </summary>
//    /// <typeparam name="T">Output type of the lambda</typeparam>
//    /// <param name="lambda">Lambda to execute.</param>
//    public static T Execute<T>(this Func<T> lambda)
//    {
//        return lambda();
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/>.
//    /// </summary>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="lambda">Lambda to execute.</param>
//    /// <param name="state">Lambda state</param>
//    public static void Execute<TState>(this Action<TState> lambda,
//        TState state)
//    {
//        lambda(state);
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/> and returns its results.
//    /// </summary>
//    /// <typeparam name="TOut">Output type of the lambda</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="lambda">Lambda to execute.</param>
//    /// <param name="state">Lambda state</param>
//    public static TOut Execute<TState, TOut>(this Func<TState, TOut> lambda,
//        TState state)
//    {
//        return lambda(state);
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/> asynchronously.
//    /// </summary>
//    /// <param name="lambda">Lambda to execute.</param>
//    public static async Task ExecuteAsync(this Func<Task> lambda)
//    {
//        await lambda().Run().ConfigureAwait(false);
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/> asynchronously.
//    /// </summary>
//    /// <param name="lambda">Lambda to execute.</param>
//    public static async ValueTask ExecuteAsync(this Func<ValueTask> lambda)
//    {
//        await lambda().ConfigureAwait(false);
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/> asynchronously.
//    /// </summary>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="lambda">Lambda to execute.</param>
//    /// <param name="state">Lambda state</param>
//    public static async Task ExecuteAsync<TState>(this Func<TState, Task> lambda,
//        TState state)
//    {
//        await lambda(state).Run().ConfigureAwait(false);
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/> asynchronously.
//    /// </summary>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="lambda">Lambda to execute.</param>
//    /// <param name="state">Lambda state</param>
//    public static async ValueTask ExecuteAsync<TState>(this Func<TState, ValueTask> lambda,
//        TState state)
//    {
//        await lambda(state).ConfigureAwait(false);
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/> asynchronously.
//    /// </summary>
//    /// <param name="lambda">Lambda to execute.</param>
//    public static async Task<TOut> ExecuteAsync<TOut>(this Func<Task<TOut>> lambda)
//    {
//        return await lambda().Run().ConfigureAwait(false);
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/> asynchronously.
//    /// </summary>
//    /// <param name="lambda">Lambda to execute.</param>
//    public static async ValueTask<TOut> ExecuteAsync<TOut>(this Func<ValueTask<TOut>> lambda)
//    {
//        return await lambda().ConfigureAwait(false);
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/> asynchronously.
//    /// </summary>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <typeparam name="TOut">Output type</typeparam>
//    /// <param name="lambda">Lambda to execute.</param>
//    /// <param name="state">Lambda state</param>
//    public static async Task<TOut> ExecuteAsync<TState, TOut>(this Func<TState, Task<TOut>> lambda,
//        TState state)
//    {
//        return await lambda(state).Run().ConfigureAwait(false);
//    }

//    /// <summary>
//    /// Executes the given <paramref name="lambda"/> asynchronously.
//    /// </summary>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <typeparam name="TOut">Output type</typeparam>
//    /// <param name="lambda">Lambda to execute.</param>
//    /// <param name="state">Lambda state</param>
//    public static async ValueTask<TOut> ExecuteAsync<TState, TOut>(this Func<TState, ValueTask<TOut>> lambda,
//        TState state)
//    {
//        return await lambda(state).ConfigureAwait(false);
//    }

//    /// <summary>
//    /// Executes <paramref name="lambda"/> inside try block.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="lambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="lambda">Lambda to execute inside try clause</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static void ExecuteWithCatch<TError>(this Action lambda,
//        Action<ExceptionDispatchInfo, TError> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            lambda();
//        }
//        catch (TError e)
//        {
//            errorHandler(ExceptionDispatchInfo.Capture(e), e);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Executes <paramref name="lambda"/> inside try block and returns its value.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="lambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>
//    /// to obtain the return value.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="lambda">Lambda to execute inside try clause</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static TOut ExecuteWithCatch<TOut, TError>(this Func<TOut> lambda,
//        Func<ExceptionDispatchInfo, TError, TOut> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            return lambda();
//        }
//        catch (TError e)
//        {
//            return errorHandler(ExceptionDispatchInfo.Capture(e), e);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Executes <paramref name="lambda"/> inside try block.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="lambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="lambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static void ExecuteWithCatch<TState, TError>(this Action<TState> lambda,
//        TState state,
//        Action<ExceptionDispatchInfo, TError, TState> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            lambda(state);
//        }
//        catch (TError e)
//        {
//            errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Executes <paramref name="lambda"/> inside try block and returns its value.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="lambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>
//    /// to obtain the return value.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="lambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static TOut ExecuteWithCatch<TState, TOut, TError>(this Func<TState, TOut> lambda,
//        TState state,
//        Func<ExceptionDispatchInfo, TError, TState, TOut> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            return lambda(state);
//        }
//        catch (TError e)
//        {
//            return errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="asyncLambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async Task ExecuteWithCatchAsync<TError>(this Func<Task> asyncLambda,
//        Action<ExceptionDispatchInfo, TError> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            await asyncLambda().Run().ConfigureAwait(false);
//        }
//        catch (TError e)
//        {
//            errorHandler(ExceptionDispatchInfo.Capture(e), e);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="asyncLambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async ValueTask ExecuteWithCatchAsync<TError>(this Func<ValueTask> asyncLambda,
//        Action<ExceptionDispatchInfo, TError> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            await asyncLambda().ConfigureAwait(false);
//        }
//        catch (TError e)
//        {
//            errorHandler(ExceptionDispatchInfo.Capture(e), e);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="asyncLambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>
//    /// to obtain the return value.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async Task ExecuteWithCatchAsync<TState, TError>(this Func<TState, Task> asyncLambda,
//        TState state,
//        Action<ExceptionDispatchInfo, TError, TState> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            await asyncLambda(state).Run().ConfigureAwait(false);
//        }
//        catch (TError e)
//        {
//            errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="asyncLambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>
//    /// to obtain the return value.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async ValueTask ExecuteWithCatchAsync<TState, TError>(this Func<TState, ValueTask> asyncLambda,
//        TState state,
//        Action<ExceptionDispatchInfo, TError, TState> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            await asyncLambda(state).ConfigureAwait(false);
//        }
//        catch (TError e)
//        {
//            errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="asyncLambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>
//    /// to obtain the return value.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async Task<TOut> ExecuteWithCatchAsync<TOut, TError>(this Func<Task<TOut>> asyncLambda,
//        Func<ExceptionDispatchInfo, TError, TOut> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            return await asyncLambda().Run().ConfigureAwait(false);
//        }
//        catch (TError e)
//        {
//            return errorHandler(ExceptionDispatchInfo.Capture(e), e);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="asyncLambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>
//    /// to obtain the return value.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async ValueTask<TOut> ExecuteWithCatchAsync<TOut, TError>(this Func<ValueTask<TOut>> asyncLambda,
//        Func<ExceptionDispatchInfo, TError, TOut> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            return await asyncLambda().ConfigureAwait(false);
//        }
//        catch (TError e)
//        {
//            return errorHandler(ExceptionDispatchInfo.Capture(e), e);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="asyncLambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>
//    /// to obtain the return value.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async Task<TOut> ExecuteWithCatchAsync<TState, TOut, TError>(this Func<TState, Task<TOut>> asyncLambda,
//        TState state,
//        Func<ExceptionDispatchInfo, TError, TState, TOut> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            return await asyncLambda(state).Run().ConfigureAwait(false);
//        }
//        catch (TError e)
//        {
//            return errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
//    /// If any exception of type <typeparamref name="TError"/> (or
//    /// its derived types) occurs during <paramref name="asyncLambda"/>
//    /// execution, relevant information is passed to <paramref name="errorHandler"/>
//    /// to obtain the return value.
//    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT re-throw caught exception, but,
//    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
//    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <typeparam name="TError">Exception type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async ValueTask<TOut> ExecuteWithCatchAsync<TState, TOut, TError>(this Func<TState, ValueTask<TOut>> asyncLambda,
//        TState state,
//        Func<ExceptionDispatchInfo, TError, TState, TOut> errorHandler,
//        Action? finallyClause = null)
//        where TError : Exception
//    {
//        try
//        {
//            return await asyncLambda(state).ConfigureAwait(false);
//        }
//        catch (TError e)
//        {
//            return errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
//        }
//        finally
//        {
//            finallyClause?.Invoke();
//        }
//    }

//    /// <summary>
//    /// Executes <paramref name="lambda"/> inside try block and
//    /// excutes <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <param name="lambda">Lambda to execute inside try clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static void ExecuteWithFinally(this Action lambda,
//        Action finallyClause)
//    {
//        try
//        {
//            lambda();
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Executes <paramref name="lambda"/> inside try block and returns its value
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <param name="lambda">Lambda to execute inside try clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static TOut ExecuteWithFinally<TOut>(this Func<TOut> lambda,
//        Action finallyClause)
//    {
//        try
//        {
//            return lambda();
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Executes <paramref name="lambda"/> inside try block and
//    /// excutes <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <param name="lambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static void ExecuteWithFinally<TState>(this Action<TState> lambda,
//        TState state,
//        Action finallyClause)
//    {
//        try
//        {
//            lambda(state);
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Executes <paramref name="lambda"/> inside try block and returns its value
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="lambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static TOut ExecuteWithFinally<TState, TOut>(this Func<TState, TOut> lambda,
//        TState state,
//        Action finallyClause)
//    {
//        try
//        {
//            return lambda(state);
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Executes <paramref name="lambda"/> inside try block and
//    /// excutes <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <param name="lambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static void ExecuteWithFinally<TState>(this Action<TState> lambda,
//        TState state,
//        Action<TState> finallyClause)
//    {
//        try
//        {
//            lambda(state);
//        }
//        finally
//        {
//            finallyClause(state);
//        }
//    }

//    /// <summary>
//    /// Executes <paramref name="lambda"/> inside try block and returns its value
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="lambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static TOut ExecuteWithFinally<TState, TOut>(this Func<TState, TOut> lambda,
//        TState state,
//        Action<TState> finallyClause)
//    {
//        try
//        {
//            return lambda(state);
//        }
//        finally
//        {
//            finallyClause(state);
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async Task ExecuteWithFinallyAsync(this Func<Task> asyncLambda,
//        Action finallyClause)
//    {
//        try
//        {
//            await asyncLambda().Run().ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async ValueTask ExecuteWithFinallyAsync(this Func<ValueTask> asyncLambda,
//        Action finallyClause)
//    {
//        try
//        {
//            await asyncLambda().ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async Task ExecuteWithFinallyAsync<TState, TOut>(this Func<TState, Task> asyncLambda,
//        TState state,
//        Action finallyClause)
//    {
//        try
//        {
//            await asyncLambda(state).Run().ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async ValueTask ExecuteWithFinallyAsync<TState>(this Func<TState, ValueTask> asyncLambda,
//        TState state,
//        Action finallyClause)
//    {
//        try
//        {
//            await asyncLambda(state).ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async Task ExecuteWithFinallyAsync<TState>(this Func<TState, Task> asyncLambda,
//        TState state,
//        Action<TState> finallyClause)
//    {
//        try
//        {
//            await asyncLambda(state).Run().ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause(state);
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async ValueTask ExecuteWithFinallyAsync<TState>(this Func<TState, ValueTask> asyncLambda,
//        TState state,
//        Action<TState> finallyClause)
//    {
//        try
//        {
//            await asyncLambda(state).ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause(state);
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async Task<TOut> ExecuteWithFinallyAsync<TOut>(this Func<Task<TOut>> asyncLambda,
//        Action finallyClause)
//    {
//        try
//        {
//            return await asyncLambda().Run().ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async ValueTask<TOut> ExecuteWithFinallyAsync<TOut>(this Func<ValueTask<TOut>> asyncLambda,
//        Action finallyClause)
//    {
//        try
//        {
//            return await asyncLambda().ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async Task<TOut> ExecuteWithFinallyAsync<TState, TOut>(this Func<TState, Task<TOut>> asyncLambda,
//        TState state,
//        Action finallyClause)
//    {
//        try
//        {
//            return await asyncLambda(state).Run().ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async ValueTask<TOut> ExecuteWithFinallyAsync<TState, TOut>(this Func<TState, ValueTask<TOut>> asyncLambda,
//        TState state,
//        Action finallyClause)
//    {
//        try
//        {
//            return await asyncLambda(state).ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause();
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async Task<TOut> ExecuteWithFinallyAsync<TState, TOut>(this Func<TState, Task<TOut>> asyncLambda,
//        TState state,
//        Action<TState> finallyClause)
//    {
//        try
//        {
//            return await asyncLambda(state).Run().ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause(state);
//        }
//    }

//    /// <summary>
//    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
//    /// after excuting <paramref name="finallyClause"/> inside finally.
//    /// <para>
//    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
//    /// </para>
//    /// </summary>
//    /// <typeparam name="TOut">Return type</typeparam>
//    /// <typeparam name="TState">State type</typeparam>
//    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
//    /// <param name="state">Lambda state</param>
//    /// <param name="finallyClause">Code to run inside finally clause</param>
//    public static async ValueTask<TOut> ExecuteWithFinallyAsync<TState, TOut>(this Func<TState, ValueTask<TOut>> asyncLambda,
//        TState state,
//        Action<TState> finallyClause)
//    {
//        try
//        {
//            return await asyncLambda(state).ConfigureAwait(false);
//        }
//        finally
//        {
//            finallyClause(state);
//        }
//    }
//}