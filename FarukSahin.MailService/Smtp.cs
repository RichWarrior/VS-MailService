using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FarukSahin.MailService
{
    public class Smtp : Model, ISmtp
    {
        /// <summary>
        /// Constructor Metodu
        /// </summary>
        /// <param name="email">Sunucu Mail Adresi</param>
        /// <param name="password">Sunucu Mail Şifresi</param>
        /// <param name="host">Sunucu IP Adresi</param>
        /// <param name="port">Sunucu Port Numarası</param>
        public Smtp(string email, string password,
            string host, int port)
        {
            this.Mail = email;
            this.Password = password;
            this.Host = host;
            this.Port = port;
        }       
        /// <summary>
        /// Kullanıcılara Gönderilecek Mail İçeriği Bu Blok İçerisinde İlgili Property'lere Set Edilir.
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        public void AddMail(string subject, string body)
        {
            this.MailList = new MailContent { body = body, subject = subject };
        }
        /// <summary>
        /// Test Edildi Kullanıcıya Senkron Mail Gönderir
        /// </summary>        
        public bool Send(string email)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.BodyEncoding = Encoding.UTF8;
                message.HeadersEncoding = Encoding.UTF8;
                message.SubjectEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                message.Subject = this.MailList.subject;
                message.From = new MailAddress(this.Mail);
                message.Body = this.MailList.body;
                message.To.Add(email);
                SmtpClient smtp = new SmtpClient(this.Host);
                smtp.Credentials = new NetworkCredential(this.Mail, this.Password);
                smtp.EnableSsl = true;
                smtp.Port = this.Port;
                smtp.Send(message);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Test Edildi Kullanıcya Asenkron Mail Gönderir.
        /// </summary>        
        public async Task<bool> SendAsync(string email)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.BodyEncoding = Encoding.UTF8;
                message.HeadersEncoding = Encoding.UTF8;
                message.SubjectEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                message.Subject = this.MailList.subject;
                message.From = new MailAddress(this.Mail);
                message.Body = this.MailList.body;
                message.To.Add(email);
                SmtpClient smtp = new SmtpClient(this.Host);
                smtp.Credentials = new NetworkCredential(this.Mail, this.Password);
                smtp.EnableSsl = true;
                smtp.Port = this.Port;
                await smtp.SendMailAsync(message);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Test Edilmedi ! Kullanıcılara Toplu Bir Şekilde Otomatik Mail Gönderir. Senkron Çalışır
        /// </summary>
        /// <param name="list">Kullanıcı Listesi</param>        
        public bool SendRange(List<string> list)
        {
            var result = false;
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient(this.Host);
                smtp.EnableSsl = true;
                smtp.Port = this.Port;
                smtp.Credentials = new NetworkCredential(this.Mail, this.Password);
                foreach (var item in list)
                {
                    message.BodyEncoding = Encoding.UTF8;
                    message.HeadersEncoding = Encoding.UTF8;
                    message.SubjectEncoding = Encoding.UTF8;
                    message.IsBodyHtml = true;
                    message.Subject = this.MailList.subject;
                    message.From = new MailAddress(this.Mail);
                    message.Body = this.MailList.body;
                    message.To.Add(item);
                    smtp.SendMailAsync(message);
                }
            }
            catch (Exception)
            {
            }
            return result;
        }
        /// <summary>
        /// Test Edilmedi ! Kullanıcılara Toplu Bir Şekilde Otomatik Mail Gönderir. Asenkron Çalışır.
        /// </summary>
        /// <param name="list">Kullanıcı Listesi</param>
        /// <returns></returns>
        public async Task<bool> SendAsyncRange(List<string> list)
        {

            var result = false;
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient(this.Host);
                smtp.EnableSsl = true;
                smtp.Port = this.Port;
                smtp.Credentials = new NetworkCredential(this.Mail, this.Password);
                foreach (var item in list)
                {
                    message.BodyEncoding = Encoding.UTF8;
                    message.HeadersEncoding = Encoding.UTF8;
                    message.SubjectEncoding = Encoding.UTF8;
                    message.IsBodyHtml = true;
                    message.Subject = this.MailList.subject;
                    message.From = new MailAddress(this.Mail);
                    message.Body = this.MailList.body;
                    message.To.Add(item);
                    await smtp.SendMailAsync(message);
                }
            }
            catch (Exception)
            {
            }
            return result;
        }

    }
}
