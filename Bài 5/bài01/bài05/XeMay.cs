
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using bài05;
namespace bài05 {
	public class XeMay : Xe {
		
		public XeMay(){
			
		}

		public XeMay(string maxe, string tenxe, double giatrixe) : base(maxe, tenxe, giatrixe)
		{

		}

		public override double tinhThue(){
			return Giatrixe * 0.1 + Giatrixe * 0.05;
        }

        public override string ToString()
        {
            return $"Mã xe: {Maxe}, Tên xe: {Tenxe}, Giá trị xe: {Giatrixe}, Thuế: {tinhThue()}";
        }

    }//end XeMay

}//end namespace Bài05