using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_3.Bài_3_1
{
    internal class DoXiNgau
    {
        public static void Main(string[] args)
        {
           gameEngine();
        }
        /// <summary>
        /// Gieo cap xuc xac cho nguoi choi 
        /// Nguoi dung se doan nho (1-5) hay lon (7-10), so 6 se duoc tinh la dat biet
        /// neu doan dung nho hoac lon thi duoc tra tien bang so tien dat cuoc, nguoc lai thi mat tien dat cuoc
        /// neu doan dung so 6 thi duoc tra tien bang 3 lan so tien dat cuoc
        /// Luc khoi dau, nguoi choi se co 1000USD, nguoi choi se dat cuoc 100USD cho moi lan choi
        /// Choi cho den khi nguoi choi het tien hoac nguoi choi muon dung choi
        /// Sau khi nguoi choi het tien hoac muon dung choi, hien thi tong so lan choi, tong so lan doan dung, tong so lan doan sai, tong so lan doan dung so 6
        /// </summary>
        /// 
        static void gameEngine()
        {
            int Budget = 1000;
            int countcorrect = 0; 
            int countwrong  = 0;
            int count = 0;
            PairOfDice pod = new PairOfDice();

            Console.WriteLine("Chào mừng đến đỗ xí ngầu game");
            Console.WriteLine("---------------");

            do
            {
                ///1
                pod.Roll();
                ///2.
                Console.WriteLine("Bạn muốn đoán nho (1-5) hay lon (7-10) hay so 6 (1,2,hoặc 3) ?");
                int guess;
                while(!int.TryParse(Console.ReadLine(), out guess) || (guess < 1 || guess > 3))
                {
                    Console.WriteLine("Vui lòng nhập số hợp lệ (1 hoặc 2 hoặc 3):");
                }
                ///In kết quả
                Console.WriteLine($"Kết quả gieo xí ngầu: {pod}-{pod.GetPoints()}");
                ///3. Kiểm tra kết quả đoán
                bool isCorrect = false;
                switch (guess)
                {
                    case 1:
                        isCorrect = pod.GetPoints() >= 2 && pod.GetPoints() <= 5;
                        break;
                    case 2:
                        isCorrect = pod.GetPoints() >= 2 && pod.GetPoints() >= 7;
                        break;
                    case 3:
                        isCorrect = pod.GetPoints() == 6;
                        break;
                }
                        if (isCorrect)
                        {
                            Console.WriteLine("Chúc mừng! Bạn đoán đúng.");
                            countcorrect++;
                            if (guess == 3)
                            {
                                Console.WriteLine("bạn đoán đúng số 6");
                        Budget += 300; //đoán đúng số 6, cộng 3 lần tiền cược
                            }
                            else
                            {
                        Budget += 100; //đoán đúng nhỏ hoặc lớn, cộng 1 lần tiền cược
                            }
                        }
                        else
                        {
                            Console.WriteLine("Rất tiếc! Bạn đoán sai.");
                            countwrong++;
                    Budget -= 100; //đoán sai, trừ 1 lần tiền cược
                        }
                        //xong 1 lượt chơi
                        Console.WriteLine($"Số tiền trong tài khoản: {Budget}");
                        Console.WriteLine("--------------------------");
                        //nếu không đủ tiền chơi tiếp thì dừng
                        if (Budget < 100)
                        {
                            Console.WriteLine("Bạn không đủ tiền để chơi tiếp. Kết thúc trò chơi.");
                            break;
                        }

                        //4.  hỏi người chơi có muốn tiếp tục chơi hay không
                        Console.Write("Bạn có dám tiếp tục chơi? (y/n): ");
                        string continueGame = Console.ReadLine();
                        if (continueGame.ToLower() != "y")
                        {
                            break;
                        }
                } while (true) ;

                //5. thong ke ket qua choi
                Console.WriteLine($"Bạn đã chơi {count} lần.");
                Console.WriteLine($"Bạn đoán đúng {countcorrect} lần.");
                Console.WriteLine($"Bạn đoán sai {countwrong} lần.");
                Console.WriteLine($"Bạn đoán đúng số 6 {count - countcorrect - countwrong} lần.");
                Console.WriteLine($"Số tiền trong tài khoản: {Budget}");

                Console.WriteLine("\n Bye, Lo kiếm tiền rồi chơi tiếp nhé.");
            }

            }

    }


