
using System;
using System.Collections;
using System.Collections.Generic;

/*

https://runestone.academy/runestone/books/published/pythonds/BasicDS/ConvertingDecimalNumberstoBinaryNumbers.html


*/
namespace source
{

  public class NumberConversionSolution{

      public static string ConvertNumber(int decimalNumber, int baseNumber ){

          const string  digits = "0123456789ABCDEF";

          Stack<int> stack = new Stack<int>();

          while(decimalNumber > 0){
              var rem = decimalNumber % baseNumber;
              stack.Push(rem);
              decimalNumber = decimalNumber / baseNumber;

          }

          string result = String.Empty;
          while(stack.Count >0){
              result += digits[stack.Pop()];
          }

          return result;


      }

        public static string    ConvertToString(int N, int baseNumber ){

          const string  convertString = "0123456789ABCDEF";

          if(N < baseNumber){
              return convertString[N].ToString();
          }else{
              return ConvertToString(N / baseNumber, baseNumber) + convertString[N % baseNumber].ToString();
          }

        }

    
  } 


}