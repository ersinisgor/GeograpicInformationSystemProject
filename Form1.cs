using GMap.NET.MapProviders;
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
		public Form1()
		{
			InitializeComponent();
			InitializeMap();
		}

		private void InitializeMap()
		{
			map.DragButton = MouseButtons.Left;
			map.MapProvider = GMapProviders.GoogleMap;
			map.Position = new GMap.NET.PointLatLng(36.3275, 32.8187);
			map.MinZoom = 4;
			map.MaxZoom = 25;
			map.Zoom = 10;

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			map.Dispose();
			Application.Exit();
		}
	}
}
