using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public interface IEligibilityChecker
    {
        bool IsApplicantEligible(Loan loan);
    }
}
