using LoanApplication.Core.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Tests.Unit
{
    public class LoanDTOData : IEnumerable<object[]>
    {
        private IEnumerable<object[]> data => new[]
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
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<object[]> GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }
}
