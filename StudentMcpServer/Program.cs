using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentMcpServer;

var builder = Host.CreateApplicationBuilder(args);

builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithTools<StudentTools>();

await builder.Build().RunAsync();