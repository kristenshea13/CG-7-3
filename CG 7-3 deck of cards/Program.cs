using System;
using System.Collections.Generic;

namespace CG_7_3_deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that contains a deck of cards and randomly draws one.You will need a Card class to store
            //information about each individual card.The Card class should have a method that gives you the full card name
            //like “2 of Hearts”. You will need a Deck class that contains an array of all the cards.The Deck class will 
            //need a method to draw a random card.Your main method in the Program class should create a deck object, draw 
            //a random card and display the value.

            Console.WriteLine("Pick a card!");
            Console.ReadLine();

            Deck deck = new Deck();

            Card card = deck.DrawCard();

            Console.WriteLine("You drew the {0}!", card.CardName());

            Console.ReadLine();




        }



    }



    public class Card
    {
        public int Face { get; set; }
        public string Suit { get; set; }
        

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

        //property called Cards
        //deck list
        //random card draw
        public List<Card> Deckofcards { get; set; }

        //constructor- to make sure the deck is always created and cannot draw a card before there is a deck
        public Deck()
        {
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };

            Deckofcards = new List<Card>();

            foreach (var suit in suits)
            {
                for (int face = 1; face <= 13; face++)
                {
                    Card card = new Card
                    {
                        Face = face,
                        Suit = suit
                    };

                    Deckofcards.Add(card);

                }


            }


        }

        public Card DrawCard()
        {
            Random rnd = new Random();
            int cardIndex = rnd.Next(0, 52);

            return Deckofcards[cardIndex];

        }



    }



}
