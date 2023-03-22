// https://www.codewars.com/kata/57241e0f440cd279b5000829/train/csharp
using System;
public class Kata
{
  public static int SumMul(int n, int m)
  {
    if(m<=n||n<=0){
      throw new ArgumentException();
    }
    var result = 0;
    for(int i=n;i<m;i+=n){
      result+=i;
    }
    return result;
  }
}