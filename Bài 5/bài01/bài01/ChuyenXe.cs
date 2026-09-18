using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bai01 {
	public class ChuyenXe {

		private double Doanhthu;
		private string Hotentaixe;
		private string Masochuyen;
		private string Soxe;

		public ChuyenXe(){
            Masochuyen = "";
            Hotentaixe = "";
            Soxe = "";
            Doanhthu = 0;
        }
		public ChuyenXe(string masochuyen, string hotentaixe, string soxe, double doanhthu){
            this.Masochuyen = masochuyen;
            this.Hotentaixe = hotentaixe;
            this.Soxe = soxe;
            this.Doanhthu = doanhthu;
        }
       public string masochuyen
        {
            get { return Masochuyen; }
            set { Masochuyen = value; }
        }
        public string hotentaixe
        {
            get { return Hotentaixe; }
            set { Hotentaixe = value; }
        }
        public string soxe
        {
            get { return Soxe; }
            set { Soxe = value; }
        }
        public double doanhthu
        {
            get { return Doanhthu; }
            set { Doanhthu = value; }
        }
        public override string ToString()
        {
            return $"Mã số chuyến: {Masochuyen}, Họ tên tài xế: {Hotentaixe}, Số xe: {Soxe}, Doanh thu: {Doanhthu}";
        }

    }
}