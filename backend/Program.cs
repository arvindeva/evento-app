using Npgsql;

DotNetEnv.Env.Load();
var connectionString = Environment.GetEnvironmentVariable("DATABASE_URL");

try
{
    using var conn = new NpgsqlConnection(connectionString);
    conn.Open();
    Console.WriteLine("✅ PostgreSQL connection successful.");
    conn.Close();
}
catch (Exception ex)
{
    Console.WriteLine($"❌ PostgreSQL connection failed: {ex.Message}");
}

var builder = WebApplication.CreateBuilder(args);

// Add required services (you'll use these later)
builder.Services.AddControllers();

var app = builder.Build();

// Basic test route
app.MapGet("/api/hello", () => "Hello, Evento! 👋");

// Keep controller support even if unused (future-ready)
app.MapControllers();

app.Run();
