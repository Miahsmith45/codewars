// https://www.codewars.com/kata/56b29582461215098d00000f/train/csharp
using System.Collections.Generic;
using System.Linq;

public class Fixer
{
  public static List<int> PipeFix(List<int> numbers)
  {
    return Enumerable.Range(numbers.First(), numbers.Last() - numbers.First() + 1).ToList();
  }
}