
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using bài04;
namespace bài04
{
    public class Sach
    {

        private string maSach;
        private DateTime ngayNhap;
        private double donGia;
        private int soLuong;
        private string nhaXuatBan;


        public Sach()
        {
            maSach = "";
            ngayNhap = DateTime.Now;
            donGia = 0;
            soLuong = 0;
            nhaXuatBan = "";
        }

        /// khởi tạo gắn giá trị cho các thuộc tính
        public Sach(string masach, DateTime ngaynhap, double dongia, int soluong, string nhaxuatban)
        {
            this.maSach = masach;
            this.ngayNhap = ngaynhap;
            this.donGia = dongia;
            this.soLuong = soluong;
            this.nhaXuatBan = nhaxuatban;
        }

        public string masach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public DateTime ngaynhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }

        public double dongia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public int soluong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public string nhaxuatban
        {
            get { return nhaXuatBan; }
            set { nhaXuatBan = value; }
        }

        public virtual double ThanhTien()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Mã sách: {maSach} " +
                $" - Ngày nhập: {ngayNhap.ToShortDateString()}" +
                $" - Đơn giá: {donGia}" +
                $" - Số lượng: {soLuong} " +
                $" - Nhà xuất bản: {nhaXuatBan}";
        }

    }
}