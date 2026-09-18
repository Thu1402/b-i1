
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Bai02
{
    public class Test {
        /// <summary>
        /// khởi tạo anh sách các loại sách
        /// </summary>
        /// <param name="main"></param>
        static void Main2(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Sach> sachList = new List<Sach>();
            List<SachGiaoKhoa> sachGiaoKhoaList = new List<SachGiaoKhoa>();
            List<SachThamKhao> sachThamKhaoList = new List<SachThamKhao>();

            /// <summary>
            /// tạo 3 cuốn sách mỗi loại
            /// </summary>
            SachGiaoKhoa sgk1 = new SachGiaoKhoa("SGK001", new DateTime(2023, 1, 15), 50000, 10, "NXB A", true);
            SachGiaoKhoa sgk2 = new SachGiaoKhoa("SGK002", new DateTime(2023, 1, 16), 55000, 15, "NXB B", false);
            SachGiaoKhoa sgk3 = new SachGiaoKhoa("SGK003", new DateTime(2023, 1, 17), 60000, 20, "NXB C", true);

            SachThamKhao stk1 = new SachThamKhao("STK001", new DateTime(2023, 1, 18), 40000, 5, "NXB D", 0.1);
            SachThamKhao stk2 = new SachThamKhao("STK002", new DateTime(2023, 1, 19), 45000, 8, "NXB E", 0.15);
            SachThamKhao stk3 = new SachThamKhao("STK003", new DateTime(2023, 1, 20), 50000, 12, "NXB F", 0.2);

            ///add mỗi sách vào danh sách
            ///
            sachGiaoKhoaList.Add(sgk1);
            sachGiaoKhoaList.Add(sgk2);
            sachGiaoKhoaList.Add(sgk3);
            sachThamKhaoList.Add(stk1);
            sachThamKhaoList.Add(stk2);
            sachThamKhaoList.Add(stk3);

            sachList.Add(sgk1);
            sachList.Add(sgk2);
            sachList.Add(sgk3);
            sachList.Add(stk1);
            sachList.Add(stk2);
            sachList.Add(stk3);

            ///in ra danh sách các sách và tính tổng thành tiền của từng loại sách
            ///Danh sách các loại sách  

            Console.WriteLine("------- Danh sách các sách:--------");
            foreach (Sach sach in sachList)
            {
                Console.WriteLine(sach);
            }
            ///tính tổng thành tiền của sách giáo khoa
            double tongThanhTienSachGiaoKhoa = 0;
            double tongThanhTienSachThamKhao = 0;

            ///tính tổng thành tiền của sách giáo khoa
            foreach (Sach sach in sachList)
            {
                if (sach is SachGiaoKhoa)
                {
                    tongThanhTienSachGiaoKhoa += sach.ThanhTien();
                }
                else if (sach is SachThamKhao)
                {
                    tongThanhTienSachThamKhao += sach.ThanhTien();
                }
            }
            Console.WriteLine("Tổng thành tiền sách giáo khoa: " + tongThanhTienSachGiaoKhoa);
            Console.WriteLine("Tổng thành tiền sách tham khảo: " + tongThanhTienSachThamKhao);


            ///Nhập nhà xuất bản K để tìm sách giáo khoa theo nhà xuất bản K
            Console.WriteLine("Nhập nhà xuất bản cần tìm: ");
            Console.Write("-----------");
            string nxbk = Console.ReadLine();
            List<Sach> ketqua = timSachGiaoKhoaTheoNXB(sachList.ToArray(), nxbk);

            Console.WriteLine("Danh sách sách giáo khoa theo nhà xuất bản " + nxbk + ":");
            if (ketqua.Count == 0)
            {
                Console.WriteLine("Không tìm thấy sách giáo khoa theo nhà xuất bản " + nxbk);
            }
            else
            {
                foreach (SachGiaoKhoa sach in ketqua)
                {
                    Console.WriteLine(sach);
                }
            }

            double maxThanhTien = timThanhTienCaoNhat(sachList.ToArray());
            Console.WriteLine("Thành tiền cao nhất của tất cả các loại sách: " + maxThanhTien);
        }

        public static List<Sach> timSachGiaoKhoaTheoNXB(Sach[] sachList, string nxb)
        {
            List<Sach> ketqua = new List<Sach>();
            foreach (Sach sach in sachList)
            {
                if (sach is SachGiaoKhoa && sach.nhaxuatban.Contains(nxb))
                {
                    ketqua.Add(sach);
                }
            }
            return ketqua;
        }
        /// 
        /// tìm Thành tiền cao nhất của tất cả các loại sách
        public static double timThanhTienCaoNhat(Sach[] sachList)
        {
            double maxThanhTien = 0;
            foreach (Sach sach in sachList)
            {
                double thanhTien = sach.ThanhTien();
                if (thanhTien > maxThanhTien)
                {
                    maxThanhTien = thanhTien;
                }
            }
            return maxThanhTien;
        }

    }
}
  
    