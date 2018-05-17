using LoanApplication.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public interface ILenderManager
    {
        Lender FindLender(LoanType loanType);
    }
}
