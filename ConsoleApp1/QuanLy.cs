using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.entities;

namespace ConsoleApp1
{
	public class QuanLy
	{
		private Shiba[] danhsachShiba = new Shiba[100];
		public int tongSo;
		public void NhapDS()
		{
			Console.Write("Nhap vao tong so shiba: ");
			tongSo = int.Parse(Console.ReadLine());

			for (int i = 0; i < tongSo; i++)
			{
				Console.WriteLine("Nhap thong tin shiba thu {0}", i + 1);
				Console.Write("Nhap vao ten: "); var ten = Console.ReadLine();
				Console.Write("Nhap vao tuoi: "); var tuoi = int.Parse(Console.ReadLine());
				Console.Write("Nhap vao mau sac: "); var mausac = Console.ReadLine();

				danhsachShiba[i] = new Shiba
				{
					Ten = ten,
					Tuoi = tuoi,
					MauSac = mausac
				};
			}
		}
		public void Xuat_1_Con(Shiba sb)
		{
			Console.WriteLine("| {0,5} | {1,7} | {2,20} |", sb.Ten, sb.Tuoi, sb.MauSac);
		}
		public void XuatDS()
		{
			Console.WriteLine("Tong so cho trong danh sach: {0}", tongSo);
			Console.WriteLine("| {0,5} | {1,7} | {2,20} |", "Ten", "Tuoi", "Mau sac");
			for (int i = 0; i < tongSo; i++)
				Xuat_1_Con(danhsachShiba[i]);
			Console.WriteLine();
		}
		public void TK_TatCa_Ten(string ten)
		{
			Console.WriteLine("Ket qua: ");
			int dem = 0;

			for (int i = 0; i < tongSo; i++)
				if (danhsachShiba[i].Ten == ten)
				{
					Xuat_1_Con(danhsachShiba[i]);
					dem++;
				}

			if (dem == 0)
				Console.WriteLine("Khong tim thay con nao!");
		}
		public void Read(string fileName)
		{
			using (var reader = File.OpenText(fileName))
			{
				Console.WriteLine("Bat dau doc du lieu tu tap tin...");
				Console.WriteLine("Xong.");

				var line = reader.ReadLine();

				tongSo = int.Parse(line);

				for (int i = 0; i < tongSo; i++)
				{
					line = reader.ReadLine();

					var parts = line.Split(' ');

					var ten = parts[0];
					var tuoi = int.Parse(parts[1]);
					var mausac = parts[2];

					Shiba shiba = new Shiba
					{
						Ten = ten,
						Tuoi = tuoi,
						MauSac = mausac
					};
					danhsachShiba[i] = shiba;
				}

				Console.WriteLine("Bat dau giai ma du lieu ...");
				Console.WriteLine("Xong.");
			}
		}
	}
}
