using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace dynamicDeduct
{
    class dynamic
    {
        public void checkaccount(String fromAdd, String password)
        {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAdd, password)
                };
                using (var message = new MailMessage(fromAdd, "haiqy97@gmail.com")
                   {
                       Body = null
                   }) { }
        }

        public void SendEmail(String name, String content,String fromAdd, String password)
        {
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAdd, password)
            };

                using (var message = new MailMessage(fromAdd, "haiqy97@gmail.com")
                {
                    Body = content
                })
                {
                    try
                    {
                        smtp.Send(message);
                    }
                    catch (SmtpException e) 
                    {
                        EmailLogin el = new EmailLogin();
                        el.Show();
                    }
                }
        }
    }
}
