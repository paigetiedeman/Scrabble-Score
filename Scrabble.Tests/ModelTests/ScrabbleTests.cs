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
    [TestMethod]
    public void Dictionary_ReturnsScoreOfLetters_Number4()
    {
      Dictionary<char, int> letters = new Dictionary<char, int>(){{'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4}};
      Assert.AreEqual(4, letters['F']);
      Assert.AreEqual(4, letters['H']);
      Assert.AreEqual(4, letters['V']);
      Assert.AreEqual(4, letters['W']);
      Assert.AreEqual(4, letters['Y']);
    }
    [TestMethod]
    public void Dictionary_ReturnsScoreOfLetters_Number5()
    {
      Dictionary<char, int> letters = new Dictionary<char, int>(){{'K', 5}};
      Assert.AreEqual(5, letters['K']);
    }
    [TestMethod]
    public void Dictionary_ReturnsScoreOfLetters_Number8()
    {
      Dictionary<char, int> letters = new Dictionary<char, int>(){{'J', 8}, {'X', 8}};
      Assert.AreEqual(8, letters['J']);
      Assert.AreEqual(8, letters['X']);
    }
    [TestMethod]
    public void Dictionary_ReturnsScoreOfLetters_Number10()
    {
      Dictionary<char, int> letters = new Dictionary<char, int>(){{'Q', 10}, {'Z', 10}};
      Assert.AreEqual(10, letters['Q']);
      Assert.AreEqual(10, letters['Z']);
    }
  }
}

// input:string word
// output: int score

