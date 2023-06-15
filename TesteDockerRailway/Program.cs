
using System.Collections;

Console.WriteLine("Hello, World!");
Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");
Console.WriteLine("variavel PORTA: " + Environment.GetEnvironmentVariable("PORTA"));
Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");
Console.WriteLine("variavel PARAR: " + Environment.GetEnvironmentVariable("PARAR"));
Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");
Console.WriteLine("variavel PORT: " + Environment.GetEnvironmentVariable("PORT"));


var variaveis = Environment.GetEnvironmentVariables();


foreach (DictionaryEntry variavel in variaveis)
{
    Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");
    Console.WriteLine($"Nome: {variavel.Key} -=- Valor: {variavel.Value}");
}



var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();
    
