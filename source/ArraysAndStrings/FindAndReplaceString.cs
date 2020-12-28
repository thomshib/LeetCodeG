
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*




*/
namespace source
{

    public class FindAndReplaceStringSolution{

        public static string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets) {

            int N = S.Length;
            int[] match = new int[N];
            Array.Fill(match, -1);

            for(int i = 0; i < indexes.Length; i++){
                int ix = indexes[i];
                int subStringLength = sources[i].Length;
                if( S.Substring(ix,subStringLength) == sources[i]){
                    match[ix] = i;  
                }
            }

            StringBuilder result = new StringBuilder();
            int index = 0;
            while(index < N){
                if(match[index] >= 0){
                    result.Append(targets[match[index]]);
                    index += sources[match[index]].Length;
                }else{
                    result.Append(S[index++]);
                }
            }

            return result.ToString();
        
    
    
    }  




    }

}