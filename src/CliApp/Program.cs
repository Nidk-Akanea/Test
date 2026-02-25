using System.CommandLine;
using CliApp.Commands;

var rootCommand = new RootCommand("CliApp - a sample C# CLI application");

rootCommand.AddCommand(new GreetCommand());

return await rootCommand.InvokeAsync(args);
