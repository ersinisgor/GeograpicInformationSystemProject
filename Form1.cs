using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeograpicInformationSystemProject
{
	public partial class Form1 : Form
	{
		GMapOverlay overlayOne;
		List<Vehicle> vehiclesList;

		public Form1()
		{
			InitializeComponent();
			InitializeMap();
			CreateVehiclesList();
		}

		private void CreateVehiclesList()
		{
			vehiclesList = new List<Vehicle>();

			vehiclesList.Add(new Vehicle("34 ABC 123", "Car", new PointLatLng(40.785397813331365, 31.315855975984952), "Istanbul", "Ankara"));
			vehiclesList.Add(new Vehicle("35 DEF 456", "Truck", new PointLatLng(37.49294824548611, 29.31525021416406), "Izmir", "Antalya"));
			vehiclesList.Add(new Vehicle("06 GHI 789", "Bus", new PointLatLng(38.22548069806728, 32.2572346766421), "Bursa", "Konya"));
			vehiclesList.Add(new Vehicle("07 JKL 101", "Motorcycle", new PointLatLng(36.988929029068515, 35.14200101760847), "Adana", "Mersin"));
			vehiclesList.Add(new Vehicle("08 MNO 112", "Bicycle", new PointLatLng(37.651220129700384, 39.21234331898435), "Gaziantep", "Diyarbakir"));

		}

		private void InitializeMap()
		{
			map.DragButton = MouseButtons.Left;
			map.MapProvider = GMapProviders.GoogleMap;
			map.Position = new GMap.NET.PointLatLng(39.259964455356815, 35.20948397150086);
			map.MinZoom = 3;
			map.MaxZoom = 25;
			map.Zoom = 6;


			overlayOne = new GMapOverlay("OverlayOne");
			map.Overlays.Add(overlayOne);

		}

		private void buttonPlace1_Click(object sender, EventArgs e)
		{
			PointLatLng point1 = new PointLatLng(Convert.ToDouble(textBoxPlace1Latitude1.Text), Convert.ToDouble(textBoxPlace1Longitude1.Text));
			GMarkerGoogle marker1 = new GMarkerGoogle(point1, GMarkerGoogleType.red_pushpin);

			marker1.ToolTipText = string.Format("\nPlace 1\nLatitude: {0}\nLongitude: {1}\n", textBoxPlace1Latitude1.Text, textBoxPlace1Longitude1.Text);
			marker1.ToolTipMode = MarkerTooltipMode.Always;
			marker1.ToolTip.Fill = Brushes.Black;
			marker1.ToolTip.Foreground = Brushes.White;
			marker1.ToolTip.Stroke = Pens.Black;
			marker1.ToolTip.TextPadding = new Size(10, 10);
			marker1.Tag = 101;

			overlayOne.Markers.Add(marker1);
		}


		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			map.Dispose();
			Application.Exit();
		}

		private void buttonPlace2_Click(object sender, EventArgs e)
		{
			PointLatLng point2 = new PointLatLng(Convert.ToDouble(textBoxPlace2Latitude2.Text), Convert.ToDouble(textBoxPlace2Longitude2.Text));
			GMarkerGoogle marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.arrow);

			marker2.ToolTipText = string.Format("\nPlace 2\nLatitude: {0}\nLongitude: {1}\n", textBoxPlace2Latitude2.Text, textBoxPlace2Longitude2.Text);
			marker2.ToolTipMode = MarkerTooltipMode.Always;
			marker2.ToolTip.Fill = Brushes.Black;
			marker2.ToolTip.Foreground = Brushes.White;
			marker2.ToolTip.Stroke = Pens.Black;
			marker2.ToolTip.TextPadding = new Size(10, 10);
			marker2.Tag = 102;

			overlayOne.Markers.Add(marker2);

		}

		private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
		{
			//int markerId = (int)item.Tag;
			//Console.WriteLine("Marker Id: " + markerId + " marker is clicked.");

			string selectedVehicle = item.Tag.ToString();

			foreach (var vehicle in vehiclesList)
			{
				if (vehicle.Plate == selectedVehicle)
				{
					textBoxPlate.Text = vehicle.Plate;
					textBoxVehicleType.Text = vehicle.VehicleType;
					textBoxFrom.Text = vehicle.From;
					textBoxTo.Text = vehicle.To;
					break;

				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			foreach (var vehicle in vehiclesList)
			{

				GMarkerGoogle marker = new GMarkerGoogle(vehicle.Location, GMarkerGoogleType.green_small);
				overlayOne.Markers.Add(marker);

				marker.ToolTipText = string.Format("\nVehicle\nPlate: {0}\nType: {1}\nFrom: {2}\nTo: {3}\n", vehicle.Plate, vehicle.VehicleType, vehicle.From, vehicle.To);
				marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
				marker.ToolTip.Fill = Brushes.AliceBlue;
				marker.ToolTip.Foreground = Brushes.Black;
				marker.ToolTip.Stroke = Pens.Black;
				marker.ToolTip.TextPadding = new Size(10, 10);
				marker.Tag = vehicle.Plate;

			}
		}
	}
}
