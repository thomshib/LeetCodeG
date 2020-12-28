using System;

/*

https://medium.com/educative/5-dynamic-programming-problems-and-solutions-for-your-next-coding-interview-ad938bce2351


*/
namespace source
{

public class LongestPalindromeSubStringSolution{

    public  int findLPSLength(string input) {

        int N = input.Length;
        int?[,] dp = new int?[N,N];
        return FindLPSRecursive(dp,input,0, N - 1); 

    }

        private  int FindLPSRecursive(int?[,] dp,string input, int startIndex, int endIndex)
        {
            if(startIndex > endIndex) return 0;

            if(startIndex == endIndex) return 1;  //every sequence with one element is a palindrome of length 1

            if(dp[startIndex,endIndex] == null){
                //case 1: 
                if(input[startIndex] == input[endIndex]){
                    dp[startIndex,endIndex] =  2 + FindLPSRecursive(dp,input,startIndex++,endIndex--);
                }else{

                //case 2:   skip one element from the beginnning or the end

                var length1 = FindLPSRecursive(dp,input, startIndex + 1, endIndex);
                var length2 = FindLPSRecursive(dp,input, startIndex, endIndex-1);

                dp[startIndex,endIndex] =  Math.Max(length1,length2);
            }

            }

            return dp[startIndex,endIndex] ?? default(int);





        }
    }

}