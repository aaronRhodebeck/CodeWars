export function rgb(r, g, b) {
  const colors = [...arguments].map(number => roundToValidNumber(number));
  return colors
    .map(color => {
      const hex = convertToHex(color);
      return addLeadingZero(hex);
    })
    .join("");
}

export function roundToValidNumber(number) {
  number = number > 255 ? 255 : number;
  number = number < 0 ? 0 : number;
  return number;
}

export function convertToHex(num) {
  return num.toString(16).toUpperCase();
}

export function addLeadingZero(numString) {
  return numString.length < 2 ? "0" + numString : numString;
}
