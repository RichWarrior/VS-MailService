# VS-MailService

#Kullanýmý
```c#
SendMail mail = new SendMail("mail_adresi","þifre");
mail.AddReceiver("hedef_adres");
            mail.AddMail("Mail Konusu","Mail Ýçeriði");
            Task<bool> result = Task.Run(() => mail.SendMailWithGmailAsync());
            if (result.Result)
            {
                Console.Write("Gönderildi!");
            }
```
#Özellikleri
<ul>
<li>Kullanýcýlara Gmail Üzerinden Çoklu veya Tekli Mail Göndermek</li>
<li>Kullanýcýlara Outlook Üzerinden Çoklu veya Tekli Mail Göndermek</li>
</ul>
