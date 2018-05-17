using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class LoanProcessor
    {
        private EligibilityChecker eligibilityChecker;
        private CurrencyConverter currencyConverter;

        public LoanProcessor()
        {
            eligibilityChecker = new EligibilityChecker();
            currencyConverter = new CurrencyConverter();
            currencyConverter.DownloadCurrentRates();
            eligibilityChecker.CurrentRates = currencyConverter.Rates;
        }

        // constructor for testing
        public LoanProcessor(EligibilityChecker eligibilityChecker, CurrencyConverter currencyConverter)
        {
            this.eligibilityChecker = eligibilityChecker;
            this.currencyConverter = currencyConverter;
        }

        public void ProcessCustomerLoan(Loan loan)
        {
            bool isEligible = eligibilityChecker.CheckLoan(loan);
            throw new NotImplementedException();
        }
    }
}
