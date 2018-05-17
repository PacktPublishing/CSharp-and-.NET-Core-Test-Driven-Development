using LoanApplication.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xunit_test
{
    public class LoanModuleTest : IDisposable
    {
        public LoanAppContext Context { get; private set; }

        public LoanModuleTest()
        {
            Context = new LoanAppContext();
        }

        public void Dispose()
        {
            Context = null;
        }

        [Fact]
        public void TestSaveLoan_ShouldReturnTrue()
        {
            Loan loan = new Loan { Description = "Car Loan" };
            Context.Loan.Add(loan);
            var isSaved = Context.Save();
            Assert.True(isSaved);
        }
    }
}
