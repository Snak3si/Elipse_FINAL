
// code .\src\WebUI\Program.cs
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.MapRazorPages();
app.Run();

public partial class Program { }