using MailServie._Interface;
using MailServie.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailServie._Class
{
    public class SendMail : MailModel, MailService
    {
        public SendMail(string mail,string password){
            this.Mail = mail;
            this.Password = password;
            this.MailList = new List<MailContent>();
            this.ReceiverList = new List<ReceiverModel>();
        }
        public void AddReceiver(string mail)
        {
            this.ReceiverList.Add(new ReceiverModel { ReceiverMailAddress = mail });
        }
        public void AddMail(string subject,string body)
        {
            this.MailList.Add(new MailContent { subject=subject,body = body });
        }
        public bool SendMailWithGmail()
        {
            try
            {
                MailMessage message = new MailMessage();
                message.BodyEncoding = Encoding.UTF8;
                message.HeadersEncoding = Encoding.UTF8;
                message.SubjectEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                foreach (MailContent item in this.MailList)
                {
                    message.Subject = item.subject;
                    message.From = new MailAddress(this.Mail);
                    message.Body = item.body;
                    foreach (ReceiverModel subItem in this.ReceiverList)
                    {
                        message.To.Add(subItem.ReceiverMailAddress);                      
                    }
                }
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Credentials = new NetworkCredential(this.Mail, this.Password);
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(message);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> SendMailWithGmailAsync()
        {
            try
            {
                MailMessage message = new MailMessage();
                message.BodyEncoding = Encoding.UTF8;
                message.HeadersEncoding = Encoding.UTF8;
                message.SubjectEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                foreach (MailContent item in this.MailList)
                {
                    message.Subject = item.subject;
                    message.From = new MailAddress(this.Mail);
                    message.Body = item.body;
                    foreach (ReceiverModel subItem in this.ReceiverList)
                    {
                        message.To.Add(subItem.ReceiverMailAddress);
                    }
                }
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Credentials = new NetworkCredential(this.Mail, this.Password);
                smtp.EnableSsl = true;
                smtp.Port = 587;
                await smtp.SendMailAsync(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SendMailWithOutlook()
        {
            try
            {
                MailMessage message = new MailMessage();
                message.BodyEncoding = Encoding.UTF8;
                message.HeadersEncoding = Encoding.UTF8;
                message.SubjectEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                foreach (MailContent item in this.MailList)
                {
                    message.Subject = item.subject;
                    message.From = new MailAddress(this.Mail);
                    message.Body = item.body;
                    foreach (ReceiverModel subItem in this.ReceiverList)
                    {
                        message.To.Add(subItem.ReceiverMailAddress);
                    }
                }
                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com");
                smtp.Credentials = new NetworkCredential(this.Mail, this.Password);
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> SendMailWithOutlookAsync()
        {
            try
            {
                MailMessage message = new MailMessage();
                message.BodyEncoding = Encoding.UTF8;
                message.HeadersEncoding = Encoding.UTF8;
                message.SubjectEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                foreach (MailContent item in this.MailList)
                {
                    message.Subject = item.subject;
                    message.From = new MailAddress(this.Mail);
                    message.Body = item.body;
                    foreach (ReceiverModel subItem in this.ReceiverList)
                    {
                        message.To.Add(subItem.ReceiverMailAddress);
                    }
                }
                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com");
                smtp.Credentials = new NetworkCredential(this.Mail, this.Password);
                smtp.EnableSsl = true;
                smtp.Port = 587;
                await smtp.SendMailAsync(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
