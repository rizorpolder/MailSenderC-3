using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace MailSenderGUI
{
    
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var email = new MailMessage("email@emalli.com", "email@email.com"))
                {
                    email.Subject = "Theme message";
                    email.Body = "Body message";

                    using (var client = new SmtpClient("smt.gmail.com", 465))
                    {
                        var user = UsernameTextBox.Text;
                        var password = Password.SecurePassword;
                        client.Credentials = new NetworkCredential(user, password);
                        client.EnableSsl = true;

                        client.Send(email);
                    }
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error!", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            //MessageBox.Show("Почта отправлена", "MailSender", 
            //    MessageBoxButton.OK, MessageBoxImage.Information);

        var dlg=  new SendCompleteDialog();
            dlg.Owner = this;
            dlg.ShowDialog();

        }
    }
}
