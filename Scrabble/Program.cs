using System;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
    Console.WriteLine("-----------------");
    Console.WriteLine("Scrabble word calculator");
    Console.WriteLine("Enter a word to see the points calculation."); 
    string scrabbleWord = Console.ReadLine();
    Console.WriteLine(Score.ScrabbleScore(scrabbleWord));
    Main();
    }
  }
}


