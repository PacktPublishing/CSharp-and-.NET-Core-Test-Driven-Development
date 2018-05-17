using Good_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chapter_Test
{
    public class SmppManagerTest
    {
        public bool IsServerOnline()
        {
            string address = "localhost";
            int port = 8034;
            SmppManager smppManager = new SmppManager(address, port);
            bool isOnline = smppManager.TestConnection();
            return isOnline;
        }


        [Fact]
        public void Test_IsServerOnline_ShouldReturnTrue()
        {
            bool isOnline = IsServerOnline();

            Assert.True(isOnline);
        }
    }
}
