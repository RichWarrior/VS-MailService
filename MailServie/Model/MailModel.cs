using System.Collections.Generic;

namespace MailServie.Model
{
    public abstract class MailModel
    {
        public string Mail { get; set; }
        public string Password { get; set; }
        public class ReceiverModel{
            public string ReceiverMailAddress { get; set; }
        }
        public class MailContent{
            public string subject { get; set; }
            public string body { get; set; }
        }
        public ReceiverModel ReceiverList { get; set; }
        public MailContent MailList { get; set; }
    }
    
}
