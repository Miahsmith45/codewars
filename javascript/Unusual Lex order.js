// https://www.codewars.com/kata/5a438bc1e1ce0e129100005a/train/javascript

const unusualLexOrder = a => a.map(_ => _)
  .sort((a, b) => [...a].reverse().join``.localeCompare([...b].reverse().join``));