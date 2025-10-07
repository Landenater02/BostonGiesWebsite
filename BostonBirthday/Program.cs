var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // Enables default file mapping (like index.html)
app.UseStaticFiles();  // Enables static file serving

app.Run();
