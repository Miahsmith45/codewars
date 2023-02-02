// https://www.codewars.com/kata/5865918c6b569962950002a1/train/csharp
using System.Linq;

class Kata
{
    public static int StrCount(string str, string letter)
    {
        return str.Count(c => c.ToString() == letter);
    }
}