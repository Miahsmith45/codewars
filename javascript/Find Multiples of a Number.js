// https://www.codewars.com/kata/58ca658cc0d6401f2700045f/train/javascript

function findMultiples(integer, limit) {
    let result = []
    for(i = integer; i<=limit; i+=integer){
      result.push(i)
    }
      return result
    }