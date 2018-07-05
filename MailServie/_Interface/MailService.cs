using System.Threading.Tasks;

namespace MailServie._Interface
{
    public interface MailService
    {
        Task<bool> SendMailWithGmailAsync();
        Task<bool> SendMailWithOutlookAsync();
        bool SendMailWithGmail();
        bool SendMailWithOutlook();
    }
}
