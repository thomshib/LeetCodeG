


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*

*/
namespace source
{

public class MedianOfTwoArray{

    public double findMedian(int[] input1,int[] input2){


        if(input1.Length > input2.Length){
            findMedian(input2,input1);
        }

        int x = input1.Length;
        int y = input2.Length;
        int low = 0;
        int high = x;

        while(low <= high){
            int partitionX = ( low + high ) /2;
            int partitionY =  ( x + y + 1) / 2 - partitionX;

            int maxLeftX = partitionX ==  0 ? int.MinValue : input1[partitionX - 1] ;
            int minRightX = partitionX ==  x ? int.MaxValue : input1[partitionX];

             int maxLeftY = partitionY ==  0 ? int.MinValue : input2[partitionY - 1] ;
            int minRightY = partitionY ==  y ? int.MaxValue : input2[partitionY];

            if( maxLeftX <= minRightY && maxLeftY <= minRightX){
                //found
                if( ( x + y ) % 2 == 0){
                    return  ( Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY) ) / 2.0;
                }else{
                    return Math.Max(maxLeftX, maxLeftY);
                }

            }else if( maxLeftX > minRightY){
                //move towards left in X
                high = partitionX  - 1;
            }else{

                //move towards right in X
                low = partitionX + 1;   
            }


        }

        return double.MinValue;

    }

}

}