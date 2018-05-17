using LoanApplication.Core.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class LoanRepository
    {
        private DbContext dbContext;
        IRateParser rateParser;

        public LoanRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void InjectRateParser(IRateParser rateParser)
        {
            this.rateParser = rateParser;
        }

        public float GetCheapestRate(LoanType loanType)
        {
            return rateParser.GetRateByLoanType(loanType);
        }
           
        public List<CarLoan> GetCarLoans()
        {
            return dbContext.CarLoan;
        }

        public List<HouseLoan> GetHouseLoans()
        {
            return dbContext.HouseLoan;
        }
    }
}
