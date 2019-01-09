using System;
using System.Net;
using System.Net.Mail;

namespace ConsoleMailSender
{
    class Program
    {
        static void Main(string[] args)
        {

            var mail = new MailMessage();
            mail.From = new MailAddress(@"email@email.com");
            mail.To.Add(@"Mail@mail.com");
            mail.Subject = "Hello,world";
            mail.Body = "Body message";


            var client = new SmtpClient("host", 58);
            client.Credentials=new NetworkCredential("userName", "password");
            client.EnableSsl = true;


            client.Send(mail);


            Console.ReadLine();

        }
    }
}
