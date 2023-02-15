// https://www.codewars.com/kata/5b4e779c578c6a898e0005c5/train/csharp

using System.Linq;
public class Kata
{
  public static string DrawStairs(int n)
  
 => string.Join("\n ", Enumerable.Repeat("I", n).Select((e,s) =>e.PadLeft(s)));
  
}
