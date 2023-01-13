using System.Net;
using System.Net.Mail;

namespace DiamondConsole;

public static class Email
{
    public static void Message(string diamond)
    {
        Console.WriteLine("Do you want to receive your diamond by email? [Y/n]");
        var result = Console.ReadLine() ?? "";
        var options = new List<string>() { "y", "yes" };

        if (options.Contains(result.ToLower()))
        {
            Console.WriteLine("What is your best email?");
            var email = Console.ReadLine() ?? "";
            var verifyEmail = CheckEmail(email);

            while (!verifyEmail)
            {
                Console.WriteLine("Invalid email! Try again:");
                email = Console.ReadLine() ?? "";
                verifyEmail = CheckEmail(email);
            }
            var subject = "Your diamond with the letters of alphabet";

            SendMail(email, subject, diamond);
        }
    }

    // https://stackoverflow.com/questions/5342375/regex-email-validation
    public static bool CheckEmail(string email)
    {
        try
        {
            var m = new MailAddress(email);

            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    public static void SendMail(string email, string subject, string message)
    {
        var emailFrom = Consts.email;
        var password = Consts.password;

        var mail = new MailMessage { From = new MailAddress(emailFrom) };
        mail.To.Add(email);
        mail.Subject = subject;
        mail.Body = message;

        using var smtp = new SmtpClient("smtp.office365.com", 587);
        smtp.UseDefaultCredentials = false;
        smtp.EnableSsl = true;
        smtp.Credentials = new NetworkCredential(emailFrom, password);

        try
        {
            smtp.Send(mail);

            Console.WriteLine("Email successfully sent!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error {ex.Message}");
        }
    }
}
