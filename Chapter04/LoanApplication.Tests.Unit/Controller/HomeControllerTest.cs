using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using LoanApplication.Controllers;
using LoanApplication.Core.Repository;
using Xunit;
using LoanApplication.Core.Model;

namespace LoanApplication.Tests.Unit.Controller
{
    public class HomeControllerTest
    {
            private Mock<ILoanRepository> loanRepository;
            private HomeController homeController;
            public HomeControllerTest()
            {
                loanRepository = new Mock<ILoanRepository>();
                loanRepository.Setup(x =>x.GetLoanTypes()).Returns(GetLoanTypes());
                homeController = new HomeController(loanRepository.Object);
            }
            [Fact]
            public void TestIndex()
            {
                var result = homeController.Index();
                var viewResult = Assert.IsType<ViewResult>(result);
                var loanTypes =
                Assert.IsAssignableFrom<IEnumerable<LoanType>>(viewResult.ViewData["LoanTypes"]);
                Assert.Equal(2, loanTypes.Count());
            }
            private List<LoanType> GetLoanTypes()
            {
                var loanTypes = new List<LoanType>();
                loanTypes.Add(new LoanType()
                {
                    Id = 1,
                    Name = "Car Loan"
                });
                loanTypes.Add(new LoanType()
                {
                    Id = 2,
                    Name = "House Loan"
                });
                return loanTypes;
            }
        }
    }