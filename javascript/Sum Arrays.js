// https://www.codewars.com/kata/53dc54212259ed3d4f00071c

sum = function(numbers) {
    return numbers.reduce(function(t, n) {
            return t + n
        }
        0);
}
sum = function(numbers) {
    "use strict";
    return numbers.reduce(function(t, n) {
        return t + n;
    }, 0);
};