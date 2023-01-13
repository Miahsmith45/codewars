// https://www.codewars.com/kata/53d16bd82578b1fb5b00128c
function grader(score) {
    if (score >= 0.9 && score <= 1) {
        return 'A'
    }
    if (score >= 0.8 && score <= 1) {
        return 'B'
    }

    if (score >= 0.7 && score <= 1) {
        return 'C'
    }
    if (score >= 0.6 && score <= 1) {
        return 'D'

    }
    return 'F'
}

function grader(score) {
    if (score === 1) return "A";
    return ["D", "C", "B", "A"][Math.floor(score * 10) - 6] || "F";
}