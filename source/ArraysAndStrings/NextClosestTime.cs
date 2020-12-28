
using System;
using System.Collections;
using System.Collections.Generic;

/*




*/
namespace source
{
public class NextClosestTimeSolution{


     public static string NextClosestTime(string time) {
        
        int curr = 60 * int.Parse(time.Substring(0,2));
        
        curr += int.Parse(time.Substring(3));
        
        HashSet<int> allowed = new HashSet<int>();
        
        foreach(var c in time.ToCharArray()){
            if(c != ':'){
                allowed.Add(c - '0');
            }
        }
        
        while(true){
            curr = (curr + 1) % (24 * 60);
            int[] digits = new int[]{ 
                curr / 60 / 10 , curr / 60 % 10, curr % 60 / 10, curr % 60 % 10  };
            
                    if (IsValidChars(allowed, digits)){
                        
                        return  (curr / 60).ToString("D") + ":" + (curr % 60).ToString("D");
                    }
                }
            }

        private static bool IsValidChars(HashSet<int> allowed, int[] digits)
        {
            
                foreach(var d in digits){
                    if(!allowed.Contains(d)) return false;
                }

                return true;
        }
    }


}
