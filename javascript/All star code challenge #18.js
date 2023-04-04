// https://www.codewars.com/kata/5865918c6b569962950002a1/train/javascript

function strCount(str, letter){  
    const h = str.split('').filter(e => e === letter) 
    return h.length
      }