using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            var strOperations = new StringOperations();

            var result = strOperations.ConcatenateStrings("Hello", "World");

            Assert.Equal("Hello World", result);
        }
    }
}
