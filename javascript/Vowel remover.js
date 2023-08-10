// https://www.codewars.com/kata/5547929140907378f9000039/train/javascript
function shortcut (string) {
    const val = ['a','e','i','o','u']
    return string.split('').filter(e => !val.includes(e)).join('')
  }