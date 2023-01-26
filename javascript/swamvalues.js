// https://www.codewars.com/kata/5388f0e00b24c5635e000fc6
function swapValues(args) {
    var args = Array.prototype.slice.call(arguments);
    var temp = args[0];
    args[0] = args[1];
    args[1] = temp;
}

function swapValues() {
    return arguments[0].reverse();
}

function swapValues(args) {
    var temp = args[0];
    args[0] = args[1];
    args[1] = temp;
}