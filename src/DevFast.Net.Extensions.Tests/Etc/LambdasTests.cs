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
        Ae ex = new("Error");
        int lambdaCount = 0;
        int handlerCount = 0;
        int finallyCount = 0;
        Action result = () => Interlocked.Increment(ref lambdaCount);
        Action error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }

        void errorHandler(Edi edi, Ae e)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            _ = Interlocked.Increment(ref handlerCount);
        }
        void errorNoHandler(Edi edi, Ae _)
        {
            edi.Throw();
        }

        result.Execute((Action<Edi, Ae>)errorHandler);
        That(lambdaCount, Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(0));
        error.Execute((Action<Edi, Ae>)errorHandler);
        That(handlerCount, Is.EqualTo(1));
        Ae? err = Throws<Ae>(() => error.Execute((Action<Edi, Ae>)errorNoHandler));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        result.Execute((Action<Edi, Ae>)errorHandler, Finally);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(2));
        That(handlerCount, Is.EqualTo(1));
        error.Execute((Action<Edi, Ae>)errorHandler, Finally);
        That(handlerCount, Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        err = Throws<Ae>(() => error.Execute((Action<Edi, Ae>)errorNoHandler, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public void Execute_On_FuncT_With_ErrorHandler_Works_As_Expected()
    {
        Ae ex = new("Error");
        int handlerCount = 0;
        int finallyCount = 0;
        Func<int> result = static () => 1;
        Func<int> error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }
        int errorHandler(Edi edi, Ae e)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            return Interlocked.Increment(ref handlerCount);
        }
        int errorNoHandler(Edi edi, Ae _)
        {
            edi.Throw();
            return 0;
        }

        That(result.Execute((Func<Edi, Ae, int>)errorHandler), Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(0));
        That(error.Execute((Func<Edi, Ae, int>)errorHandler), Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(1));
        Ae? err = Throws<Ae>(() => error.Execute((Func<Edi, Ae, int>)errorNoHandler));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        That(result.Execute((Func<Edi, Ae, int>)errorHandler, Finally), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(1));
        That(error.Execute((Func<Edi, Ae, int>)errorHandler, Finally), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        That(handlerCount, Is.EqualTo(2));
        err = Throws<Ae>(() => error.Execute((Func<Edi, Ae, int>)errorNoHandler, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public void Execute_On_ActionT_With_ErrorHandler_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        int handlerCount = 0;
        int finallyCount = 0;
        Action<int> result = i => Interlocked.Add(ref lambdaCount, i);
        Action<int> error = _ => throw ex;
        void Finally()
        {
            ++finallyCount;
        }
        void errorHandler(Edi edi, Ae e, int i)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            _ = Interlocked.Add(ref handlerCount, i);
        }
        void errorNoHandler(Edi edi, Ae _, int __)
        {
            edi.Throw();
        }

        result.Execute(5, (Action<Edi, Ae, int>)errorHandler);
        That(lambdaCount, Is.EqualTo(5));
        That(handlerCount, Is.EqualTo(0));
        error.Execute(3, (Action<Edi, Ae, int>)errorHandler);
        That(handlerCount, Is.EqualTo(3));
        Ae? err = Throws<Ae>(() => error.Execute(1, (Action<Edi, Ae, int>)errorNoHandler));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        result.Execute(5, (Action<Edi, Ae, int>)errorHandler, Finally);
        That(lambdaCount, Is.EqualTo(10));
        That(handlerCount, Is.EqualTo(3));
        That(finallyCount, Is.EqualTo(1));
        error.Execute(3, (Action<Edi, Ae, int>)errorHandler, Finally);
        That(handlerCount, Is.EqualTo(6));
        That(finallyCount, Is.EqualTo(2));
        err = Throws<Ae>(() => error.Execute(1, (Action<Edi, Ae, int>)errorNoHandler, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public void Execute_On_FuncTInTOut_With_ErrorHandler_Works_As_Expected()
    {
        Ae ex = new("Error");
        int handlerCount = 0;
        int finallyCount = 0;
        Func<int, int> result = static i => Interlocked.Increment(ref i);
        Func<int, int> error = _ => throw ex;
        void Finally()
        {
            ++finallyCount;
        }
        int errorHandler(Edi edi, Ae e, int i)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            return Interlocked.Add(ref handlerCount, i);
        }
        int errorNoHandler(Edi edi, Ae _, int __)
        {
            edi.Throw();
            return 0;
        }

        That(result.Execute(5, (Func<Edi, Ae, int, int>)errorHandler), Is.EqualTo(6));
        That(handlerCount, Is.EqualTo(0));
        That(error.Execute(3, (Func<Edi, Ae, int, int>)errorHandler), Is.EqualTo(3));
        That(handlerCount, Is.EqualTo(3));
        Ae? err = Throws<Ae>(() => error.Execute(1, (Func<Edi, Ae, int, int>)errorNoHandler));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        That(result.Execute(5, (Func<Edi, Ae, int, int>)errorHandler, Finally), Is.EqualTo(6));
        That(handlerCount, Is.EqualTo(3));
        That(finallyCount, Is.EqualTo(1));
        That(error.Execute(3, (Func<Edi, Ae, int, int>)errorHandler, Finally), Is.EqualTo(6));
        That(finallyCount, Is.EqualTo(2));
        That(handlerCount, Is.EqualTo(6));
        err = Throws<Ae>(() => error.Execute(1, (Func<Edi, Ae, int, int>)errorNoHandler, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public void Execute_On_ActionT_With_ErrorHandler_N_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        int handlerCount = 0;
        int finallyCount = 0;
        Action<int> result = i => Interlocked.Add(ref lambdaCount, i);
        Action<int> error = _ => throw ex;
        void Finally(int i)
        {
            That(i, Is.EqualTo(1));
            ++finallyCount;
        }
        void errorHandler(Edi edi, Ae e, int i)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            _ = Interlocked.Add(ref handlerCount, i);
        }
        void errorNoHandler(Edi edi, Ae _, int __)
        {
            edi.Throw();
        }

        result.Execute(1, (Action<Edi, Ae, int>)errorHandler, Finally);
        That(lambdaCount, Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(0));
        That(finallyCount, Is.EqualTo(1));
        error.Execute(1, (Action<Edi, Ae, int>)errorHandler, Finally);
        That(handlerCount, Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(2));
        Ae? err = Throws<Ae>(() => error.Execute(1, (Action<Edi, Ae, int>)errorNoHandler, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public void Execute_On_FuncTInTOut_With_ErrorHandler_N_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        int handlerCount = 0;
        int finallyCount = 0;
        Func<int, int> result = static i => Interlocked.Increment(ref i);
        Func<int, int> error = _ => throw ex;
        void Finally(int i)
        {
            That(i, Is.EqualTo(1));
            ++finallyCount;
        }
        int errorHandler(Edi edi, Ae e, int i)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            return Interlocked.Add(ref handlerCount, i);
        }
        int errorNoHandler(Edi edi, Ae _, int __)
        {
            edi.Throw();
            return 0;
        }

        That(result.Execute(1, (Func<Edi, Ae, int, int>)errorHandler, Finally), Is.EqualTo(2));
        That(handlerCount, Is.EqualTo(0));
        That(finallyCount, Is.EqualTo(1));
        That(error.Execute(1, (Func<Edi, Ae, int, int>)errorHandler, Finally), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(2));
        That(handlerCount, Is.EqualTo(1));
        Ae? err = Throws<Ae>(() => error.Execute(1, (Func<Edi, Ae, int, int>)errorNoHandler, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public void Execute_On_Action_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        int finallyCount = 0;
        Action result = () => Interlocked.Increment(ref lambdaCount);
        Action error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }

        result.Execute(Finally);
        That(lambdaCount, Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = Throws<Ae>(() => error.Execute(Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public void Execute_On_FuncT_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        int finallyCount = 0;
        Func<int> result = static () => 1;
        Func<int> error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }
        That(result.Execute(Finally), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = Throws<Ae>(() => error.Execute(Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public void Execute_On_ActionT_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        int finallyCount = 0;
        Action<int> result = _ => Interlocked.Increment(ref lambdaCount);
        Action<int> error = _ => throw ex;
        void Finally()
        {
            ++finallyCount;
        }

        result.Execute(1, Finally);
        That(lambdaCount, Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = Throws<Ae>(() => error.Execute(1, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public void Execute_On_FuncTInTOut_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        int finallyCount = 0;
        Func<int, int> result = static _ => 1;
        Func<int, int> error = _ => throw ex;
        void Finally()
        {
            ++finallyCount;
        }
        That(result.Execute(1, Finally), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = Throws<Ae>(() => error.Execute(1, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public void Execute_On_ActionT_With_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        int finallyCount = 0;
        Action<int> result = _ => Interlocked.Increment(ref lambdaCount);
        Action<int> error = _ => throw ex;
        void Finally(int s)
        {
            That(s, Is.EqualTo(1));
            ++finallyCount;
        }

        result.Execute(1, Finally);
        That(lambdaCount, Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = Throws<Ae>(() => error.Execute(1, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public void Execute_On_FuncTInTOut_With_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        int finallyCount = 0;
        Func<int, int> result = static _ => 1;
        Func<int, int> error = _ => throw ex;
        void Finally(int s)
        {
            That(s, Is.EqualTo(1));
            ++finallyCount;
        }
        That(result.Execute(1, Finally), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = Throws<Ae>(() => error.Execute(1, Finally));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTask_Works_As_Expected()
    {
        Exception ex = new("Error");
        int lambdaCount = 0;
        Func<Task> result = () =>
        {
            _ = Interlocked.Increment(ref lambdaCount);
            return Task.CompletedTask;
        };
        Func<Task> error = () => throw ex;
        await result.ExecuteAsync().ConfigureAwait(false);
        That(lambdaCount, Is.EqualTo(1));
        Exception? err = ThrowsAsync<Exception>(async () => await error.ExecuteAsync().ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncValueTask_Works_As_Expected()
    {
        Exception ex = new("Error");
        int lambdaCount = 0;
        Func<ValueTask> result = () =>
        {
            _ = Interlocked.Increment(ref lambdaCount);
            return ValueTask.CompletedTask;
        };
        Func<ValueTask> error = () => throw ex;
        await result.ExecuteAsync().ConfigureAwait(false);
        That(lambdaCount, Is.EqualTo(1));
        Exception? err = ThrowsAsync<Exception>(async () => await error.ExecuteAsync().ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInTask_Works_As_Expected()
    {
        Exception ex = new("Error");
        int lambdaCount = 0;
        Func<int, Task> result = i =>
        {
            _ = Interlocked.Add(ref lambdaCount, i);
            return Task.CompletedTask;
        };
        Func<int, Task> error = _ => throw ex;
        await result.ExecuteAsync(1).ConfigureAwait(false);
        That(lambdaCount, Is.EqualTo(1));
        Exception? err = ThrowsAsync<Exception>(async () => await error.ExecuteAsync(1).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInValueTask_Works_As_Expected()
    {
        Exception ex = new("Error");
        int lambdaCount = 0;
        Func<int, ValueTask> result = i =>
        {
            _ = Interlocked.Add(ref lambdaCount, i);
            return ValueTask.CompletedTask;
        };
        Func<int, ValueTask> error = _ => throw ex;
        await result.ExecuteAsync(1).ConfigureAwait(false);
        That(lambdaCount, Is.EqualTo(1));
        Exception? err = ThrowsAsync<Exception>(async () => await error.ExecuteAsync(1).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTaskTOut_Works_As_Expected()
    {
        Exception ex = new("Error");
        int lambdaCount = 0;
        Func<Task<int>> result = () => Task.FromResult(Interlocked.Increment(ref lambdaCount));
        Func<Task> error = () => throw ex;
        That(await result.ExecuteAsync().ConfigureAwait(false), Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(1));
        Exception? err = ThrowsAsync<Exception>(async () => await error.ExecuteAsync().ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncValueTaskTOut_Works_As_Expected()
    {
        Exception ex = new("Error");
        int lambdaCount = 0;
        Func<ValueTask<int>> result = () => ValueTask.FromResult(Interlocked.Increment(ref lambdaCount));
        Func<ValueTask<int>> error = () => throw ex;
        That(await result.ExecuteAsync().ConfigureAwait(false), Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(1));
        Exception? err = ThrowsAsync<Exception>(async () => await error.ExecuteAsync().ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInTaskTOut_Works_As_Expected()
    {
        Exception ex = new("Error");
        Func<int, Task<int>> result = static i => Task.FromResult(++i);
        Func<int, Task<int>> error = _ => throw ex;
        That(await result.ExecuteAsync(0).ConfigureAwait(false), Is.EqualTo(1));
        Exception? err = ThrowsAsync<Exception>(async () => await error.ExecuteAsync(0).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInValueTaskTOut_Works_As_Expected()
    {
        Exception ex = new("Error");
        Func<int, ValueTask<int>> result = static i => ValueTask.FromResult(++i);
        Func<int, ValueTask<int>> error = _ => throw ex;
        That(await result.ExecuteAsync(0).ConfigureAwait(false), Is.EqualTo(1));
        Exception? err = ThrowsAsync<Exception>(async () => await error.ExecuteAsync(0).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTask_With_ErrorHandler_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        int finallyCount = 0;
        int handlerCount = 0;
        Func<Task> result = () =>
        {
            _ = Interlocked.Increment(ref lambdaCount);
            return Task.CompletedTask;
        };
        Func<Task> error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }

        void errorHandler(Edi edi, Ae e)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            _ = Interlocked.Increment(ref handlerCount);
        }
        void errorNoHandler(Edi edi, Ae _)
        {
            edi.Throw();
        }
        await result.ExecuteAsync((Action<Edi, Ae>)errorHandler).ConfigureAwait(false);
        That(lambdaCount, Is.EqualTo(1));
        await error.ExecuteAsync((Action<Edi, Ae>)errorHandler).ConfigureAwait(false);
        That(handlerCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync((Action<Edi, Ae>)errorNoHandler).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        await result.ExecuteAsync((Action<Edi, Ae>)errorHandler, Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(2));
        That(handlerCount, Is.EqualTo(1));
        await error.ExecuteAsync((Action<Edi, Ae>)errorHandler, Finally).ConfigureAwait(false);
        That(handlerCount, Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync((Action<Edi, Ae>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncValueTask_With_ErrorHandler_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        Func<ValueTask> result = () =>
        {
            _ = Interlocked.Increment(ref lambdaCount);
            return ValueTask.CompletedTask;
        };
        Func<ValueTask> error = () => throw ex;

        int finallyCount = 0;
        int handlerCount = 0;
        void Finally()
        {
            ++finallyCount;
        }

        void errorHandler(Edi edi, Ae e)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            _ = Interlocked.Increment(ref handlerCount);
        }
        void errorNoHandler(Edi edi, Ae _)
        {
            edi.Throw();
        }
        await result.ExecuteAsync((Action<Edi, Ae>)errorHandler).ConfigureAwait(false);
        That(lambdaCount, Is.EqualTo(1));
        await error.ExecuteAsync((Action<Edi, Ae>)errorHandler).ConfigureAwait(false);
        That(handlerCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync((Action<Edi, Ae>)errorNoHandler).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        await result.ExecuteAsync((Action<Edi, Ae>)errorHandler, Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(2));
        That(handlerCount, Is.EqualTo(1));
        await error.ExecuteAsync((Action<Edi, Ae>)errorHandler, Finally).ConfigureAwait(false);
        That(handlerCount, Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync((Action<Edi, Ae>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInTask_With_ErrorHandler_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        Func<int, Task> result = i =>
        {
            _ = Interlocked.Add(ref lambdaCount, i);
            return Task.CompletedTask;
        };
        Func<int, Task> error = _ => throw ex;
        int finallyCount = 0;
        int handlerCount = 0;
        void Finally()
        {
            ++finallyCount;
        }

        void errorHandler(Edi edi, Ae e, int _)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            _ = Interlocked.Increment(ref handlerCount);
        }
        void errorNoHandler(Edi edi, Ae _, int __)
        {
            edi.Throw();
        }

        await result.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler).ConfigureAwait(false);
        That(lambdaCount, Is.EqualTo(1));
        await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler).ConfigureAwait(false);
        That(handlerCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorNoHandler).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        await result.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(2));
        That(handlerCount, Is.EqualTo(1));
        await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false);
        That(handlerCount, Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInValueTask_With_ErrorHandler_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        Func<int, ValueTask> result = i =>
        {
            _ = Interlocked.Add(ref lambdaCount, i);
            return ValueTask.CompletedTask;
        };
        Func<int, ValueTask> error = _ => throw ex;
        int finallyCount = 0;
        int handlerCount = 0;
        void Finally()
        {
            ++finallyCount;
        }

        void errorHandler(Edi edi, Ae e, int _)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            _ = Interlocked.Increment(ref handlerCount);
        }
        void errorNoHandler(Edi edi, Ae _, int __)
        {
            edi.Throw();
        }

        await result.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler).ConfigureAwait(false);
        That(lambdaCount, Is.EqualTo(1));
        await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler).ConfigureAwait(false);
        That(handlerCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorNoHandler).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        await result.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(2));
        That(handlerCount, Is.EqualTo(1));
        await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false);
        That(handlerCount, Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInTask_With_ErrorHandler_N_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        Func<int, Task> result = i =>
        {
            _ = Interlocked.Add(ref lambdaCount, i);
            return Task.CompletedTask;
        };
        Func<int, Task> error = _ => throw ex;
        int finallyCount = 0;
        int handlerCount = 0;
        void Finally(int i)
        {
            That(i, Is.EqualTo(1));
            ++finallyCount;
        }

        void errorHandler(Edi edi, Ae e, int _)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            _ = Interlocked.Increment(ref handlerCount);
        }
        void errorNoHandler(Edi edi, Ae _, int __)
        {
            edi.Throw();
        }

        await result.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(0));
        await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false);
        That(handlerCount, Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(2));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInValueTask_With_ErrorHandler_N_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        Func<int, ValueTask> result = i =>
        {
            _ = Interlocked.Add(ref lambdaCount, i);
            return ValueTask.CompletedTask;
        };
        Func<int, ValueTask> error = _ => throw ex;
        int finallyCount = 0;
        int handlerCount = 0;
        void Finally(int i)
        {
            That(i, Is.EqualTo(1));
            ++finallyCount;
        }

        void errorHandler(Edi edi, Ae e, int _)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            _ = Interlocked.Increment(ref handlerCount);
        }
        void errorNoHandler(Edi edi, Ae _, int __)
        {
            edi.Throw();
        }

        await result.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(0));
        await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false);
        That(handlerCount, Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(2));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Action<Edi, Ae, int>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTaskTOut_With_ErrorHandler_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        int finallyCount = 0;
        int handlerCount = 0;
        Func<Task<int>> result = () => Task.FromResult(Interlocked.Increment(ref lambdaCount));
        Func<Task<int>> error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }

        int errorHandler(Edi edi, Ae e)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            return Interlocked.Increment(ref handlerCount);
        }
        int errorNoHandler(Edi edi, Ae _)
        {
            edi.Throw();
            return 0;
        }
        That(await result.ExecuteAsync((Func<Edi, Ae, int>)errorHandler).ConfigureAwait(false), Is.EqualTo(1));
        That(await error.ExecuteAsync((Func<Edi, Ae, int>)errorHandler).ConfigureAwait(false), Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync((Func<Edi, Ae, int>)errorNoHandler).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        That(await result.ExecuteAsync((Func<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(1));
        That(await error.ExecuteAsync((Func<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync((Func<Edi, Ae, int>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncValueTaskTOut_With_ErrorHandler_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        int finallyCount = 0;
        int handlerCount = 0;
        Func<ValueTask<int>> result = () => ValueTask.FromResult(Interlocked.Increment(ref lambdaCount));
        Func<ValueTask<int>> error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }

        int errorHandler(Edi edi, Ae e)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            return Interlocked.Increment(ref handlerCount);
        }
        int errorNoHandler(Edi edi, Ae _)
        {
            edi.Throw();
            return 0;
        }
        That(await result.ExecuteAsync((Func<Edi, Ae, int>)errorHandler).ConfigureAwait(false), Is.EqualTo(1));
        That(await error.ExecuteAsync((Func<Edi, Ae, int>)errorHandler).ConfigureAwait(false), Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync((Func<Edi, Ae, int>)errorNoHandler).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        That(await result.ExecuteAsync((Func<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(1));
        That(handlerCount, Is.EqualTo(1));
        That(await error.ExecuteAsync((Func<Edi, Ae, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync((Func<Edi, Ae, int>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInTaskTOut_With_ErrorHandler_Works_As_Expected()
    {
        Ae ex = new("Error");
        Func<int, Task<int>> result = static i => Task.FromResult(++i);
        Func<int, Task<int>> error = _ => throw ex;
        int finallyCount = 0;
        void Finally()
        {
            ++finallyCount;
        }

        int errorHandler(Edi edi, Ae e, int i)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            return i + 2;
        }
        int errorNoHandler(Edi edi, Ae _, int i)
        {
            edi.Throw();
            return i;
        }

        That(await result.ExecuteAsync(0, (Func<Edi, Ae, int, int>)errorHandler).ConfigureAwait(false), Is.EqualTo(1));
        That(await error.ExecuteAsync(0, (Func<Edi, Ae, int, int>)errorHandler).ConfigureAwait(false), Is.EqualTo(2));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Func<Edi, Ae, int, int>)errorNoHandler).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        That(await result.ExecuteAsync(0, (Func<Edi, Ae, int, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        That(await error.ExecuteAsync(0, (Func<Edi, Ae, int, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Func<Edi, Ae, int, int>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInValueTaskTOut_With_ErrorHandler_Works_As_Expected()
    {
        Ae ex = new("Error");
        Func<int, ValueTask<int>> result = static i => ValueTask.FromResult(++i);
        Func<int, ValueTask<int>> error = _ => throw ex;
        int finallyCount = 0;
        void Finally()
        {
            ++finallyCount;
        }

        int errorHandler(Edi edi, Ae e, int i)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            return i + 2;
        }
        int errorNoHandler(Edi edi, Ae _, int i)
        {
            edi.Throw();
            return i;
        }

        That(await result.ExecuteAsync(0, (Func<Edi, Ae, int, int>)errorHandler).ConfigureAwait(false), Is.EqualTo(1));
        That(await error.ExecuteAsync(0, (Func<Edi, Ae, int, int>)errorHandler).ConfigureAwait(false), Is.EqualTo(2));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Func<Edi, Ae, int, int>)errorNoHandler).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));

        That(await result.ExecuteAsync(0, (Func<Edi, Ae, int, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        That(await error.ExecuteAsync(0, (Func<Edi, Ae, int, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(2));
        err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Func<Edi, Ae, int, int>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInTaskTOut_With_ErrorHandler_N_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        Func<int, Task<int>> result = static i => Task.FromResult(++i);
        Func<int, Task<int>> error = _ => throw ex;
        int finallyCount = 0;
        void Finally(int i)
        {
            That(i, Is.EqualTo(1));
            ++finallyCount;
        }

        int errorHandler(Edi edi, Ae e, int i)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            return i + 2;
        }
        int errorNoHandler(Edi edi, Ae _, int i)
        {
            edi.Throw();
            return i;
        }

        That(await result.ExecuteAsync(1, (Func<Edi, Ae, int, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(1));
        That(await error.ExecuteAsync(1, (Func<Edi, Ae, int, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(3));
        That(finallyCount, Is.EqualTo(2));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Func<Edi, Ae, int, int>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInValueTaskTOut_With_ErrorHandler_N_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        Func<int, ValueTask<int>> result = static i => ValueTask.FromResult(++i);
        Func<int, ValueTask<int>> error = _ => throw ex;
        int finallyCount = 0;
        void Finally(int i)
        {
            That(i, Is.EqualTo(1));
            ++finallyCount;
        }

        int errorHandler(Edi edi, Ae e, int i)
        {
            That(e, Is.Not.Null);
            That(ReferenceEquals(e, ex), Is.EqualTo(true));
            That(ReferenceEquals(edi.SourceException, e), Is.EqualTo(true));
            return i + 2;
        }
        int errorNoHandler(Edi edi, Ae _, int i)
        {
            edi.Throw();
            return i;
        }

        That(await result.ExecuteAsync(1, (Func<Edi, Ae, int, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(1));
        That(await error.ExecuteAsync(1, (Func<Edi, Ae, int, int>)errorHandler, Finally).ConfigureAwait(false), Is.EqualTo(3));
        That(finallyCount, Is.EqualTo(2));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, (Func<Edi, Ae, int, int>)errorNoHandler, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(3));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTask_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        int finallyCount = 0;
        Func<Task> result = () =>
        {
            _ = Interlocked.Increment(ref lambdaCount);
            return Task.CompletedTask;
        };
        Func<Task> error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }

        await result.ExecuteAsync(Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncValueTask_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        Func<ValueTask> result = () =>
        {
            _ = Interlocked.Increment(ref lambdaCount);
            return ValueTask.CompletedTask;
        };
        Func<ValueTask> error = () => throw ex;

        int finallyCount = 0;
        void Finally()
        {
            ++finallyCount;
        }
        await result.ExecuteAsync(Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInTask_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        Func<int, Task> result = i =>
        {
            _ = Interlocked.Add(ref lambdaCount, i);
            return Task.CompletedTask;
        };
        Func<int, Task> error = _ => throw ex;
        int finallyCount = 0;
        void Finally()
        {
            ++finallyCount;
        }

        await result.ExecuteAsync(1, Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInValueTask_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        Func<int, ValueTask> result = i =>
        {
            _ = Interlocked.Add(ref lambdaCount, i);
            return ValueTask.CompletedTask;
        };
        Func<int, ValueTask> error = _ => throw ex;
        int finallyCount = 0;
        void Finally()
        {
            ++finallyCount;
        }

        await result.ExecuteAsync(1, Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInTask_With_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        Func<int, Task> result = i =>
        {
            _ = Interlocked.Add(ref lambdaCount, i);
            return Task.CompletedTask;
        };
        Func<int, Task> error = _ => throw ex;
        int finallyCount = 0;
        void Finally(int i)
        {
            That(i, Is.EqualTo(1));
            ++finallyCount;
        }

        await result.ExecuteAsync(1, Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInValueTask_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        Func<int, ValueTask> result = i =>
        {
            _ = Interlocked.Add(ref lambdaCount, i);
            return ValueTask.CompletedTask;
        };
        Func<int, ValueTask> error = _ => throw ex;
        int finallyCount = 0;
        void Finally(int i)
        {
            That(i, Is.EqualTo(1));
            ++finallyCount;
        }

        await result.ExecuteAsync(1, Finally).ConfigureAwait(false);
        That(finallyCount, Is.EqualTo(1));
        That(lambdaCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTaskTOut_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        int finallyCount = 0;
        Func<Task<int>> result = () => Task.FromResult(Interlocked.Increment(ref lambdaCount));
        Func<Task<int>> error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }

        That(await result.ExecuteAsync(Finally).ConfigureAwait(false), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncValueTaskTOut_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        int lambdaCount = 0;
        int finallyCount = 0;
        Func<ValueTask<int>> result = () => ValueTask.FromResult(Interlocked.Increment(ref lambdaCount));
        Func<ValueTask<int>> error = () => throw ex;
        void Finally()
        {
            ++finallyCount;
        }

        That(await result.ExecuteAsync(Finally).ConfigureAwait(false), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInTaskTOut_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        Func<int, Task<int>> result = static i => Task.FromResult(++i);
        Func<int, Task<int>> error = _ => throw ex;
        int finallyCount = 0;
        void Finally()
        {
            ++finallyCount;
        }

        That(await result.ExecuteAsync(0, Finally).ConfigureAwait(false), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInValueTaskTOut_With_Finally_Works_As_Expected()
    {
        Ae ex = new("Error");
        Func<int, ValueTask<int>> result = static i => ValueTask.FromResult(++i);
        Func<int, ValueTask<int>> error = _ => throw ex;
        int finallyCount = 0;
        void Finally()
        {
            ++finallyCount;
        }

        That(await result.ExecuteAsync(0, Finally).ConfigureAwait(false), Is.EqualTo(1));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInTaskTOut_With_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        Func<int, Task<int>> result = static i => Task.FromResult(++i);
        Func<int, Task<int>> error = _ => throw ex;
        int finallyCount = 0;
        void Finally(int i)
        {
            That(i, Is.EqualTo(1));
            ++finallyCount;
        }

        That(await result.ExecuteAsync(1, Finally).ConfigureAwait(false), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }

    [Test]
    public async Task ExecuteAsync_On_FuncTInValueTaskTOut_With_FinallyT_Works_As_Expected()
    {
        Ae ex = new("Error");
        Func<int, ValueTask<int>> result = static i => ValueTask.FromResult(++i);
        Func<int, ValueTask<int>> error = _ => throw ex;
        int finallyCount = 0;
        void Finally(int i)
        {
            That(i, Is.EqualTo(1));
            ++finallyCount;
        }

        That(await result.ExecuteAsync(1, Finally).ConfigureAwait(false), Is.EqualTo(2));
        That(finallyCount, Is.EqualTo(1));
        Ae? err = ThrowsAsync<Ae>(async () => await error.ExecuteAsync(1, Finally).ConfigureAwait(false));
        That(err, Is.Not.Null);
        That(ReferenceEquals(err, ex), Is.EqualTo(true));
        That(finallyCount, Is.EqualTo(2));
    }
}
