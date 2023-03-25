https://www.codewars.com/kata/574b1916a3ebd6e4fa0012e7/train/csharp

using System.Linq;
using System;
public class Kata {
  public static bool IsOpposite(string s1, string s2)
   => string.IsNullOrEmpty(s1) ? false :   
       s1.SequenceEqual( s2.Select(e=>  Char.IsLower(e) ? Char.ToUpper(e) : Char.ToLower(e))); 
}