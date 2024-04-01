using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeograpicInformationSystemProject
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Form1 mainForm = new Form1();
			Form2 form2 = new Form2();

			mainForm.Show();
			form2.Show();


			Application.Run(mainForm);
		}
	}
}
