using System;
using System.Collections.Generic;
using System.Linq;

namespace source.datastructures.heap
{

   public class PriorityQueue<TValue> : PriorityQueue<TValue, int>{}

    public class PriorityQueue<TValue, TPriority> where TPriority:IComparable
    {
        SortedDictionary<TPriority,Queue<TValue>> dict = new SortedDictionary<TPriority, Queue<TValue>>();
        private int count;

        public void Enqueue(TValue val){
            Enqueue(val, default(TPriority));
        } 

         public void Enqueue(TValue val, TPriority priority){
            if(!dict.ContainsKey(priority)){
                dict.Add(priority, new Queue<TValue>());
            }
            dict[priority].Enqueue(val);    
           
            count++;
        } 

        public TValue Dequeue()
        {
            var item = dict.First();
            if(item.Value.Count == 1){
                dict.Remove(item.Key);
            }
            count--;
            return item.Value.Dequeue();    


        }

        

        public bool IsEmpty(){
            return count == 0;  
        }
    
    }       
}