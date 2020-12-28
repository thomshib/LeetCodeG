
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

/*




*/
namespace source
{


public class RLE{
    public  string key;
    public List<int> counts;
    public RLE(string input)
    {
        StringBuilder sb = new StringBuilder();
        counts = new List<int>();

        var characters = input.ToCharArray();
        int N = characters.Length;
        int prev = -1;
        for(int i = 0; i < N; i++){

            if( i == N-1 || characters[i] != characters[i+1]){
                sb.Append(characters[i]);
                counts.Add(i - prev);
                prev = i;

            }
        }
        key = sb.ToString();
    }
}
public class ExpressiveWordsSolution{

     public static int ExpressiveWords(string S, string[] words) {

        if(S == null) return 0;
        if(words.Length == 0) return 0;
        
        RLE r1 = new RLE(S);
        int result = 0;
        bool skipWord = false;
        
        foreach(var word in words){
            RLE r2 = new RLE(word);
            skipWord = false;
            
            if( r1.key != r2.key) continue;
            
            for(int i = 0; i < r1.counts.Count; i++){
                int c1 = r1.counts[i];
                int c2 = r2.counts[i];
                if(c1 < c2 || c1 < 3 && c1 != c2){
                    skipWord = true;
                    break;
                }
            }
            
            if(!skipWord){
                result++;
            }
        }
        
        return result;
        
       

    }

}

}
