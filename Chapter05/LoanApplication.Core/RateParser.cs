using LoanApplication.Core.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoanApplication.Core
{
    public class RateParser : IRateParser
    {
        public List<Rate> ParseRatesFromXml(string xmlString)
        {
            throw new NotImplementedException();
        }
        public List<Rate> ParseRatesFromXmlFile(string xmlFile)
        {
            throw new NotImplementedException();
        }

        public float GetRateByLoanType(LoanType loanType)
        {
            if (loanType == LoanType.CarLoan)
            {

                return 8F;
            }
            else
                return 10F;
        }
    }
}
