// https://www.codewars.com/kata/563b74ddd19a3ad462000054/train/csharp

using System.Text;

public class Kata
{
  public static string Stringy(int size)
  {
      var result = new StringBuilder();
      for (var i = 1; i <= size; i++)
      {
          result.Append(i%2);
      }
      return result.ToString();
  }
}