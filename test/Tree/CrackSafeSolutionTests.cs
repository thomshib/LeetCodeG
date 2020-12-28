using System;
using Xunit;
using source;
using System.Text;
using System.Collections.Generic;

namespace test
{

  public class CrackSafeSolutionTests
    {
        [Fact]
        public void shouldreturnValidResult(){
            int n = 2;
            int k = 2;
            string expectedResult = "01100";

            var result = new CrackSafeSolution().CrackSafe(n,k);
            Assert.Equal(expectedResult, result);
        }
    }

}

