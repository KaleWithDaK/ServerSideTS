var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapGet("/", () => "Hello from server!");

app.Run();
