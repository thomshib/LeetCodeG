using System;
using System.Collections.Generic;
using System.Linq;

namespace source.datastructures.heap
{

public enum HeapType{
    Min,
    Max
}


public class Heap<T> where T: IComparable{
    List<T> elements;
    HeapType _type;

    public Heap(HeapType value)
    {
        this._type = value ;
        this.elements = new List<T>();

    }

    public int GetSize(){
        return elements.Count;
    }

    public bool IsEmpty(){
        return elements.Count == 0;
    }

    public void Add(T item){
        elements.Add(item);
        this.BubbleUp(elements.Count - 1);
    }

    public T Pop(){
        if(!IsEmpty()){
            var item = elements[0];
            Swap(0, elements.Count - 1);
            elements.RemoveAt(elements.Count - 1);
            this.BubbleDown(0);
            return item;
        }

        throw new ArgumentException("No elements in Heap");
    }

        private void BubbleDown(int index)
        {
            var smallest = index;
            var right = GetRight(index);
            var left = GetLeft(index);

            if(left < elements.Count && LessOrMore(index, left)){
                smallest = left;
            }

             if(right <= elements.Count && LessOrMore(index, right)){
                smallest = right;
            }

            if(smallest != index){
                Swap(smallest,index);
                this.BubbleDown(smallest);
            }
        }

        private int GetLeft(int index)
        {
            return (index * 2) + 1; 
        }

        private int GetRight(int index)
        {
           return (index * 2) + 2; 
        }

        private void BubbleUp(int index)
        {
            int parent = this.GetParent(index);

            if(parent >=0 && LessOrMore(parent,index)){
                Swap(parent,index);
                this.BubbleUp(parent);
            }
        }

        private void Swap(int parent, int child)
        {
            var temp = elements[parent];
            elements[parent] = elements[child];
            elements[child] = temp;
        }

        private bool LessOrMore(int i, int j)
        {
            if(_type == HeapType.Max) return elements[i].CompareTo(elements[j]) < 0;
            else 
                return elements[i].CompareTo(elements[j]) > 0;
        }

        private int GetParent(int index)
        {
            if(index <=0 ) return -1;
            return (index - 1) / 2;
        }
    }

}


