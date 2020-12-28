using System;
using Xunit;
using source;
using System.Text;
using source.datastructures.tree;

namespace test
{
    public class ParseTreeTests
    {
        [Fact]
        public void ParseTreeTestsSuccess(){
                
            string input = "(,3,+,(,4,*,5,),)";
            var tree = ParseTree.BuildParseTree(input);
            var result = new PreOrderTraversal().Traversal(tree);
            Assert.Equal("+,3,*,4,5,",result);
        }
    }

}