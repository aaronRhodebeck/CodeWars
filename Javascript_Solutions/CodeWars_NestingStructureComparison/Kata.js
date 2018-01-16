Array.prototype.sameStructureAs = function(other) {
  return compareArrays(this, other);
};

function compareArrays(arr1, arr2) {
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
