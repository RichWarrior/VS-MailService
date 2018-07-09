# VS-MailService

# Kullanımı

# Async
```c#
SendMail mail = new SendMail("mail_adresi","şifre");
mail.AddReceiver("hedef_adres");
mail.AddMail("Mail Konusu","Mail İçeriği");
Task<bool> result = Task.Run(() => mail.SendMailWithGmailAsync());
if (result.Result)
{
Console.Write("Gönderildi!");
}
```

# Sync
```c#
SendMail mail = new SendMail("mail_adresi","şifre");
mail.AddReceiver("hedef_adres");
mail.AddMail("Mail Konusu","Mail İçeriği");
if (mail.SendMailWithGmailAsync())
{
Console.Write("Gönderildi!");
}
```

# Özellikleri


<ul>
<li>Kullanıcılara Gmail Üzerinden  Tekli Mail Göndermek</li>
<li>Kullanıcılara Outlook Üzerinden  Tekli Mail Göndermek</li>
 <li>Kullanıcılara Hostinger Mail Sunucusu Üzerinden  Tekli Mail Göndermek</li>
</ul>
