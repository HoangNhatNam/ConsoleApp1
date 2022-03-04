using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.entities
{
	public class Dog
	{
		public string Ten { get; set; }
		public int Tuoi { get; set; }
		public string MauSac { get; set; }

		public string GioiThieuBanThan()
		{
			return $"Xin Chao, toi ten la {Ten}, toi {Tuoi} tuoi, co mau {MauSac}";
		}

		public string Chay()
		{
			return "Toi dang chay";
		}
	}
}
