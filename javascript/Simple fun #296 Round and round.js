// https://www.codewars.com/kata/591e8c715b1d254f9e00005e/train/javascript
function roundAndRound(n, a, b) {
    let i = (a+b) % n
   return i < 1 ? i += n : i
      
  }