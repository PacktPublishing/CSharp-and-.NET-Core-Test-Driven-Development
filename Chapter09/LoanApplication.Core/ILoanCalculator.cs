using LoanApplication.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public interface ILoanCalculator
    {
        Loan CalculateLoan(LoanDTO loanDTO);
    }
}
