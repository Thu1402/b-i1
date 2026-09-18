
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace bài05 {
	public class Xe {

		private string maXe;
		private string tenXe;
		private double giatriXe;



		public Xe(){
            maXe = "";
            tenXe = "";
            giatriXe = 0;
        }

		public Xe(string maxe, string tenxe, double giatrixe){
			this.maXe = maxe;
			this.tenXe = tenxe;
			this.giatriXe = giatrixe;
        }

        public string Maxe
        {
            get { return maXe; }
            set { maXe = value; }
        }
        public string Tenxe
        {
            get { return tenXe; }
            set { tenXe = value; }
        }
        public double Giatrixe
        {
            get { return giatriXe; }
            set { giatriXe = value; }
        }
        public virtual double tinhThue(){

			return 0;
		}

        public override string ToString()
        {
            return $"Mã xe: {Maxe}, Tên xe: {Tenxe}, Giá trị xe: {Giatrixe}, Thuế: {tinhThue()}";
        }
    }

}