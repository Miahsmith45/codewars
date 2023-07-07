// https://www.codewars.com/kata/5547929140907378f9000039/train/csharp
using System.Text.RegularExpressions;

public class Kata
{
  public static string Shortcut(string input)
  {
    return Regex.Replace(input, "[aeiou]", "");
  }
}