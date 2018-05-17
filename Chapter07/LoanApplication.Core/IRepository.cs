using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public interface IRepository
    {
        void InjectRateParser(IRateParser rateParser);
    }
}
