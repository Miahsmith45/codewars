// https://www.codewars.com/kata/5b190aa7803388ec97000054/train/javascript

function tram(s, d, o){
    let c = 0 , p = 0;
    for (let i = 0; i<s; i++){
      p -= d[i]
      p += o[i]
      c = Math.max(c,p);
    }
    return c
    }