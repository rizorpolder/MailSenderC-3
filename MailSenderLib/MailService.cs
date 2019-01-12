using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MailSenderLib
{
    /// <summary>
    ///  рассылка почты
    /// </summary>
   public  class MailService
    {
        private string _login;
        private string _password;

        private string _sercverAdress = "smtp.yandex.ru";
        private int _port = 25;
        private string _body;
        private string _subject;

        public MailService(string User, string Password)
        {
            _login = User;
            _password = Password;
        }

        public void SendMail(string Mail, string Name)
        {
            try
            {
                using (var message = new MailMessage(_login, Mail)
                {
                    Subject = _subject,
                    Body = _body,
                    IsBodyHtml = false,
                })
                {
                    using (var client = new SmtpClient(_sercverAdress, _port)
                    {
                        EnableSsl = true,
                        Credentials = new NetworkCredential(_login, _password)
                    })
                    {
                        client.Send(message);
                    }
                   

                }
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.ToString());
                throw new InvalidOperationException("Отправка почты", e);
            }
        }

    }

}
