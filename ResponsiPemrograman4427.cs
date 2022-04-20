using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4427
{
	class Program
	{
		static void Main(string[] args)
		{
			//objek
			
			Karyawan Riku = new Karyawan("21218888", "Riku", 4000000);
			Karyawan Mazai = new Karyawan("21219999", "Mazai", 5000000);
			
			//menampilkan
			Console.WriteLine("No NIK/Nama				Gaji Bulanan");
			Console.WriteLine("1. {0} {1}				{2}", Riku.Nik, Riku.Nama, Riku.Gajibulanan);
			Console.WriteLine("1. {0} {1}				{2}", Mazai.Nik, Mazai.Nama, Mazai.Gajibulanan);
			
			Riku.Gajibulanan = Riku.Gajibulanan + (Riku.Gajibulanan/100)*10;
			Riku.Gajibulanan = Riku.Gajibulanan + (Riku.Gajibulanan/100)*10;
			
			Console.WriteLine("Yey, gaji naik 10%!!");
			
			
			Console.WriteLine("No NIK/Nama				Gaji Bulanan");
			Console.WriteLine("1. {0} {1}				{2}", Riku.Nik, Riku.Nama, Riku.Gajibulanan);
			Console.WriteLine("1. {0} {1}				{2}", Mazai.Nik, Mazai.Nama, Mazai.Gajibulanan);
			
			
		}
		
		
		
	}
	
	public class Karyawan
	{
		//properties
		public string Nik {get; set;}
		public string Nama {get; set;}
		public float Gajibulanan {get; set;}
		
		//consrtuctor
		public Karyawan()
		{
		}
		
		//constructor overload
		public Karyawan(string nik, string nama, float gajibulanan);
		{
			Nik = nik;
			Nama = nama;
			Gajibulanan = gajibulanan;
		}
		
	}		
	
	
}

//maaf pak belum download vs.net
		
