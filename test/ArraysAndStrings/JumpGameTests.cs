using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class JumpGameTests
    {
        [Fact]
        public void JumpGameResultsInTrue(){

            var input = new int[]{2,3,1,1,4};

            var result = JumpGame.canJump(input);

            Assert.True(result);
        }

        [Fact]
        public void JumpGameResultsInFalse(){

            var input = new int[]{3,2,1,0,4};

            var result = JumpGame.canJump(input);

            Assert.False(result);
        }

    }

}