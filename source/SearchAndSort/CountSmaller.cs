using System;
using System.Collections.Generic;

/*

https://runestone.academy/runestone/books/published/pythonds/SortSearch/TheInsertionSort.html
    https://leetcode.com/explore/featured/card/google/63/sorting-and-searching-4/3083/

                            https://leetcode.com/explore/featured/card/google/63/sorting-and-searching-4/3083/discuss/76584/Mergesort-solution


*/
namespace source
{

public class CountSmallerSolution{


    public List<int> countSmaller(int[] nums) {

        
        List<int> result = new List<int>();
        int N = nums.Length;
        if(N==0) return result;

        Pair[] pairList = new Pair[N];

        for(int i = 0; i < N; i++){
            pairList[i] = new Pair(i,nums[i]);
        }

        int[] smaller = new int[N];

        MergeSort(pairList, smaller);

        return new List<int>(smaller);

    }

    private void MergeSort(Pair[] input, int[] smaller){

        if(input.Length > 1){

            int mid = input.Length / 2;
            var leftHalf = input[0..mid];
            var rightHalf = input[mid..];
            MergeSort(leftHalf, smaller);
            MergeSort(rightHalf,smaller);

            int i = 0; 
            int j = 0;
            int k = 0;
            int rightCount = 0;

            while( i < leftHalf.Length && j < rightHalf.Length){

                /*
                    Each time we choose a left to the merged array. 
                    We want to know how many numbers from array right are moved before this number.

                    index: 0, 1, 2
                    left: 4, 5, 6
                    right: 1, 2, 3
                    when we take 4 for merge sort. We add j (j == 3) because we already take j numbers before take this 4.

                */

                if(leftHalf[i].value < rightHalf[j].value){
                    input[k] = leftHalf[i];
                    smaller[leftHalf[i].index] += rightCount;
                    i++;
                }else{
                    input[k] = rightHalf[j];
                    j++;
                    rightCount++;
                }
                k++;

            }

            while(i < leftHalf.Length){
                input[k] = leftHalf[i];
                smaller[leftHalf[i].index] += rightCount;
                i++;
                k++;
            }

             while(j < rightHalf.Length){
                input[k] = rightHalf[j];
                j++;
                k++;
            }

        }

    }

}

public class Pair{
    public int index;
    public int value;

    public Pair(int index, int val){
        this.index  = index;
        this.value = val;
    }
}

}