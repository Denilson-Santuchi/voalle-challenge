using Xunit;
using FluentAssertions;

namespace DiamondConsole.Test;

public class TestEmail
{
    [Theory(DisplayName = "Verify if is a valid email")]
    [InlineData("test@test.com", true)]
    [InlineData("test@test.com.br", true)]
    [InlineData("testtest.com", false)]
    public void TestIsValidEmail(string email, bool expected)
    {
        var result = Email.CheckEmail(email);

        result.Should().Be(expected);
    }
}
