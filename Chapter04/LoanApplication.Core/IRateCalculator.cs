using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public interface IRateCalculator
    {
        Rate GetYearlyCarLoanRate();
        Rate GetYearlyHouseLoanRate();
    }
}
