using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
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


		}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
			map2.Dispose();
			Application.Exit();
		}
	}
}
