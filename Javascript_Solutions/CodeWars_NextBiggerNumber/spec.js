import nextBigger from "./nextBigger";
import * as methods from "./nextBigger";

xdescribe("nextBigger", () => {
  it("should accept a positive integer number and return the next bigger number formed by the same digits", () => {
    expect(nextBigger(12)).toBe(21);
    expect(nextBigger(513)).toBe(531);
    expect(nextBigger(2017)).toBe(2071);
    expect(nextBigger(414)).toBe(441);
    expect(nextBigger(144)).toBe(414);
  });
});

describe("splitToArray", () => {
  it("should return an array", () => {
    expect(methods.splitToArray(123)).toEqual(["1", "2", "3"]);
  });
});

describe("sortArray", () => {
  it("should return a sorted array", () => {
    expect(methods.sortArray(["2", "5", "3", "4"])).toEqual(["2", "3", "4", "5"]);
  });
});

describe("getAllCombinations", () => {
  it("should return an array of all possible combinations of numbers", () => {
    expect(methods.getAllCombinations(["1", "2", "3"])).toEqual([
      "123",
      "132",
      "213",
      "231",
      "312",
      "321"
    ]);
  });
});
