using System;
using System.Collections;
using System.Collections.Generic;


namespace source.datastructures.graph
{

  public class Vertex<T>{

        private T value;
        private  Dictionary<Vertex<T>,double> connectedTo;
    
        public Vertex(T key)
        {
            this.value = key;
            connectedTo  =  new Dictionary<Vertex<T>, double>();
        }

        public Dictionary<Vertex<T>,double>.KeyCollection GetConnections(){
            return connectedTo.Keys;
        }

        public void AddNeighbor(Vertex<T> nbr, double weight=0){
            
            if(!connectedTo.ContainsKey(nbr)){
                connectedTo.Add(nbr,0);
            }
            connectedTo[nbr] = weight;
        }

        public double GetWeight(Vertex<T> nbr){
            return connectedTo[nbr];
        }

        public T Value{
            get{ return value;}
            set{ this.value = value;}
        }



    }


}

