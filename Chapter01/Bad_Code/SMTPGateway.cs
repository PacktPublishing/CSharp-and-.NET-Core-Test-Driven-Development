using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bad_Code
{
    public class SMTPGateway
    {
        private static SMTPGateway smtpGateway = null;

        private SMTPGateway()
        {
        }

        public static SMTPGateway SMTPGatewayObject
        {
            get
            {
                if (smtpGateway == null)
                {
                    smtpGateway = new SMTPGateway();
                }
                return smtpGateway;
            }
        }
    }
}
