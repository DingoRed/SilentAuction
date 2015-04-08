using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Security;

namespace SilentAuction.Utilities
{
    public class EmailHelper
    {
        public static bool SendEmail(string gmailAccount, SecureString gmailPassword, 
            string fromAddress, List<string> toAddressList, string subject, string body)
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

                smtp.Port = 587;  //465  587  25
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;

                // TODO: Replace with stored acct/pwd
                smtp.Credentials = new NetworkCredential(gmailAccount, gmailPassword);

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
