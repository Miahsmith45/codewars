// https://www.codewars.com/kata/53da6d8d112bd1a0dc00008b/train/csharp
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
    return Enumerable.Reverse(list).ToList();
  }
}