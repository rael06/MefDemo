using System.ComponentModel.Composition;

namespace MefDemo.Dependencies;

[Export(typeof(ILogger))]
public class DebugLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Debug   ]: {message}");
    }
}
