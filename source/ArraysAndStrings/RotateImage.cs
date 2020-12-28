using System;

/*

https://leetcode.com/problems/rotate-image/

http://buttercola.blogspot.com/2014/08/leetcode-rotate-image.html


The basic idea is that we process the matrix from inner to outer. 
First we process the inner circle of the matrix, and then the outer circle 
 
For each circle, we exchange elements clockwise and after we finish one circle, we can continue processing the next.


*/          
namespace source
{
    public class RotateImage{

        public static void Rotate(int[][] matrix) {

            int N = matrix.GetLength(0);

            for(int layer = 0; layer < N / 2; layer++){
                int first = layer;
                int last = N - layer - 1;

                for(int i = first; i < last; i++){
                    int offset = i - first;
                    /*
                        pattern

                        lefttop = [first][i]
                        leftbotton = [last-offset][first]
                        rightbottom = [last][last-offset]
                        righttop = [i][last]

                    */

                    int lefttop = matrix[first][i];

                    //left top
                    matrix[first][i] = matrix[last-offset][first];
                    
                    //left bottom
                    matrix[last-offset][first] = matrix[last][last-offset];

                    //right bottom
                    matrix[last][last-offset] = matrix[i][last];

                    //top right
                    matrix[i][last] = lefttop;


                    //left -> top

                }
            }



        
        }

    }


}

