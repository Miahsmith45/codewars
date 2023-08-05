// https://www.codewars.com/kata/594fae1a0462da7beb000046/train/javascript
canJump = a => a.slice(0,-1).reduce((a,b )=> (a = Math.max(a-1,a<0?a:b) )==0 ? -1 : a, 0) > 1 ;