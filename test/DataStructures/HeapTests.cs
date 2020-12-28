using System;
using Xunit;
using source.datastructures.heap;
using System.Text;

namespace test
{
    public class HeapTests
    {
        [Fact]
        public void MinHeapBasicTests(){

            var minHeap = new Heap<int>(HeapType.Min);
            minHeap.Add(5);
            minHeap.Add(7);
            minHeap.Add(3);
            minHeap.Add(11);

            var result = minHeap.Pop();

            Assert.Equal(3, result);
        }

    }

}
