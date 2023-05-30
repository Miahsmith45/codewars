// https://www.codewars.com/kata/56b8b0ae1d36bb86b2000eaa/train/javascript

const convert = time => time.toJSON().replace(/.*T(.*)\.(.*)Z/, '$1,$2');