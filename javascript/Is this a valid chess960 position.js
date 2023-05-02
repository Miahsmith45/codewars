// https://www.codewars.com/kata/61488fde47472d000827a51d/train/javascript
function isValidChess960 (pieces) {
	return /^(?=.*R.*K.*R)(?=.*B(?:..)*B)(?=.*Q)(?=.*N.*N)[RNBQK]{8}$/.test(pieces);
}