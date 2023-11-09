using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        string binary = Convert.ToString(n, 2);
        
        int maxConsectiveCount = 1;
        int consectiveCount = 0;
        
        for(int i = 0; i < binary.Count(); i++)
        {
            if(binary[i] == '1')
            {
                consectiveCount++;
                
                if(consectiveCount > maxConsectiveCount)
                    maxConsectiveCount = consectiveCount;
            }
            else
                consectiveCount = 0;
                
        }
        
        Console.WriteLine(maxConsectiveCount);
    }
}
