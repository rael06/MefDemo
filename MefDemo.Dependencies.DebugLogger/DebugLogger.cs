using System.ComponentModel.Composition;
using MefDemo.Abstractions;

namespace MefDemo.Dependencies.DebugLogger;

[Export(typeof(ILogger))]
public class DebugLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Debug   ]: {message}");
    }
}
