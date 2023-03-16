// https://www.codewars.com/kata/588417e576933b0ec9000045/train/csharp
public class Kata
{
  public static int SeatsInTheater(int nCols, int nRows, int col, int row)
  {
    return (nRows - row) * (nCols - col + 1);
  }
}