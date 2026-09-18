using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_3
{
    internal class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }
        public int Point()
        {
            if (Rank == "A")
                return 1;
            else if (Rank == "10" || Rank == "J" || Rank == "Q" || Rank == "K")
                return 0;
            else
                return int.Parse(Rank);
        }
        public bool IsFaceCard()
        {
            return Rank == "J" || Rank == "Q" || Rank == "K";
        }
        public override string ToString()
        {
            return $"{Rank} + {Suit}";
        }
    }
}
