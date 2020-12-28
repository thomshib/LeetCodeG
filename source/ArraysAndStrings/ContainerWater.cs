using System;
using System.Collections;
using System.Collections.Generic;

/*




*/
namespace source
{
    public class ContainerWater{
         public static int MaxArea(int[] height) {
            
            int maxArea = 0;

            int N = height.Length;

            for(int i =0; i < N; i++){
                for(int j = i + 1; j < N; j++){
                    int area = Math.Min(height[j], height[i]) * (j - i);
                    maxArea = Math.Max(maxArea,area);
                }

            }

            return maxArea;
        
        }

         public static int MaxAreaTwoPointers(int[] height) {
            
            int maxArea = 0;
            int N = height.Length;
            int left = 0;
            int right = N - 1;

            

            while(left< right){
                
                int area = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea,area);

                if(height[left] < height[right]){
                    left++;
                }else{
                    right--;
                }
            }

            

            return maxArea;
        
        }




    }

}