namespace GeograpicInformationSystemProject
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.map2 = new GMap.NET.WindowsForms.GMapControl();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.plate2 = new System.Windows.Forms.Label();
			this.textBoxPlate2 = new System.Windows.Forms.TextBox();
			this.textBoxTo2 = new System.Windows.Forms.TextBox();
			this.textBoxFrom2 = new System.Windows.Forms.TextBox();
			this.textBoxVehicleType2 = new System.Windows.Forms.TextBox();
			this.to2 = new System.Windows.Forms.Label();
			this.from2 = new System.Windows.Forms.Label();
			this.vehicleType2 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// map2
			// 
			this.map2.Bearing = 0F;
			this.map2.CanDragMap = true;
			this.map2.EmptyTileColor = System.Drawing.Color.Navy;
			this.map2.GrayScaleMode = false;
			this.map2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.map2.LevelsKeepInMemory = 5;
			this.map2.Location = new System.Drawing.Point(12, 12);
			this.map2.MarkersEnabled = true;
			this.map2.MaxZoom = 2;
			this.map2.MinZoom = 2;
			this.map2.MouseWheelZoomEnabled = true;
			this.map2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.map2.Name = "map2";
			this.map2.NegativeMode = false;
			this.map2.PolygonsEnabled = true;
			this.map2.RetryLoadTile = 0;
			this.map2.RoutesEnabled = true;
			this.map2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.map2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.map2.ShowTileGridLines = false;
			this.map2.Size = new System.Drawing.Size(1057, 430);
			this.map2.TabIndex = 0;
			this.map2.Zoom = 0D;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(12, 459);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(847, 150);
			this.dataGridView2.TabIndex = 1;
			// 
			// plate2
			// 
			this.plate2.AutoSize = true;
			this.plate2.Location = new System.Drawing.Point(903, 514);
			this.plate2.Name = "plate2";
			this.plate2.Size = new System.Drawing.Size(37, 13);
			this.plate2.TabIndex = 2;
			this.plate2.Text = "Plate: ";
			// 
			// textBoxPlate2
			// 
			this.textBoxPlate2.Location = new System.Drawing.Point(946, 511);
			this.textBoxPlate2.Name = "textBoxPlate2";
			this.textBoxPlate2.Size = new System.Drawing.Size(123, 20);
			this.textBoxPlate2.TabIndex = 3;
			// 
			// textBoxTo2
			// 
			this.textBoxTo2.Location = new System.Drawing.Point(946, 589);
			this.textBoxTo2.Name = "textBoxTo2";
			this.textBoxTo2.Size = new System.Drawing.Size(123, 20);
			this.textBoxTo2.TabIndex = 5;
			// 
			// textBoxFrom2
			// 
			this.textBoxFrom2.Location = new System.Drawing.Point(946, 563);
			this.textBoxFrom2.Name = "textBoxFrom2";
			this.textBoxFrom2.Size = new System.Drawing.Size(123, 20);
			this.textBoxFrom2.TabIndex = 6;
			// 
			// textBoxVehicleType2
			// 
			this.textBoxVehicleType2.Location = new System.Drawing.Point(946, 537);
			this.textBoxVehicleType2.Name = "textBoxVehicleType2";
			this.textBoxVehicleType2.Size = new System.Drawing.Size(123, 20);
			this.textBoxVehicleType2.TabIndex = 7;
			// 
			// to2
			// 
			this.to2.AutoSize = true;
			this.to2.Location = new System.Drawing.Point(903, 592);
			this.to2.Name = "to2";
			this.to2.Size = new System.Drawing.Size(23, 13);
			this.to2.TabIndex = 9;
			this.to2.Text = "To:";
			// 
			// from2
			// 
			this.from2.AutoSize = true;
			this.from2.Location = new System.Drawing.Point(903, 566);
			this.from2.Name = "from2";
			this.from2.Size = new System.Drawing.Size(33, 13);
			this.from2.TabIndex = 10;
			this.from2.Text = "From:";
			// 
			// vehicleType2
			// 
			this.vehicleType2.AutoSize = true;
			this.vehicleType2.Location = new System.Drawing.Point(868, 540);
			this.vehicleType2.Name = "vehicleType2";
			this.vehicleType2.Size = new System.Drawing.Size(72, 13);
			this.vehicleType2.TabIndex = 11;
			this.vehicleType2.Text = "Vehicle Type:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(965, 470);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Vehicle Details";
			// 
			// Form2
			// 
			this.ClientSize = new System.Drawing.Size(1091, 625);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.vehicleType2);
			this.Controls.Add(this.from2);
			this.Controls.Add(this.to2);
			this.Controls.Add(this.textBoxVehicleType2);
			this.Controls.Add(this.textBoxFrom2);
			this.Controls.Add(this.textBoxTo2);
			this.Controls.Add(this.textBoxPlate2);
			this.Controls.Add(this.plate2);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.map2);
			this.Name = "Form2";
			this.Text = "Form2";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GMap.NET.WindowsForms.GMapControl gMapControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label type;
		private System.Windows.Forms.Label from;
		private System.Windows.Forms.Label to;
		private System.Windows.Forms.Label plate;
		private System.Windows.Forms.TextBox textBoxVehicleType;
		private System.Windows.Forms.TextBox textBoxFrom;
		private System.Windows.Forms.TextBox textBoxTo;
		private System.Windows.Forms.TextBox textBoxPlate;
		private System.Windows.Forms.DataGridView dataGridView1;
		private GMap.NET.WindowsForms.GMapControl map2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label plate2;
		private System.Windows.Forms.TextBox textBoxPlate2;
		private System.Windows.Forms.TextBox textBoxTo2;
		private System.Windows.Forms.TextBox textBoxFrom2;
		private System.Windows.Forms.TextBox textBoxVehicleType2;
		private System.Windows.Forms.Label to2;
		private System.Windows.Forms.Label from2;
		private System.Windows.Forms.Label vehicleType2;
		private System.Windows.Forms.Label label2;
	}
}