// https://www.codewars.com/kata/55a996e0e8520afab9000055/train/javascript
function cookie(x){
    return `Who ate the last cookie? It was ${({string: "Zach", number: "Monica"}[typeof x] || "the dog")}!`;
  }