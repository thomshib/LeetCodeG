using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class WordLadderTests
    {
        [Fact]
        public void WordLadderResultsInTrue(){
            
            string[] words = new string[]{
                "FOOL",
                "POOL",
                "POLL",
                "POLE",
                "PALE",
                "SALE",
                "SAGE"     
            };

            var result = WordLadderProblem.WordLadder("FOOL","SAGE",words);
            Assert.True(result);



        }

    }

}
