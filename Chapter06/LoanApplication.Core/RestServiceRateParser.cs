using LoanApplication.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class RestServiceRateParser : IRateParser
    {
        public Rate ParseRate()
        {
            // Parse rate available from REST service
            throw new NotImplementedException();
        }

        public float GetRateByLoanType(LoanType loanType)
        {
            throw new NotImplementedException();
        }
    }
}
