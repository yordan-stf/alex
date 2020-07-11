using System.Net.Mail;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.IsBodyHtml = true;
            mailMessage.From = new MailAddress("[you@gmail.com]");
            mailMessage.To.Add("[receiver@email.provider]");
            mailMessage.Subject = "-- Subject --";
            mailMessage.Body = System.IO.File.ReadAllText("email.html");
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("[you@gmail.com]", "[парола за gmail account-а ти]");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }
    }
}
