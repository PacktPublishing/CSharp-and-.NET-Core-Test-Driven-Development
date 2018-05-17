using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bad_Code
{
    public class Transaction
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public float TransactionAmount { get; set; }
        public string TransactionType { get; set; }
        public DateTime Time { get; set; }
        public bool CanProcess { get; set; }
        public bool RetryOnfailure { get; set; }
    }
}
