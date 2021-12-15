using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net;
using System.Net.Mail;
using MailKit.Net.Imap;
using MimeKit;
using System.Configuration;

namespace EmailClient
{
    /// <summary>
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        public Account()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var login = tbLogin.Text;
            var password = tbPassword.Text;

            var client = new ImapClient();

            client.Connect("imap.gmail.com", 993, true);
            client.Authenticate(login, password);

            if (!client.IsAuthenticated)
            {
                MessageBox.Show("Connection error!");
                
                return;
            }
            else
            {
                User user = new User();
               
                user.Login = login;
                user.Client = client;
                
                
            }
        }
    }
}
