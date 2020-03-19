using System;
namespace LatihanClass
{
	class Program
	{
		static void Main(string[] args)
		{
			// membuat objek dari class taxi

			Taxi taxi = new Taxi();
			

			// mengeset nilai properties objek saya dan kamu
			taxi.DriverName = "FerdyOkta";
			taxi.OnDuty = true;
			taxi.NumPassenger = 10;

			// memanggil method registrasi dan isi krs
			taxi.TaxiInfo();
			taxi.PickupPassenger();
			taxi.DropOffPassenger();

			Console.ReadKey();
		}

	}
}