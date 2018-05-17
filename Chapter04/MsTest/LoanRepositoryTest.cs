using LoanApplication.Core.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTest
{
    [TestClass]
    public class LoanRepositoryTest
    {
        private LoanRepository loanRepository;
        public LoanRepositoryTest()
        {
            loanRepository = new LoanRepository();
        }


        [TestMethod]
        public void Test_GetLoanById_ShouldReturnLoan()
        {
            var loan = loanRepository.GetLoanById(12);
            Assert.IsNotNull(loan);
        }
    }

}