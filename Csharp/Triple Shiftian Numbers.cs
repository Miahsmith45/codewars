// https://www.codewars.com/kata/56b7526481290c2ff1000c75/train/csharp
using System.Linq;

public class Kata
{
  public static long TripleShiftian(int[] baseValues, int n)
  {
    var values = baseValues.Select(i => (long) i).ToList();
    for (var i = 2; i <= n; i++)
    {
        values.Add(4 * values[i] - 5 * values[i - 1] + 3 * values[i - 2]);
    }
    
    return values[n];
  }
}