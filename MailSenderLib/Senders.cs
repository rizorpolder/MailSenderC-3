using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSenderLib
{
    public class Senders
    {
        public static readonly ObservableCollection<Sender> Items =
            new ObservableCollection<Sender>(new []
            {
                new Sender{Name="Иванов", Email="Ivanov@server.org", Password = PasswordEncoder.Encode("Password1")},
                new Sender{Name="Петров", Email="Pvanov@server.org", Password = PasswordEncoder.Encode("Password2")},
                new Sender{Name="Сидоров", Email="SAvanov@server.org", Password = PasswordEncoder.Encode("Password3")},


            });
    }

    public class Sender
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
