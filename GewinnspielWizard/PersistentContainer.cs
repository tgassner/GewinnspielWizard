using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GewinnspielWizard {
    class PersistentContainer {
        public IList<EmailEntry> EmailEntries{ get; set; }
        public string MailServer { get; set; }
        public string MailUsername { get; set; }
        public string DestinationEmailAddress { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
    }
}
