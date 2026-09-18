
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace bài03
{
	public class GiaodichTiente : Giaodich
	{

		private double Tygia;
		private string LoaitienTe;

		public GiaodichTiente(): base()
        {
            Tygia = 0;
            LoaitienTe = "";
        }

		public GiaodichTiente(string magiaodich, DateTime ngaygiaodich, double dongia, int soluong, double tygia, string loaitienTe)
            : base(magiaodich, ngaygiaodich, dongia, soluong)
        {
			this.Tygia = tygia;
			this.LoaitienTe = loaitienTe;
        }

        public double tygia
        {
            get { return Tygia; }
            set { Tygia = value; }
        }

        public string loaitienTe
        {
            get { return LoaitienTe; }
            set { LoaitienTe = value; }
        }
        public override double ThanhTien()
        {
            if (loaitienTe == "USD" || loaitienTe == "EUR")
            {
                return dongia * soluong * tygia;
            }
            else if (loaitienTe == "VND")
            {
                return dongia * soluong;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $" - Tỷ giá: {tygia} - Loại tiền tệ: {loaitienTe}";
        }
       
	}
}