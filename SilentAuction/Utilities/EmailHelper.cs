using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace SilentAuction.Utilities
{
    public class EmailHelper
    {
        public static bool SendEmail(string fromAddress, List<string> toAddressList, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                mail.From = new MailAddress(fromAddress);

                foreach (string toAddress in toAddressList)
                {
                    MailAddress to = new MailAddress(toAddress);
                    if (!mail.To.Contains(to))
                        mail.To.Add(to);
                }

                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                //smtp.Host = "ormail.intel.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("john.b.buell@gmail.com", "GMpassword01!");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(mail);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
