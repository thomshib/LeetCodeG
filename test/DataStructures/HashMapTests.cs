using System;
using Xunit;
using source.datastructures;
using System.Text;

namespace test
{
    public class GraphTraversalTests
    {
        [Fact]
        public void HashMapBasicTests(){

            var map = new source.datastructures.HashMap();
            map.Put(1,"Cat");
            map.Put(56,"dogs");

            var expectedResult = "dogs";

            var result = map.Get(56);

            Assert.Equal(expectedResult,result);


        }

    }

}