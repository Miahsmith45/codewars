// https://www.codewars.com/kata/572ab0cfa3af384df7000ff8/train/javascript

const shuffleIt = (arr, ...args) =>
  args.reduce((pre, [a, b]) => ([pre[a], pre[b]] = [pre[b], pre[a]], pre), arr);