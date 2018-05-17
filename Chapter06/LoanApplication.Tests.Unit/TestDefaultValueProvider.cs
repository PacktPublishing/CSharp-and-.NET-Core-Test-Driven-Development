using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanApplication.Tests.Unit
{
    public class TestDefaultValueProvider :LookupOrFallbackDefaultValueProvider
    {
        public TestDefaultValueProvider()
        {
            base.Register(typeof(string), (type, mock) => string.Empty);
            base.Register(typeof(List<>), (type, mock) =>
            Activator.CreateInstance(type));
        }
    }
}
