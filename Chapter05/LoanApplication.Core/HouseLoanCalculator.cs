using LoanApplication.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class HouseLoanCalculator : LoanCalculator
    {
        public HouseLoanCalculator(IRateParser rateParser) : base(rateParser)
        {
            base.rateParser = rateParser;
        }

        public override Loan CalculateLoan(LoanDTO loanDTO)
        {
            Loan loan = new Loan();
            loan.LoanType = LoanType.HouseLoan;
            loan.InterestRate = rateParser.GetRateByLoanType(LoanType.HouseLoan);
            // do other processing
            return loan;
        }
    }
}
