
1
using System;
2
public class Kata
3
{
4
  public static string Stringy(int size)
5
  {
6
    var n = "";
7
      for (var i = 0; i < size; i++)
8
        {
9
        n += i%2 == 0 ? "1" : "0";
10
      };
11
    return n;
12
  }
13
}
 Excellent!