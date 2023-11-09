using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string T = Console.ReadLine();
        int t = Convert.ToInt32(T);
        Dictionary<string, int> phoneNumbers = new Dictionary<string, int>(t);
        string line;
        string[] contexts;
        
        for(int i = 0; i < t; i++)
        {
            contexts = Console.ReadLine().Split(' ');
            phoneNumbers.Add(contexts[0], int.Parse(contexts[1]));
        }
        
        while ((line = Console.ReadLine()) != null)
        {
            try
            {
                Console.WriteLine($"{line}={phoneNumbers[line]}");
            }
            catch
            {
                 Console.WriteLine("Not found");
            }
        }
    }
}
