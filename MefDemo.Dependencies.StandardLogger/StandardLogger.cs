using System.ComponentModel.Composition;
using MefDemo.Abstractions;

namespace MefDemo.Dependencies.StandardLogger;

[Export(typeof(ILogger))]
public class StandardLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Standard]: {message}");
    }
}
