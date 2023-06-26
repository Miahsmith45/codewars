// https://www.codewars.com/kata/63f96036b15a210058300ca9/train/csharp
public class Kata
{
  public static int SecondSymbol(string str, char symbol)
  {
    int occur = 0;
    for (int i = 0; i < str.Length; i++) {
      if (str[i] == symbol) occur++;
      if (occur == 2) return i;
    }
    return -1;
  }
}