
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using bài04;    
namespace bài04 {
	public class DanhSachSach {

		private List<Sach> list;
		private int count;


		public DanhSachSach(){
            list = new List<Sach>();
        }

		public DanhSachSach(int capacity){
             list = new List<Sach>(capacity);
        }

		/// 
		public bool them(Sach s){
            if (s == null)
            {
                return false;
            }
            list.Add(s);
            return true;
        }


        /// <summary>
        /// Tính tổng thành tiền của sách giáo khoa
        /// </summary>
        /// <returns></returns>
        public double tinhTongThanhTienSGK(){
           
            double tongSGK = 0;
            foreach (Sach s in list)
            {
                if (s is SachGiaoKhoa)
                {
                    tongSGK += s.ThanhTien();
                }
            }
            return tongSGK;
        }

        /// <summary>
        /// Tính tổng thành tiền của sách tham khảo
        /// </summary>
        /// <returns></returns>
		public double tinhTongThanhTienSTK(){
            if (list == null || list.Count == 0)
            {
                return 0;
            }
            double tongSTK = 0;
            foreach (Sach s in list)
            {
                if (s is SachThamKhao)
                {
                    tongSTK += s.ThanhTien();
                }
            }
            return tongSTK;
        }

        /// tìm sách giáo khoa theo nhà xuất bản
        public List<Sach> timSachGiaoKhoaTheoNXB(string timSachGiaoKhoaTheoNXB){
           List<Sach> result = new List<Sach>();
            foreach (Sach s in list)
            {
                if (s is SachGiaoKhoa && s.nhaxuatban.Contains(timSachGiaoKhoaTheoNXB))
                {
                    result.Add(s);
                }
            }
            return result;
        }

		public double timThanhTienCaoNhat(){
            if (list == null || list.Count == 0)
            {
                return 0;
            }
            double max = list[0].ThanhTien();
            foreach (Sach s in list)
            {
                if (s.ThanhTien() > max)
                {
                    max = s.ThanhTien();
                }
            }
            return max;
        }
        public override string ToString()
        {
            string result = "Danh sách sách:\n";
            foreach (Sach s in list)
            {
                result += s.ToString() + "\n";
            }
            return result;
        }

    }

}