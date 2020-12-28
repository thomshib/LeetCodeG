using System;
using System.Collections;
using System.Collections.Generic;

/*


BackTracking Template

    backtrack(candidate){

        if find_solution(candidate){
            output(candidate)
            return;
        }

        #iterate all possible candidates

        foreach next_candidate in list{
            if  IsValid(next_candidate){
                // try this candidate
                place(next_candidate);
                // given this candidate explore futher
                backtrack(next_candidate)
                // backtrack
                remove(next_candidate)
            }
        }


        
    }



    https://www.tutorialspoint.com/Sudoku-Solving-algorithms

*/
namespace source
{
    public class SudokuSolution{

        private int N;
        private int[][] grid;




        private bool Solver(){
            int row = 0; 
            int col = 0;
            bool isEmpty;

            (row,col,isEmpty) = FindEmptyCell(row,col);

            if(!isEmpty){
                return true;
            }

            for(int num = 1; num <= 9; num++){
                if(IsValidMove(row,col, num)){
                    grid[row][col] = num;   

                    if(Solver()) return true;

                    grid[row][col] = 0; 
                }
            }

            return false;




        }
        private bool IsPresentInCol(int col , int num){

            for(int row = 0 ; row < N; row++){
                if(grid[row][col] == num) return true;  
            }

            return false;

        }

        private bool IsPresentInRow(int row , int num){

            for(int col = 0 ; col < N; col++){
                if(grid[row][col] == num) return true;  
            }

            return false;

        }

        private bool IsPresentInBox(int boxStartRow, int boxStartCol, int num){

            for(int row = 0; row < 3; row++){
                for(int col = 0; col < 3; col++){
                    if(grid[row + boxStartRow][col + boxStartCol] == num) return true;
                }
            }

            return false;
        }

        private bool IsValidMove(int row, int col, int num){
            return !IsPresentInBox(row - row % 3, col - col % 3, num) &&
                    !IsPresentInCol(col,num) &&
                    !IsPresentInRow(row,num);

        }

         private (int, int, bool) FindEmptyCell(int row, int col){

            for(int rowIdx = 0; rowIdx < 3; rowIdx++){
                for(int colIdx = 0; colIdx < 3; colIdx++){
                    if(grid[rowIdx][colIdx] == 0) return (row,col, true);
                }
            }

            return (-1,-1,false);
        }



    }

}