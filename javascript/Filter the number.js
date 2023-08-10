// https://www.codewars.com/kata/55b051fac50a3292a9000025/train/javascript
var filterString = function(value) {
   return Number(value.split('').filter(e => !/[a-z]/.test(e)).join(''))
  }
  console.log(filterString("123"))
  console.log(filterString("a1b2c3"))