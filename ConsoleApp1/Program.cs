using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.entities;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
            int chon;
            QuanLy quanLy = new QuanLy();
            string p0 = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            string p1 = Directory.GetParent(p0).ToString();
            string currentPath = Directory.GetParent(p1).ToString();
            string openPath = $"{currentPath}\\ConsoleApp1\\data.txt";
			quanLy.Read(openPath);
			Shiba nasus = new Shiba();
            Console.Write("Nhap ten : "); nasus.Ten = Console.ReadLine();
            Console.Write("Nhap tuoi: "); nasus.Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau sac: "); nasus.MauSac = Console.ReadLine();
			do
			{
				Console.WriteLine("***************MAIN MENU**********");
				Console.WriteLine("1.   Gioi thieu ban than");
				Console.WriteLine("2.   Chay");
				Console.WriteLine("3.   Mua do");
				Console.WriteLine("4.   Xuat danh sach cho");

				chon = int.Parse(Console.ReadLine());
				switch (chon)
				{
					case 1:
						Console.WriteLine(nasus.GioiThieuBanThan());
						break;

					case 2:
						Console.WriteLine(nasus.Chay());
						break;

					case 3:
						Console.WriteLine(nasus.MuaDo());
						break;
					case 4:
						Console.WriteLine("DANH SACH CHO");
						Console.WriteLine($"Si so: {quanLy.tongSo}\n");
						quanLy.XuatDS();
						break;
					default:
						Console.WriteLine("vui long nhap lai");
						break;
				}

			} while (chon != 4);
			Console.ReadLine();
		}
    }
}
