namespace bài03
{
    public class tinhtien
    {
        static void Main1(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ///tạo danh sách giao dịch
            List<Giaodich> giaodichList = new List<Giaodich>();
            List<GiaodichTiente> giaodichTienteList = new List<GiaodichTiente>();
            List<GiaodichVang> giaodichVangList = new List<GiaodichVang>();
            ///tạo 3 giao dịch tiền tệ và 3 giao dịch vàng
            GiaodichTiente gdtt1 = new GiaodichTiente("GDT001", new DateTime(2023, 1, 15), 1000, 10, 23000, "USD");
            GiaodichTiente gdtt2 = new GiaodichTiente("GDT002", new DateTime(2023, 1, 16), 2000, 3, 27000, "EUR");
            GiaodichTiente gdtt3 = new GiaodichTiente("GDT005", new DateTime(2023, 1, 17), 1500, 4, 1, "VND");
            GiaodichVang gdv1 = new GiaodichVang("GDV003", new DateTime(2023, 1, 18), 5000000, 2, "SJC");
            GiaodichVang gdv2 = new GiaodichVang("GDV004", new DateTime(2023, 1, 19), 6000000, 1, "PNJ");
            GiaodichVang gdv3 = new GiaodichVang("GDV006", new DateTime(2023, 1, 20), 7000000, 3, "SJC");

            ///thêm các giao dịch vào danh sách tương ứng
            giaodichTienteList.Add(gdtt1);
            giaodichTienteList.Add(gdtt2);
            giaodichTienteList.Add(gdtt3);
            giaodichVangList.Add(gdv1);
            giaodichVangList.Add(gdv2);
            giaodichVangList.Add(gdv3);

            giaodichList.Add(gdtt1);
            giaodichList.Add(gdtt2);
            giaodichList.Add(gdtt3);
            giaodichList.Add(gdv1);
            giaodichList.Add(gdv2);
            giaodichList.Add(gdv3);

            ///in ra danh sách các giao dịch
            ///in ra tiền tệ
            Console.WriteLine("------- Danh sách các giao dịch:--------");
            
            double tongThanhTienTienTe = 0;
            
            foreach (GiaodichTiente giaodichTiente in giaodichTienteList)
            {
                Console.WriteLine(giaodichTiente);
                tongThanhTienTienTe += giaodichTiente.ThanhTien();
            }
            Console.WriteLine($"\nTổng thành tiền giao dịch tiền tệ: {tongThanhTienTienTe}");

            ///in ra vàng
            double tongThanhTienVang = 0;

            foreach (GiaodichVang giaodichVang in giaodichVangList)
            {
                Console.WriteLine(giaodichVang);
                tongThanhTienVang += giaodichVang.ThanhTien();
            }
            Console.WriteLine($"\nTổng thành tiền giao dịch vàng: {tongThanhTienVang}");


            ///tính trung bình thành tiền giao dịch tiền tệ
            Console.WriteLine("---------------");
            double trungBinhThanhTienTienTe = tongThanhTienTienTe / giaodichTienteList.Count;
            Console.WriteLine($"Trung bình thành tiền giao dịch tiền tệ: {trungBinhThanhTienTienTe}");


            ///xuất giao dịch có đơn giá > 1 tỷ
            Console.WriteLine("---------------");
            bool timThay = false;
            foreach (Giaodich giaodich in giaodichList)
            {
                if (giaodich.dongia > 1000000000)
                {
                    Console.WriteLine("Giao dịch có đơn giá > 1 tỷ: " + giaodich);
                    timThay = true;
                }
            }
            if (!timThay)
            {
                Console.WriteLine("Không có giao dịch nào có đơn giá > 1 tỷ.");
            }
            Console.ReadKey();
        }
    }
}
