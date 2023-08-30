using System;
using System.Linq;

public class NoBoring 
{
    public static int NoBoringZeros(int n) 
    {
       return n == 0 ? 0 : Convert.ToInt32(n.ToString().TrimEnd('0'));
    }
}