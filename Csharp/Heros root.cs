// https://www.codewars.com/kata/55efecb8680f47654c000095/train/csharp
using System;

public class IntSqRoot 
{
  const int error = 1;
	public static long IntRac(long n, long guess)  
	{
    int newGuess = (int)Math.Floor((double)((guess + n/guess)/2));
		if(Math.Abs(newGuess - guess) < error)
      return 1;
    return IntRac(n, newGuess) + 1;
	}
}