using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class NumberConversionTests
    {
        [Fact]
        public void NumberConversionFromDecimalToBinaryResultsInSuccess(){

            var result = NumberConversionSolution.ConvertNumber(25,2);
            var expetedResult = "11001";

            Assert.Equal(result,expetedResult);

        }

         [Fact]
        public void NumberConversionFromDecimalToHexaResultsInSuccess(){

            var result = NumberConversionSolution.ConvertNumber(25,16);
            var expetedResult = "19";

            Assert.Equal(result,expetedResult);

        }

    }

}