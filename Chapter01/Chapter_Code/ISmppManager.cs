using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good_Code
{
    public interface ISmppManager
    {
        void SendMessage(string recipient, string message, string senderName);
    }
}
