
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace bài03
{
	public class GiaodichVang : Giaodich
    {

		private string Loaivang;

		public GiaodichVang():base()
        {
            Loaivang = "";
        }

		public GiaodichVang(string magiaodich, DateTime ngaygiaodich, double dongia, int soluong, string loaivang)
            : base (magiaodich, ngaygiaodich, dongia, soluong)
        {
			this.Loaivang = loaivang;
        }

        public string loaivang
        {
            get { return Loaivang; }
            set { Loaivang = value; }
        }
        public override double ThanhTien()
		{
            return dongia * soluong;
        }
        public override string ToString()
        {
            return base.ToString() + $"Loại vàng: {loaivang}";
        }
    }
}