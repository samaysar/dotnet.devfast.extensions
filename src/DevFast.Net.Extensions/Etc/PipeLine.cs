namespace DevFast.Net.Extensions.Etc;

/// <summary>
/// Extension methods on Lambdas to create a executable Pipeline.
/// </summary>
public static class PipeLine
{
    #region Tandem Adapter

    //private static Func<Func<TStateIn, TIn>, Func<TStateOut, TOut>> Adapter<TIn, TStateIn, TStateOut, TOut>(
    //    this Func<TIn, TStateOut, TOut> tandem,
    //    Func<TStateOut, TStateIn> stateAdapter)
    //{
    //    return src => state => tandem(src(stateAdapter(state)), state);
    //}

    //private static Func<Func<TStateIn, Task<TIn>>, Func<TStateOut, Task<TOut>>> Adapter<TIn, TStateIn, TStateOut, TOut>(
    //    this Func<TIn, TStateOut, Task<TOut>> tandem,
    //    Func<TStateOut, TStateIn> stateAdapter)
    //{
    //    return src => async state => await tandem(await src(stateAdapter(state)).Run().ConfigureAwait(false), state).Run().ConfigureAwait(false);
    //}

    //private static Func<Func<TStateIn, ValueTask<TIn>>, Func<TStateOut, ValueTask<TOut>>> Adapter<TIn, TStateIn, TStateOut, TOut>(
    //    this Func<TIn, TStateOut, ValueTask<TOut>> tandem,
    //    Func<TStateOut, TStateIn> stateAdapter)
    //{
    //    return src => async state => await tandem(await src(stateAdapter(state)).ConfigureAwait(false), state).ConfigureAwait(false);
    //}

    //private static Func<Func<TStateIn, ValueTask<TIn>>, Func<TStateOut, Task<TOut>>> CrossAdapter<TIn, TStateIn, TStateOut, TOut>(
    //    this Func<TIn, TStateOut, Task<TOut>> tandem,
    //    Func<TStateOut, TStateIn> stateAdapter)
    //{
    //    return src => async state => await tandem(await src(stateAdapter(state)).ConfigureAwait(false), state).Run().ConfigureAwait(false);
    //}

    private static Func<Func<TState, TIn>, Func<TState, TOut>> Adapter<TIn, TState, TOut>(
        this Func<TIn, TState, TOut> tandem)
    {
        return src => state => tandem(src(state), state);
    }

    private static Func<Func<TState, Task<TIn>>, Func<TState, Task<TOut>>> Adapter<TIn, TState, TOut>(
        this Func<TIn, TState, Task<TOut>> tandem)
    {
        return src => async state => await tandem(await src(state).Run().ConfigureAwait(false), state).Run().ConfigureAwait(false);
    }

    private static Func<Func<TState, TIn>, Func<TState, Task<TOut>>> SyncAdapter<TIn, TState, TOut>(
        this Func<TIn, TState, Task<TOut>> tandem)
    {
        return src => async state => await tandem(src(state), state).Run().ConfigureAwait(false);
    }

    private static Func<Func<TState, Task<TIn>>, Func<TState, Task<TOut>>> TaskAdapter<TIn, TState, TOut>(
        this Func<TIn, TState, TOut> tandem)
    {
        return src => async state => tandem(await src(state).Run().ConfigureAwait(false), state);
    }

    private static Func<Func<TState, TIn>, Func<TState, ValueTask<TOut>>> SyncAdapter<TIn, TState, TOut>(
        this Func<TIn, TState, ValueTask<TOut>> tandem)
    {
        return src => async state => await tandem(src(state), state).ConfigureAwait(false);
    }

    private static Func<Func<TState, ValueTask<TIn>>, Func<TState, ValueTask<TOut>>> Adapter<TIn, TState, TOut>(
        this Func<TIn, TState, ValueTask<TOut>> tandem)
    {
        return src => async state => await tandem(await src(state).ConfigureAwait(false), state).ConfigureAwait(false);
    }

    private static Func<Func<TState, ValueTask<TIn>>, Func<TState, ValueTask<TOut>>> ValueTaskAdapter<TIn, TState, TOut>(
        this Func<TIn, TState, TOut> tandem)
    {
        return src => async state => tandem(await src(state).ConfigureAwait(false), state);
    }

    #endregion Tandem Adapter

    #region Source Adapter

    private static Func<TState, T> Adapter<T, TState>(this T value)
    {
        return _ => value;
    }

    private static Func<TState, T> Adapter<T, TState>(this Func<T> lambda)
    {
        return _ => lambda();
    }

    private static Func<TState, Task<T>> Adapter<T, TState>(this Task<T> task)
    {
        return async _ => await task.Run().ConfigureAwait(false);
    }

    private static Func<TState, Task<T>> Adapter<T, TState>(this Func<Task<T>> lambda)
    {
        return async _ => await lambda().Run().ConfigureAwait(false);
    }

    private static Func<TInState, T> Adapter<T, TInState, TState>(this Func<TState, T> lambda,
        Func<TInState, TState> stateAdapter)
    {
        return state => lambda(stateAdapter(state));
    }

    private static Func<TInState, Task<T>> Adapter<T, TInState, TState>(this Func<TState, Task<T>> lambda,
        Func<TInState, TState> stateAdapter)
    {
        return async state => await lambda(stateAdapter(state)).Run().ConfigureAwait(false);
    }

    private static Func<TState, Task<T>> TaskAdapter<T, TState>(this Func<TState, T> lambda)
    {
        return state => Task.FromResult(lambda(state));
    }

    private static Func<TState, ValueTask<T>> Adapter<T, TState>(this Func<ValueTask<T>> lambda)
    {
        return async _ => await lambda().ConfigureAwait(false);
    }

    private static Func<TState, Task<T>> CrossAdapter<T, TState>(this Func<ValueTask<T>> lambda)
    {
        return async _ => await lambda().ConfigureAwait(false);
    }

    private static Func<TState, Task<T>> CrossAdapter<T, TState>(this Func<TState, ValueTask<T>> lambda)
    {
        return async state => await lambda(state).ConfigureAwait(false);
    }

    private static Func<TState, ValueTask<T>> ValueAdapter<T, TState>(this Func<TState, T> lambda)
    {
        return state => Asynchro.FromResult(lambda(state));
    }

    private static Func<TInState, ValueTask<T>> Adapter<T, TInState, TState>(this Func<TState, ValueTask<T>> lambda,
        Func<TInState, TState> stateAdapter)
    {
        return async state => await lambda(stateAdapter(state)).ConfigureAwait(false);
    }

    private static Func<TInState, Task<T>> CrossAdapter<T, TInState, TState>(this Func<TState, ValueTask<T>> lambda,
        Func<TInState, TState> stateAdapter)
    {
        return async state => await lambda(stateAdapter(state)).ConfigureAwait(false);
    }

    #endregion Source Adapter

    #region Pipe (TIn, TOut)

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on the <paramref name="input"/>
    /// and returns the results.
    /// </summary>
    /// <param name="input">Source on which the adapter is applied.</param>
    /// <param name="tandemLambda">Tandem lambda</param>
    public static TOut Pipe<TIn, TOut>(this TIn input,
        Func<TIn, TOut> tandemLambda)
    {
        return tandemLambda(input);
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on the output of <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<TTOut> Pipe<TIn, TTOut>(this Func<TIn> sourceLambda,
        Func<TIn, TTOut> tandemLambda)
    {
        return () => tandemLambda(sourceLambda());
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on the output of <paramref name="task"/>.
    /// </summary>
    /// <para>
    /// IMPLEMENTATION NOTE: As the purpose of pipelines is to executes everything as lazily as possible,
    /// calling this method on a non-running <see cref="Task"/> is advisable, though NOT necessary.
    /// Irrespective to the state of the <paramref name="task"/> outcome would be identical.
    /// </para>
    /// <param name="task">Task on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<Task<TTOut>> Pipe<TIn, TTOut>(this Task<TIn> task,
        Func<TIn, Task<TTOut>> tandemLambda)
    {
        return async () => await tandemLambda(await task.Run().ConfigureAwait(false)).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on the output of <paramref name="task"/>.
    /// </summary>
    /// <para>
    /// IMPLEMENTATION NOTE: As the purpose of pipelines is to executes everything as lazily as possible,
    /// calling this method on a non-running <see cref="Task"/> is advisable, though NOT necessary.
    /// Irrespective to the state of the <paramref name="task"/> outcome would be identical.
    /// </para>
    /// <param name="task">Task on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<Task<TTOut>> Pipe<TIn, TTOut>(this Task<TIn> task,
        Func<TIn, TTOut> tandemLambda)
    {
        return async () => tandemLambda(await task.Run().ConfigureAwait(false));
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on <paramref name="value"/>.
    /// </summary>
    /// <param name="value">Value on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<Task<TTOut>> Pipe<TIn, TTOut>(this TIn value,
        Func<TIn, Task<TTOut>> tandemLambda)
    {
        return async () => await tandemLambda(value).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on the output of <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Lambda on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<Task<TTOut>> Pipe<TIn, TTOut>(this Func<Task<TIn>> sourceLambda,
        Func<TIn, Task<TTOut>> tandemLambda)
    {
        return async () => await tandemLambda(await sourceLambda().Run().ConfigureAwait(false)).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on the output of <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Lambda on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<Task<TTOut>> Pipe<TIn, TTOut>(this Func<Task<TIn>> sourceLambda,
        Func<TIn, TTOut> tandemLambda)
    {
        return async () => tandemLambda(await sourceLambda().Run().ConfigureAwait(false));
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on the output of <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Lambda on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<Task<TTOut>> Pipe<TIn, TTOut>(this Func<TIn> sourceLambda,
        Func<TIn, Task<TTOut>> tandemLambda)
    {
        return async () => await tandemLambda(sourceLambda()).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on <paramref name="value"/>.
    /// </summary>
    /// <param name="value">Value on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<ValueTask<TTOut>> Pipe<TIn, TTOut>(this TIn value,
        Func<TIn, ValueTask<TTOut>> tandemLambda)
    {
        return async () => await tandemLambda(value).ConfigureAwait(false);
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on the output of <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Lambda on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<ValueTask<TTOut>> Pipe<TIn, TTOut>(this Func<ValueTask<TIn>> sourceLambda,
        Func<TIn, ValueTask<TTOut>> tandemLambda)
    {
        return async () => await tandemLambda(await sourceLambda().ConfigureAwait(false)).ConfigureAwait(false);
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on the output of <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Lambda on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<Task<TTOut>> Pipe<TIn, TTOut>(this Func<ValueTask<TIn>> sourceLambda,
        Func<TIn, Task<TTOut>> tandemLambda)
    {
        return async () => await tandemLambda(await sourceLambda().ConfigureAwait(false)).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on the output of <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Lambda on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<ValueTask<TTOut>> Pipe<TIn, TTOut>(this Func<ValueTask<TIn>> sourceLambda,
        Func<TIn, TTOut> tandemLambda)
    {
        return async () => tandemLambda(await sourceLambda().ConfigureAwait(false));
    }

    /// <summary>
    /// Applies <paramref name="tandemLambda"/> on the output of <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Lambda on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    public static Func<ValueTask<TTOut>> Pipe<TIn, TTOut>(this Func<TIn> sourceLambda,
        Func<TIn, ValueTask<TTOut>> tandemLambda)
    {
        return async () => await tandemLambda(sourceLambda()).ConfigureAwait(false);
    }

    #endregion Pipe (TIn, TOut)

    #region Conditional Pipe (T)

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds <paramref name="input"/>
    /// to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the original
    /// <paramref name="input"/>.
    /// </summary>
    /// <param name="input">Value to feed</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static T Pipe<T>(this T input,
        Func<T, T> tandemLambda,
        bool flag)
    {
        return flag ? input.Pipe(tandemLambda) : input;
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<T> Pipe<T>(this Func<T> sourceLambda,
        Func<T, T> tandemLambda,
        bool flag)
    {
        return flag ? sourceLambda.Pipe(tandemLambda) : sourceLambda;
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="task"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="task"/>.
    /// <para>
    /// IMPLEMENTATION NOTE: As the purpose of pipelines is to executes everything as lazily as possible,
    /// calling this method on a non-running <see cref="Task"/> is advisable, though NOT necessary.
    /// Irrespective to the state of the <paramref name="task"/> outcome would be identical.
    /// </para>
    /// </summary>
    /// <param name="task">Task to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="task"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<Task<T>> Pipe<T>(this Task<T> task,
        Func<T, Task<T>> tandemLambda,
        bool flag)
    {
        return flag ? task.Pipe(tandemLambda) : () => task.Run();
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="task"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="task"/>.
    /// <para>
    /// IMPLEMENTATION NOTE: As the purpose of pipelines is to executes everything as lazily as possible,
    /// calling this method on a non-running <see cref="Task"/> is advisable, though NOT necessary.
    /// Irrespective to the state of the <paramref name="task"/> outcome would be identical.
    /// </para>
    /// </summary>
    /// <param name="task">Task to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="task"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<Task<T>> Pipe<T>(this Task<T> task,
        Func<T, T> tandemLambda,
        bool flag)
    {
        return flag ? task.Pipe(tandemLambda) : () => task.Run();
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds
    /// <paramref name="value"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns <paramref name="value"/>.
    /// </summary>
    /// <param name="value">Value to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume <paramref name="value"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<Task<T>> Pipe<T>(this T value,
        Func<T, Task<T>> tandemLambda,
        bool flag)
    {
        return flag ? value.Pipe(tandemLambda) : () => Task.FromResult(value);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<Task<T>> Pipe<T>(this Func<Task<T>> sourceLambda,
        Func<T, Task<T>> tandemLambda,
        bool flag)
    {
        return flag ? sourceLambda.Pipe(tandemLambda) : sourceLambda;
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<Task<T>> Pipe<T>(this Func<Task<T>> sourceLambda,
        Func<T, T> tandemLambda,
        bool flag)
    {
        return flag ? sourceLambda.Pipe(tandemLambda) : sourceLambda;
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<Task<T>> Pipe<T>(this Func<T> sourceLambda,
        Func<T, Task<T>> tandemLambda,
        bool flag)
    {
        return flag ? sourceLambda.Pipe(tandemLambda) : () => Task.FromResult(sourceLambda());
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds
    /// <paramref name="value"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns <paramref name="value"/>.
    /// </summary>
    /// <param name="value">Value to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume <paramref name="value"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<ValueTask<T>> Pipe<T>(this T value,
        Func<T, ValueTask<T>> tandemLambda,
        bool flag)
    {
        return flag ? value.Pipe(tandemLambda) : () => Asynchro.FromResult(value);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<ValueTask<T>> Pipe<T>(this Func<ValueTask<T>> sourceLambda,
        Func<T, ValueTask<T>> tandemLambda,
        bool flag)
    {
        return flag ? sourceLambda.Pipe(tandemLambda) : sourceLambda;
    }

    /// <summary>
    /// Conditionally applies <paramref name="tandemLambda"/> on the output of <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Lambda on which tandem lambda will be applied</param>
    /// <param name="tandemLambda">Tandem lambda to apply</param>
    /// <param name="flag">Flag which dictate whether to apply tandem lambda or not</param>
    public static Func<Task<T>> Pipe<T>(this Func<ValueTask<T>> sourceLambda,
        Func<T, Task<T>> tandemLambda,
        bool flag)
    {
        return flag ? sourceLambda.Pipe(tandemLambda) : async () => await sourceLambda().ConfigureAwait(false);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<ValueTask<T>> Pipe<T>(this Func<ValueTask<T>> sourceLambda,
        Func<T, T> tandemLambda,
        bool flag)
    {
        return flag ? sourceLambda.Pipe(tandemLambda) : sourceLambda;
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<ValueTask<T>> Pipe<T>(this Func<T> sourceLambda,
        Func<T, ValueTask<T>> tandemLambda,
        bool flag)
    {
        return flag ? sourceLambda.Pipe(tandemLambda) : () => Asynchro.FromResult(sourceLambda());
    }

    #endregion Conditional Pipe (T)

    #region Conditional Pipes (T, TState)

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds <paramref name="value"/>
    /// to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the original
    /// <paramref name="value"/>.
    /// </summary>
    /// <param name="value">Value to feed</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, T> Pipe<T, TState>(this T value,
        Func<T, TState, T> tandemLambda,
        bool flag)
    {
        return value.Adapter<T, TState>().Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, T> Pipe<T, TState>(this Func<T> sourceLambda,
        Func<T, TState, T> tandemLambda,
        bool flag)
    {
        return sourceLambda.Adapter<T, TState>().Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, T> Pipe<T, TState>(this Func<TState, T> sourceLambda,
        Func<T, TState, T> tandemLambda,
        bool flag)
    {
        return sourceLambda.Pipe(tandemLambda.Adapter(), flag);
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="task"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="task"/>.
    /// <para>
    /// IMPLEMENTATION NOTE: As the purpose of pipelines is to executes everything as lazily as possible,
    /// calling this method on a non-running <see cref="Task"/> is advisable, though NOT necessary.
    /// Irrespective to the state of the <paramref name="task"/> outcome would be identical.
    /// </para>
    /// </summary>
    /// <param name="task">Task to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="task"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, Task<T>> Pipe<T, TState>(this Task<T> task,
        Func<T, TState, Task<T>> tandemLambda,
        bool flag)
    {
        return task.Adapter<T, TState>().Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, Task<T>> Pipe<T, TState>(this Func<Task<T>> sourceLambda,
        Func<T, TState, Task<T>> tandemLambda,
        bool flag)
    {
        return sourceLambda.Adapter<T, TState>().Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/>'s <see cref="Task{T}"/> to the <paramref name="tandemLambda"/>
    /// and returns a <see cref="Task{T}"/> containing the output of <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns a <see cref="Task{T}"/>
    /// containing the output of the original <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>'s <see cref="Task{TResult}"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, Task<T>> Pipe<T, TState>(this Func<TState, Task<T>> sourceLambda,
        Func<T, TState, Task<T>> tandemLambda,
        bool flag)
    {
        return sourceLambda.Pipe(tandemLambda.Adapter(), flag);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, Task<T>> Pipe<T, TState>(this Func<TState, T> sourceLambda,
        Func<T, TState, Task<T>> tandemLambda,
        bool flag)
    {
        return sourceLambda.Pipe(flag ? tandemLambda.SyncAdapter() : static s => s.TaskAdapter());
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/>'s <see cref="Task{T}"/> to the <paramref name="tandemLambda"/>
    /// and returns a <see cref="Task{T}"/> containing the output of <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns a <see cref="Task{T}"/>
    /// containing the output of the original <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>'s <see cref="Task{TResult}"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, Task<T>> Pipe<T, TState>(this Func<TState, Task<T>> sourceLambda,
        Func<T, TState, T> tandemLambda,
        bool flag)
    {
        return sourceLambda.Pipe(tandemLambda.TaskAdapter(), flag);
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, ValueTask<T>> Pipe<T, TState>(this Func<ValueTask<T>> sourceLambda,
        Func<T, TState, ValueTask<T>> tandemLambda,
        bool flag)
    {
        return sourceLambda.Adapter<T, TState>().Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/>'s <see cref="Task{T}"/> to the <paramref name="tandemLambda"/>
    /// and returns a <see cref="Task{T}"/> containing the output of <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns a <see cref="Task{T}"/>
    /// containing the output of the original <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>'s <see cref="Task{TResult}"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, ValueTask<T>> Pipe<T, TState>(this Func<TState, ValueTask<T>> sourceLambda,
        Func<T, TState, ValueTask<T>> tandemLambda,
        bool flag)
    {
        return sourceLambda.Pipe(tandemLambda.Adapter(), flag);
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, Task<T>> Pipe<T, TState>(this Func<ValueTask<T>> sourceLambda,
        Func<T, TState, Task<T>> tandemLambda,
        bool flag)
    {
        return sourceLambda.CrossAdapter<T, TState>().Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/>'s <see cref="Task{T}"/> to the <paramref name="tandemLambda"/>
    /// and returns a <see cref="Task{T}"/> containing the output of <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns a <see cref="Task{T}"/>
    /// containing the output of the original <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>'s <see cref="Task{TResult}"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, Task<T>> Pipe<T, TState>(this Func<TState, ValueTask<T>> sourceLambda,
        Func<T, TState, Task<T>> tandemLambda,
        bool flag)
    {
        return sourceLambda.CrossAdapter().Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, ValueTask<T>> Pipe<T, TState>(this Func<TState, T> sourceLambda,
        Func<T, TState, ValueTask<T>> tandemLambda,
        bool flag)
    {
        return sourceLambda.Pipe(flag ? tandemLambda.SyncAdapter() : static s => s.ValueAdapter());
    }

    /// <summary>
    /// Provides a conditional asynchronous lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/>'s <see cref="Task{T}"/> to the <paramref name="tandemLambda"/>
    /// and returns a <see cref="Task{T}"/> containing the output of <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns a <see cref="Task{T}"/>
    /// containing the output of the original <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>'s <see cref="Task{TResult}"/>.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TState, ValueTask<T>> Pipe<T, TState>(this Func<TState, ValueTask<T>> sourceLambda,
        Func<T, TState, T> tandemLambda,
        bool flag)
    {
        return sourceLambda.Pipe(tandemLambda.ValueTaskAdapter(), flag);
    }

    #endregion Conditional Pipes (T, TState)

    #region Conditional Pipes (T, TTanState <> TSrcState)

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TTanState, T> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, T> sourceLambda,
        Func<T, TTanState, T> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter,
        bool flag)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TTanState, Task<T>> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, Task<T>> sourceLambda,
        Func<T, TTanState, Task<T>> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter,
        bool flag)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TTanState, Task<T>> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, T> sourceLambda,
        Func<T, TTanState, Task<T>> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter,
        bool flag)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TTanState, Task<T>> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, Task<T>> sourceLambda,
        Func<T, TTanState, T> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter,
        bool flag)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TTanState, ValueTask<T>> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, ValueTask<T>> sourceLambda,
        Func<T, TTanState, ValueTask<T>> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter,
        bool flag)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TTanState, Task<T>> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, ValueTask<T>> sourceLambda,
        Func<T, TTanState, Task<T>> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter,
        bool flag)
    {
        return sourceLambda.CrossAdapter(stateAdapter).Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TTanState, ValueTask<T>> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, T> sourceLambda,
        Func<T, TTanState, ValueTask<T>> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter,
        bool flag)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda, flag);
    }

    /// <summary>
    /// Provides a conditional lambda, which upon execution:
    /// <para>
    /// 1. If <paramref name="flag"/> is <see langword="true"/>, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </para>
    /// 2. If <paramref name="flag"/> is <see langword="false"/>, returns the output of the original
    /// <paramref name="sourceLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    /// <param name="flag">Conditional flag dictating whether <paramref name="tandemLambda"/> should be applied or not</param>
    public static Func<TTanState, ValueTask<T>> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, ValueTask<T>> sourceLambda,
        Func<T, TTanState, T> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter,
        bool flag)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda, flag);
    }

    #endregion Conditional Pipes (T, TTanState <> TSrcState)

    #region Conditional Pipes To Void Lambda (T, TState)

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    public static Action<TState> Pipe<T, TState>(this Func<TState, T> sourceLambda,
        Action<T, TState> tandemLambda)
    {
        return state => tandemLambda(sourceLambda(state), state);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    public static Func<TState, Task> Pipe<T, TState>(this Func<TState, T> sourceLambda,
        Func<T, TState, Task> tandemLambda)
    {
        return async state => await tandemLambda(sourceLambda(state), state).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    public static Func<TState, Task> Pipe<T, TState>(this Func<TState, Task<T>> sourceLambda,
        Action<T, TState> tandemLambda)
    {
        return async state => tandemLambda(await sourceLambda(state).Run().ConfigureAwait(false), state);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    public static Func<TState, Task> Pipe<T, TState>(this Func<TState, Task<T>> sourceLambda,
        Func<T, TState, Task> tandemLambda)
    {
        return async state => await tandemLambda(await sourceLambda(state).Run().ConfigureAwait(false), state).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    public static Func<TState, ValueTask> Pipe<T, TState>(this Func<TState, T> sourceLambda,
        Func<T, TState, ValueTask> tandemLambda)
    {
        return async state => await tandemLambda(sourceLambda(state), state).ConfigureAwait(false);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    public static Func<TState, ValueTask> Pipe<T, TState>(this Func<TState, ValueTask<T>> sourceLambda,
        Action<T, TState> tandemLambda)
    {
        return async state => tandemLambda(await sourceLambda(state).ConfigureAwait(false), state);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    public static Func<TState, ValueTask> Pipe<T, TState>(this Func<TState, ValueTask<T>> sourceLambda,
        Func<T, TState, ValueTask> tandemLambda)
    {
        return async state => await tandemLambda(await sourceLambda(state).ConfigureAwait(false), state).ConfigureAwait(false);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    public static Func<TState, Task> Pipe<T, TState>(this Func<TState, ValueTask<T>> sourceLambda,
        Func<T, TState, Task> tandemLambda)
    {
        return async state => await tandemLambda(await sourceLambda(state).ConfigureAwait(false), state).Run().ConfigureAwait(false);
    }

    #endregion Conditional Pipes To Void Lambda (T, TState)

    #region Conditional Pipes To Void Lambda (T, TTanState <> TSrcState)

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Action<TTanState> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, T> sourceLambda,
        Action<T, TTanState> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, Task> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, T> sourceLambda,
        Func<T, TTanState, Task> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, Task> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, Task<T>> sourceLambda,
        Action<T, TTanState> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, Task> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, Task<T>> sourceLambda,
        Func<T, TTanState, Task> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, ValueTask> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, T> sourceLambda,
        Func<T, TTanState, ValueTask> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, ValueTask> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, ValueTask<T>> sourceLambda,
        Action<T, TTanState> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, ValueTask> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, ValueTask<T>> sourceLambda,
        Func<T, TTanState, ValueTask> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of <paramref name="sourceLambda"/>
    /// to the <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the output of <paramref name="sourceLambda"/>.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, Task> Pipe<T, TSrcState, TTanState>(this Func<TSrcState, ValueTask<T>> sourceLambda,
        Func<T, TTanState, Task> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    #endregion Conditional Pipes To Void Lambda (T, TState)

    #region Pipes (TIn, TState, TOut)

    /// <summary>
    /// Provides a lambda, which upon execution, feeds <paramref name="value"/>
    /// to the <paramref name="tandemLambda"/> and returns its output.
    /// </summary>
    /// <param name="value">Value to feed</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, TOut> Pipe<TIn, TState, TOut>(this TIn value,
        Func<TIn, TState, TOut> tandemLambda)
    {
        return value.Adapter<TIn, TState>().Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, TOut> Pipe<TIn, TState, TOut>(this Func<TIn> sourceLambda,
        Func<TIn, TState, TOut> tandemLambda)
    {
        return sourceLambda.Adapter<TIn, TState>().Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, TOut> Pipe<TIn, TState, TOut>(this Func<TState, TIn> sourceLambda,
        Func<TIn, TState, TOut> tandemLambda)
    {
        return sourceLambda.Pipe(tandemLambda.Adapter());
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="task"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <para>
    /// IMPLEMENTATION NOTE: As the purpose of pipelines is to executes everything as lazily as possible,
    /// calling this method on a non-running <see cref="Task"/> is advisable, though NOT necessary.
    /// Irrespective to the state of the <paramref name="task"/> outcome would be identical.
    /// </para>
    /// <param name="task">Task to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, Task<TOut>> Pipe<TIn, TState, TOut>(this Task<TIn> task,
        Func<TIn, TState, Task<TOut>> tandemLambda)
    {
        return task.Adapter<TIn, TState>().Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, Task<TOut>> Pipe<TIn, TState, TOut>(this Func<Task<TIn>> sourceLambda,
        Func<TIn, TState, Task<TOut>> tandemLambda)
    {
        return sourceLambda.Adapter<TIn, TState>().Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, Task<TOut>> Pipe<TIn, TState, TOut>(this Func<TState, Task<TIn>> sourceLambda,
        Func<TIn, TState, Task<TOut>> tandemLambda)
    {
        return sourceLambda.Pipe(tandemLambda.Adapter());
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, Task<TOut>> Pipe<TIn, TState, TOut>(this Func<TState, TIn> sourceLambda,
        Func<TIn, TState, Task<TOut>> tandemLambda)
    {
        return sourceLambda.Pipe(tandemLambda.SyncAdapter());
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, Task<TOut>> Pipe<TIn, TState, TOut>(this Func<TState, Task<TIn>> sourceLambda,
        Func<TIn, TState, TOut> tandemLambda)
    {
        return sourceLambda.Pipe(tandemLambda.TaskAdapter());
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, ValueTask<TOut>> Pipe<TIn, TState, TOut>(this Func<ValueTask<TIn>> sourceLambda,
        Func<TIn, TState, ValueTask<TOut>> tandemLambda)
    {
        return sourceLambda.Adapter<TIn, TState>().Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, ValueTask<TOut>> Pipe<TIn, TState, TOut>(this Func<TState, ValueTask<TIn>> sourceLambda,
        Func<TIn, TState, ValueTask<TOut>> tandemLambda)
    {
        return sourceLambda.Pipe(tandemLambda.Adapter());
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, Task<TOut>> Pipe<TIn, TState, TOut>(this Func<ValueTask<TIn>> sourceLambda,
        Func<TIn, TState, Task<TOut>> tandemLambda)
    {
        return sourceLambda.CrossAdapter<TIn, TState>().Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, Task<TOut>> Pipe<TIn, TState, TOut>(this Func<TState, ValueTask<TIn>> sourceLambda,
        Func<TIn, TState, Task<TOut>> tandemLambda)
    {
        return sourceLambda.CrossAdapter().Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, ValueTask<TOut>> Pipe<TIn, TState, TOut>(this Func<TState, TIn> sourceLambda,
        Func<TIn, TState, ValueTask<TOut>> tandemLambda)
    {
        return sourceLambda.Pipe(tandemLambda.SyncAdapter());
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    public static Func<TState, ValueTask<TOut>> Pipe<TIn, TState, TOut>(this Func<TState, ValueTask<TIn>> sourceLambda,
        Func<TIn, TState, TOut> tandemLambda)
    {
        return sourceLambda.Pipe(tandemLambda.ValueTaskAdapter());
    }

    #endregion Pipes (TIn, TState, TOut)

    #region Pipes (TIn, TTanState <> TSrcState, TOut)

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, TOut> Pipe<TIn, TSrcState, TTanState, TOut>(this Func<TSrcState, TIn> sourceLambda,
        Func<TIn, TTanState, TOut> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, Task<TOut>> Pipe<TIn, TSrcState, TTanState, TOut>(this Func<TSrcState, Task<TIn>> sourceLambda,
        Func<TIn, TTanState, Task<TOut>> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, Task<TOut>> Pipe<TIn, TSrcState, TTanState, TOut>(this Func<TSrcState, TIn> sourceLambda,
        Func<TIn, TTanState, Task<TOut>> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, Task<TOut>> Pipe<TIn, TSrcState, TTanState, TOut>(this Func<TSrcState, Task<TIn>> sourceLambda,
        Func<TIn, TTanState, TOut> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, ValueTask<TOut>> Pipe<TIn, TSrcState, TTanState, TOut>(this Func<TSrcState, ValueTask<TIn>> sourceLambda,
        Func<TIn, TTanState, ValueTask<TOut>> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, Task<TOut>> Pipe<TIn, TSrcState, TTanState, TOut>(this Func<TSrcState, ValueTask<TIn>> sourceLambda,
        Func<TIn, TTanState, Task<TOut>> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.CrossAdapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, ValueTask<TOut>> Pipe<TIn, TSrcState, TTanState, TOut>(this Func<TSrcState, TIn> sourceLambda,
        Func<TIn, TTanState, ValueTask<TOut>> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    /// <summary>
    /// Provides a lambda, which upon execution, feeds the output of
    /// <paramref name="sourceLambda"/> to the <paramref name="tandemLambda"/> and returns the output obtained
    /// from <paramref name="tandemLambda"/>.
    /// </summary>
    /// <param name="sourceLambda">Source lambda to which the tandem operation would be applied.</param>
    /// <param name="tandemLambda">Tandem lambda that would consume the value.</param>
    /// <param name="stateAdapter">Lambda for state manipulation.</param>
    public static Func<TTanState, ValueTask<TOut>> Pipe<TIn, TSrcState, TTanState, TOut>(this Func<TSrcState, ValueTask<TIn>> sourceLambda,
        Func<TIn, TTanState, TOut> tandemLambda,
        Func<TTanState, TSrcState> stateAdapter)
    {
        return sourceLambda.Adapter(stateAdapter).Pipe(tandemLambda);
    }

    #endregion Pipes (TIn, TTanState <> TSrcState, TOut)

    //    //-------------------------------------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

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
}