using LoanApplication.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class CarLoanCalculator : LoanCalculator
    {
        public CarLoanCalculator(IRateParser rateParser) :base(rateParser)
        {
            base.rateParser = rateParser;
        }

        public override Loan CalculateLoan(DTO.LoanDTO loanDTO)
        {
            Loan loan = new Loan();
            loan.LoanType = loanDTO.LoanType;
            loan.InterestRate = rateParser.GetRateByLoanType(loanDTO.LoanType);
            // do other processing
            return loan;
        }
    }
}
