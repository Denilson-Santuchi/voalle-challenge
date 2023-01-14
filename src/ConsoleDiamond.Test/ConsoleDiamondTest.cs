using Xunit;
using System.IO;
using System;
using DiamondConsole;
using FluentAssertions;

namespace DiamondConsole.Test;

[Collection("Sequential")]
public class TestConsoleDiamond
{
    [Theory(DisplayName = "test greeting!")]
    [InlineData(
        new object[] { new string[] { "Hello player!", "choose a letter to draw a diamond:" } }
    )]
    public void TestPrintInitialMessage(string[] expected)
    {
        using var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        Program.Greet();
        var response = stringWriter.ToString().Trim().Split("\n");

        for (int i = 0; i < expected.Length; i += 1)
        {
            response[i].Should().Be(expected[i]);
        }
    }

    [Theory(DisplayName = "draw diamond")]
    [InlineData("D", "    A\n  B   B\n C     C\nD       D\n C     C\n  B   B\n    A")]
    public void TestReceiveUserInputAndDraw(string entry, string expected)
    {
        using var stringReader = new StringReader(entry);
        Console.SetIn(stringReader);

        char letter = char.Parse("D");
        var diamond = Diamond.Create(letter);
        diamond.Should().Be(expected);
    }
}
