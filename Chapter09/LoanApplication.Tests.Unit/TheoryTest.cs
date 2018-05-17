using Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LoanApplication.Tests.Unit
{
    public class TheoryTest
    {
        [Theory,
            InlineData("name"),
            InlineData("word"),
            InlineData("city")
        ]
        public void TestCheckWordLength_ShouldReturnBoolean(string word)
        {
            Assert.Equal(4, word.Length);
        }


        [Theory, CsvData(@"C:\gcd.csv", false)]
        public void Test_GetGcd_ShouldRetunTrue(int firstNumber, int secondNumber,int gcd)
        {
            int gcdValue = GetGcd(firstNumber, secondNumber);
            Assert.Equal(gcd, gcdValue);
        }

        public int GetGcd(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
                return firstNumber;
            else
                return GetGcd(secondNumber, firstNumber % secondNumber);
        }
    }
}
