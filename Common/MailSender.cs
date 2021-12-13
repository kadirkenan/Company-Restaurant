using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public class MailSender
    {
        public static void SendMail(string email, string subject,string message)
        {
            try
            {
                MailMessage sender = new MailMessage();
                sender.From = new MailAddress("ba.yzl3148@gmail.com", "YZL3148");
                sender.To.Add(email);
                sender.Subject = subject;
                sender.Body = message;

                SmtpClient smtp = new SmtpClient();

                smtp.Credentials = new NetworkCredential("ba.yzl3148@gmail.com", "Yzl3148!!--");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;

                smtp.Send(sender);
            }
            catch (Exception ex)
            {

                throw;
            }



            
        }
        
        
    }
}
