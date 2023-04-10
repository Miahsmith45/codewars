// https://www.codewars.com/kata/57a2013acf1fa5bfc4000921/train/javascript
function findAverage(arr) {

    return arr.length === 0 ? 0 : arr.reduce((a, b) => a + b, 0) / arr.length
}