// https://www.codewars.com/kata/57eae65a4321032ce000002d/train/csharp
public class Kata
{
  public static string FakeBin(string x)
  {
    string result = "";
    
    foreach (char c in x)
                result += c < '5' ? "0" : "1";
                
    return result;
  }
}