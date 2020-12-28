
using System;
using Xunit;
using source;
using System.Text;
using System.Collections.Generic;
using test.utility;

namespace test
{
    
        

public class WordSearchTests{
        [Fact]
        public void shouldreturnvalidresultforMethod()
        {

            char[][] board = new char[][]{
                new char[]{'o','a','a','n'},
                new char[]{'e','t','a','e'},
                new char[]{'i','h','k','r'},
                new char[]{'i','f','l','v'}
            };

            string[] words = new string[]{"oath","pea","eat","rain"};

            var exptectedResult = new List<string>{"oath","eat"};

            var result = new WordSearchSolution().FindWords(board,words);

            //var IsTrue = CollectionEquivalence.AreEqual(exptectedResult,result);


            Assert.Equal(exptectedResult,result);



        }

}

}