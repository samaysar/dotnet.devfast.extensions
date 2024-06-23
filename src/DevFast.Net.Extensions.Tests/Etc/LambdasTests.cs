using System.Runtime.ExceptionServices;

namespace DevFast.Net.Extensions.Tests.Etc;

[TestFixture]
public class LambdasTests
{
    [Test]
    public void Execute_On_Action_Works_As_Expected()
    {
        Exception ex = new("Error");
        int lambdaCount = 0;
        Action result = () => Interlocked.Increment(ref lambdaCount);
        Action error = () => throw ex;
        result.Execute();
        That(lambdaCount, Is.EqualTo(1));
        Exception? err = Throws<Exception>(() => error.Execute());
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public void Execute_On_FuncT_Works_As_Expected()
    {
        Exception ex = new("Error");
        Func<int> result = static () => 1;
        Func<int> error = () => throw ex;
        That(result.Execute(), Is.EqualTo(1));
        Exception? err = Throws<Exception>(() => error.Execute());
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public void Execute_On_ActionT_Works_As_Expected()
    {
        Exception ex = new("Error");
        int lambdaCount = 0;
        Action<int> result = i => Interlocked.Add(ref lambdaCount, i);
        Action<int> error = _ => throw ex;
        result.Execute(2);
        That(lambdaCount, Is.EqualTo(2));
        Exception? err = Throws<Exception>(() => error.Execute(1));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public void Execute_On_FuncTInTOut_Works_As_Expected()
    {
        Exception ex = new("Error");
        Func<int, int> result = static i => ++i;
        Func<int, int> error = _ => throw ex;
        That(result.Execute(1), Is.EqualTo(2));
        Exception? err = Throws<Exception>(() => error.Execute(1));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public void Execute_On_Action_With_ErrorHandler_Works_As_Expected()
    {
        ArgumentException ex = new("Error");
        int lambdaCount = 0;
        int handlerCount = 0;
        int finallyCount = 0;
        Action result = () => Interlocked.Increment(ref lambdaCount);
        Action error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }

        void errorHandler(ExceptionDispatchInfo edi, ArgumentException e)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            _ = Interlocked.Increment(ref handlerCount);
        }
        void errorNoHandler(ExceptionDispatchInfo edi, ArgumentException _)
        {
            edi.Throw();
        }

        result.Execute((Action<ExceptionDispatchInfo, ArgumentException>)errorHandler);
        That(lambdaCount, Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(0));
        error.Execute((Action<ExceptionDispatchInfo, ArgumentException>)errorHandler);
        That(handlerCount, Is.EqualTo(1));
        ArgumentException? err = Throws<ArgumentException>(() => error.Execute((Action<ExceptionDispatchInfo, ArgumentException>)errorNoHandler));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        result.Execute((Action<ExceptionDispatchInfo, ArgumentException>)errorHandler, Finally);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(2));
        That(handlerCount, Is.EqualTo(1));
        error.Execute((Action<ExceptionDispatchInfo, ArgumentException>)errorHandler, Finally);
        That(handlerCount, Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        err = Throws<ArgumentException>(() => error.Execute((Action<ExceptionDispatchInfo, ArgumentException>)errorNoHandler, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public void Execute_On_FuncT_With_ErrorHandler_Works_As_Expected()
    {
        ArgumentException ex = new("Error");
        int handlerCount = 0;
        int finallyCount = 0;
        Func<int> result = static () => 1;
        Func<int> error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }
        int errorHandler(ExceptionDispatchInfo edi, ArgumentException e)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            return Interlocked.Increment(ref handlerCount);
        }
        int errorNoHandler(ExceptionDispatchInfo edi, ArgumentException _)
        {
            edi.Throw();
            return 0;
        }

        That(result.Execute((Func<ExceptionDispatchInfo, ArgumentException, int>)errorHandler), Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(0));
        That(error.Execute((Func<ExceptionDispatchInfo, ArgumentException, int>)errorHandler), Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(1));
        ArgumentException? err = Throws<ArgumentException>(() => error.Execute((Func<ExceptionDispatchInfo, ArgumentException, int>)errorNoHandler));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        That(result.Execute((Func<ExceptionDispatchInfo, ArgumentException, int>)errorHandler, Finally), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(1));
        That(error.Execute((Func<ExceptionDispatchInfo, ArgumentException, int>)errorHandler, Finally), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        That(handlerCount, Is.EqualTo(2));
        err = Throws<ArgumentException>(() => error.Execute((Func<ExceptionDispatchInfo, ArgumentException, int>)errorNoHandler, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public void Execute_On_ActionT_With_ErrorHandler_Works_As_Expected()
    {
        ArgumentException ex = new("Error");
        int lambdaCount = 0;
        int handlerCount = 0;
        int finallyCount = 0;
        Action<int> result = i => Interlocked.Add(ref lambdaCount, i);
        Action<int> error = _ => throw ex;
        void Finally()
        {
            ++finallyCount;
        }
        void errorHandler(ExceptionDispatchInfo edi, ArgumentException e, int i)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            _ = Interlocked.Add(ref handlerCount, i);
        }
        void errorNoHandler(ExceptionDispatchInfo edi, ArgumentException _, int __)
        {
            edi.Throw();
        }

        result.Execute(5, (Action<ExceptionDispatchInfo, ArgumentException, int>)errorHandler);
        That(lambdaCount, Is.EqualTo(5));
        That(handlerCount, Is.EqualTo(0));
        error.Execute(3, (Action<ExceptionDispatchInfo, ArgumentException, int>)errorHandler);
        That(handlerCount, Is.EqualTo(3));
        ArgumentException? err = Throws<ArgumentException>(() => error.Execute(1, (Action<ExceptionDispatchInfo, ArgumentException, int>)errorNoHandler));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        result.Execute(5, (Action<ExceptionDispatchInfo, ArgumentException, int>)errorHandler, Finally);
        That(lambdaCount, Is.EqualTo(10));
        That(handlerCount, Is.EqualTo(3));
        That(finallyCount, Is.EqualTo(1));
        error.Execute(3, (Action<ExceptionDispatchInfo, ArgumentException, int>)errorHandler, Finally);
        That(handlerCount, Is.EqualTo(6));
        That(finallyCount, Is.EqualTo(2));
        err = Throws<ArgumentException>(() => error.Execute(1, (Action<ExceptionDispatchInfo, ArgumentException, int>)errorNoHandler, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }
}
