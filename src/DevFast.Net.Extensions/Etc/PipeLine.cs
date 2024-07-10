namespace DevFast.Net.Extensions.Etc
{
    /// <summary>
    /// Extension methods on Lambdas to create a executable Pipeline.
    /// </summary>
    public static class PipeLine
    {
        private static Func<Func<TStateIn, TIn>, Func<TStateOut, TOut>> Adapter<TIn, TStateIn, TStateOut, TOut>(
            this Func<TIn, TStateOut, TOut> tandem,
            Func<TStateOut, TStateIn> stateAdapter)
        {
            return src => state => tandem(src(stateAdapter(state)), state);
        }

        private static Func<Func<TStateIn, Task<TIn>>, Func<TStateOut, Task<TOut>>> Adapter<TIn, TStateIn, TStateOut, TOut>(
            this Func<TIn, TStateOut, Task<TOut>> tandem,
            Func<TStateOut, TStateIn> stateAdapter)
        {
            return src => async state => await tandem(await src(stateAdapter(state)).Run().ConfigureAwait(false), state).Run().ConfigureAwait(false);
        }

        private static Func<Func<TStateIn, ValueTask<TIn>>, Func<TStateOut, ValueTask<TOut>>> Adapter<TIn, TStateIn, TStateOut, TOut>(
            this Func<TIn, TStateOut, ValueTask<TOut>> tandem,
            Func<TStateOut, TStateIn> stateAdapter)
        {
            return src => async state => await tandem(await src(stateAdapter(state)).ConfigureAwait(false), state).ConfigureAwait(false);
        }

        //private static Func<Func<TStateIn, ValueTask<TIn>>, Func<TStateOut, Task<TOut>>> CrossAdapter<TIn, TStateIn, TStateOut, TOut>(
        //    this Func<TIn, TStateOut, Task<TOut>> tandem,
        //    Func<TStateOut, TStateIn> stateAdapter)
        //{
        //    return src => async state => await tandem(await src(stateAdapter(state)).ConfigureAwait(false), state).Run().ConfigureAwait(false);
        //}

        private static Func<Func<TStateIn, TIn>, Func<TStateOut, TOut>> Adapter<TIn, TStateIn, TStateOut, TOut>(
            this Func<TIn, TStateOut, TOut> tandem)
            where TStateOut : TStateIn
        {
            return src => state => tandem(src(state), state);
        }

        private static Func<Func<TStateIn, Task<TIn>>, Func<TStateOut, Task<TOut>>> Adapter<TIn, TStateIn, TStateOut, TOut>(
            this Func<TIn, TStateOut, Task<TOut>> tandem)
            where TStateOut : TStateIn
        {
            return src => async state => await tandem(await src(state).Run().ConfigureAwait(false), state).Run().ConfigureAwait(false);
        }

        private static Func<Func<TStateIn, ValueTask<TIn>>, Func<TStateOut, ValueTask<TOut>>> Adapter<TIn, TStateIn, TStateOut, TOut>(
            this Func<TIn, TStateOut, ValueTask<TOut>> tandem)
            where TStateOut : TStateIn
        {
            return src => async state => await tandem(await src(state).ConfigureAwait(false), state).ConfigureAwait(false);
        }

        //private static Func<Func<TStateIn, ValueTask<TIn>>, Func<TStateOut, Task<TOut>>> CrossAdapter<TIn, TStateIn, TStateOut, TOut>(
        //    this Func<TIn, TStateOut, Task<TOut>> tandem)
        //    where TStateOut : TStateIn
        //{
        //    return src => async state => await tandem(await src(state).ConfigureAwait(false), state).Run().ConfigureAwait(false);
        //}

        private static Func<Func<TState, TIn>, Func<TState, TOut>> Adapter<TIn, TState, TOut>(
            this Func<TIn, TState, TOut> tandem)
        {
            return tandem.Adapter<TIn, TState, TState, TOut>();
        }

        private static Func<Func<TState, Task<TIn>>, Func<TState, Task<TOut>>> Adapter<TIn, TState, TOut>(
            this Func<TIn, TState, Task<TOut>> tandem)
        {
            return tandem.Adapter<TIn, TState, TState, TOut>();
        }

        private static Func<Func<TState, ValueTask<TIn>>, Func<TState, ValueTask<TOut>>> Adapter<TIn, TState, TOut>(
            this Func<TIn, TState, ValueTask<TOut>> tandem)
        {
            return tandem.Adapter<TIn, TState, TState, TOut>();
        }

        //private static Func<Func<TState, ValueTask<TIn>>, Func<TState, Task<TOut>>> CrossAdapter<TIn, TState, TOut>(
        //    this Func<TIn, TState, Task<TOut>> tandem)
        //{
        //    return tandem.CrossAdapter<TIn, TState, TState, TOut>();
        //}

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

        //private static Func<TStateOut, T> Adapter<T, TStateIn, TStateOut>(this Func<TStateIn, T> lambda)
        //    where TStateOut : TStateIn
        //{
        //    return state => lambda(state);
        //}

        //private static Func<TStateOut, T> Adapter<T, TStateIn, TStateOut>(this Func<TStateIn, T> lambda,
        //    Func<TStateOut, TStateIn> stateAdapter)
        //{
        //    return state => lambda(stateAdapter(state));
        //}

        /// <summary>
        /// Applies <paramref name="adapter"/> on the <paramref name="input"/>
        /// and returns the results.
        /// </summary>
        /// <param name="input">Source on which the adapter is applied.</param>
        /// <param name="adapter">Adapter lambda</param>
        public static TOut Pipe<TIn, TOut>(this TIn input,
            Func<TIn, TOut> adapter)
        {
            return adapter(input);
        }

        /// <summary>
        /// Applies <paramref name="adapter"/> on the <paramref name="input"/>
        /// when <paramref name="flag"/> is <see langword="true"/> and returns the result;
        /// otherwise, returns back the original <paramref name="input"/>.
        /// </summary>
        /// <param name="input">Source on which the adapter is applied.</param>
        /// <param name="adapter">Adapter lambda</param>
        /// <param name="flag">Flag dictating whether should be applied or not</param>
        public static T Pipe<T>(this T input,
            Func<T, T> adapter,
            bool flag)
        {
            return flag ? input.Pipe(adapter) : input;
        }

        #region Conditional Pipes (TIn = TOut, TState)

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
        /// <param name="task">Source lambda to which the tandem operation would be applied.</param>
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

        #endregion Conditional Pipes (TIn = TOut, TState)

        #region Conditional Pipes To Action (TIn = TOut, TState)

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

        #endregion Conditional Pipes To Action (TIn = TOut, TState)

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
}
