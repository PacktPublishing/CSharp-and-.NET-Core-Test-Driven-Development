using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core.DTO
{
    public class LoanDTO
    {

        public LoanType LoanType { get; set; }
    }

    public enum LoanType
    {
        CarLoan,
        HouseLoan
    }
}
