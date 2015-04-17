using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Text.RegularExpressions;

namespace SilentAuction.Utilities
{
    public class EmailHelper
    {
        private static bool _invalid;

        #region Public Methods
        public static bool SendEmail(string gmailAccount, SecureString gmailPassword, 
            string fromAddress, List<string> toAddressList, List<string> ccAddressList, 
            string subject, string body, List<string> attachmentFilenameList)
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

                foreach (string ccAddress in ccAddressList)
                {
                    MailAddress cc = new MailAddress(ccAddress);
                    if(!mail.CC.Contains(cc))
                        mail.CC.Add(cc);
                }

                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                foreach (string filename in attachmentFilenameList)
                {
                    Attachment attachment = new Attachment(filename);
                    mail.Attachments.Add(attachment);
                }

                smtp.Port = 587;  //465  587  25
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;

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

        public static bool IsValidEmailAddress(string strIn)
        {
            _invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper);
            if (_invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
                   @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                   RegexOptions.IgnoreCase);
        }
        #endregion

        #region Private Methods
        private static string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                _invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
        #endregion
    }
}
