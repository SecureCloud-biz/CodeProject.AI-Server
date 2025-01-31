
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using CodeProject.AI.AnalysisLayer.SentimentAnalysis;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<TextClassifier>();
        services.AddHostedService<SentimentAnalysisWorker>();
    })
    .Build();

await host.RunAsync();
