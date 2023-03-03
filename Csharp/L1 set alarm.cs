// https://www.codewars.com/kata/568dcc3c7f12767a62000038/train/csharp
public class Kata {
  public static bool SetAlarm(bool employed, bool vacation) {
   return employed == vacation ? false : employed == false && vacation == true ? false : true;
  }
}