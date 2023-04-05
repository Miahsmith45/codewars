// https://www.codewars.com/kata/59d9ff9f7905dfeed50000b0/train/javascript
function solve(arr){  
    const abc = "abcdefghijklmnopqrstuvwxyz";
    return arr.map(e=>e.toLowerCase().split('').filter((a,b)=> b == abc.indexOf(a)).length)
  };