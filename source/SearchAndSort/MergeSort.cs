using System;

/*

https://runestone.academy/runestone/books/published/pythonds/SortSearch/TheInsertionSort.html


*/
namespace source
{

public class MergeSortSolution{

    public  static void MergeSort(int[] input) {

        if(input.Length > 1){

            int mid = input.Length / 2;
            var leftHalf = input[0..mid];
            var rightHalf = input[mid..];
    
            MergeSort(leftHalf);
            MergeSort(rightHalf);

            int i = 0;
            int j = 0;
            int k = 0;

            while(i < leftHalf.Length && j < rightHalf.Length){
                if(leftHalf[i] <= rightHalf[j]){
                    input[k] = leftHalf[i];
                    i++;
                    k++;    
                }else{
                    input[k] = rightHalf[j];
                    j++;
                    k++;
                }
            }

            while(i < leftHalf.Length){
                input[k] = leftHalf[i];
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

}