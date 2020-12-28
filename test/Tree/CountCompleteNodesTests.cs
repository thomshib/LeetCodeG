
using System;
using Xunit;
using source;
using System.Text;

namespace test
{

  public class CountCompleteTests
    {
        [Fact]
        public void shouldreturnValidCount(){

            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            root.right = new TreeNode(3);
            root.right.left = new TreeNode(6);

            var result = new CountCompleteNodes().CountNodes(root);
            Assert.Equal(6,result);

        }

}
}