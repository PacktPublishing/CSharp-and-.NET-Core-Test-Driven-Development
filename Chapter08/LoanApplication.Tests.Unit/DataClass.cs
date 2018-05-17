using LoanApplication.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanApplication.Tests.Unit
{
    public class DataClass
    {
        public static IEnumerable<object[]> GetLoanDTOs(int records)
        {
            var loanDTOs = new List<object[]>
            {
                new object[]
                {
                new LoanDTO
                {
                LoanType = LoanType.CarLoan,
                JobType = JobType.Professional,
                LocationType = LocationType.Location1
                }
                },
                new object[]
                {
                new LoanDTO
                {
                LoanType = LoanType.CarLoan,
                JobType = JobType.Professional,
                LocationType = LocationType.Location2
                }
            }
            };
            return loanDTOs.TakeLast(records);
        }
    }
}
