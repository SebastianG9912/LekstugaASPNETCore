using Microsoft.VisualBasic;

var builder = WebApplication.CreateBuilder(args);
//fas 1 - konfigurering av webbapp
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();
//fas 2 - middleware pipelining

/*app.Use(async (context, nextMiddlewareStep) =>
{
    //HTTP request p�v�g in
    Console.WriteLine($"Request for: {context.Request.Path}");

    await nextMiddlewareStep();

    //HTTP request p�v�g ut
    Console.WriteLine($"Answer status code: {context.Response.StatusCode}");
    return;
});*/

//middleware steg
app.UseRouting();

//mappning
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=snippet}/{action=index}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Birthday}/{Overview}");
//app.MapRazorPages();
//Beh�vs inte f�r MVC eller Razor Pages
/*var endpoint = () => "Hemlig endpoint";
app.MapGet("/", () => "Hello World!");
app.MapGet("/hemlig", () => endpoint);
app.MapGet("/hemlig/mer", endpoint);
app.MapGet("/namn/{name}", (string name) => $"Hej {name}!");
app.MapGet("/welcome", () => "Hej och v�lkommen!");*/

app.Run();
//fas 3 - server startad