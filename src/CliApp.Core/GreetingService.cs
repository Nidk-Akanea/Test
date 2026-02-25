namespace CliApp.Core;

public class GreetingService : IGreetingService
{
    public string Greet(string name) => $"Hello, {name}!";
}
