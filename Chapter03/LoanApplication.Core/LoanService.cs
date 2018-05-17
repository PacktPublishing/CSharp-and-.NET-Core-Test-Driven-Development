using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class LoanService
    {
        private IEligibilityChecker eligibilityChecker;

        public LoanService(IEligibilityChecker eligibilityChecker)
        {
            this.eligibilityChecker = eligibilityChecker;
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
