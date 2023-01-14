using Xunit;
using System.IO;
using System;
using FluentAssertions;

namespace DiamondConsole.Test;

public class TestPdf
{
    [Theory(DisplayName = "Verify if show the correct message")]
    [InlineData("y", true)]
    [InlineData("yes", true)]
    [InlineData("n", false)]
    [InlineData("any", false)]
    [InlineData("no", false)]
    public void TestPdfGeneratorMessage(string entry, bool expectedBool)
    {
        using var stringWriter = new StringWriter();
        using var stringReader = new StringReader(entry);

        Console.SetOut(stringWriter);
        Console.SetIn(stringReader);

        var response = PdfGenerator.Message();
        var console = stringWriter.ToString().Trim().Split('\n');

        response.Should().Be(expectedBool);
    }
}
