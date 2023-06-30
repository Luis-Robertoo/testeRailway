using System.Collections;

Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");
Console.WriteLine("Hello, World!");
Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");

var variaveis = Environment.GetEnvironmentVariables();


foreach (DictionaryEntry variavel in variaveis)
{
    Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");
    Console.WriteLine($"Nome: {variavel.Key} === Valor: {variavel.Value}");
}

Console.WriteLine("-=-=-=-=-=-=-=--=-==--=-=-==--=-==-=--=-=-=-=-=--=-=-=-=----=-=-=");

var porta = Environment.GetEnvironmentVariable("PORT");
Environment.SetEnvironmentVariable("ASPNETCORE_URLS", $"http://0.0.0.0:{porta}");

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.MapGet("/", async () => await GetConfig());


app.Run();
    

async Task<string> GetConfig()
{
    var config =  new Led
    {
        Vermelho = "255",
        Verde = "200",
        Azul = "220",
        Brilho = "255"
    };

    return $"{config.Vermelho}{config.Verde}{config.Azul}{config.Brilho}";
}


class Led
{
    public string Vermelho { get; set; }
    public string Verde { get; set; }
    public string Azul { get; set; }
    public string Brilho { get; set; } = "128";
}