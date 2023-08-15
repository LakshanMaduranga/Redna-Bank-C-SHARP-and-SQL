using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace REDNA_BANK
{
    class emailsender
    {
        private SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        private MailMessage msgx = new MailMessage();
        public emailsender()
        {
            client.EnableSsl = true;
            client.Timeout = 100000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("rednabank@gmail.com", "rednabank123");
            msgx.From = new MailAddress("rednabank@gmail.com");
        }
        public void to(string to)
        {
            msgx.To.Add(to);
        }
        public void cc(string cc)
        {
            msgx.CC.Add(cc);
        }
        public void bcc(string bcc)
        {
            msgx.Bcc.Add(bcc);
        }
        public void subject(string subject)
        {
            msgx.Subject = subject;
        }
        public void msg(string msg)
        {
            msgx.Body = msg;
        }
        public void Attachment(string location)
        {
            Attachment att = new Attachment(location);
            msgx.Attachments.Add(att);
        }
        public void send()
        {
            client.Send(msgx);
        }
    }
}
