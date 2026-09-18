using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_3
{
    internal class Deck
    {
        private List<Card> Cards = new List<Card>();
        /// <summary>
        /// tạo 52 lá bài
        /// </summary>
        public string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public string[] suits = { "Cơ", "Vuông", "Chuồn", "Bích" };

        public Deck()
        {
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Cards.Add(new Card(rank, suit));
                }
            }
        }
        /// <summary>
        /// Xào 52 lá bài
        /// </summary>
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int j = rand.Next(i, Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
        }
        /// <summary>
        /// Chia bài cho 4 người chơi, mỗi người 3 lá bài
        /// </summary>
        /// <returns></returns>
        public Card[] Deal()
        {
            Card[] hand = new Card[3];
            for (int i = 0; i < 3; i++)
            {
                hand[i] = Cards[0];
                Cards.RemoveAt(0);
            }
            return hand;
        }

    }
}
