using System;
using System.Collections.Generic;
namespace third_assignment_cards_loops_arrays
{
  class Program
  {

    static Random randomNumber = new Random();
    /*static void ShuffleCards()
    {
      //Shuffle decklist

      for (var firstIndex = 1; firstIndex < deck - 1; firstIndex++)
      {
        var yates = randomNumber.Next(deck.Length - firstIndex);
        var firstValue = deck[firstIndex];
        deck[firstIndex] = deck[yates];
        deck[yates] = firstValue;
      }



      string endShuffleLine = "\nDone Shuffling! Here are the top two cards! \n";
      //Console.Write(topTwoCards);
      Console.Write(endShuffleLine);

    }*/

    static void Main(string[] args)
    {

      //Vegas Program with
      //declare suits and faces
      var suitsArray = new string[] { " of Hearts, ", " of Diamonds, ", " of Clubs, ", " of Spades, " };
      var numberOfCardsArray = new string[] { "Ace", "2", "3", "4", "5", "6", "7",
      "8", "9", "10", "Jack", "Queen", "King" };

      //make deck List and for loops
      var deckList = new List<string>() { " " };
      for (var dex = 0; dex < suitsArray.Length; dex++)
      {
        var currentSuit = suitsArray[dex];
        for (var index = 0; index < numberOfCardsArray.Length; index++)
        {
          var currentFace = numberOfCardsArray[index];
          var currentCard = currentFace + currentSuit;
          deckList.Add(currentCard);
        }
      }
      string programIntroLine = " Hello! \nHere is a brand new deck of cards all in order! \n";
      Console.Write(programIntroLine);
      deckList.ForEach(Console.Write);
      string programShuffleLine = "\nNow it is time to shuffle the deck.\n";
      Console.Write(programShuffleLine);
      //ShuffleCards();

      //Epic War Game


    }

  }

}