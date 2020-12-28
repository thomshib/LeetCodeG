using System;
using System.Collections;
using System.Collections.Generic;

/*




*/
namespace source
{
    public class Permutations{

        public static List<List<int>> findPermutations(int[] nums) {

            List<List<int>> result = new List<List<int>>();
            Queue<List<int>> queue = new Queue<List<int>>();
            queue.Enqueue(new List<int>());
            foreach(var currentNumber in nums){

                int N =  queue.Count;

                for(int i =0; i < N; i++){

                    var oldPermutation = queue.Dequeue();
                    for(int j =0; j <= oldPermutation.Count; j++){
                        var newPermutation = new List<int>(oldPermutation);
                        newPermutation.Insert(j,currentNumber);

                        if(newPermutation.Count == nums.Length){
                            result.Add( newPermutation);
                        }else{
                            queue.Enqueue(newPermutation);
                        }
                    }
                }
            }

            return result;
        }
    
    
    //https://leetcode.com/explore/featured/card/google/59/array-and-strings/3050/

        public static void NextPermutation(int[] nums) {

            if(nums == null) return;
            if(nums.Length == 0 ) return;
            int N = nums.Length;

            int reverseIndex = N-2;
            
            //breaks descending order N > N + 1
            while(reverseIndex >=0 && nums[reverseIndex] >= nums[reverseIndex + 1] ){
                reverseIndex--;
            }

            if(reverseIndex >=0){
                int indexRightMosElement = N - 1;
                //find righmost element greater than reverseIndex
                while(nums[indexRightMosElement] <= nums[reverseIndex]){
                    indexRightMosElement--;
                }
                Swap(nums,indexRightMosElement, reverseIndex);
                Reverse(nums, reverseIndex + 1, N-1);
            }else{
                Reverse(nums,0, N - 1);
            }
        
        }

        private static void Reverse(int[] nums, int start, int end)
        {
            while(start < end){
                Swap(nums,start++,end--);
            }
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}

