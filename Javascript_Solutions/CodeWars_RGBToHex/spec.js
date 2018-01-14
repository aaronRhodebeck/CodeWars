// This Kata recommends using test driven development

import * as methods from "./Kata";

const { convertToHex, rgb, addLeadingZero } = methods;

describe("convertToHex", () => {
  it("should accept a number and return a string", () => {
    expect(convertToHex(255)).toEqual(jasmine.any(String));
  });
  it("should return the hexidecimal representation of the decimal number", () => {
    const randomNumber = Math.floor(Math.random() * 100);
    const convertedHex = convertToHex(randomNumber);
    expect(Number.parseInt(convertedHex, 16)).toEqual(randomNumber);
  });
});
describe("addLeadingZero", () => {
  it("should accept a string a return a string", () => {
    expect(addLeadingZero("0")).toEqual(jasmine.any(String));
  });
  it("should convert single digit strings to double digit strings", () => {
    expect(addLeadingZero("1").length).toEqual(2);
  });
  it("should add a zero to the beginning of single digit numbers", () => {
    expect(addLeadingZero("2")).toBe("02");
  });
  it("should not change numbers with more than 1 digit", () => {
    expect(addLeadingZero("23")).toBe("23");
  });
});
describe("rgb()", () => {
  it("should accept 3 numbers and return a string", () => {
    expect(rgb(5, 5, 5)).toEqual(jasmine.any(String));
  });
  it("should return a string with a length of 6", () => {
    expect(rgb(5, 5, 5).length).toBe(6);
  });
  it("should return FF for numbers over 255", () => {
    expect(rgb(255, 255, 300)).toBe("FFFFFF");
  });
  it("should return the correct hexidecimal for the rgb code", () => {
    expect(rgb(255, 255, 255)).toBe("FFFFFF");
    expect(rgb(0, 0, 0)).toBe("000000");
    expect(rgb(148, 0, 211)).toBe("9400D3");
  });
});
