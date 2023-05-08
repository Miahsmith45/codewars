// https://www.codewars.com/kata/57280481e8118511f7000ffa/train/javascript

function splitAndMerge(str, sep) {
    return str.split(' ').map(word => word.split('').join(sep)).join(' ');
   }