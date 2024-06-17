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
}