// https://www.codewars.com/kata/570a6a46455d08ff8d001002/train/csharp
using System;
using System.Linq;
public class NoBoring 
{
    public static int NoBoringZeros(int n) 
  => (n == 0) ? 0 : Convert.ToInt32(n.ToString().TrimEnd('0'));
}