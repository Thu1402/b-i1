
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Bai01;
namespace Bai01 {
	public class chuyenxeNoithanh : ChuyenXe {

		private double soKmdiduoc;
		private int soTuyen;

		public chuyenxeNoithanh() : base(){
			soKmdiduoc = 0;	
			soTuyen = 0;
        }
        public chuyenxeNoithanh(string masochuyen, string hotentaixe, string soxe, double doanhthu, double sokmdiduoc, int sotuyen) 
			: base(masochuyen, hotentaixe, soxe, doanhthu)
        {
            soKmdiduoc = sokmdiduoc;
            soTuyen = sotuyen;
        }
        public double sokmdiduoc
        {
            get { return soKmdiduoc; }
            set { soKmdiduoc = value; }
        }
        public int sotuyen
        {
            get { return soTuyen; }
            set { soTuyen = value; }
        }
        public override string ToString()
        {
            return base.ToString() + $", Số km đi được: {soKmdiduoc}, Số tuyến: {soTuyen}";
        }

    }

}