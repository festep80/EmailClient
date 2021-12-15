using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailClient
{
    public class User
    {
        public string Login { get; set; }
        public ImapClient Client { get; set; }
    }

}
