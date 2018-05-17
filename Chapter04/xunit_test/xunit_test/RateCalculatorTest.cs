using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace xunit_test
{
    [Collection("Do not run in parallel")]
    public class RateCalculatorTest
    {
        [Fact]
        public void TestCalculateRate()
        {
            Assert.Equal(12, (4 * 3));
        }
    }
}

