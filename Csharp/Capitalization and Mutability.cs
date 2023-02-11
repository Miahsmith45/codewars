// https://www.codewars.com/kata/595970246c9b8fa0a8000086/train/csharp

using System;
public class Kata
{
  public static string CapitalizeWord(string word)
  {
return char.ToUpper(word[0]) + word.Substring(1);
  }
}