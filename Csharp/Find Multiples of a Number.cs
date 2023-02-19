// https://www.codewars.com/kata/58ca658cc0d6401f2700045f

using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static List<int> FindMultiples(int num, int limit) =>
     Enumerable.Range(1, limit / num)
               .Select(x => x * num)
               .ToList();
 }