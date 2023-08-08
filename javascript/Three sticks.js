// https://www.codewars.com/kata/57c1f22d8fbb9fd88700009b/train/javascript
function maxlen(l1, l2) {
    // return maximum length
    let max = Math.max(l1, l2)
    let min = Math.min(l1, l2)
    
    if(max / 3 > min)
      return max/3
    
    if(max - min > min)
      return min
    
    return max/2
  }