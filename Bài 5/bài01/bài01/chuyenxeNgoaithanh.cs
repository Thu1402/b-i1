
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Bai01 {
	public class chuyenxeNgoaithanh : ChuyenXe {

		private string noiDen;
		private int Songaydiduoc;

		public chuyenxeNgoaithanh():base(){
            noiDen = "";
            Songaydiduoc = 0;
        }
		public chuyenxeNgoaithanh(string masochuyen, string hotentaixe, string soxe, double doanhthu, string noiden, int songaydiduoc) 
			: base(masochuyen, hotentaixe, soxe, doanhthu)
        {
            this.noiDen = noiden;
            this.Songaydiduoc = songaydiduoc;
        }
        public string noiden
        {
            get { return noiDen; }
            set { noiDen = value; }
        }
        public int songaydiduoc
        {
            get { return Songaydiduoc; }
            set { Songaydiduoc = value; }
        }
        public override string ToString()
        {
            return base.ToString() + $", Nơi đến: {noiDen}, Số ngày đi được: {Songaydiduoc}";
        }

	}//end chuyenxeNgoaithanh

}//end namespace Bai01