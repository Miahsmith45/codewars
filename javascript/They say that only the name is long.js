// https://www.codewars.com/kata/574b1916a3ebd6e4fa0012e7/train/javascript

function isOpposite(s1,s2){
    return s1.split('')
      .map(c => c === c.toUpperCase() ? c.toLowerCase() : c.toUpperCase())
      .join('') === s2 && s1 !== '';
    
  }