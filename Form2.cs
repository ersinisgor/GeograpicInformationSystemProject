using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeograpicInformationSystemProject
{
	public partial class Form2 : Form
	{
		GMapOverlay overlayOne;
		List<Vehicle> vehiclesList;
		SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1LT3S9C\SQL2022;Initial Catalog=C#_Projects_Udemy;Integrated Security=True;Encrypt=False");

		public Form2()
		{
			InitializeComponent();
			InitializeMap();
			CreateVehiclesList();
		}

		private void InitializeMap()
		{
			map2.DragButton = MouseButtons.Left;
			map2.MapProvider = GMapProviders.GoogleMap;
			map2.Position = new GMap.NET.PointLatLng(39.259964455356815, 34.20948397150086);
			map2.MinZoom = 3;
			map2.MaxZoom = 25;
			map2.Zoom = 6;


			overlayOne = new GMapOverlay("OverlayOne");
			map2.Overlays.Add(overlayOne);
		}

		public void CreateVehiclesList()
		{
			vehiclesList = new List<Vehicle>();

			try
			{
				connection.Open();
				string query = "SELECT Plate, VehicleType, FromWhere, ToWhere, Latitude, Longitude FROM Vehicles";

				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				DataTable table = new DataTable();
				adapter.Fill(table);
				if (table.Rows.Count > 0)
				{
					dataGridView2.DataSource = table;
				}

				for (int i = 0; i < table.Rows.Count; i++)
				{
					vehiclesList.Add(new Vehicle(table.Rows[i][0].ToString(), 
																			table.Rows[i][1].ToString(), 
																			new PointLatLng(Convert.ToDouble(table.Rows[i][4]), 
																			Convert.ToDouble(table.Rows[i][5])), 
																			table.Rows[i][2].ToString(), 
																			table.Rows[i][3].ToString()));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occured while connection to the database, ErrorCode:CON101\n\n" + ex.Message);
			}
			finally
			{
				if (connection != null)
					connection.Close();
			}

			ShowVehicleOnMap();
		}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
			map2.Dispose();
			Application.Exit();
		}

		private void ShowVehicleOnMap()
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

		private void map2_OnMarkerClick(GMapMarker item, MouseEventArgs e)
		{
			string selectedVehicle = item.Tag.ToString();

			foreach (var vehicle in vehiclesList)
			{
				if (vehicle.Plate == selectedVehicle)
				{
					textBoxPlate2.Text = vehicle.Plate;
					textBoxVehicleType2.Text = vehicle.VehicleType;
					textBoxFrom2.Text = vehicle.From;
					textBoxTo2.Text = vehicle.To;
					break;

				}
			}
		}
	}
}
