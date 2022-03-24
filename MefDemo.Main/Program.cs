using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using MefDemo.Abstractions;

namespace MefDemo.Main;

public class Program
{
    [ImportMany(AllowRecomposition = true)]
    private IEnumerable<ILogger> _loggers = null!;

    public static void Main(string[] args)
    {
        var program = new Program();
        program.Start();
    }

    private void Start()
    {
        var standardLoggerCatalog = new DirectoryCatalog("../../../../MefDemo.Dependencies.StandardLogger/bin/Debug/net6.0");
        var aggregateCatalog = new AggregateCatalog(standardLoggerCatalog);
        var container = new CompositionContainer(aggregateCatalog, true);
        container.ComposeParts(this);

        Process();

        var debugLoggerCatalog = new DirectoryCatalog("../../../../MefDemo.Dependencies.DebugLogger/bin/Debug/net6.0");
        aggregateCatalog.Catalogs.Add(debugLoggerCatalog);
        Process();
    }

    private void Process()
    {
        foreach (var logger in _loggers)
        {
            logger.Log("Hello world");
        }
    }
}
