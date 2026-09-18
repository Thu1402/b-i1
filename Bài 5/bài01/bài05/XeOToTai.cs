
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using bài05;
namespace bài05 {
	public class XeOToTai : Xe {

		public XeOToTai(){

		}

		public XeOToTai(string maxe, string tenxe, double giatrixe) : base(maxe, tenxe, giatrixe)
		{

		}

		public override double tinhThue(){
            return Giatrixe * 0.02 + Giatrixe * 0.1;
        }
        public override string ToString()
        {
            return $"Mã xe: {Maxe}, Tên xe: {Tenxe}, Giá trị xe: {Giatrixe}, Thuế: {tinhThue()}";
        }

	}//end XeOToTai

}//end namespace Bài05