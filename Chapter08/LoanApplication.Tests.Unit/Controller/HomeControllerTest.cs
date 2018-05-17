using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using LoanApplication.Controllers;
using LoanApplication.Core;
using Xunit;
using LoanApplication.Core.Model;

namespace LoanApplication.Tests.Unit.Controller
{
    public class HomeControllerTest
    {
      
        [Fact]
        public void TestMethod1()
        {
            Assert.Equal(8, (4 * 2));
        }


        [Theory,
        InlineData("name"),
        InlineData("word")]
        public void TestMethod2(string value)
        {
            Assert.Equal(4,value.Length);
        }


        [Fact]
        public void Assertions()
        {

            Assert.Equal(8 , (4*2));
            Assert.NotEqual(6, (4 * 2));

            List<string> list = new List<String> { "Rick", "John" };
            Assert.Contains("John", list);
            Assert.DoesNotContain("Dani", list);

            Assert.Empty(new List<String>());
            Assert.NotEmpty(list);

            Assert.False(false);
            Assert.True(true);

            Assert.NotNull(list);
            Assert.Null(null);            

        }

        
    }
}