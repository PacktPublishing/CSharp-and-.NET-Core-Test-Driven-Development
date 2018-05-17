using LoanApplication.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class Loan
    {
        public bool IsElligible { get; set; }

        public string Description { get; set; }

        public float DiscountFactor { get; set; }

        public LoanType LoanType { get; set; }

        public float InterestRate { get; set; }

        public int LoanId { get; set; }
    }
}
