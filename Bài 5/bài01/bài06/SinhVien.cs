
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using bài06;


namespace bài06 {
	public class SinhVien {

		private string maSV;
		private string hoTen;
		private int namSinh;
		private double diemTB;



		public SinhVien(){
			maSV = "";
			hoTen = "";
			namSinh = ;
			diemTB = 0;
        }

		public SinhVien(string masv, string hoten, int namsinh, double diemtb) {
			this.maSV = masv;
			this.hoTen = hoten;
			this.namSinh = namsinh;
			this.diemTB = diemtb;
		}

		public string masv()
		{
			
		}
		
		public virtual string toString(){

			return "";
		}

        
	}//end SinhVien

}//end namespace Bài06