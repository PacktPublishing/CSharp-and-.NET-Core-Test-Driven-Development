using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core
{
    public class AuthenticationManager
    {
        private IDbContext dbContext;

        public AuthenticationManager(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
