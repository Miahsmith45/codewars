// https://www.codewars.com/kata/57eae65a4321032ce000002d/train/csharp
function fakeBin(x){
    let res = []
    for (let i = 0; i < x.length; i++){
        res.push(x[i] < "5" ? "0" : "1")
    }
    return res.join('')
    }