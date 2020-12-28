using System;
using Xunit;
using source;
using System.Text;

namespace test
{
    public class RotateImageTests
    {
        [Fact]
        public void RotateImageFourByFourMatrixResultsInSuccess()
        {

            //arrange
            int[][] matrix = new int[][]{
                new int[]{5,1,9,11},
                new int[]{2,4,8,10},
                new int[]{13,3,6,7},
                new int[]{15,14,12,16},

            };

            //arrange
            int[][] rotatedMatrix = new int[][]{
                new int[]{15,13,2,5},
                new int[]{14,3,4,1},
                new int[]{12,6,8,9},
                new int[]{16,7,10,11},

            };

            var expectedResult = TraveseArray(rotatedMatrix);

               RotateImage.Rotate(matrix);
            
            var actualResult = TraveseArray(matrix);

            Assert.Equal(expectedResult, actualResult);




        }

        public string TraveseArray(int[][] matrix){

            int N = matrix.GetLength(0);
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < N; i++){
                for(int j = 0; j < matrix[i].Length; j++){
                    sb.Append(matrix[i][j]);
                    sb.Append(",");

                }
            }

            return sb.ToString();
        }
    }
}
