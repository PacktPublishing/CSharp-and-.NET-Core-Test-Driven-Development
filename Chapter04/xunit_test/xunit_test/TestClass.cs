using LoanApplication.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace xunit_test
{
    public class TestClass
    {
        private LoanRepository loanRepository;

        public TestClass()
        {
            loanRepository = new LoanRepository();
        }
        [Fact]
        public void Test_CheckPasswordLength_ShouldReturnTrue()
        {
            string password = "civic";
            bool isValid = false;
            if (password.Length >= 10)
                isValid = true;
            Assert.True(isValid);
        }

        [Fact]
        public void Test_CompareTwoStrings_ShouldReturnTrue()
        {
            string input = "civic";
            string reversed =  new string(input.Reverse().ToArray());
            Assert.Equal(reversed, input);
        }

        [Fact]
        public void Test_DeleteLoan_ShouldReturnNull()
        {
            loanRepository.ArchiveLoan(12);
            loanRepository.DeleteLoan(12);
            var loan = loanRepository.GetById(12);
            Assert.Null(loan);
        }
    }
}

