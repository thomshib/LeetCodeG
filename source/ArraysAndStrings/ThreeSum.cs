using System;
using System.Collections;
using System.Collections.Generic;

/*




*/
namespace source
{
    public class ThreeSumSolution{
        public static IList<IList<int>> ThreeSum(int[] nums) {

            List<IList<int>> result = new   List<IList<int>>();
            Array.Sort(nums);
            int N = nums.Length;

            for(int i =0; i < N-2; i++){
                if( i > 0 && nums[i-1] == nums[i]) continue;
                SearchPair(nums,-nums[i], i+1, result);
            }

            return result;

        
        }

        private static void SearchPair(int[] nums, int targetSum, int left, List<IList<int>> result)
        {
            int right = nums.Length - 1;

            while(left < right){
                int currentSum = nums[left] + nums[right];
                if( currentSum == targetSum){
                    result.Add(new List<int>{ -targetSum,nums[left], nums[right]});
                    left++;
                    right--;
                    while(left< right && nums[left] == nums[left-1]) left++;
                    while(left< right && nums[right] == nums[right+1]) right--;


                }else if( currentSum < targetSum){
                    left++;
                }else{
                    right--;    
                }
            }
        }
    
    
    
      public static IList<IList<int>> ThreeSumWithNoSort(int[] nums) {

            HashSet<List<int>> result = new    HashSet<List<int>>();
            
            Dictionary<int,int> seen = new Dictionary<int, int>(); //value to index map
            HashSet<int> dups = new HashSet<int>();
            int N = nums.Length;

            for(int i =0; i < N; i++){
                
                if(dups.Add(nums[i])){
                    for(int j = i + 1; j < N ;j++){
                        int complement = -nums[i] - nums[j];
                        if (seen.ContainsKey(complement) && seen[complement] == i){
                            List<int> res = new List<int>{nums[i],nums[j],complement};
                            res.Sort();
                            result.Add(res);
                        }
                        seen[ nums[j] ] = i; // this is i not j
                    }
                }
            }
            List<IList<int>> finalResult = new List<IList<int>>(result);
            
             return finalResult;

        
        }
    
    
    
    
    
    
    
    
    }

}