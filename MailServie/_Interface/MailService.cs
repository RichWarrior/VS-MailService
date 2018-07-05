using System.Threading.Tasks;

namespace MailServie._Interface
{
    public interface MailService
    {
        Task<bool> SendMailWithGmailAsync();
        Task<bool> SendMailWithOutlookAsync();
        Task<bool> SendMultipleMailGmailAsync();
        Task<bool> SendMultipleMailOutlookAsync();
        bool SendMailWithGmail();
        bool SendMailWithOutlook();
        void ClearReceiverList();
        void ClearMailList();
    }
}
