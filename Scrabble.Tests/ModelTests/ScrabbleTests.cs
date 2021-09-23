using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Scrabble.Models;

namespace Scrabble.Models.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void Dictionary_ReturnsScoreOfLetters_Number()
    {
      Dictionary<char, int> letters = new Dictionary<char, int>(){{'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}, {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3}, {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4}, {'K', 5},	{'J', 8}, {'X', 8},	{'Q', 10}, {'Z', 10}};
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
      Assert.AreEqual(2, letters['D']);
      Assert.AreEqual(2, letters['G']);
      Assert.AreEqual(3, letters['B']);
      Assert.AreEqual(3, letters['C']);
      Assert.AreEqual(3, letters['M']);
      Assert.AreEqual(3, letters['P']);
      Assert.AreEqual(4, letters['F']);
      Assert.AreEqual(4, letters['H']);
      Assert.AreEqual(4, letters['V']);
      Assert.AreEqual(4, letters['W']);
      Assert.AreEqual(4, letters['Y']);
      Assert.AreEqual(5, letters['K']);
      Assert.AreEqual(8, letters['J']);
      Assert.AreEqual(8, letters['X']);
      Assert.AreEqual(10, letters['Q']);
      Assert.AreEqual(10, letters['Z']);
    }
  [TestMethod]
    public void scrabbleScore_ReturnScoreOfWord_Returns2()
    {
      Assert.AreEqual(2, Score.ScrabbleScore("to"));
    }
  }
}


