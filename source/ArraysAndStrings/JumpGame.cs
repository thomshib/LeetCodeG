
using System;

/*

https://leetcode.com/problems/jump-game/solution/


*/
namespace source
{
    
    enum Index{
        
        UNKNOWN,
        GOOD,
        BAD
     
    }

public class JumpGame{

    static Index[] memo;
    public static  bool canJump(int[] nums) {

        // basic recursion
        //return canJumpFromPosition(0, nums);

        //recursion with memoization
        // memo = new Index[nums.Length];
        // memo[memo.Length - 1] = Index.GOOD;
        // return canJumpFromPositionWithMemoization(0,nums);

        //bottom up dynamic programming

        // memo = new Index[nums.Length];
        // memo[nums.Length - 1] = Index.GOOD;

        // for(int i = nums.Length - 2; i >=0; i--){
        //     int furthestJump = Math.Min(i + nums[i], nums.Length - 1);
        //     for(int j = i + 1; j <= furthestJump; j++){
        //         if(memo[j] == Index.GOOD){
        //             memo[i] = Index.GOOD;
        //             break;
        //         }

        //     }
        // }

        // return memo[0] == Index.GOOD;

        


        //Greedy

        int leftmostGoodPosition = nums.Length - 1;

        for(int i = nums.Length - 1; i >= 0; i--){
            if( i + nums[i] >= leftmostGoodPosition){
                leftmostGoodPosition = i;
            }
        }

        return leftmostGoodPosition == 0;



    }

        private static bool canJumpFromPosition(int position, int[] nums)
        {
            //backtracking

            //base case
            if(position == nums.Length - 1) return true;

            int furthestJump = Math.Min(position + nums[position], nums.Length - 1);

            for(int nextPosition = position + 1; nextPosition <= furthestJump; nextPosition++){
                if(canJumpFromPosition(nextPosition, nums)){
                    return true;
                }
            }

            //backtrack
            return false;

        }


         private static bool canJumpFromPositionWithMemoization(int position, int[] nums){

             if(memo[position] != Index.UNKNOWN){
                 return memo[position] == Index.GOOD ? true : false;
             }

             int furthestJump = Math.Min(position + nums[position], nums.Length - 1);

            for(int nextPosition = position + 1; nextPosition <= furthestJump; nextPosition++){

                if(canJumpFromPositionWithMemoization(nextPosition, nums)){
                    memo[nextPosition] = Index.GOOD;
                    return true;
                }
            }

            memo[position] = Index.BAD;
            return false;

         }
    }


}