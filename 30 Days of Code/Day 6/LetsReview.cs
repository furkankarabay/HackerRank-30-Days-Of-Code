using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int T =int.Parse(Console.In.ReadLine());
        
        for(int i = 0; i < T; i++)
        {
            string input = Console.ReadLine();
            List<char> odd = new List<char>();
            List<char> even = new List<char>();
            
            for(int j = 0; j < input.Length; j++)
            {
                if(j % 2 == 0)
                    even.Add(input[j]);
                else
                    odd.Add(input[j]);
            }
            
            var output = "";
            output = new string(even.ToArray());
            Console.Write(output);
            output = new string(odd.ToArray());
            Console.WriteLine(" " + output);
        }
    }
}
