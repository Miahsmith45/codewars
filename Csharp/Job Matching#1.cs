// https://www.codewars.com/kata/56c22c5ae8b139416c00175d/train/csharp

using StriveObjects;
using System;

public class Strive
{
  public static bool Match(Candidate c, Job j)
  {
    if (c.MinSalary == null || j.MaxSalary == null)
    {
      throw new Exception();
    }
    
    return (c.MinSalary * 0.9 <= j.MaxSalary);    
  }
}