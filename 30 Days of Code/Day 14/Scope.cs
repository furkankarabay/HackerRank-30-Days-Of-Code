using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] a)
    {
        elements = a;
    }
    
    public void computeDifference()
    {
        for(int i = 0; i < elements.Count(); i++)
        {
            for(int j = 0; j < elements.Count(); j++)
            {
                if(i == j)
                    continue;
                
                int difference = Math.Abs(elements[i] - elements[j]);
                
                try
                {
                    if(difference > maximumDifference)
                        maximumDifference = difference;
                }
                catch (Exception e)
                {
                    maximumDifference = difference;
                }
            }
        }
    }
	// Add your code here

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}