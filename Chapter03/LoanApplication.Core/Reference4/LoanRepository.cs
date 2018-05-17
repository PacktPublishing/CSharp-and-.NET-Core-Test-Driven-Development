using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core.Reference4
{
    public class LoanRepository
    {
        private DbContext dbContext;
        private IEligibilityChecker eligibilityChecker;

        public LoanRepository(DbContext dbContext, IEligibilityChecker eligibilityChecker)
        {
            this.dbContext = dbContext;
            this.eligibilityChecker = eligibilityChecker;
        }

        public List<CarLoan> GetCarLoans()
        {
            return dbContext.CarLoan;
        }

        public List<HouseLoan> GetHouseLoans()
        {
            return dbContext.HouseLoan;
        }

        public double CalculateCarLoanRate(CarLoan carLoan)
        {
            double rate = 12.5F;
            bool isEligible = eligibilityChecker.IsApplicantEligible(carLoan);
            if (isEligible)
                rate = rate - carLoan.DiscountFactor;
            return rate;
        }
    }
}
