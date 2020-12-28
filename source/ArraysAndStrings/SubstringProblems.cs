using System;
using System.Collections;
using System.Collections.Generic;

/*




*/
namespace source
{
    public class SubStringProblems{



        //https://leetcode.com/problems/longest-substring-without-repeating-characters/solution/
        public static int LengthOfLongestSubstring(string input) {
            if(input == null) return 0;
            HashSet<char> set = new HashSet<char>();

            int result = 0;

            int start = 0;
            int end = 0;
            int N = input.Length;

            while(start < N && end < N ){

                //try to extend the range 
                var rightChar = char.Parse(input.Substring(end,1));
                if(!set.Contains(rightChar)){
                   
                    set.Add(rightChar);
                    end++;
                    result = Math.Max(result,end - start);
                    
                }else{
                    //shrink the window
                    set.Remove(rightChar);
                    start++;
                }

            }



            return result;

        }



        // if s[j]  have a duplicate in the range [i, j) with index j'
        // we don't need to increase i little by little. 
        // We can skip all the elements in the range [i, j']  
        //  and let i to be j' + 1 directly.
         public static int LengthOfLongestSubstringOptimized(string input) {
            if(input == null) return 0;
            Dictionary<char,int> map = new Dictionary<char, int>();
            int result = 0;

            int start = 0;
            int end = 0;
            int N = input.Length;

            while(end < N ){

                //try to extend the range 
                var rightChar = char.Parse(input.Substring(end,1));
                if(map.ContainsKey(rightChar)){
                   
                    start = Math.Max( map[rightChar] + 1,start);
                     
                }
                result = Math.Max(result, end - start + 1);     
                map[rightChar] = end;
                end++;

            }



            return result;

        }




        //https://leetcode.com/submissions/detail/420882326/?from=/explore/featured/card/google/59/array-and-strings/3054/

        public static int LengthOfLongestSubstringTwoDistinct(string s) {
        
        if(s == null || s.Length < 2) return 0;
        int K = 2;
        
        Dictionary<char,int> charMap = new  Dictionary<char,int>();
        
        int windowStart = 0;
        int maxLength = 0;
        
        for(int windowEnd = 0; windowEnd < s.Length; windowEnd++){
            
            char rightChar = s[windowEnd];
            
            if(!charMap.ContainsKey(rightChar)){
                charMap.Add(rightChar,0);
            }
            charMap[rightChar]++;
            
            while(charMap.Count > K){
                char leftChar = s[windowStart++];
                 if(charMap.ContainsKey(leftChar)){
                     charMap[leftChar]--;
                     
                     if(charMap[leftChar] == 0){
                         charMap.Remove(leftChar);
                     }
                     
                     
                 }
            }
            
            maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            
        }
        
        return maxLength;
        
        
    }

    }

}