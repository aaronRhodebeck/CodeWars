// Test driven development is recommended for this kata

import snail from "./Kata";

describe("Sample tests", () => {
  it("should return the outermost elements to the innermost, traveling clockwise", () => {
    expect(snail([[1, 2, 3], [4, 5, 6], [7, 8, 9]])).toEqual([1, 2, 3, 4, 5, 6, 7, 8, 9]);
  });
});

fdescribe("snail()", () => {
  it("should return an array", () => {
    expect(snail([])).toEqual(jasmine.any("Array"));
  });
});
