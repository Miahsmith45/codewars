// https://www.codewars.com/kata/5875b200d520904a04000003/train/javascript

function enough(cap, on, wait) {
    let capcity = on + wait
 return cap >= capcity ? 0 : capcity - cap
  }