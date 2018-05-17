using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core.Reference2
{
    public static class LoanProcessor
    {
        private static EligibilityChecker eligibilityChecker = new EligibilityChecker();

        public static double CalculateCarLoanRate(Loan loan)
        {
            double rate = 12.5F;
            bool isEligible = eligibilityChecker.IsApplicantEligible(loan);
            if (isEligible)
                rate = rate - loan.DiscountFactor;
            return rate;
        }
    }
}
