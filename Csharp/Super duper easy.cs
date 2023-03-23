// https://www.codewars.com/kata/55a5bfaa756cfede78000026/train/csharp
using System;

public class Kata
{
  public static String Problem(String Input)
  {
    Double value;
    return (Double.TryParse(Input, out value)) ? (value * 50 + 6).ToString() : "Error";
  }
}