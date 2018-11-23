using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarukSahin.MailService
{
    public interface ISmtp
    {
        Task<bool> SendAsync(string email);
        Task<bool> SendAsyncRange(List<string> list);
        bool Send(string email);
        bool SendRange(List<string> list);
    }
}
