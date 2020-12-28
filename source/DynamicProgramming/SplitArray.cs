using System;
using System.Collections.Generic;


/*
https://leetcode.com/problems/split-array-largest-sum/solution/
https://leetcode.com/problems/split-array-largest-sum/discuss/89819/C%2B%2B-Fast-Very-clear-explanation-Clean-Code-Solution-with-Greedy-Algorithm-and-Binary-Search

https://shirleyisnotageek.blogspot.com/2016/10/split-array-largest-sum.html

*/

namespace source
{

    public class SplitArraySoluton{

         public int SplitArray(int[] nums, int m) {

            /*
                nums = [7,2,5,10,8]
                
                If m equals length of the array, the largest sum should be the maximum among the elements. 
                i.e. if m = 5 then the largest sum is 10
                
                If m equals 1, then 
                it should be the sum of all elements in the array. Now the maximum sum of a subarray should be 
                between these two numbers.
                i.e if m = 1, then the largest sum = 32

                so interval for binary search is [10, 32]

                Approach ----

                First we choose the mid of these two [10, 32]    and find if there exist m subarrays that have 
                largest sum less than or equal to mid. If we can find such split, we know we probably can do better. 
                
                So we set right to mid. We keep on doing this until we find a value that we cannot get by splitting the array 
                to m subarrays, i.e., the number is too small that we need to split the array further more. 
                
                Now we increase left to mid + 1. When left = right, we find the number.


                nums = [7,2,5,10,8] ; m = 2 ; 

                left = 10, right = 32, mid = 21 => [7, 2, 5], [10, 8]

                left = 10, right = 21, mid = 15 => [7, 2], [10, 5],[8]

                left = 16, right = 21, mid = 18 => [7, 2, 5], [10, 8]

                left = 16, right = 18, mid = 17 => [7, 2], [10, 5],[8]

                left = 18, right = 18 => return 18




            */  

            int left = 0;
            int right = 0;
            int N = nums.Length;

            for(int i = 0;  i < N; i++ ){
                 left = Math.Max(left, nums[i]);
                 right += nums[i];
            } 

            while(left < right){

                int mid = left + ( right - left ) / 2;

                if(canSplit(nums, mid, m)){
                    right = mid;
                } else{

                    //too many groups; hence go towards right; right has higher values  
                    left = mid + 1;
                }

            } 

            return left;


        
        }

        private bool canSplit(int[] nums, int maxSum, int cuts)
        {
            int countSubGroup = 1;
            int currentSum = 0;
            foreach(var num in nums){
                currentSum += num;
                if(currentSum > maxSum){
                    // we need to split into more groups 
                    // with num as the first element of the new group

                    currentSum = num;
                    countSubGroup++;

                    //if it exceeds the max cuts; discard this option
                    if(countSubGroup > cuts){
                        return false;
                    }
                }

            }

            return true;    
        }
    }
}