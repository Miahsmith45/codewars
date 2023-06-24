// https://www.codewars.com/kata/596fba44963025c878000039/train/csharp
using System.Linq;

public class Kata
{
  public static string Contamination(string text, string character)
  {
    return character.Any() ? new string(character[0], text.Length) : "";
  }
}