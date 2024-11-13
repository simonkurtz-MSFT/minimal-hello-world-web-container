var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options => options.ListenAnyIP(8080));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();