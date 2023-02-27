// https://www.codewars.com/kata/5601409514fc93442500010b/train/csharp
using System.Linq;

public class Kata
{
  public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
  {
    return YourPoints > ClassPoints.Average();
  }
}