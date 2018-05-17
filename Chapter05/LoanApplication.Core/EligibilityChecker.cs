using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class EligibilityChecker
    {
        public List<Rate> CurrentRates { get; set; }

        public bool CheckLoan(Loan loan)
        {
            return false;
        }

        public bool IsApplicantEligible(Loan loan)
        {
            return false;
        }
    }
}
