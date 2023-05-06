// https://www.codewars.com/kata/56b29582461215098d00000f/train/javascript

function pipeFix(numbers){
    let res = []
    const first = numbers[0]
    const last = numbers[numbers.length-1]
    for(let i = first; i <= last; i++){
      res.push(i)
    }
      return res 
    }