
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace bài03
{
    public class Giaodich
    {

        private string Magiaodich;
        private DateTime Ngaygiaodich;
        private double Dongia;
        private int Soluong;



        public Giaodich()
        {
            Magiaodich = "";
            Ngaygiaodich = DateTime.Now;
            Dongia = 0;
            Soluong = 0;
        }

        public Giaodich(string magiaodich, DateTime ngaygiaodich, double dongia, int soluong)
        {
            this.Magiaodich = magiaodich;
            this.Ngaygiaodich = ngaygiaodich;
            this.Dongia = dongia;
            this.Soluong = soluong;
        }

        public string magiaodich
        {
            get { return Magiaodich; }
            set { Magiaodich = value; }
        }

        public DateTime ngaygiaodich
        {
            get { return Ngaygiaodich; }
            set { Ngaygiaodich = value; }
        }

        public double dongia
        {
            get { return Dongia; }
            set { Dongia = value; }
        }

        public int soluong
        {
            get { return Soluong; }
            set { Soluong = value; }
        }
        public virtual double ThanhTien()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"Mã giao dịch: {magiaodich} - Ngày giao dịch: {ngaygiaodich.ToShortDateString()} - Đơn giá: {dongia} - Số lượng: {soluong}";
        }
    }
}