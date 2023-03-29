// https://www.codewars.com/kata/602db3215c22df000e8544f0/train/csharp
namespace Solution {
    public static class Kata {
        public static bool TwoArePositive(int a, int b, int c) {
            return  a > 0 && b > 0 && c > 0 ? false 
            : a > 0 && b > 0 ? true 
            : b > 0 && c > 0 ? true 
            : a > 0 && c > 0 ? true 
            : false;
        }
    }
}