using System;
using System.Windows.Forms;

namespace ArchiveRipper
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			// Enable custom visual styles
			Application.EnableVisualStyles();

			Application.SetCompatibleTextRenderingDefault(false);

			Application.Run(new MainForm());
		}
	}
}
