# VS-MailService

#Kullan�m�
```c#
SendMail mail = new SendMail("mail_adresi","�ifre");
mail.AddReceiver("hedef_adres");
            mail.AddMail("Mail Konusu","Mail ��eri�i");
            Task<bool> result = Task.Run(() => mail.SendMailWithGmailAsync());
            if (result.Result)
            {
                Console.Write("G�nderildi!");
            }
```
#�zellikleri
<ul>
<li>Kullan�c�lara Gmail �zerinden �oklu veya Tekli Mail G�ndermek</li>
<li>Kullan�c�lara Outlook �zerinden �oklu veya Tekli Mail G�ndermek</li>
</ul>
