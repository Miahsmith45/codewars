// https://www.codewars.com/kata/6411b91a5e71b915d237332d/train/csharp

public class Kata
{
  public static bool ValidParentheses(string str)
  {
    while ((str = str.Replace("()", "")).Contains("()"));
    return str.Length == 0;
  }
}