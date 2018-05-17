using LoanApplication.Core.Repository;
using NUnit;
using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture]
    public class LoanRepositoryTest
    {
        private LoanRepository loanRepository;

        [OneTimeSetUp]
        public void SetupTest()
        {
            loanRepository = new LoanRepository();
        }

        [Test]
        public void Test_GetLoanById_ShouldReturnLoan()
        {            
            var loan = loanRepository.GetLoanById(12);
            Assert.IsNotNull(loan);
        }
    }
}
