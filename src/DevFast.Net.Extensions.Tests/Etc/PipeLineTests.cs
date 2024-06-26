namespace DevFast.Net.Extensions.Tests.Etc
{
    [TestFixture]
    public class PipeLineTests
    {
        [Test]
        public void Pipe_TInTOut_Uses_Adapter()
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
        [TestCase(true)]
        [TestCase(false)]
        public void Pipe_TIn_TOut_Uses_Adapter(bool useAdapter)
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
    }
}
