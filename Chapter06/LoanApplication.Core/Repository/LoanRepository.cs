using LoanApplication.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
           
        //public List<CarLoan> GetCarLoans()
        //{
        //    return dbContext.CarLoan;
        //}

        public Loan GetLoanById(int loanId)
        {
            return dbContext.Loan.Find(c => c.LoanId == loanId);
        }

        public List<Loan> GetBadCarLoans()
        {
            return dbContext.Loan.FindAll(c=>c.HasDefaulted==true);
        }

        public List<HouseLoan> GetHouseLoans()
        {
            return dbContext.HouseLoan;
        }

        //private List<LoanType> GetLoanTypes()
        //{
        //    var loanTypes = new List<LoanType>();
        //    loanTypes.Add(new LoanType()
        //    {
        //        Id = 1,
        //        Name = "Car Loan"
        //    });
        //    loanTypes.Add(new LoanType()
        //    {
        //        Id = 2,
        //        Name = "House Loan"
        //    });
        //    return loanTypes;
        //}

        public List<LoanType> GetLoanTypes()
        {
            List<LoanType> loanTypes = new List<LoanType>();
            using (LoanContext context = new LoanContext())
            {
                loanTypes = context.LoanType.ToList();
            }
            return loanTypes;
        }

        public List<Loan> GetCarLoans()
        {
            List<Loan> loans = new List<Loan>();
            using (LoanContext context = new LoanContext())
            {
                loans = context.Loan.ToList();
            }
            return loans;
        }



        public List<Person> GetCarLoanDefaulters(int year)
        {
            List<Person> defaulters = new List<Person>();
            using (LoanContext context = new LoanContext())
            {
                defaulters = context.Loan.Where(c => c.HasDefaulted
                && c.ServiceYear == year).Select(c =>
                c.Person).ToList();
            }
            return defaulters;
        }
    }
}
