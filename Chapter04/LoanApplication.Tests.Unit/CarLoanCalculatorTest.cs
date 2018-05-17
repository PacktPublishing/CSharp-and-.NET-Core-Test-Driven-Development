using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoanApplication.Core;
using LoanApplication.Core.DTO;
using Xunit;
using Xunit.Extensions;

namespace LoanApplication.Tests.Unit
{
    public class CarLoanCalculatorTest
    {
        private CarLoanCalculator carLoanCalculator;

        public CarLoanCalculatorTest()
        {
            RateParser rateParser = new RateParser();
            this.carLoanCalculator = new CarLoanCalculator();
        }

        [Theory, ClassData(typeof(LoanDTOData))]
        public void Test_CalculateLoan_ShouldReturnCorrectRate(LoanDTO loanDTO)
        {
            Loan loan = carLoanCalculator.CalculateLoan(loanDTO);
            Assert.NotNull(loan);
            Assert.InRange(loan.InterestRate, 8, 12);
        }

        [Theory, MemberData(nameof(GetLoanDTOs), parameters: 2, MemberType = typeof(DataClass))]
        public void Test_CalculateLoan_ShouldReturnCorrectRate3(LoanDTO loanDTO)
        {
            Loan loan = carLoanCalculator.CalculateLoan(loanDTO);
            Assert.NotNull(loan);
            Assert.InRange(loan.InterestRate, 8, 12);
        }
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
                    },
                    new object[]
                    {
                        new LoanDTO
                        {
                            LoanType = LoanType.CarLoan,
                            JobType = JobType.Artisan,
                            LocationType = LocationType.Location3
                        }
                    }
                };
                return loanDTOs.TakeLast(records);
            }
        }

        public bool IsWordPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse());
        }
        public static IEnumerable<object[]> LoanDTOs
        {
            get
            {
                yield return new object[]
                {
                    new LoanDTO
                    {
                        LoanType = LoanType.CarLoan,
                        JobType = JobType.Professional,
                        LocationType = LocationType.Location1
                    }
                };

                yield return new object[]
                {
                    new LoanDTO
                    {
                        LoanType = LoanType.CarLoan,
                        JobType = JobType.Professional,
                        LocationType = LocationType.Location2
                    }
                };


                yield return new object[]
                {
                    new LoanDTO
                    {
                        LoanType = LoanType.CarLoan,
                        JobType = JobType.Artisan,
                        LocationType = LocationType.Location3
                    }
                };
            }
        }


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
                },
                new object[]
                {
                    new LoanDTO
                    {
                        LoanType = LoanType.CarLoan,
                        JobType = JobType.Artisan,
                        LocationType = LocationType.Location3
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

        public static IEnumerable<object[]> GetLoanDTOs()
        {
            yield return new object[]
            {
                new LoanDTO
                {
                    LoanType = LoanType.CarLoan,
                    JobType = JobType.Professional,
                    LocationType = LocationType.Location1
                }
            };

            yield return new object[]
            {
                new LoanDTO
                {
                    LoanType = LoanType.CarLoan,
                    JobType = JobType.Professional,
                    LocationType = LocationType.Location2
                }
            };


            yield return new object[]
            {
                new LoanDTO
                {
                    LoanType = LoanType.CarLoan,
                    JobType = JobType.Artisan,
                    LocationType = LocationType.Location3
                }
            };
        }



        public class Loan
        {
            public int InterestRate { get; set; }
        }

        [Fact]
        public void Test_CalculateLoan_ShouldReturnCorrectRate1()
        {
            // first scenario
            LoanDTO loanDTO1 = new LoanDTO();
            loanDTO1.LoanType = LoanType.CarLoan;
            loanDTO1.LocationType = LocationType.Location1;
            loanDTO1.JobType = JobType.Professional;
            Loan loan1 = carLoanCalculator.CalculateLoan(loanDTO1);

            Assert.NotNull(loan1);
            Assert.Equal(8, loan1.InterestRate);


            // second scenario
            LoanDTO loanDTO2 = new LoanDTO();
            loanDTO2.LoanType = LoanType.CarLoan;
            loanDTO2.LocationType = LocationType.Location2;
            loanDTO2.JobType = JobType.Professional;
            Loan loan2 = carLoanCalculator.CalculateLoan(loanDTO2);

            Assert.NotNull(loan2);
            Assert.Equal(10, loan2.InterestRate);

            // third scenario
            LoanDTO loanDTO3 = new LoanDTO();
            loanDTO3.LoanType = LoanType.CarLoan;
            loanDTO3.LocationType = LocationType.Location3;
            loanDTO3.JobType = JobType.Artisan;
            Loan loan3 = carLoanCalculator.CalculateLoan(loanDTO3);

            Assert.NotNull(loan3);
            Assert.Equal(9.5, loan3.InterestRate);
        }

    }

    public class CarLoanCalculator
    {
        public CarLoanCalculatorTest.Loan CalculateLoan(LoanDTO loanDTO)
        {
            return null;
        }
    }
}






