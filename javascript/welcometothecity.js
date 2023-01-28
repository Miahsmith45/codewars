// https://www.codewars.com/kata/5302d846be2a9189af0001e4

function sayHello(name, city, state) {
    return [
        'Hello, ',
        name.join(' '),
        '! Welcome to ', [city, state].join(', '),
        '!'
    ].join('');
}

function sayHello(name, city, state) {
    const nameStr = name.join(' ');
    return `Hello, ${nameStr}! Welcome to ${city}, ${state}!`;
}