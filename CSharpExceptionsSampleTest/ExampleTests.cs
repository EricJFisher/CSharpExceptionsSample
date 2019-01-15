using CSharpExceptionsSample;
using System;
using Xunit;

namespace CSharpExceptionsSampleTest
{
    public class UnitTest1
    {
        [Fact]
        public void ExpectingException()
        {
            var exception = Record.Exception(() => Sample.Payment(0));
            Assert.IsType<ArgumentException>(exception);
        }
    }
}
