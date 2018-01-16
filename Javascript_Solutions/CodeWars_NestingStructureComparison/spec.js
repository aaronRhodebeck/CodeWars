// Test driven development is recommended for this kata

describe("Sample Tests", () => {
  it("should pass all these tests before submitting", () => {
    expect([1, 1, 1].sameStructureAs([2, 2, 2])).toBe(true);
    expect([1, [1, 1]].sameStructureAs([2, [2, 2]])).toBe(true);
    expect([1, [1, 1]].sameStructureAs([[2, 2], 2])).toBe(false);
    expect([1, [1, 1]].sameStructureAs([[2], 2])).toBe(false);
    expect([[[], []]].sameStructureAs([[[], []]])).toBe(true);
    expect([[[], []]].sameStructureAs([[1, 1]])).toBe(true);
  });
});
