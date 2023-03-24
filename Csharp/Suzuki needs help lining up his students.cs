// https://www.codewars.com/kata/5701800886306a876a001031/train/csharp
using System.Linq;

public class Kata
{
  public static string[] LineupStudents(string a)
  {
    return a.Split().OrderBy(s => -s.Length).ThenByDescending(s => s).ToArray();
  }
}