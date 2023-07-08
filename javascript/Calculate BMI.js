// https://www.codewars.com/kata/57a429e253ba3381850000fb/train/javascript
function bmi(weight, height) {
    let b = weight / Math.pow(height, 2) 
    if (b < 18.5) {
        return "Underweight"
    }else if (b <= 25.0) {
return 'Normal'
    }else if (b <= 30.0) {
        return 'Overweight'
    }else {
        return 'Obese'
    }
  }