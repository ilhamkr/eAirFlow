using MimeKit;
using MailKit.Net.Smtp;
using DotNetEnv;

namespace eAirFlow.Subscriber.MailSenderService
{
    public class MailSenderService : IMailSenderService
    {
        public async Task SendEmail(Email emailObj)
        {
            if (emailObj == null) return;

            Env.Load();

            string fromAddress = Environment.GetEnvironmentVariable("_fromAddress") ?? "vizzman9@gmail.com";
            string password = Environment.GetEnvironmentVariable("_password") ?? string.Empty;
            string host = Environment.GetEnvironmentVariable("_host") ?? "smtp.gmail.com";
            int port = int.Parse(Environment.GetEnvironmentVariable("_port") ?? "465");
            bool enableSSL = bool.Parse(Environment.GetEnvironmentVariable("_enableSSL") ?? "true");
            string displayName = Environment.GetEnvironmentVariable("_displayName") ?? "no-reply";
            int timeout = int.Parse(Environment.GetEnvironmentVariable("_timeout") ?? "255");

            if (password == string.Empty)
            {
                Console.WriteLine("Password je prazan.");
                return;
            }

            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(displayName, fromAddress));
            email.To.Add(new MailboxAddress(emailObj.ReceiverName, emailObj.EmailTo));

            email.Subject = emailObj.Subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = emailObj.Message
            };

            try
            {
                Console.WriteLine("Spajanje na SMTP server...");

                using (var smtp = new SmtpClient())
                {
                    Console.WriteLine($"Pokušavam da se povežem na SMTP server {host} na portu {port} sa SSL: {enableSSL}");

                    await smtp.ConnectAsync(host, port, enableSSL);
                    Console.WriteLine("Uspješno spojeno na SMTP server...");

                    Console.WriteLine($"Pokušavam da se autentifikujem sa korisničkim imenom {fromAddress}");

                    await smtp.AuthenticateAsync(fromAddress, password);
                    Console.WriteLine("Autentifikacija na SMTP serveru uspješna.");

                    Console.WriteLine("Pokušavam da pošaljem email...");
                    await smtp.SendAsync(email);
                    await smtp.DisconnectAsync(true);

                    Console.WriteLine("Email uspješno poslan.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom slanja emaila: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                if (ex is SmtpCommandException smtpEx)
                {
                    Console.WriteLine($"SMTP Greška: {smtpEx.Message}");
                }
                else if (ex is SmtpProtocolException smtpProtocolEx)
                {
                    Console.WriteLine($"SMTP Protokol Greška: {smtpProtocolEx.Message}");
                }

                return;
            }
        }
    }
}
