using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_3
{
    internal class Playgame
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Playgame.gamePlay();
        }

        static void gamePlay()
        {
            /// <summary>
            /// tạo 4 người chơi
            /// </summary>
            List<Player> players = new List<Player>() {
                new Player("Người chơi 1"),
                new Player("Người chơi 2"),
                new Player("Người chơi 3"),
                new Player("Người chơi 4")
            };
            /// Tạo bộ bài và xáo trộn
            Deck deck = new Deck();
            deck.Shuffle();

            /// Chia bài cho từng người chơi
           
            for (int i = 0; i < 4; i++)
            {
                players[i] = new Player($"Người chơi {i + 1}");
                players[i].Hand.AddRange(deck.Deal());
            }
            Console.WriteLine("Kết quả chia bài:");

            foreach (Player player in players)
            {
                Console.WriteLine($"{player.Name}: {string.Join(", ", player.Hand)} - {player.Result()}");
            }
            ///<summary>
            ///tìm điểm cao nhất
            ///</summary>  
            int max = 0;
            foreach (Player player in players)
            {
                if (player.RankValue() > max)
                {
                    max = player.RankValue();
                }
            }
            ///<summary>   
            ///người thắng cuộc chơi là người có điểm cao nhất
            ///</summary>   
            List<Player> winners = new List<Player>();
            foreach (Player player in players)
            {
                if (player.RankValue() == max)
                {
                    winners.Add(player);
                }
            }

            // thông báo người thắng cuộc
            Console.WriteLine("\nNgười thắng cuộc là:");
            if (winners.Count == 1)
            {
                Console.WriteLine($"{winners[0].Name} với số nút: {winners[0].Result()}");
            }
            else
            {
                Console.WriteLine("Những người còn lại thua");
               
            }
            Console.ReadKey();
            }
        }

}
