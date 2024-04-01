namespace GeograpicInformationSystemProject
{
	partial class Form1
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
			this.map1 = new GMap.NET.WindowsForms.GMapControl();
			this.labelPlace2Latitude2 = new System.Windows.Forms.Label();
			this.labelPlace2Longitude2 = new System.Windows.Forms.Label();
			this.textBoxPlace2Latitude2 = new System.Windows.Forms.TextBox();
			this.textBoxPlace2Longitude2 = new System.Windows.Forms.TextBox();
			this.buttonPlace2 = new System.Windows.Forms.Button();
			this.buttonPlace1 = new System.Windows.Forms.Button();
			this.textBoxPlace1Longitude1 = new System.Windows.Forms.TextBox();
			this.textBoxPlace1Latitude1 = new System.Windows.Forms.TextBox();
			this.labelPlace1Longitude1 = new System.Windows.Forms.Label();
			this.labelPlace1Latitude1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxPlate = new System.Windows.Forms.TextBox();
			this.textBoxTo = new System.Windows.Forms.TextBox();
			this.textBoxFrom = new System.Windows.Forms.TextBox();
			this.textBoxVehicleType = new System.Windows.Forms.TextBox();
			this.plate = new System.Windows.Forms.Label();
			this.to = new System.Windows.Forms.Label();
			this.from = new System.Windows.Forms.Label();
			this.type = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// map1
			// 
			this.map1.Bearing = 0F;
			this.map1.CanDragMap = true;
			this.map1.EmptyTileColor = System.Drawing.Color.Navy;
			this.map1.GrayScaleMode = false;
			this.map1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.map1.LevelsKeepInMemory = 5;
			this.map1.Location = new System.Drawing.Point(12, 12);
			this.map1.MarkersEnabled = true;
			this.map1.MaxZoom = 2;
			this.map1.MinZoom = 2;
			this.map1.MouseWheelZoomEnabled = true;
			this.map1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.map1.Name = "map1";
			this.map1.NegativeMode = false;
			this.map1.PolygonsEnabled = true;
			this.map1.RetryLoadTile = 0;
			this.map1.RoutesEnabled = true;
			this.map1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.map1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.map1.ShowTileGridLines = false;
			this.map1.Size = new System.Drawing.Size(699, 623);
			this.map1.TabIndex = 0;
			this.map1.Zoom = 0D;
			this.map1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.map_OnMarkerClick);
			// 
			// labelPlace2Latitude2
			// 
			this.labelPlace2Latitude2.AutoSize = true;
			this.labelPlace2Latitude2.Location = new System.Drawing.Point(720, 185);
			this.labelPlace2Latitude2.Name = "labelPlace2Latitude2";
			this.labelPlace2Latitude2.Size = new System.Drawing.Size(60, 13);
			this.labelPlace2Latitude2.TabIndex = 2;
			this.labelPlace2Latitude2.Text = "Latitude 2: ";
			// 
			// labelPlace2Longitude2
			// 
			this.labelPlace2Longitude2.AutoSize = true;
			this.labelPlace2Longitude2.Location = new System.Drawing.Point(893, 185);
			this.labelPlace2Longitude2.Name = "labelPlace2Longitude2";
			this.labelPlace2Longitude2.Size = new System.Drawing.Size(69, 13);
			this.labelPlace2Longitude2.TabIndex = 3;
			this.labelPlace2Longitude2.Text = "Longitude 2: ";
			// 
			// textBoxPlace2Latitude2
			// 
			this.textBoxPlace2Latitude2.Location = new System.Drawing.Point(786, 182);
			this.textBoxPlace2Latitude2.Name = "textBoxPlace2Latitude2";
			this.textBoxPlace2Latitude2.Size = new System.Drawing.Size(81, 20);
			this.textBoxPlace2Latitude2.TabIndex = 4;
			// 
			// textBoxPlace2Longitude2
			// 
			this.textBoxPlace2Longitude2.Location = new System.Drawing.Point(968, 182);
			this.textBoxPlace2Longitude2.Name = "textBoxPlace2Longitude2";
			this.textBoxPlace2Longitude2.Size = new System.Drawing.Size(81, 20);
			this.textBoxPlace2Longitude2.TabIndex = 5;
			// 
			// buttonPlace2
			// 
			this.buttonPlace2.Location = new System.Drawing.Point(819, 233);
			this.buttonPlace2.Name = "buttonPlace2";
			this.buttonPlace2.Size = new System.Drawing.Size(143, 23);
			this.buttonPlace2.TabIndex = 6;
			this.buttonPlace2.Text = "Mark Place 2";
			this.buttonPlace2.UseVisualStyleBackColor = true;
			this.buttonPlace2.Click += new System.EventHandler(this.buttonPlace2_Click);
			// 
			// buttonPlace1
			// 
			this.buttonPlace1.Location = new System.Drawing.Point(819, 98);
			this.buttonPlace1.Name = "buttonPlace1";
			this.buttonPlace1.Size = new System.Drawing.Size(143, 23);
			this.buttonPlace1.TabIndex = 11;
			this.buttonPlace1.Text = "Mark Place 1";
			this.buttonPlace1.UseVisualStyleBackColor = true;
			this.buttonPlace1.Click += new System.EventHandler(this.buttonPlace1_Click);
			// 
			// textBoxPlace1Longitude1
			// 
			this.textBoxPlace1Longitude1.Location = new System.Drawing.Point(968, 47);
			this.textBoxPlace1Longitude1.Name = "textBoxPlace1Longitude1";
			this.textBoxPlace1Longitude1.Size = new System.Drawing.Size(81, 20);
			this.textBoxPlace1Longitude1.TabIndex = 10;
			// 
			// textBoxPlace1Latitude1
			// 
			this.textBoxPlace1Latitude1.Location = new System.Drawing.Point(786, 47);
			this.textBoxPlace1Latitude1.Name = "textBoxPlace1Latitude1";
			this.textBoxPlace1Latitude1.Size = new System.Drawing.Size(81, 20);
			this.textBoxPlace1Latitude1.TabIndex = 9;
			// 
			// labelPlace1Longitude1
			// 
			this.labelPlace1Longitude1.AutoSize = true;
			this.labelPlace1Longitude1.Location = new System.Drawing.Point(893, 50);
			this.labelPlace1Longitude1.Name = "labelPlace1Longitude1";
			this.labelPlace1Longitude1.Size = new System.Drawing.Size(69, 13);
			this.labelPlace1Longitude1.TabIndex = 8;
			this.labelPlace1Longitude1.Text = "Longitude 1: ";
			// 
			// labelPlace1Latitude1
			// 
			this.labelPlace1Latitude1.AutoSize = true;
			this.labelPlace1Latitude1.Location = new System.Drawing.Point(720, 50);
			this.labelPlace1Latitude1.Name = "labelPlace1Latitude1";
			this.labelPlace1Latitude1.Size = new System.Drawing.Size(60, 13);
			this.labelPlace1Latitude1.TabIndex = 7;
			this.labelPlace1Latitude1.Text = "Latitude 1: ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(819, 362);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 35);
			this.button1.TabIndex = 12;
			this.button1.Text = "Show vehicles";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxPlate
			// 
			this.textBoxPlate.Location = new System.Drawing.Point(896, 482);
			this.textBoxPlate.Name = "textBoxPlate";
			this.textBoxPlate.Size = new System.Drawing.Size(123, 20);
			this.textBoxPlate.TabIndex = 13;
			// 
			// textBoxTo
			// 
			this.textBoxTo.Location = new System.Drawing.Point(896, 560);
			this.textBoxTo.Name = "textBoxTo";
			this.textBoxTo.Size = new System.Drawing.Size(123, 20);
			this.textBoxTo.TabIndex = 15;
			// 
			// textBoxFrom
			// 
			this.textBoxFrom.Location = new System.Drawing.Point(896, 534);
			this.textBoxFrom.Name = "textBoxFrom";
			this.textBoxFrom.Size = new System.Drawing.Size(123, 20);
			this.textBoxFrom.TabIndex = 16;
			// 
			// textBoxVehicleType
			// 
			this.textBoxVehicleType.Location = new System.Drawing.Point(896, 508);
			this.textBoxVehicleType.Name = "textBoxVehicleType";
			this.textBoxVehicleType.Size = new System.Drawing.Size(123, 20);
			this.textBoxVehicleType.TabIndex = 18;
			// 
			// plate
			// 
			this.plate.AutoSize = true;
			this.plate.Location = new System.Drawing.Point(853, 485);
			this.plate.Name = "plate";
			this.plate.Size = new System.Drawing.Size(37, 13);
			this.plate.TabIndex = 19;
			this.plate.Text = "Plate: ";
			// 
			// to
			// 
			this.to.AutoSize = true;
			this.to.Location = new System.Drawing.Point(864, 563);
			this.to.Name = "to";
			this.to.Size = new System.Drawing.Size(26, 13);
			this.to.TabIndex = 21;
			this.to.Text = "To: ";
			// 
			// from
			// 
			this.from.AutoSize = true;
			this.from.Location = new System.Drawing.Point(854, 537);
			this.from.Name = "from";
			this.from.Size = new System.Drawing.Size(36, 13);
			this.from.TabIndex = 22;
			this.from.Text = "From: ";
			// 
			// type
			// 
			this.type.AutoSize = true;
			this.type.Location = new System.Drawing.Point(816, 511);
			this.type.Name = "type";
			this.type.Size = new System.Drawing.Size(72, 13);
			this.type.TabIndex = 24;
			this.type.Text = "Vehicle Type:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(920, 452);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 25;
			this.label1.Text = "Vehicle Details";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1058, 684);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.type);
			this.Controls.Add(this.from);
			this.Controls.Add(this.to);
			this.Controls.Add(this.plate);
			this.Controls.Add(this.textBoxVehicleType);
			this.Controls.Add(this.textBoxFrom);
			this.Controls.Add(this.textBoxTo);
			this.Controls.Add(this.textBoxPlate);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonPlace1);
			this.Controls.Add(this.textBoxPlace1Longitude1);
			this.Controls.Add(this.textBoxPlace1Latitude1);
			this.Controls.Add(this.labelPlace1Longitude1);
			this.Controls.Add(this.labelPlace1Latitude1);
			this.Controls.Add(this.buttonPlace2);
			this.Controls.Add(this.textBoxPlace2Longitude2);
			this.Controls.Add(this.textBoxPlace2Latitude2);
			this.Controls.Add(this.labelPlace2Longitude2);
			this.Controls.Add(this.labelPlace2Latitude2);
			this.Controls.Add(this.map1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GMap.NET.WindowsForms.GMapControl map1;

		private System.Windows.Forms.Label labelPlace2Latitude2;
		private System.Windows.Forms.Label labelPlace2Longitude2;
		private System.Windows.Forms.TextBox textBoxPlace2Latitude2;
		private System.Windows.Forms.TextBox textBoxPlace2Longitude2;
		private System.Windows.Forms.Button buttonPlace2;
		private System.Windows.Forms.Button buttonPlace1;
		private System.Windows.Forms.TextBox textBoxPlace1Longitude1;
		private System.Windows.Forms.TextBox textBoxPlace1Latitude1;
		private System.Windows.Forms.Label labelPlace1Longitude1;
		private System.Windows.Forms.Label labelPlace1Latitude1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxPlate;
		private System.Windows.Forms.TextBox textBoxTo;
		private System.Windows.Forms.TextBox textBoxFrom;
		private System.Windows.Forms.TextBox textBoxVehicleType;
		private System.Windows.Forms.Label plate;
		private System.Windows.Forms.Label to;
		private System.Windows.Forms.Label from;
		private System.Windows.Forms.Label type;
		private System.Windows.Forms.Label label1;
	}
}

