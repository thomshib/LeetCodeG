using System;

/*

https://runestone.academy/runestone/books/published/pythonds/SortSearch/TheInsertionSort.html


*/
namespace source
{

public class InsertionSortSolution{

    public  static void InsertionSort(int[] input) {

        int N = input.Length;

        for(int index = 1; index < N; index++){
            var position = index;
            var currentValue = input[index];
            while(position > 0 && input[position - 1] > currentValue){
                input[position] = input[position - 1];
                position = position - 1;
            }
    
            input[position] = currentValue;
        }


    }
}
}