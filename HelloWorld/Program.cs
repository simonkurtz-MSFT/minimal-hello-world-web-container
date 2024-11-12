var builder = WebApplication.CreateBuilder(args);

// Configure the Kestrel server to listen on both HTTP and HTTPS.
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5080);
    options.ListenAnyIP(5443, listenOptions => listenOptions.UseHttps());
    options.AddServerHeader = false;        // remove the Server header
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();