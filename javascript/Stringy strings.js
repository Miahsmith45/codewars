// https://www.codewars.com/kata/563b74ddd19a3ad462000054/train/javascript

function stringy(size) {
    let res = ''
    for(let i = 0; i < size; i++){
      res += i%2 === 0 ? "1" : "0"
    }
    return res
    }