using System;
using System.Collections.Generic;

namespace CG_7_3_deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //explain program
            Console.WriteLine("Pick a card!");
            //added readline so user would have to hit enter to pick a card
            Console.ReadLine();

            //create deck of cards using Deck class
            Deck deck = new Deck();

            //draw random card from Card class
            Card card = deck.DrawCard();

            //print card to console
            Console.WriteLine("You drew the {0}!", card.CardName());

            Console.ReadLine();

        }
    }


    /// <summary>
    /// create card class using properties for face value of card and the suit
    /// </summary>
    public class Card
    {
        public int Face { get; set; }
        public string Suit { get; set; }
        
        //created method for how card from card class is displayed, if Face is between 2 and 10 it will be the "{number} of *suit*", 
        //if Face is 1 it will be the "Ace of *suit*",
        //if 11 "Jack of *suit*", if 12 "Queen of *suit*", if 13 "King of *suit*"
        public string CardName()
        {
            string faceValue = "";
            if (Face >= 2 && Face <= 10)
                faceValue = Face.ToString();
            else if (Face == 1)
                faceValue = "Ace";
            else if (Face == 11)
                faceValue = "Jack";
            else if (Face == 12)
                faceValue = "Queen";
            else if (Face == 13)
                faceValue = "King";


            return $"{faceValue} of {Suit}";
        }
    }

    public class Deck
    {
        //created a property for the list of cards
        public List<Card> Deckofcards { get; set; }

        //used a constructor- to make sure user cannot draw a card before the deck is created
        public Deck()
        {
            //string for all 4 suits
            string[] suitValues = { "Hearts", "Clubs", "Diamonds", "Spades" };

            //initiated new list of cards for deck
            Deckofcards = new List<Card>();

            //created a loop so as not to type out all 52 card values
            foreach (var suit in suitValues)
            {
                for (int face = 1; face <= 13; face++)
                {
                    Card card = new Card
                    {
                        Face = face,
                        Suit = suit
                    };
                    
                    //add all card value/suit combinations to the Deckofcards
                    Deckofcards.Add(card);

                }
            }
        }

        /// <summary>
        /// method to draw random card from Deck
        /// </summary>
        /// <returns>random card from deckofcards</returns>
        public Card DrawCard()
        {
            Random rnd = new Random();
            int cardIndex = rnd.Next(0, 52);

            return Deckofcards[cardIndex];

        }
    }
}
