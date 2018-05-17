using System;
using System.Collections.Generic;
using System.Text;
using LoanApplication.Core.DTO;

namespace LoanApplication.Core
{
    public interface IRateParser
    {

        float GetRateByLoanType(LoanType loanType);
    }
}
