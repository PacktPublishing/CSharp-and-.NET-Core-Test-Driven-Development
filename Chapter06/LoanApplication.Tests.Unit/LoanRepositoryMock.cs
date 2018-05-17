using LoanApplication.Core;
using LoanApplication.Core.Model;
using LoanApplication.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Tests.Unit
{
    public class LoanRepositoryMock : ILoanRepository
    {
        LoanType ILoanRepository.LoanType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        float ILoanRepository.Rate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<Loan> GetCarLoans()
        {
            List<Loan> loans = new List<Loan>
                {
                new Loan{Amount = 120000, Rate = 12.5, ServiceYear = 5,
                HasDefaulted = false },
                new Loan {Amount = 150000, Rate = 12.5, ServiceYear = 4,
                HasDefaulted = true },
                new Loan { Amount = 200000, Rate = 12.5, ServiceYear = 5,
                HasDefaulted = false }
                };
            return loans;
        }


        List<LoanType> ILoanRepository.GetLoanTypes()
        {
            throw new NotImplementedException();
        }

        List<Loan> ILoanRepository.GetCarLoans()
        {
            throw new NotImplementedException();
        }

        List<Person> ILoanRepository.GetCarLoanDefaulters(int year)
        {
            throw new NotImplementedException();
        }

        List<Loan> ILoanRepository.GetBadCarLoans()
        {
            throw new NotImplementedException();
        }
    }
}
