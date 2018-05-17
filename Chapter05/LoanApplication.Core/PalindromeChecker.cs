using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanApplication.Core
{
    public class PalindromeChecker
    {
        public bool IsWordPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse());
        }
    }
}
