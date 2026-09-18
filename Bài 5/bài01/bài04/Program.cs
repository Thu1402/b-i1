
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using bài04;

namespace bài04 {
		public class Program
		{
			static void Main(string[] args)
			{
			Console.OutputEncoding = Encoding.UTF8;
            List<Sach> listSach = new List<Sach>();

            ///thêm sách giáo khoa
			
			SachGiaoKhoa sgk1 = new SachGiaoKhoa("SGK001", DateTime.Now, 100000, 10, "NXB Giáo Dục", true);
            SachGiaoKhoa sgk2 = new SachGiaoKhoa("SGK002", DateTime.Now, 120000, 5, "NXB Kim Đồng", false);
            SachGiaoKhoa sgk3 = new SachGiaoKhoa("SGK003", DateTime.Now, 90000, 7, "NXB Nhã Nam", true);
            listSach.Add(sgk1);
            listSach.Add(sgk2);
            listSach.Add(sgk3);


            ///thêm sách tham khảo
            SachThamKhao stk1 = new SachThamKhao("STK001", DateTime.Now, 150000, 8, "NXB Khoa Học", 20000);
            SachThamKhao stk2 = new SachThamKhao("STK002", DateTime.Now, 180000, 3, "NXB Khoa Học", 30000);
            SachThamKhao stk3 = new SachThamKhao("STK003", DateTime.Now, 200000, 6, "NXB Khoa Học", 40000);
            listSach.Add(stk1);
            listSach.Add(stk2);
            listSach.Add(stk3);


            ///in ra danh sách sách
            ///
            Console.WriteLine(listSach);

            ///tính tổng thành tiền của sách giáo khoa
            ///
            Console.WriteLine($"Tổng thành tiền của sách giáo khoa: {listSach.Sum(s => s is SachGiaoKhoa ? s.ThanhTien() : 0)}");
            ///tính tổng thành tiền của sách tham khảo
            ///
            Console.WriteLine($"Tổng thành tiền của sách tham khảo: {listSach.Sum(s => s is SachThamKhao ? s.ThanhTien() : 0)}");
            ///tính trung bình thành tiền của sách tham khảo
            ///
            Console.WriteLine($"Trung bình thành tiền của sách tham khảo: {listSach.Where(s => s is SachThamKhao).Average(s => s.ThanhTien())}");
            ///Tìm sách theo nhà xuất bản
            ///
            Console.WriteLine("Sách theo nhà xuất bản NXB Giáo Dục:");

            foreach (var sach in listSach.Where(s => s.nhaxuatban.Contains("NXB Nhã Nam")))
            {
                Console.WriteLine(sach);
            }

        }

    }

}