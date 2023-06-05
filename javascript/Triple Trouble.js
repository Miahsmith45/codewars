// https://www.codewars.com/kata/5704aea738428f4d30000914/train/javascript
function tripleTrouble(one, two, three){
    let res = ''
    for(let i = 0; i < one.length; i++){

        res += one[i]+two[i]+three[i]
    }
        
    return res
    
   }