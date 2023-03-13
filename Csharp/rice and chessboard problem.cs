https://www.codewars.com/kata/5b0d67c1cb35dfa10b0022c7/train/javascript

using System;
class Kata
{
    public static int SquaresNeeded(long grains)
    {
        return (int)Math.Ceiling(Math.Log(grains+1 ,2));
    }
}