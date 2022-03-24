namespace MefDemo.Dependencies;

public class StandardLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Standard]: {message}");
    }
}
