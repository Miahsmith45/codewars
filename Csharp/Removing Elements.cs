// https://www.codewars.com/kata/5769b3802ae6f8e4890009d2/train/csharp

using System.Linq;

public static class Kata
{
    public static object[] RemoveEveryOther(object[] arr)
    {
        return arr.Where((e, i) => i%2 == 0).ToArray();
    }
}