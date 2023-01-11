// https://www.codewars.com/kata/524f5125ad9c12894e00003f
function remainder(a, b) {
    if (a > b) {
        return a % b
    } else {
        return b % a
    }
}

function remainder(a, b) {
    return a > b ? a % b : b % a;
}