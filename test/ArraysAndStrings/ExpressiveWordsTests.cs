
using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class ExpressiveWordsTests
    {
        [Fact]
        public void shouldreturnvalidresultfoBasicMethod()
        {
            string S = "heeellooo";
            string[] words = new string[]{"hello", "hi", "helo"};

            var result = ExpressiveWordsSolution.ExpressiveWords(S,words);

            Assert.Equal(1, result);

        }

        [Fact]
        public void shouldreturnvalidresultfoEdgeCase   ()
        {
            string S = "heeellooo";
            string[] words = new string[]{"axxxrrzzz"};

            var result = ExpressiveWordsSolution.ExpressiveWords(S,words);

            Assert.Equal(0, result);

        }

    }
}



