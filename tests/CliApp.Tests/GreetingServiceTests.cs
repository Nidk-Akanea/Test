using CliApp.Core;

namespace CliApp.Tests;

public class GreetingServiceTests
{
    private readonly IGreetingService _service = new GreetingService();

    [Fact]
    public void Greet_ReturnsExpectedMessage()
    {
        var result = _service.Greet("World");

        Assert.Equal("Hello, World!", result);
    }

    [Fact]
    public void Greet_WithDifferentName_ReturnsCorrectMessage()
    {
        var result = _service.Greet("Alice");

        Assert.Equal("Hello, Alice!", result);
    }
}
