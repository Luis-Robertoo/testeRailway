
using System.Collections;
using static System.Net.WebRequestMethods;

Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");
Console.WriteLine("Hello, World!");
Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");

var variaveis = Environment.GetEnvironmentVariables();


foreach (DictionaryEntry variavel in variaveis)
{
    Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");
    Console.WriteLine($"Nome: {variavel.Key} -=- Valor: {variavel.Value}");
}

Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");

var porta = Environment.GetEnvironmentVariable("PORT");

Environment.SetEnvironmentVariable("ASPNETCORE_URLS", $"http://0.0.0.0:{porta}");

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();
    
