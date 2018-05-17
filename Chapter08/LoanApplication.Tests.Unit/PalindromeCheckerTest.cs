using Extensions;
using LoanApplication.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LoanApplication.Tests.Unit
{
    public class PalindromeCheckerTest
    {
        //    [Theory, SqlServerData(@".\sqlexpress", "TheoryDb", "select word from Palindrome")]
        //    public void Test_IsWordPalindrome_ShouldReturnTrue(string word)
        //    {
        //        PalindromeChecker palindromeChecker = new PalindromeChecker();
        //        Assert.True(palindromeChecker.IsWordPalindrome(word));
        //    }

        [Theory, CsvData(@"C:\data.csv", false)]
        public void Test_IsWordPalindrome_ShouldReturnTrue(string word)
        {
            PalindromeChecker palindromeChecker = new PalindromeChecker();
            Assert.True(palindromeChecker.IsWordPalindrome(word));
        }
    }
}
