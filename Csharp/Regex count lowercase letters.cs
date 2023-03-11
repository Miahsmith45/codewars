// https://www.codewars.com/kata/56a946cd7bd95ccab2000055/train/csharp

using System.Linq;

public class Kata
{
  public static int LowercaseCountCheck(string s)
  {
    return s.Count(char.IsLower);
  }
}