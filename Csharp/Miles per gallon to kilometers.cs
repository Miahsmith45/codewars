// https://www.codewars.com/kata/557b5e0bddf29d861400005d/train/csharp

using System;

public static class Kata
{
  
  private const double km_per_mile = 1.609344;
  private const double litres_per_gallon = 4.54609188;
  
	public static double Converter(int mpg)
	{
		return Math.Round(mpg * km_per_mile / litres_per_gallon, 2);
	}
}