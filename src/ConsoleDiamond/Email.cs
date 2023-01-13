using System.Net.Mail;

namespace DiamondConsole;

public static class Email
{
    public static void Message()
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

            Console.WriteLine($"{email}: Email successfully sent!");
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
}
