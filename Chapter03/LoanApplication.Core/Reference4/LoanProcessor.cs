using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core.Reference4
{
    public class LoanProcessor
    {
        private EligibilityChecker eligibilityChecker;
        public EligibilityChecker EligibilityCheckerObject
        {
            set { eligibilityChecker = value; }
        }
        public void ProcessCustomerLoan(Loan loan)
        {
            bool isEligible = eligibilityChecker.CheckLoan(loan);
        throw new NotImplementedException();
        }
    }
}
