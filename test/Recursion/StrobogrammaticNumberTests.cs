using System;
using Xunit;
using source;
using System.Text;
using System.Collections.Generic;
using test.utility;

namespace test
{
    public class StrobogrammaticNumberTests
    {
        [Fact]
        public void shouldreturnvalidresultfoRecursiveMethod()
        {
            List<string> expectedResult = new List<string>(){
                "1001",
                "6009",
                "8008",
                "9006",
                "1111",
                "6119",
                "8118",
                "9116",
                "1691",
                "6699",
                "8698",
                "9696",
                "1881",
                "6889",
                "8888",
                "9886",
                "1961",
                "6969",
                "8968",
                "9966"

                //1001, 1111, 1691, 1881, 1961, 6009, 6119, 6699, 6889, 6969, 8008, 8118, 8698, 8888, 8968, 9006, 9116, 9696, 9886, 9966,
            };

            var result  = new StrobogrammaticNumber().findStrobogrammatic(4);

            var IsEqual = CollectionEquivalence.AreEqual(result,expectedResult);

            Assert.True(IsEqual);
        }


        [Fact]
        public void shouldreturnvalidresultforIterativeMethod()
        {
            List<string> expectedResult = new List<string>(){
                "1001",
                "6009",
                "8008",
                "9006",
                "1111",
                "6119",
                "8118",
                "9116",
                "1691",
                "6699",
                "8698",
                "9696",
                "1881",
                "6889",
                "8888",
                "9886",
                "1961",
                "6969",
                "8968",
                "9966"

                //1001, 1111, 1691, 1881, 1961, 6009, 6119, 6699, 6889, 6969, 8008, 8118, 8698, 8888, 8968, 9006, 9116, 9696, 9886, 9966,
            };

            var result  = new StrobogrammaticNumber().findStrobogrammaticIterative(4);

            var IsEqual = CollectionEquivalence.AreEqual(result,expectedResult);

            Assert.Equal(expectedResult,result);
        }
    }

}