using LoanApplication.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class RateCalculator : IRateCalculator
    {
        public Rate GetYearlyCarLoanRate()
        {
            throw new NotImplementedException();
        }

        public Rate GetYearlyHouseLoanRate()
        {
            throw new NotImplementedException();
        }

        public Lender FindLender(LoanType loanType)
        {
            throw new NotImplementedException();
        }
    }
}
