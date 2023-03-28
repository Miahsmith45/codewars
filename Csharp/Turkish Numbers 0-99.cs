// https://www.codewars.com/kata/5ebd53ea50d0680031190b96/train/csharp
using System;
using System.Collections.Generic;
public class Kata
{
	public static string GetTurkishNumber(int num)
	{
		var turkisNames = new Dictionary<int, string>()
      {
       { 0, "sıfır"},
            { 1, "bir" },
            { 2, "iki"},
            { 3, "üç"},
            {4, "dört"},
            { 5, "beş"},
            {6 ,"altı" },
            {7,"yedi"},
            {8,"sekiz" },
            {9,"dokuz"},
            {10,"on"},
            {20, "yirmi" },
            {30, "otuz"},
            {40, "kırk" },
            {50, "elli" },
            {60, "altmış" },
            {70, "yetmiş" },
            {80, "seksen" },
            {90, "doksan" }
    };
    if(num < 10) return turkisNames[num];
      else if (num % 10 == 0) return $"{turkisNames[num]}";
    else return $"{turkisNames[int.Parse(num.ToString()[0] + "0")]} {turkisNames[num % 10]}";
	}
}