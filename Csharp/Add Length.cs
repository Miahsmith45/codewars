// https://www.codewars.com/kata/559d2284b5bb6799e9000047/train/csharp

using System.Linq;
public class Kata
{
  public static string[] AddLength(string str)
    => str.Split(' ').Select(e=> $"{e} {e.Length}").ToArray();
}