using System;
using Xunit;
using source;
using System.Text;
using System.Collections.Generic;
using test.utility;

namespace test
{
    public class WordSquareTests
    {
        [Fact]
        public void shouldreturnvalidresultfoBasicMethod()
        {

            string[] words = new string[]{"ball","wall","area","lead","lady"};
            List<List<string>> expectedResult = new List<List<string>>(){
                new List<string>{"wall",
                                "area",
                                "lead",
                                "lady"},
                new List<string>{"ball",
                                "area",
                                "lead",
                                "lady"}
            };

            var result = new WordSquaresSolution().WordSquares(words);
            var isTrue = CollectionEquivalence.AreEqual(expectedResult, result);
            Assert.True(isTrue);

        }


         [Fact]
        public void shouldreturnvalidresultfoTrieMethod()
        {

            string[] words = new string[]{"ball","wall","area","lead","lady"};
            List<List<string>> expectedResult = new List<List<string>>(){
                new List<string>{"wall",
                                "area",
                                "lead",
                                "lady"},
                new List<string>{"ball",
                                "area",
                                "lead",
                                "lady"}
            };

            var result = new WordSquaresTrieSolution().WordSquares(words);
            var isTrue = CollectionEquivalence.AreEqual(expectedResult, result);
            Assert.True(isTrue);

        }

    }
}



