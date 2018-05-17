using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class DbContext : IDbContext
    {
        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Loan> Loan { get; set; }
        public List<CarLoan> CarLoan { get; set; }
        public List<HouseLoan> HouseLoan { get; set; }
    }
}
