using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core.Reference3
{
    public class LoanProcessor
    {
        private CurrencyConverter currencyConverter;

        public LoanProcessor(LoanCalculator loanCalculator)
        {
            currencyConverter = loanCalculator.GetCurrencyConverter();
        }
    }
}
