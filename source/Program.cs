using System;
using source;

namespace source
{
    class Program
    {
        static void Main(string[] args)
        {   
            // string word = "SAGE";

            //   for(int i = 0; i < word.Length; i++){
            //         string key = word.Substring(0,i) + "_" + word.Substring(i+1);
            //         Console.WriteLine(key);
            //     }
            

            // var result = WordLadderProblem.BuildGraph();


               int[,] dirs = new int[4,2]{
                {0,1},
                {0,-1},
                {1,0},
                {-1,0}
               };

               for(int i = 0; i < dirs.GetLength(0); i++){
                   Console.WriteLine(dirs[i,0] + " " + dirs[i,1]);
               }
            Console.Read();
        }
    }
}
