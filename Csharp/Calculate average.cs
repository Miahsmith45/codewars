// https://www.codewars.com/kata/57a2013acf1fa5bfc4000921/train/csharp
using System.Linq;

class AverageSolution
{
  public static double FindAverage(double[] array)
  {
    return array.Length == 0 ? 0 : array.Average();
  }
} 