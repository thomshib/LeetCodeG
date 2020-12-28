using System;
using System.Collections;
using System.Collections.Generic;


namespace source.datastructures
{

    public class HashMap{

        private int?[]  slots;
        private string?[] data;
        const int SIZE = 11;

        public HashMap()
        {
            slots = new int?[SIZE];

            data = new string?[SIZE];
        }


        public void Put(int key , string value){
            var hashValue = HashFunction(key, slots.Length);

            if(slots[hashValue] == null){
                slots[hashValue] = key;
                data[hashValue] = value;
                
            }else{
                
                    if(slots[hashValue] == key){
                        //replace
                        data[hashValue] = value;    
                    }else{
                        //collision
                        var nextSlot = Rehash(hashValue, slots.Length);
                        while(slots[nextSlot] != null && slots[nextSlot] != key){
                            nextSlot = Rehash(nextSlot,slots.Length);
                        }

                        if(slots[nextSlot] == null){
                            slots[nextSlot] = key;
                            data[nextSlot] = value;
                        }else{
                            //replace
                            data[nextSlot] = value;
                        }

                    }
            }

        }

       
       
       public string? Get(int key){
           var startSlot = HashFunction(key, slots.Length);
           var position = startSlot;
           string? value = null;

           while(slots[position]   != null){
               if(slots[position] == key){
                   value =  data[position];
                   break;
               }else{
                   position = Rehash(position,slots.Length);
                   if(position == startSlot){
                       break;
                   }
               }
           }

           return value;
       }
       
       
        private int HashFunction(int key, int size){
            return key % size;
        }

        private int Rehash(int oldHash,int size){
            return (oldHash + 1) % size;
        }


    }
}