// https://www.codewars.com/kata/56170e844da7c6f647000063/train/csharp
public class Kata
{
  public static string PeopleWithAgeDrink(int old)
  {
   return old < 14 ? "drink toddy" :
    old <= 15 || old < 18 ? "drink coke" :
    old <= 19 || old == 20 ? "drink beer" :
    old >= 21 ? "drink whisky" :
    null;
  }
}