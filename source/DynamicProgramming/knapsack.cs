using System;

/*

https://medium.com/educative/5-dynamic-programming-problems-and-solutions-for-your-next-coding-interview-ad938bce2351


*/
namespace source
{

public class KnapSackSolution{

    public static  int solveKnapsack(int[] profits, int[] weights, int capacity){

        return KnapSackRecursive(profits,weights,capacity, 0);
        
    }

    private static int KnapSackRecursive(int[] profits, int[] weights, int capacity, int index)
    {
            if(capacity <= 0 || index < 0 || index >= profits.Length) return 0;

            int profit1 = 0;
            int profit2 = 0;

            if(weights[index] <= capacity){
             profit1 = profits[index] + KnapSackRecursive(profits,weights, capacity - weights[index], index++);
             profit2 = KnapSackRecursive(profits,weights, capacity , index++);
            }

            return Math.Max(profit1,profit2);
    }


     public static  int solveKnapsackDynamic(int[] profits, int[] weights, int capacity){

        int N = profits.Length;
        int[,] dp = new int[N,capacity + 1];


        //initialize capacity 0 columns with 0 profit
        for(int i = 0; i < N; i++){
            dp[i,0] = 0;
        }

        //process

        for(int i = 0; i  < N ; i++){
            for(int c = 1; c <= capacity; c++){
                int profit1 = 0;
                int profit2  = 0;
                if(weights[i] <= c){
                    //include
                    profit1 = profits[i] + dp[i,c - weights[i]];
                    if( i > 0){
                        //exclude
                        profit2 = dp[i-1,c];
                    }

                    dp[i,c] = Math.Max(profit1,profit2);   
                }
            }
        }

        return dp[N-1, capacity];       

        
    }




    }

}