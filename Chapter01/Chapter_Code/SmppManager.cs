using JamaaTech.Smpp.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good_Code
{
    public class SmppManager
    {
        private string sourceAddress;
        private SmppClient smppClient;

        public SmppManager()
        {
            smppClient = new SmppClient();
            smppClient.Start();
        }

        public SmppManager(string address, int port)
        {
            smppClient = new SmppClient();
            smppClient.Start();
        }

        public void SendMessage(string recipient, string message, string senderName)
        {
            // send message using referenced library            
        }

        public bool TestConnection()
        {
            return true;
        }
    }
}
