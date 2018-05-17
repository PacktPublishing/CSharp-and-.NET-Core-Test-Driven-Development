using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public interface IDbContext
    {
        int SaveChanges();
        void Dispose();
    }
}
