using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class KnapsackTests
    {
        [Fact]
        public void KnapSackRecusiveResultsInMaxProfit(){

            int[] weights = new int[]{1,2,3};
            int[] profits = new int[]{15,20,50};
            int capacity = 5;

            var result = KnapSackSolution.solveKnapsack(profits,weights,capacity);

            Assert.Equal(80,result);

        }

        [Fact]
        public void KnapSackDynamicProgrammingResultsInMaxProfit(){

            int[] weights = new int[]{1,2,3};
            int[] profits = new int[]{15,20,50};
            int capacity = 5;

            var result = KnapSackSolution.solveKnapsack(profits,weights,capacity);

            Assert.Equal(80,result);

        }
    }

}