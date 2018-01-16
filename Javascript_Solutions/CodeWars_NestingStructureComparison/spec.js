// Test driven development is recommended for this kata
import Array from "./Kata";

fdescribe("sameStructureAs", () => {
  it("should return a boolean", () => {
    expect([].sameStructureAs([])).toEqual(jasmine.any(Boolean));
  });
  describe("compareArrays", () => {
    it("should return false if the arrays dont match", () => {
      expect([1].sameStructureAs([[1]])).toBe(false);
      expect([[1]].sameStructureAs([1])).toBe(false);
      expect([1, [1, 1]].sameStructureAs([2, [2]])).toBe(false);
    });
    it("should ignore non-arrays", () => {
      expect([1].sameStructureAs([2])).toBe(true);
      expect([[2]].sameStructureAs([[1]])).toBe(true);
    });
  });
});

fdescribe("Sample Tests", () => {
  it("should pass all these tests before submitting", () => {
    expect([1, 1, 1].sameStructureAs([2, 2, 2])).toBe(true);
    expect([1, [1, 1]].sameStructureAs([2, [2, 2]])).toBe(true);
    expect([1, [1, 1]].sameStructureAs([[2, 2], 2])).toBe(false);
    expect([1, [1, 1]].sameStructureAs([[2], 2])).toBe(false);
    expect([[[], []]].sameStructureAs([[[], []]])).toBe(true);
    expect([[[], []]].sameStructureAs([[1, 1]])).toBe(false);
  });
});
