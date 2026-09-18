namespace bài05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ///tạo danh sách xe
            List<Xe> listXe = new List<Xe>();

            Xe xe1 = new XeMay("001", "Xe Máy 1", 10000);
            Xe xe2 = new XeMay("002", "Xe May 2", 20000);
            Xe xe3 = new XeOToTai("003", "Xe O To Tai 1", 30000);
            Xe xe4 = new XeOToKhach("004", "Xe O To Khach 1", 40000, 40);
            Xe xe6 = new XeOToKhach("006", "Xe O To Khach 2", 60000, 4);
            Xe xe5 = new XeDap("005", "Xe Dap 1", 50000);

            ///thêm các xe vào danh sách
            ///
            listXe.Add(xe1);
            listXe.Add(xe2);
            listXe.Add(xe3);
            listXe.Add(xe4);
            listXe.Add(xe5);
            listXe.Add(xe6);

            ///hiển thị thông tin các xe
            ///
            Console.WriteLine("----------Danh sách các xe:-----------");
            foreach (Xe xe in listXe)
            {
                Console.WriteLine(xe.ToString());
            }
        }
    }

}