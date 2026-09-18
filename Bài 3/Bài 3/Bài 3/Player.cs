using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Bài_3
{
    internal class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();
        public Player(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Kiểm tra xem người chơi có 3 lá bài cùng chất hay không
        /// </summary>
        public bool IsThreeCardsSameSuit()
        {
            if (Hand.Count != 3)
                return false;
            string suit = Hand[0].Suit;
            foreach (Card card in Hand)
            {
                if (card.Suit != suit)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// tổng điểm của 3 lá bài
        /// </summary>  
        public int TotalPoints()
        {
            int total = 0;
            foreach (Card card in Hand)
            {
                total += card.Point();
            }
            return total % 10;
        }
        /// <summary>
        /// so sánh điểm
        /// </summary>  
        public int RankValue() => (IsThreeCardsSameSuit() ? 10 : TotalPoints());
        public string Result()
        {
            if (IsThreeCardsSameSuit())
                return "3 Cào";
            else
                return $"Total points: {TotalPoints()} điểm ";
        }
        //public override string ToString()
        //{
        //    return $"{Name}: {string.Join(", ", Hand)} - Total Points: {TotalPoints()}";
        //}
    }
}
