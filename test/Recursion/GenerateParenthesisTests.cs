
using System;
using Xunit;
using source;
using System.Text;
using System.Collections.Generic;

namespace test
{

  public class GenerateParenthesisTests
    {
        [Fact]
        public void shouldreturnValidBrackets(){

            List<string> expectedResult = new List<string>(){"((()))","(()())","(())()","()(())","()()()"};

            var result = new GenerateParenthesisSolution().GenerateParenthesis(3);

            Assert.Equal(expectedResult,result);
        }



    }

}