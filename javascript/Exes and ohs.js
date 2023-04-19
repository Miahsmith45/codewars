// https://www.codewars.com/kata/55908aad6620c066bc00002a/train/javascript?
function XO(str) {
    let n = str.toLowerCase().split('')
    return n.filter(e=>e === "x" ).length === n.filter(e=>e === "o").length ? true : false
    
    
}