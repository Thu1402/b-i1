
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Bai02
{
	public class SachGiaoKhoa : Sach {

		private bool tinhTrang;

		public SachGiaoKhoa() {
           
        }

		public SachGiaoKhoa(string masach, DateTime ngaynhap, double dongia, int soluong, string nhaxuatban, bool tinhtrang	)
			:base(masach, ngaynhap, dongia, soluong, nhaxuatban) {
			
			this.tinhTrang = tinhtrang;
        }

		public bool tinhtrang {
			get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        public override double ThanhTien()
        {
            if (tinhTrang == true)
            {
                return dongia * soluong;
            }
            else
            {
                return dongia * soluong * 0.5;
            }
        }

		public override string ToString() {

			return base.ToString() + $"\nTình trạng: {tinhTrang}";
		}
	}
}