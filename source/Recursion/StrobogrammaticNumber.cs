using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*

    https://leetcode.com/explore/featured/card/google/62/recursion-4/399/discuss/67280/AC-clean-Java-solution


*/

namespace source
{
    public class StrobogrammaticNumber{

        public List<String> findStrobogrammatic(int n) {
            return helper(n, n);
        }

        private List<string> helper(int currentLen, int n)
        {
            if(currentLen == 0) return new List<string>(){String.Empty};
            if(currentLen == 1) return new List<string>(){"0","1","8"};

            var intermediateResult = helper(currentLen - 2, n);
            var result = new List<string>();

            foreach(var num in intermediateResult){
                if( currentLen != n) result.Add( "0" +  num + "0");
                result.Add("1" + num + "1");
                result.Add("6" + num + "9");
                result.Add("8" + num + "8");
                result.Add("9" + num + "6");

            }

            return result;

        }


        public List<String> findStrobogrammaticIterative(int n) {

            List<string> result = new List<string>();
            if(n % 2 == 0){
                result.Add("");
            }else{
                result.Add("0");
                result.Add("1");
                result.Add("8");
                n--;

            }

            while( n > 0){
                List<string> next = new List<string>();
                foreach(var num in result){
                    if( n > 2) next.Add("0" + num + "0"); // to account for 1001
                    next.Add("1"+  num + "1");
                    next.Add("6"+  num + "9");
                    next.Add("8"+  num + "8");
                    next.Add("9"+  num + "6");

                }
                result = next;
                n -= 2;
            }

            return result;
            
        }

        


    }

}