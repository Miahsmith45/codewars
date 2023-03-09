// https://www.codewars.com/kata/544d114f84e41094a9000439/train/csharp

using System;
public class Power
{
  public static bool PowerOf4(object n)
  {
    if(!(n is int || n is long)) return false;
    if(n is int && (int) n == 0) return false;
    
    var root = Math.Log(Convert.ToDouble(n), 4);
      return root == Math.Truncate(root);
  }
}
