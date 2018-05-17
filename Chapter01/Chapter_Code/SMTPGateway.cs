using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good_Code
{
    public class SMTPGateway
    {
        private static SMTPGateway smtpGateway = null;
        private static object lockObject = new object();

        private SMTPGateway()
        {
        }

        public static SMTPGateway SMTPGatewayObject
        {
            get
            {
                lock (lockObject)
                {
                    if (smtpGateway == null)
                    {
                        smtpGateway = new SMTPGateway();
                    }
                }
                return smtpGateway;
            }
        }
    }
}
