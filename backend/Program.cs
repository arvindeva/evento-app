var builder = WebApplication.CreateBuilder(args);

// Add required services (you'll use these later)
builder.Services.AddControllers();

var app = builder.Build();

// Basic test route
app.MapGet("/api/hello", () => "Hello, Evento! 👋");

// Keep controller support even if unused (future-ready)
app.MapControllers();

app.Run();
