namespace Bai01
{
    class Program
    {
        static void Main55(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<ChuyenXe> list = new List<ChuyenXe>();

            // Tạo 2 chuyến xe cho mỗi loại xe chuyenxeNoithanh và chuyenxeNgoaithanh
            chuyenxeNoithanh nt1 = new chuyenxeNoithanh("CX005", "Nguyen Van A", "29A-12345", 5000000, 100, 5);
            chuyenxeNoithanh nt2 = new chuyenxeNoithanh("CX003", "Le Thi C", "30A-54321", 6000000, 150, 7);
            chuyenxeNgoaithanh ngt1 = new chuyenxeNgoaithanh("CX002", "Tran Van B", "30B-67890", 8000000, "Da Nang", 3);
            chuyenxeNgoaithanh ngt2 = new chuyenxeNgoaithanh("CX004", "Pham Thi D", "31B-09876", 9000000, "Hue", 4);

            // Thêm các chuyến xe vào danh sách
            list.Add(nt1);
            list.Add(nt2);
            list.Add(ngt1);
            list.Add(ngt2);

            // Xuất dữ liệu của các chuyến xe trong danh sách
            Console.WriteLine("------- Danh sách các chuyến xe:--------");
            foreach (ChuyenXe xe in list)
            {
                Console.WriteLine(xe);
            }
            ///tính tổng doanh thu cho từng loại xe
            double tongDoanhthu = 0;
            double tongDoanhthuNoiThanh = 0;
            double tongDoanhthuNgoaiThanh = 0;

            foreach (ChuyenXe xe in list)
            {
                tongDoanhthu += xe.doanhthu;
                if (xe is chuyenxeNoithanh)
                {
                    tongDoanhthuNoiThanh += xe.doanhthu;
                }
                else if (xe is chuyenxeNgoaithanh)
                {
                    tongDoanhthuNgoaiThanh += xe.doanhthu;
                }
            }

            // Xuất kết quả
            Console.WriteLine("------- Tổng doanh thu: --------");
            Console.WriteLine($"Tổng doanh thu: {tongDoanhthu}");
            Console.WriteLine($"Tổng doanh thu chuyến xe nội thành: {tongDoanhthuNoiThanh}");
            Console.WriteLine($"Tổng doanh thu chuyến xe ngoại thành: {tongDoanhthuNgoaiThanh}");
            Console.WriteLine($"Doanh thu của từng chuyến xe Ngoại thành 1: {ngt1.doanhthu}");
            Console.WriteLine($"Doanh thu của từng chuyến xe Ngoại thành 2: {ngt2.doanhthu}");
            Console.WriteLine($"Doanh thu của từng chuyến xe Nội thành 1: {nt1.doanhthu}");
            Console.WriteLine($"Doanh thu của từng chuyến xe Nội thành 2: {nt2.doanhthu}");
        }
    }
}