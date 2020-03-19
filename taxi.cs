using System;
namespace LatihanClass
{
	public class Taxi
	{
		// Properties
		public string Driver { get; set; }
		public bool OnDuty = true;
		public int NumPassenger { get; set; }

		// method
		public void TaxiInfo()
		{
			Console.WriteLine("Driver Name: {0}", Driver);
			Console.Write("On Duty: ");
			Console.WriteLine(OnDuty ? "Yes" : "No");
			Console.WriteLine("Num of Passenger: {0}", NumPassenger);
			
		}

		public void PickupPassenger()
		{
			Console.WriteLine("{0} sedang menjemput ", Driver);
		}

		public void DropOffPassenger()
		{
			Console.WriteLine("{0} selesai mengantar  ", Driver);
		}

	}
}