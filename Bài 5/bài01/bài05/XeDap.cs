
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using bài05;
namespace bài05 {
	public class XeDap : Xe {

		public XeDap(){

		}

		public XeDap(string maxe, string tenxe, double giatrixe) : base(maxe, tenxe, giatrixe)
		{

		}

		public override double tinhThue(){

			return 0;
		}

        public override string ToString()
        {
            return $"Mã xe: {Maxe}, Tên xe: {Tenxe}, Giá trị xe: {Giatrixe}, Thuế: {tinhThue()}";
        }

    }//end XeDap

}//end namespace Bài05