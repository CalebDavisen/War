using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Davidsen
{

    enum Suit
    {
        Diamond,
        Hearts,
        Spades,
        Clubs
    }

    enum Face
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    /// <summary>
    /// Represents a card in a deck.s
    /// </summary>
    class Card
    {
        /// <summary>
        /// The suit of the card.
        /// </summary>
        public Suit Suit { get; set;  }

        /// <summary>
        /// The face of the card.
        /// </summary>
        public Face Face { get; set;  }

        /// <summary>
        /// Cunstructs a new card object with a given suit and face.
        /// </summary>
        /// <param name="suit">Suit of the card.</param>
        /// <param name="face">Face of the card.</param>
        public Card(Suit suit, Face face)
        {
            this.Suit = suit;
            this.Face = face;
        }

        /// <summary>
        /// Compares the current card to the passed card.
        /// </summary>
        /// <param name="other">The other card to compair to.</param>
        /// <returns>Return a negative number if current card is smaller 
        /// returns positive number if current card is bigger.</returns>
        public int CompareTo(Card other)
        {
            return this.Face - other.Face;
        }
    }
}
