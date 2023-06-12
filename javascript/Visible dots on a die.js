// https://www.codewars.com/kata/5a39724945ddce2223000800/train/javascript
function totalAmountVisible(t, n) {
    const math = n == 6 ? 21 - (7 - t)
        : n == 8 ? 36 - (9 - t)
            : n == 10 ? 55 - (11 - t)
                : n == 12 ? 78 - (13 - t)
                    : n == 20 ? 210 - (21 - t) : null

    return math
}