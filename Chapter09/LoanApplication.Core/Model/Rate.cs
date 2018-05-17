using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class Rate
    {
        public string CurrencyCode { get; set; }
        public string BaseCurrency { get; set; }
        public decimal Amount { get; set; }
    }
}
