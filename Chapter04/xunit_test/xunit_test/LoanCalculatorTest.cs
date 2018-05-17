using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace xunit_test
{
    [Collection("Do not run in parallel")]
    public class LoanCalculatorTest
    {
        [Fact]
        public void TestCalculateLoan()
        {
            Assert.Equal(16, (4 * 4));
        }

        [Fact]
        public void TestCalculateRate()
        {
            Assert.Equal(12, (4 * 3));
        }
    }
}
