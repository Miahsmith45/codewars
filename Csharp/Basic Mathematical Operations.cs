// https://www.codewars.com/kata/57356c55867b9b7a60000bd7/train/csharp

namespace Solution
{
  public static class Program
  {
    public static double basicOp(char op, double val1, double val2)
    {
      switch(op){
        case '+': return val1+val2;
        case '-': return val1-val2;
        case '*': return val1*val2;
        case '/': return val1/val2;
        default:
           throw new System.ArgumentException("Unknown operation!", op.ToString());
      }
    }
  }
}