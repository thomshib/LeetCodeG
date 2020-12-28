using System;

/*

https://runestone.academy/runestone/books/published/pythonds/SortSearch/TheBinarySearch.html


*/
namespace source
{

public class BinarySearchSolution{

    public  static bool binarySearch(int[] input, int item) {

        int start = 0;
        int end = input.Length - 1;

        while(start <= end){
            int mid = start + (end - start) / 2;

            if(input[mid] == item) return true;
            else if ( item > input[mid]){
                start = mid + 1;
            }else{
                end = mid - 1 ;
            }
        }

        return false;

    }


}

}