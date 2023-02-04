// https://www.codewars.com/kata/5ab6538b379d20ad880000ab/train/csharp
public class MathCheck {
    public static int AreaOrPerimeter(int l, int w) {
        return l == w ? l * w : (l + w) * 2;
    }
}