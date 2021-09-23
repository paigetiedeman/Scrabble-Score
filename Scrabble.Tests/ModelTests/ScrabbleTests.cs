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
    public void scrabbleScore_ReturnsScoreOfLetters_Number1()
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
  }
}

// input:string word
// output: int score
