using source.datastructures.heap;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*




*/
namespace source
{

public class ListNode {
    public int val;
     public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
    public class MergeKSortedListsSolution{
        public ListNode MergeKLists(ListNode[] lists) {
            
            if(lists == null) return null;
            if(lists.Length == 1) return lists[0];

            PriorityQueue<ListNode,int> queue = new PriorityQueue<ListNode, int>();
            foreach(var item in lists){
                queue.Enqueue(item, item.val);
            }

            ListNode head = new ListNode(0);
            ListNode point = head;

            while(!queue.IsEmpty()){
                var currentNode = queue.Dequeue();
                point.next = currentNode;
                point = point.next;
                var node = currentNode.next;
                if(node != null){
                    queue.Enqueue(node, node.val);
                }
            }

            return  head.next;
        }
    }
}