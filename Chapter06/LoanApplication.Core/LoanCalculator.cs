using LoanApplication.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class LoanCalculator
    {
        protected IRateParser rateParser;

        public LoanCalculator(IRateParser rateParser)
        {
            this.rateParser = rateParser;
        }

        public virtual Loan CalculateLoan(LoanDTO loanDTO)
        {
            Loan loan = new Loan();
            if (loanDTO.LoanType == LoanType.CarLoan)
            {
                loan.LoanType = LoanType.CarLoan;
                loan.InterestRate = rateParser.GetRateByLoanType(LoanType.CarLoan);
                // do other processing
            }
            else if (loanDTO.LoanType == LoanType.HouseLoan)
            {
                loan.LoanType = LoanType.HouseLoan;
                loan.InterestRate = rateParser.GetRateByLoanType(LoanType.HouseLoan);
                // do other processing
            }
            return loan;
        }

        public CarLoan CalculateCarLoan(LoanDTO loanDTO)
        {
            throw new NotImplementedException();
        }

        public HouseLoan CalculateHouseLoan(LoanDTO loanDTO)
        {
            throw new NotImplementedException();
        }

        public List<Rate> ParseRatesFromXmlString(string xmlString)
        {
            throw new NotImplementedException();
        }

        public List<Rate> ParseRatesFromXmlFile(string xmlFile)
        {
            throw new NotImplementedException();
        }

        public CurrencyConverter GetCurrencyConverter()
        {
            return new CurrencyConverter();
        }
    }
}
