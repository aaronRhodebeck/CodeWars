import PokerHand from './Kata';
import { Result } from './Kata'

fdescribe("If a poker hand is compared to another poker hand then:", function () {
    it("Highest straight flush wins", function() {
        let hand = new PokerHand( "2H 3H 4H 5H 6H"); 
        expect(hand.compareWith("KS AS TS QS JS")).toEqual(Result.loss);});
    it("Straight flush wins of 4 of a kind", function() {
        let hand = new PokerHand("2H 3H 4H 5H 6H")
        expect(hand.compareWith("AS AD AC AH JD")).toEqual(Result.win);
    });
    it("Highest 4 of a kind wins", function() {
        let hand = new PokerHand("AS AH 2H AD AC") 
        expect(handcompareWith("JS JD JC JH 3D")).toEqual(Result.win);});
    it("4 Of a kind wins of full house", function() {
        let hand = new PokerHand( "2S AH 2H AS AC") 
        expect(hand.compareWith("JS JD JC JH AD")).toEqual(Result.loss);});
    it("Full house wins of flush", function() {
        let hand = new PokerHand( "2S AH 2H AS AC") 
        expect(hand.compareWith( "2H 3H 5H 6H 7H")).toEqual(Result.win);});
    it("Highest flush wins", function() {
        let hand = new PokerHand("AS 3S 4S 8S 2S") 
        expect(hand.compareWith("2H 3H 5H 6H 7H")).toEqual(Result.win);});
    it("Flush wins of straight", function() {
        let hand = new PokerHand("2H 3H 5H 6H 7H") 
        expect(hand.compareWith("2S 3H 4H 5S 6C")).toEqual(Result.win);});
    it("Equal straight is tie", function() {
        let hand = new PokerHand("2S 3H 4H 5S 6C"). 
        expect(hand.compareWith("3D 4C 5H 6H 2S")).toEqual(Result.tie);});
    it("Straight wins of three of a kind", function() {
        let hand = new PokerHand("2S 3H 4H 5S 6C") 
        expect(hand.compareWith("AH AC 5H 6H AS")).toEqual(Result.win);});
    it("3 Of a kind wins of two pair", function() {
        let hand = new PokerHand( "2S 2H 4H 5S 4C") 
        expect(hand.compareWith( "AH AC 5H 6H AS")).toEqual(Result.loss);});
    it("2 Pair wins of pair", function() {
        let hand = new PokerHand("2S 2H 4H 5S 4C") 
        expect(hand.compareWith("AH AC 5H 6H 7S")).toEqual(Result.win);});
    it("Highest pair wins", function() {
        let hand = new PokerHand( "6S AD 7H 4S AS") 
        expect(hand.compareWith( "AH AC 5H 6H 7S")).toEqual(Result.loss);});
    it("Pair wins of nothing", function() {
        let hand = new PokerHand( "2S AH 4H 5S KC") 
        expect(hand.compareWith( "AH AC 5H 6H 7S")).toEqual(Result.loss);});
    it("Highest card loses", function() {
        let hand = new PokerHand( "2S 3H 6H 7S 9C") 
        expect(hand.compareWith( "7H 3C TH 6H 9S")).toEqual(Result.loss);});
    it("Highest card wins", function() {
        let hand = new PokerHand("4S 5H 6H TS AC") 
        expect(hand.compareWith("3S 5H 6H TS AC")).toEqual(Result.win);});
    it("Equal cards is tie", function() {
        let hand = new PokerHand("2S AH 4H 5S 6C") 
        expect(hand.compareWith("AD 4C 5H 6H 2C")).toEqual(Result.tie);});
});
