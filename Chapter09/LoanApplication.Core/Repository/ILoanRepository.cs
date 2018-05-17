using LoanApplication.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core.Repository
{
    public interface ILoanRepository
    {
        LoanType LoanType { get; set; }
        float Rate { get; set; }
        List<LoanType> GetLoanTypes();
        List<Loan> GetCarLoans();
        List<Person> GetCarLoanDefaulters(int year);
        List<Loan> GetBadCarLoans();
    }
}

