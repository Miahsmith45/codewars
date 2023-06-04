// https://www.codewars.com/kata/56b7526481290c2ff1000c75/train/javascript
function tripleShiftian(b,n){
       
    for(let i =3; i < n + 1; i++){
     b.push(4 * b[i - 1] - 5 * b[i - 2] + 3 * b[i - 3])
    }
    return b[n]
   }