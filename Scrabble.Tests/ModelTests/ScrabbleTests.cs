using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void Dictionary_ReturnsScoreOfLetters_Number1()
    {
      Dictionary<char, int> letters = new Dictionary<char, int>(){{'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, 
		{'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}};
      Assert.AreEqual(1, letters['A']);
      Assert.AreEqual(1, letters['E']);
      Assert.AreEqual(1, letters['I']);
      Assert.AreEqual(1, letters['O']);
      Assert.AreEqual(1, letters['U']);
      Assert.AreEqual(1, letters['L']);
      Assert.AreEqual(1, letters['N']);
      Assert.AreEqual(1, letters['R']);
      Assert.AreEqual(1, letters['S']);
      Assert.AreEqual(1, letters['T']);
    }
    [TestMethod]
    public void Dictionary_ReturnsScoreOfLetters_Number2()
    {
        Dictionary<char, int> letters = new Dictionary<char, int>(){{'D', 2}, {'G', 2}};
        Assert.AreEqual(2,letters['D']);
        Assert.AreEqual(2,letters['G']);
    }
    [TestMethod]
    public void Dictionary_ReturnsScoreOfLetters_Number3()
    {
      Dictionary<char, int> letters = new Dictionary<char, int>(){{'B', 3}, {'C', 3}, {'M', 3}, {'P', 3}};
      Assert.AreEqual(3, letters['B']);
      Assert.AreEqual(3, letters['C']);
      Assert.AreEqual(3, letters['M']);
      Assert.AreEqual(3, letters['P']);
    }
  }
}


// input:string word
// output: int score
// A, E, I, O, U, L, N, R, S, T       1
// D, G                               2
// B, C, M, P                         3
// F, H, V, W, Y                      4
// K                                  5
// J, X                               8
// Q, Z                               10