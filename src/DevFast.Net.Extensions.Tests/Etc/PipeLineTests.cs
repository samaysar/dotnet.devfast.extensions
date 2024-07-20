namespace DevFast.Net.Extensions.Tests.Etc;

[TestFixture]
public class PipeLineTests
{
    #region Conditional Pipes (T, TState)

    [Test]
    public void Pipe_TInTOut_Uses_Tandem()
    {
        int calledWith = 0;
        double Adapter(int i)
        {
            calledWith = i;
            return 0;
        }

        That(2.Pipe(Adapter), Is.EqualTo(0));
        That(calledWith, Is.EqualTo(2));
    }

    [Test]
    public void Pipe_TInTOut_FuncTIn_Uses_Tandem()
    {
        int calledWith = 0;
        Func<int> src = () => 2;
        double Adapter(int i)
        {
            calledWith = i;
            return 0;
        }

        That(src.Pipe(Adapter).Execute(), Is.EqualTo(0));
        That(calledWith, Is.EqualTo(2));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void Pipe_T_Uses_Tandem(bool useAdapter)
    {
        int calledWith = 0;
        int Adapter(int i)
        {
            calledWith = i;
            return 0;
        }

        That(2.Pipe(Adapter, useAdapter), Is.EqualTo(!useAdapter ? 2 : 0));
        That(calledWith, Is.EqualTo(useAdapter ? 2 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void Pipe_T_FuncT_Uses_Tandem(bool useAdapter)
    {
        int calledWith = 0;
        Func<int> src = () => 2;
        int Adapter(int i)
        {
            calledWith = i;
            return 0;
        }

        That(src.Pipe(Adapter, useAdapter).Execute(), Is.EqualTo(!useAdapter ? 2 : 0));
        That(calledWith, Is.EqualTo(useAdapter ? 2 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void Pipe_T_TState_FuncTStateT_Combines_Tandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, int> src = token =>
        {
            That(token, Is.EqualTo(t));
            return 1;
        };
        int Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return ++i;
        }

        That(src.Pipe(Tandem, useAdapter).Execute(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void Pipe_T_TState_T_Combines_Tandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        int Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return ++i;
        }

        That(1.Pipe((Func<int, Token, int>)Tandem, useAdapter).Execute(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void Pipe_T_TState_FuncT_Combines_Tandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<int> src = static () => 1;
        int Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return ++i;
        }

        That(src.Pipe((Func<int, Token, int>)Tandem, useAdapter).Execute(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TState_FuncTStateTaskT_Combines_Tandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, Task<int>> src = token =>
        {
            That(token, Is.EqualTo(t));
            return Task.FromResult(1);
        };
        Task<int> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(++i);
        }

        That(await src.Pipe(Tandem, useAdapter).ExecuteAsync(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TState_TaskT_Combines_Tandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Task<int> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(++i);
        }

        That(await Task.FromResult(1).Pipe((Func<int, Token, Task<int>>)Tandem, useAdapter).ExecuteAsync(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TState_FuncTaskT_Combines_Tandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Task<int>> src = static () => Task.FromResult(1);
        Task<int> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(++i);
        }

        That(await src.Pipe((Func<int, Token, Task<int>>)Tandem, useAdapter).ExecuteAsync(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TState_FuncTStateValueTaskT_Combines_Tandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, ValueTask<int>> src = token =>
        {
            That(token, Is.EqualTo(t));
            return ValueTask.FromResult(1);
        };
        ValueTask<int> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return ValueTask.FromResult(++i);
        }

        That(await src.Pipe(Tandem, useAdapter).ExecuteAsync(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TState_FuncValueTaskT_Combines_Tandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<ValueTask<int>> src = static () => ValueTask.FromResult(1);
        ValueTask<int> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return ValueTask.FromResult(++i);
        }

        That(await src.Pipe((Func<int, Token, ValueTask<int>>)Tandem, useAdapter).ExecuteAsync(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TState_FuncValueTaskT_Combines_TaskT_Tandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<ValueTask<int>> src = static () => ValueTask.FromResult(1);
        Task<int> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(++i);
        }

        That(await src.Pipe((Func<int, Token, Task<int>>)Tandem, useAdapter).ExecuteAsync(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TState_FuncTStateValueTaskT_Combines_TaskT_Tandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, ValueTask<int>> src = token =>
        {
            That(token, Is.EqualTo(t));
            return ValueTask.FromResult(1);
        };
        Task<int> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(++i);
        }

        That(await src.Pipe(Tandem, useAdapter).ExecuteAsync(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#endif

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TState_FuncTStateT_Combines_AsyncTandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, int> src = token =>
        {
            That(token, Is.EqualTo(t));
            return 1;
        };
        Task<int> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(++i);
        }

        That(await src.Pipe(Tandem, useAdapter).ExecuteAsync(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async ValueTask Pipe_T_TState_FuncTStateT_Combines_AsyncValueTandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, int> src = token =>
        {
            That(token, Is.EqualTo(t));
            return 1;
        };
        ValueTask<int> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return ValueTask.FromResult(++i);
        }

        That(await src.Pipe(Tandem, useAdapter).ExecuteAsync(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#endif

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TState_FuncTStateTaskT_Combines_NoAsyncTandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, Task<int>> src = token =>
        {
            That(token, Is.EqualTo(t));
            return Task.FromResult(1);
        };
        int Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return ++i;
        }

        That(await src.Pipe(Tandem, useAdapter).ExecuteAsync(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TState_FuncTStateValueTaskT_Combines_NoAsyncTandem(bool useAdapter)
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, ValueTask<int>> src = token =>
        {
            That(token, Is.EqualTo(t));
            return ValueTask.FromResult(1);
        };
        int Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return ++i;
        }

        That(await src.Pipe(Tandem, useAdapter).ExecuteAsync(t), Is.EqualTo(useAdapter ? 2 : 1));
        That(calledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#endif

    #endregion Conditional Pipes (T, TState)

    #region Conditional Pipes (T, TTanState <> TSrcState)

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void Pipe_T_TScrStateTTanState_FuncTStateT_Combines_Tandem(bool useAdapter)
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static int Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ++i;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        That(src.Pipe((Func<int, StateObj, int>)Tandem, static x => x.Token, useAdapter).Execute(state), Is.EqualTo(useAdapter ? 2 : 1));
        That(state.CalledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TScrStateTTanState_FuncTStateT_Combines_AsyncTandem(bool useAdapter)
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static Task<int> Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return Task.FromResult(++i);
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        That(await src.Pipe((Func<int, StateObj, Task<int>>)Tandem, static x => x.Token, useAdapter).ExecuteAsync(state), Is.EqualTo(useAdapter ? 2 : 1));
        That(state.CalledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async ValueTask Pipe_T_TScrStateTTanState_FuncTStateT_Combines_AsyncValueTandem(bool useAdapter)
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static ValueTask<int> Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ValueTask.FromResult(++i);
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        That(await src.Pipe((Func<int, StateObj, ValueTask<int>>)Tandem, static x => x.Token, useAdapter).ExecuteAsync(state), Is.EqualTo(useAdapter ? 2 : 1));
        That(state.CalledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#endif

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TScrStateTTanState_FuncTStateTaskT_Combines_Tandem(bool useAdapter)
    {
        Func<Token, Task<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return Task.FromResult(1);
        };

        static Task<int> Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return Task.FromResult(++i);
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        That(await src.Pipe((Func<int, StateObj, Task<int>>)Tandem, static x => x.Token, useAdapter).ExecuteAsync(state), Is.EqualTo(useAdapter ? 2 : 1));
        That(state.CalledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async ValueTask Pipe_T_TScrStateTTanState_FuncTStateValueTaskT_Combines_Tandem(bool useAdapter)
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static ValueTask<int> Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ValueTask.FromResult(++i);
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        That(await src.Pipe((Func<int, StateObj, ValueTask<int>>)Tandem, static x => x.Token, useAdapter).ExecuteAsync(state), Is.EqualTo(useAdapter ? 2 : 1));
        That(state.CalledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TScrStateTTanState_FuncTStateValueTaskT_Combines_CrossTandem(bool useAdapter)
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static Task<int> Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return Task.FromResult(++i);
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        That(await src.Pipe((Func<int, StateObj, Task<int>>)Tandem, static x => x.Token, useAdapter).ExecuteAsync(state), Is.EqualTo(useAdapter ? 2 : 1));
        That(state.CalledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#endif

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task Pipe_T_TScrStateTTanState_FuncTStateTaskT_Combines_NoAsyncTandem(bool useAdapter)
    {
        Func<Token, Task<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return Task.FromResult(1);
        };

        static int Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ++i;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        That(await src.Pipe((Func<int, StateObj, int>)Tandem, static x => x.Token, useAdapter).ExecuteAsync(state), Is.EqualTo(useAdapter ? 2 : 1));
        That(state.CalledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async ValueTask Pipe_T_TScrStateTTanState_FuncTStateValueTaskT_Combines_NoAsyncTandem(bool useAdapter)
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static int Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ++i;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        That(await src.Pipe((Func<int, StateObj, int>)Tandem, static x => x.Token, useAdapter).ExecuteAsync(state), Is.EqualTo(useAdapter ? 2 : 1));
        That(state.CalledWith, Is.EqualTo(useAdapter ? 1 : 0));
    }

#endif

    #endregion Conditional Pipes (T, TTanState <> TSrcState)

    #region Conditional Pipes To Void Lambda (T, TState)

    [Test]
    public void Pipe_T_TState_FuncTStateT_Combines_VoidLambda()
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static void Tandem(int i, Token token)
        {
            That(token, Is.EqualTo(Token.None));
            That(i, Is.EqualTo(1));
        }

        src.Pipe(Tandem).Execute(Token.None);
    }

    [Test]
    public async Task Pipe_T_TState_FuncTStateT_Combines_TaskLambda()
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static Task Tandem(int i, Token token)
        {
            That(token, Is.EqualTo(Token.None));
            That(i, Is.EqualTo(1));
            return Task.CompletedTask;
        }

        await src.Pipe(Tandem).ExecuteAsync(Token.None);
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    public async ValueTask Pipe_T_TState_FuncTStateT_Combines_ValueTaskLambda()
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static ValueTask Tandem(int i, Token token)
        {
            That(token, Is.EqualTo(Token.None));
            That(i, Is.EqualTo(1));
            return ValueTask.CompletedTask;
        }

        await src.Pipe(Tandem).ExecuteAsync(Token.None);
    }

#endif

    [Test]
    public async Task Pipe_T_TState_FuncTStateTaskT_Combines_VoidLambda()
    {
        Func<Token, Task<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return Task.FromResult(1);
        };

        static void Tandem(int i, Token token)
        {
            That(token, Is.EqualTo(Token.None));
            That(i, Is.EqualTo(1));
        }

        await src.Pipe(Tandem).ExecuteAsync(Token.None);
    }

    [Test]
    public async Task Pipe_T_TState_FuncTStateTaskT_Combines_TaskLambda()
    {
        Func<Token, Task<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return Task.FromResult(1);
        };

        static Task Tandem(int i, Token token)
        {
            That(token, Is.EqualTo(Token.None));
            That(i, Is.EqualTo(1));
            return Task.CompletedTask;
        }

        await src.Pipe(Tandem).ExecuteAsync(Token.None);
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    public async Task Pipe_T_TState_FuncTStateValueTaskT_Combines_VoidLambda()
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static void Tandem(int i, Token token)
        {
            That(token, Is.EqualTo(Token.None));
            That(i, Is.EqualTo(1));
        }

        await src.Pipe(Tandem).ExecuteAsync(Token.None);
    }

    [Test]
    public async ValueTask Pipe_T_TState_FuncTStateValueTaskT_Combines_ValueTaskLambda()
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static ValueTask Tandem(int i, Token token)
        {
            That(token, Is.EqualTo(Token.None));
            That(i, Is.EqualTo(1));
            return ValueTask.CompletedTask;
        }

        await src.Pipe(Tandem).ExecuteAsync(Token.None);
    }

    [Test]
    public async Task Pipe_T_TState_FuncTStateValueTaskT_Combines_TaskLambda()
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static Task Tandem(int i, Token token)
        {
            That(token, Is.EqualTo(Token.None));
            That(i, Is.EqualTo(1));
            return Task.CompletedTask;
        }

        await src.Pipe(Tandem).ExecuteAsync(Token.None);
    }

#endif

    #endregion Conditional Pipes To Void Lambda (T, TState)

    #region Conditional Pipes To Void Lambda (T, TTanState <> TSrcState)

    [Test]
    public void Pipe_T_TSrcState_TTanState_FuncTStateT_Combines_VoidLambda()
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static void Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        src.Pipe((Action<int, StateObj>)Tandem, static x => x.Token).Execute(state);
        That(state.CalledWith, Is.EqualTo(1));
    }

    [Test]
    public async Task Pipe_T_TSrcState_TTanState_FuncTStateT_Combines_TaskLambda()
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static Task Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return Task.CompletedTask;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        await src.Pipe((Func<int, StateObj, Task>)Tandem, static x => x.Token).ExecuteAsync(state);
        That(state.CalledWith, Is.EqualTo(1));
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    public async ValueTask Pipe_T_TSrcState_TTanState_FuncTStateT_Combines_ValueTaskLambda()
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static ValueTask Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ValueTask.CompletedTask;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        await src.Pipe((Func<int, StateObj, ValueTask>)Tandem, static x => x.Token).ExecuteAsync(state);
        That(state.CalledWith, Is.EqualTo(1));
    }

#endif

    [Test]
    public async Task Pipe_T_TSrcState_TTanState_FuncTStateTaskT_Combines_VoidLambda()
    {
        Func<Token, Task<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return Task.FromResult(1);
        };

        static void Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        await src.Pipe((Action<int, StateObj>)Tandem, static x => x.Token).ExecuteAsync(state);
        That(state.CalledWith, Is.EqualTo(1));
    }

    [Test]
    public async Task Pipe_T_TSrcState_TTanState_FuncTStateTaskT_Combines_TaskLambda()
    {
        Func<Token, Task<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return Task.FromResult(1);
        };

        static Task Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return Task.CompletedTask;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        await src.Pipe((Func<int, StateObj, Task>)Tandem, static x => x.Token).ExecuteAsync(state);
        That(state.CalledWith, Is.EqualTo(1));
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    public async Task Pipe_T_TSrcState_TTanState_FuncTStateValueTaskT_Combines_VoidLambda()
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static void Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        await src.Pipe((Action<int, StateObj>)Tandem, static x => x.Token).ExecuteAsync(state);
        That(state.CalledWith, Is.EqualTo(1));
    }

    [Test]
    public async ValueTask Pipe_T_TSrcState_TTanState_FuncTStateValueTaskT_Combines_ValueTaskLambda()
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static ValueTask Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ValueTask.CompletedTask;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        await src.Pipe((Func<int, StateObj, ValueTask>)Tandem, static x => x.Token).ExecuteAsync(state);
        That(state.CalledWith, Is.EqualTo(1));
    }

    [Test]
    public async Task Pipe_T_TSrcState_TTanState_FuncTStateValueTaskT_Combines_TaskLambda()
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static Task Tandem(int i, StateObj state)
        {
            That(state.Token, Is.EqualTo(Token.None));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return Task.CompletedTask;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        await src.Pipe((Func<int, StateObj, Task>)Tandem, static x => x.Token).ExecuteAsync(state);
        That(state.CalledWith, Is.EqualTo(1));
    }

#endif

    #endregion Conditional Pipes To Void Lambda (T, TTanState <> TSrcState)

    #region Pipes (TIn, TState, TOut)

    [Test]
    public void Pipe_TInStateTOut_On_TIn_Combines_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        decimal Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return i * 2.0m;
        }

        That(1.Pipe((Func<int, Token, decimal>)Tandem).Execute(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

    [Test]
    public void Pipe_TInStateTOut_On_FuncTIn_Combines_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<int> source = () => 1;
        decimal Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return i * 2.0m;
        }

        That(source.Pipe((Func<int, Token, decimal>)Tandem).Execute(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

    [Test]
    public void Pipe_TInStateTOut_On_FuncTStateTIn_Combines_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, int> source = state =>
        {
            That(state, Is.EqualTo(t));
            return 1;
        };
        decimal Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return i * 2.0m;
        }

        That(source.Pipe(Tandem).Execute(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

    [Test]
    public async Task Pipe_TInStateTOut_On_TaskTIn_Combines_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Task<decimal> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(i * 2.0m);
        }

        That(await Task.FromResult(1).Pipe((Func<int, Token, Task<decimal>>)Tandem).ExecuteAsync(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

    [Test]
    public async Task Pipe_TInStateTOut_On_FuncTaskTIn_Combines_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Task<int>> source = () => Task.FromResult(1);
        Task<decimal> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(i * 2.0m);
        }

        That(await source.Pipe((Func<int, Token, Task<decimal>>)Tandem).ExecuteAsync(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

    [Test]
    public async Task Pipe_TInStateTOut_On_FuncTStateTaskTIn_Combines_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, Task<int>> source = state =>
        {
            That(state, Is.EqualTo(t));
            return Task.FromResult(1);
        };
        Task<decimal> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(i * 2.0m);
        }

        That(await source.Pipe(Tandem).ExecuteAsync(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

    [Test]
    public async Task Pipe_TInStateTOut_On_FuncTStateTIn_Combines_Async_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, int> source = state =>
        {
            That(state, Is.EqualTo(t));
            return 1;
        };
        Task<decimal> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(i * 2.0m);
        }

        That(await source.Pipe(Tandem).ExecuteAsync(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

    [Test]
    public async Task Pipe_TInStateTOut_On_FuncTStateTaskTIn_Combines_Sync_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, Task<int>> source = state =>
        {
            That(state, Is.EqualTo(t));
            return Task.FromResult(1);
        };
        decimal Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return i * 2.0m;
        }

        That(await source.Pipe(Tandem).ExecuteAsync(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    public async ValueTask Pipe_TInStateTOut_On_ValueTaskTIn_Combines_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<ValueTask<int>> source = () => ValueTask.FromResult(1);
        ValueTask<decimal> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return ValueTask.FromResult(i * 2.0m);
        }

        That(await source.Pipe((Func<int, Token, ValueTask<decimal>>)Tandem).ExecuteAsync(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

    [Test]
    public async ValueTask Pipe_TInStateTOut_On_FuncTStateValueTaskTIn_Combines_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, ValueTask<int>> source = state =>
        {
            That(state, Is.EqualTo(t));
            return ValueTask.FromResult(1);
        };
        ValueTask<decimal> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return ValueTask.FromResult(i * 2.0m);
        }

        That(await source.Pipe(Tandem).ExecuteAsync(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

    [Test]
    public async Task Pipe_TInStateTOut_On_ValueTaskTIn_Combines_Task_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<ValueTask<int>> source = () => ValueTask.FromResult(1);
        Task<decimal> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(i * 2.0m);
        }

        That(await source.Pipe((Func<int, Token, Task<decimal>>)Tandem).ExecuteAsync(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

    [Test]
    public async Task Pipe_TInStateTOut_On_FuncTStateValueTaskTIn_Combines_Task_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, ValueTask<int>> source = state =>
        {
            That(state, Is.EqualTo(t));
            return ValueTask.FromResult(1);
        };
        Task<decimal> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return Task.FromResult(i * 2.0m);
        }

        That(await source.Pipe(Tandem).ExecuteAsync(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

#if NET5_0_OR_GREATER

    [Test]
    public async ValueTask Pipe_TInStateTOut_On_FuncTStateTIn_Combines_ValueTask_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, int> source = state =>
        {
            That(state, Is.EqualTo(t));
            return 1;
        };
        ValueTask<decimal> Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return ValueTask.FromResult(i * 2.0m);
        }

        That(await source.Pipe(Tandem).ExecuteAsync(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

#endif

    [Test]
    public async ValueTask Pipe_TInStateTOut_On_FuncTStateValueTaskTIn_Combines_Sync_Tandem()
    {
        Token t = new Cts().Token;
        int calledWith = 0;
        Func<Token, ValueTask<int>> source = state =>
        {
            That(state, Is.EqualTo(t));
            return ValueTask.FromResult(1);
        };
        decimal Tandem(int i, Token state)
        {
            That(state, Is.EqualTo(t));
            That(i, Is.EqualTo(1));
            calledWith = i;
            return i * 2.0m;
        }

        That(await source.Pipe(Tandem).ExecuteAsync(t), Is.EqualTo(2.0m));
        That(calledWith, Is.EqualTo(1));
    }

#endif

    #endregion Pipes (TIn, TState, TOut)

    #region Pipes (TIn, TTanState <> TSrcState, TOut)

    [Test]
    public void Pipe_TInTSrcStateTTanStateTOut_On_FuncTSrcStateTIn_Combines_Tandem()
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static decimal Tandem(int i, StateObj state)
        {
            Multiple(() => That(state.Token, Is.EqualTo(Token.None)));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ++i;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        Multiple(() => That(src.Pipe((Func<int, StateObj, decimal>)Tandem, static x => x.Token).Execute(state), Is.EqualTo(2.0m)));
        That(state.CalledWith, Is.EqualTo(1));
    }

    [Test]
    public void Pipe_TInTSrcStateTTanStateTOut_On_FuncTSrcStateTaskTIn_Combines_Tandem()
    {
        Func<Token, Task<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return Task.FromResult(1);
        };

        static Task<decimal> Tandem(int i, StateObj state)
        {
            Multiple(() => That(state.Token, Is.EqualTo(Token.None)));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return Task.FromResult(++i * 1.0m);
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        Multiple(async () => That(await src.Pipe((Func<int, StateObj, Task<decimal>>)Tandem, static x => x.Token).ExecuteAsync(state), Is.EqualTo(2.0m)));
        That(state.CalledWith, Is.EqualTo(1));
    }

    [Test]
    public void Pipe_TInTSrcStateTTanStateTOut_On_FuncTSrcStateTIn_Combines_Task_Tandem()
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static Task<decimal> Tandem(int i, StateObj state)
        {
            Multiple(() => That(state.Token, Is.EqualTo(Token.None)));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return Task.FromResult(++i * 1.0m);
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        Multiple(async () => That(await src.Pipe((Func<int, StateObj, Task<decimal>>)Tandem, static x => x.Token).ExecuteAsync(state), Is.EqualTo(2.0m)));
        That(state.CalledWith, Is.EqualTo(1));
    }

    [Test]
    public void Pipe_TInTSrcStateTTanStateTOut_On_FuncTSrcStateTaskTIn_Combines_Sync_Tandem()
    {
        Func<Token, Task<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return Task.FromResult(1);
        };

        static decimal Tandem(int i, StateObj state)
        {
            Multiple(() => That(state.Token, Is.EqualTo(Token.None)));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ++i * 1.0m;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        Multiple(async () => That(await src.Pipe((Func<int, StateObj, decimal>)Tandem, static x => x.Token).ExecuteAsync(state), Is.EqualTo(2.0m)));
        That(state.CalledWith, Is.EqualTo(1));
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    [Test]
    public void Pipe_TInTSrcStateTTanStateTOut_On_FuncTSrcStateValueTaskTIn_Combines_Tandem()
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static ValueTask<decimal> Tandem(int i, StateObj state)
        {
            Multiple(() => That(state.Token, Is.EqualTo(Token.None)));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ValueTask.FromResult(++i * 1.0m);
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        Multiple(async () => That(await src.Pipe((Func<int, StateObj, ValueTask<decimal>>)Tandem, static x => x.Token).ExecuteAsync(state), Is.EqualTo(2.0m)));

        That(state.CalledWith, Is.EqualTo(1));
    }

    [Test]
    public void Pipe_TInTSrcStateTTanStateTOut_On_FuncTSrcStateValueTaskTIn_Combines_Task_Tandem()
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static Task<decimal> Tandem(int i, StateObj state)
        {
            Multiple(() => That(state.Token, Is.EqualTo(Token.None)));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return Task.FromResult(++i * 1.0m);
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        Multiple(async () => That(await src.Pipe((Func<int, StateObj, Task<decimal>>)Tandem, static x => x.Token).ExecuteAsync(state), Is.EqualTo(2.0m)));
        That(state.CalledWith, Is.EqualTo(1));
    }

#if NET5_0_OR_GREATER

    [Test]
    public void Pipe_TInTSrcStateTTanStateTOut_On_FuncTSrcStateTIn_Combines_ValueTask_Tandem()
    {
        Func<Token, int> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return 1;
        };

        static ValueTask<decimal> Tandem(int i, StateObj state)
        {
            Multiple(() => That(state.Token, Is.EqualTo(Token.None)));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ValueTask.FromResult(++i * 1.0m);
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        Multiple(async () => That(await src.Pipe((Func<int, StateObj, ValueTask<decimal>>)Tandem, static x => x.Token).ExecuteAsync(state), Is.EqualTo(2.0m)));

        That(state.CalledWith, Is.EqualTo(1));
    }

#endif

    [Test]
    public void Pipe_TInTSrcStateTTanStateTOut_On_FuncTSrcStateValueTaskTIn_Combines_Sync_Tandem()
    {
        Func<Token, ValueTask<int>> src = static token =>
        {
            That(token, Is.EqualTo(Token.None));
            return ValueTask.FromResult(1);
        };

        static decimal Tandem(int i, StateObj state)
        {
            Multiple(() => That(state.Token, Is.EqualTo(Token.None)));
            That(state.CalledWith, Is.EqualTo(0));
            state.CalledWith = i;
            return ++i * 1.0m;
        }

        StateObj state = new() { Token = Token.None, CalledWith = 0 };
        Multiple(async () => That(await src.Pipe((Func<int, StateObj, decimal>)Tandem, static x => x.Token).ExecuteAsync(state), Is.EqualTo(2.0m)));

        That(state.CalledWith, Is.EqualTo(1));
    }

#endif

    #endregion Pipes (TIn, TTanState <> TSrcState, TOut)

    private class StateObj
    {
        public Token Token { get; set; }
        public int CalledWith { get; set; }
    }
}