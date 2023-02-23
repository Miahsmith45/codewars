// https://www.codewars.com/kata/5f70c883e10f9e0001c89673/train/csharp

using System.Linq;
public class Kata
{
    public static int[] Flip(char dir, int[] arr)
    {
        return dir == 'R' ? arr.OrderBy(x=>x).ToArray() : arr.OrderByDescending(x=>x).ToArray();
    }
}