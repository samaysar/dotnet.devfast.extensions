using DevFast.Net.Extensions.Etc;

namespace DevFast.Net.Extensions.Tests.Etc;

[TestFixture]
internal class AsynchroTests
{
    [Test]
    public void Run_Correctly_Starts_A_Non_Running_Task()
    {
        Task t = new(() => { });
        That(t.Status, Is.EqualTo(TaskStatus.Created));
        That(t.Run().Status, Is.Not.EqualTo(TaskStatus.Created));
    }
}
