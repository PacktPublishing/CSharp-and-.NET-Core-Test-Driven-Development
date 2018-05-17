using LoanApplication.Core.Model;
using LoanApplication.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanApplication.Core
{
    public class LoanService
    {
        private ILoanRepository loanRepository;

        public LoanService(ILoanRepository loanRepository)
        {
            this.loanRepository = loanRepository;
        }
        public List<Loan> GetBadCarLoans()
        {
            List<Loan> badLoans = loanRepository.GetBadCarLoans();
            return badLoans;
        }


        public List<Loan> GetBadCarLoans(List<Loan> carLoans)
        {
            List<Loan> badLoans = new List<Loan>();
            //do business logic computations on the loans
            return badLoans;
        }

        public List<Person> GetOlderCarLoanDefaulters(int year)
        {
            List<Person> defaulters =
            loanRepository.GetCarLoanDefaulters(year);
            var filteredDefaulters = defaulters.Where(x => x.Age >
            20).ToList();
            return filteredDefaulters;
        }
    }
}

