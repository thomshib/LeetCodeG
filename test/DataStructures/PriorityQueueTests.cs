using System;
using Xunit;
using source.datastructures.heap;
using System.Text;

namespace test
{
    public class PriorityQueueTests
    {
        [Fact]
        public void PQshouldReturnValuesInMinOrder(){

            PriorityQueue<int,int> queue = new PriorityQueue<int, int>();

            string expectedResult = "0 1 2 3 4 5 6 7 8 9 ";

            for(int i =0; i <10; i++){
                queue.Enqueue(i ,  i /2);
            }
            
            string result = String.Empty;
            while(!queue.IsEmpty()){
                result += queue.Dequeue() + " ";
            }

            Assert.Equal(expectedResult, result);
        }

    }

}