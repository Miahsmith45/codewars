// https://www.codewars.com/kata/58bf9bd943fadb2a980000a7/train/javascript
function whoIsPaying(name){
    let n = name.split('', 2).join('')
    return name.length <= 2 ? [name] :  [name, n]
  }