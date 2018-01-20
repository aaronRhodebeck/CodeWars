// Test driven development is recommended for this kata

import snail from "./Kata";

describe("Sample tests", () => {
  it("should return the outermost elements to the innermost, traveling clockwise", () => {
    expect(snail([[1, 2, 3], [4, 5, 6], [7, 8, 9]])).toEqual([1, 2, 3, 6, 9, 8, 7, 4, 5]);
    expect(snail([[1, 2, 3, 1], [4, 5, 6, 4], [7, 8, 9, 7], [7, 8, 9, 7]])).toEqual([
      1,
      2,
      3,
      1,
      4,
      7,
      7,
      9,
      8,
      7,
      7,
      4,
      5,
      6,
      9,
      8
    ]);
  });
});

describe("snail()", () => {
  it("should return an array", () => {
    expect(snail([])).toEqual(jasmine.any(Array));
  });
  it("should return an array with the first array in order", () => {
    expect(snail([[1, 2, 3]])).toEqual([1, 2, 3]);
  });
  it("should make the next number the last number in the second array", () => {
    expect(snail([[1, 2, 3], [4, 5, 6], [7, 8, 9]])[3]).toEqual(6);
  });
  it("should reverse the last array", () => {
    expect(snail([[1, 2, 3], [4, 5, 6], [7, 8, 9]]).slice(4, 7)).toEqual([9, 8, 7]);
  });
});
