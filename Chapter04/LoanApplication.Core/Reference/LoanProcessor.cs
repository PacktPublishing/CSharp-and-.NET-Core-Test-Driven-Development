using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core.Reference
{
    public class LoanProcessor
    {
        private EligibilityChecker eligibilityChecker;
        private DbContext dbContext;

        public LoanProcessor(EligibilityChecker eligibilityChecker, DbContext dbContext)
        {
            this.eligibilityChecker = eligibilityChecker;
            this.dbContext = dbContext;
        }

        public double CalculateCarLoanRate(Loan loan)
        {
            double rate = 12.5F;
            bool isEligible = eligibilityChecker.IsApplicantEligible(loan);
            if (isEligible)
                rate = rate - loan.DiscountFactor;
            return rate;
        }

        public List<CarLoan> GetCarLoans()
        {
            return dbContext.CarLoan;
        }
    }
}
