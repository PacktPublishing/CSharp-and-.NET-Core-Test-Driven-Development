using LoanApplication.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class XmlRateParser : IRateParser
    {
        public Rate ParseRate()
        {
            // Parse rate available from xml file
            throw new NotImplementedException();
        }

        public float GetRateByLoanType(LoanType loanType)
        {
            throw new NotImplementedException();
        }
    }

}
