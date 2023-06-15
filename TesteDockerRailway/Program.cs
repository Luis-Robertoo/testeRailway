
using System.Collections;
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

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();
    
