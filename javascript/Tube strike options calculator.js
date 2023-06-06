// https://www.codewars.com/kata/568ade64cfd7a55d9300003e/train/javascript
function calculator(distance, busDrive, busWalk)  {
    const walkTime = distance / walk;
    const busTime = busDrive / bus + busWalk / walk;
    
    if (walkTime < 1/6) return 'Walk';
    if (walkTime > 2) return 'Bus';
    
    return walkTime <= busTime ? 'Walk' : 'Bus';
  }