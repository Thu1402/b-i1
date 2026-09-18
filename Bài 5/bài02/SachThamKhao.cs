
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bai02
{
	public class SachThamKhao : Sach {

		private double Thue;

        public SachThamKhao() : base()
        {
            Thue = 0;
        }
        public SachThamKhao(string masach, DateTime ngaynhap, double dongia, int soluong, string nhaxuatban, double thue):base(masach, ngaynhap, dongia, soluong, nhaxuatban) 
		{
			this.Thue = thue;
		}

		public double thue {
			get { return Thue; }
            set { Thue = value; }
        }

		public override double ThanhTien()
		{
			return dongia * soluong + Thue;
		}

		public override string ToString() {

			return base.ToString() + $"\nThuế: {Thue}";
		}

	}
}