export default function snail(array) {
  let finalAnswer = [];
  for (let i = 0, len = array.length / 2; i < len; i++) {
    let currentArray = trimForRound(array, i);
    finalAnswer = finalAnswer.concat(oneRound(currentArray));
  }
  return finalAnswer;
}

function trimForRound(array, round) {
  let trimmedArray = [];
  trimmedArray = array.slice(round, array.length - round);
  for (let i = 0, len = trimmedArray.length; i < len; i++) {
    trimmedArray[i] = trimmedArray[i].slice(round, trimmedArray[i].length - round);
  }
  return trimmedArray;
}

function oneRound(arrayOfArrays) {
  let firstHalf = [];
  let secondHalf = [];
  for (let i = 0, len = arrayOfArrays.length; i < len; i++) {
    if (i === 0) {
      firstHalf = firstHalf.concat(arrayOfArrays[i]);
    } else if (i !== len - 1) {
      firstHalf = firstHalf.concat(arrayOfArrays[i].slice(-1));
      secondHalf.unshift(arrayOfArrays[i][0]);
    } else if (i === len - 1) {
      firstHalf = firstHalf.concat(arrayOfArrays[i].reverse());
    }
  }
  return firstHalf.concat(secondHalf);
}
