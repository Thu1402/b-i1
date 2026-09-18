
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using bài05;
namespace bài05 {
	public class XeOToKhach : Xe {

		private int soChoNgoi;
        private object get;

        public XeOToKhach(){
            soChoNgoi = 0;
        }


        public XeOToKhach(string maxe, string tenxe, double giatrixe, int sochongoi) : base(maxe, tenxe, giatrixe)
        {
            this.soChoNgoi = sochongoi;
        }

        public int SoChoNgoi
        {
            get { return soChoNgoi; }
            set { soChoNgoi = value; }
        }
        public override double tinhThue(){
            double thueVAT = 0.1;
            double thuetruocba = 0.02;
            double thuetieuthudacbiet;
                
                    if (soChoNgoi >= 5)
                    {
                        thuetieuthudacbiet = 0.3;
                    }
                    else
                    {
                        thuetieuthudacbiet= 0.5;
                    }
            return Giatrixe * (thueVAT + thuetruocba + thuetieuthudacbiet);
        }
       
        public override string ToString()
        {
            return $"Mã xe: {Maxe}, Tên xe: {Tenxe}, Giá trị xe: {Giatrixe}, Thuế: {tinhThue()}";
        }

	}//end XeOToKhach

}//end namespace Bài05