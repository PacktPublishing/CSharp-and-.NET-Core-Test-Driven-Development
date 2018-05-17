using LoanApplication.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core.Repository
{
    public interface ILoanRepository
    {
        List<LoanType> GetLoanTypes();
    }
}
