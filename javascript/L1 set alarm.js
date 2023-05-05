// https://www.codewars.com/kata/568dcc3c7f12767a62000038/train/javascript
function setAlarm(employed, vacation){
    return employed === vacation ? false : employed === false && vacation === true ? false : true
    }