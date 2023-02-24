// https://www.codewars.com/kata/56ff1667cc08cacf4b00171b/train/csharp
using System;
using System.Linq;
using System.Collections.Generic;

public class Suzuki
{
    public static List<Tuple<int,string>> CountVegetables(string s)
    {
        return s.Split(' ')
            .Where(x => SuzukiHelper.Veggies.Contains(x))
            .GroupBy(x => x)
            .Select(x => new Tuple<int, string>(x.Count(), x.Key))
            .OrderByDescending(x => x.Item1)
            .ThenByDescending(x => x.Item2)
            .ToList();
    }
}