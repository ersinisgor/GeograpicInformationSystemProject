using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeograpicInformationSystemProject
{




	public class Vehicle
	{
		public Vehicle(string plate, string vehicleType, PointLatLng location, string from, string to)
		{
			this.Plate = plate;
			this.VehicleType = vehicleType;
			this.Location = location;
			this.From = from;
			this.To = to;
		}


		public string Plate { get; set; }
		public string VehicleType { get; set; }
		public PointLatLng Location { get; set; }
		public string From { get; set; }
		public string To { get; set; }
	}
}
