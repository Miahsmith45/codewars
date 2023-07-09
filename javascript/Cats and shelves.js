// https://www.codewars.com/kata/62c93765cef6f10030dfa92b/train/javascript
function solution(start, finish) {
    let jumps = 0
    let efinish = 0
    for (let i = start; i < finish; i+=3){
        jumps ++
        efinish = i
    }
    if((efinish+3) - finish === 1){jumps++}
    return jumps
      }