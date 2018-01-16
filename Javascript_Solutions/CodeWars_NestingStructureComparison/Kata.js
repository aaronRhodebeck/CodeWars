Array.prototype.sameStructureAs = function(other) {
  if (Array.isArray(other) === false) {
    return false;
  }
  return compareArrays(this, other);
};

function compareArrays(arr1, arr2) {
  if (arr1.length !== arr2.length) {
    return false;
  }
  for (let i = 0, len = arr1.length; i < len; i++) {
    if (Array.isArray(arr1[i]) && Array.isArray(arr2[i])) {
      return compareArrays(arr1[i], arr2[i]);
    } else if (
      (Array.isArray(arr1[i]) && !Array.isArray(arr2[i])) ||
      (!Array.isArray(arr1[i]) && Array.isArray(arr2[i]))
    ) {
      return false;
    }
  }
  return true;
}

export default Array;
