using System;

/*

https://runestone.academy/runestone/books/published/pythonds/SortSearch/TheShellSort.html


*/
namespace source
{

public class ShellSortSolution{


    public  static void ShellSort(int[] input) {
        int N = input.Length;
        int subListLength = N / 2;

        while(subListLength > 0){

           for(int index = 0; index < subListLength; index++){
               InsertionSort(input, index, subListLength);
           }

            subListLength = subListLength / 2;
        }

    }

    private  static void InsertionSort(int[] input,int start, int gap) {

      int N = input.Length;

        for(int index = start; index < N; index = index + gap){

            int currentValue = input[index];
            var position = index;

            while(position >= gap && input[position-gap] > currentValue){
                input[position] = input[position - gap];
                position = position - gap;
            }

            input[position] = currentValue;


        }


    }
}
}