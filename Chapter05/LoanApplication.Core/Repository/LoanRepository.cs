using LoanApplication.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core.Repository
{
    public class LoanRepository
    {
        private DbContext dbContext;
        IRateParser rateParser;

        public LoanRepository()
        {
            this.dbContext = new DbContext();
        }

        public void InjectRateParser(IRateParser rateParser)
        {
            this.rateParser = rateParser;
        }

        public float GetCheapestRate(DTO.LoanType loanType)
        {
            return rateParser.GetRateByLoanType(loanType);
        }
           
        public List<CarLoan> GetCarLoans()
        {
            return dbContext.CarLoan;
        }

        public Loan GetLoanById(int loanId)
        {
            return dbContext.Loan.Find(c => c.LoanId == loanId);
        }

        public List<HouseLoan> GetHouseLoans()
        {
            return dbContext.HouseLoan;
        }

        private List<LoanType> GetLoanTypes()
        {
            var loanTypes = new List<LoanType>();
            loanTypes.Add(new LoanType()
            {
                Id = 1,
                Name = "Car Loan"
            });
            loanTypes.Add(new LoanType()
            {
                Id = 2,
                Name = "House Loan"
            });
            return loanTypes;
        }
    }
}
