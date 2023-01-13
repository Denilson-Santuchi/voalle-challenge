using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DiamondConsole;

// https://www.devmedia.com.br/criando-e-manipulando-arquivos-pdf-com-a-biblioteca-itextsharp-em-csharp/33392
public class PdfGenerator
{
    public static bool Message()
    {
        Console.WriteLine("Do you want to create your diamond to pfd? [Y/n]");
        var result = Console.ReadLine() ?? "";
        var options = new List<string>() { "y", "yes" };

        if (options.Contains(result.ToLower()))
        {
            return true;
        }

        return false;
    }

    public static void Create(char letter, string diamond)
    {
        Message();
        var doc = new Document();
        PdfWriter.GetInstance(
            doc,
            new FileStream($"./PDFs/ExportedDiamond{letter}.pdf", FileMode.Create)
        );

        doc.Open();
        doc.Add(new Paragraph($"Diamond created with the letter {letter}."));
        doc.Add(new Paragraph(diamond));
        doc.Add(new Paragraph("Created by Denilson Santuchi"));
        doc.Close();

        Console.WriteLine("PDF created successfully");
    }
}
