using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamsinvitesender
{
       public class SmtpSettings
        {
            public string Host { get; set; }
            public int Port { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }
    public class AyarDosyasi
    {
        public SmtpSettings SmtpSettings { get; set; }
        public List<string> GonderilecekMailler { get; set; } = new List<string>();
    }
}
