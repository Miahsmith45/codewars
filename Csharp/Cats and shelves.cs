// https://www.codewars.com/kata/62c93765cef6f10030dfa92b/train/csharp
public class Kata
{
  public static int Cats(int start, int finish)
  {
    var diff = finish - start;
    return diff / 3 + diff % 3;
  }
}