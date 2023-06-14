


Console.WriteLine("Hello, World!");

var counter = 0;
var variavel = Environment.GetEnvironmentVariable("PORTA");
var parar = Environment.GetEnvironmentVariable("PARAR");

var max = args.Length is not 0 ? Convert.ToInt32(args[0]) : -1;

bool parou = parar is null ? false : parar.Equals("true") ? true : false;

while ((max is -1 || counter < max) && !parou)
{
    Console.WriteLine(variavel);

    Console.WriteLine($"Counter: {++counter}");
    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
}