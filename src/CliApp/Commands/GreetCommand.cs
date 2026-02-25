using System.CommandLine;
using CliApp.Core;

namespace CliApp.Commands;

public class GreetCommand : Command
{
    public GreetCommand() : base("greet", "Greet a person by name")
    {
        var nameOption = new Option<string>(
            name: "--name",
            description: "The name of the person to greet")
        {
            IsRequired = true
        };

        AddOption(nameOption);

        this.SetHandler(name =>
        {
            IGreetingService service = new GreetingService();
            Console.WriteLine(service.Greet(name));
        }, nameOption);
    }
}
