using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Core.DTO
{
    public class LoanDTO
    {

        public LoanType LoanType { get; set; }
        public LocationType LocationType { get; set; }
        public JobType JobType { get; set; }
    }

    public enum LoanType
    {
        CarLoan, HouseLoan
    }

    public enum LocationType
    {
        Location1, Location2, Location3
    }

    public enum JobType
    {
        Professional, Artisan
    }

}
