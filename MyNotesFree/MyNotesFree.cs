/*
 * Created by SharpDevelop.
 * User: roque.possamai
 * Date: 12/07/2019
 */
using System;
using System.Threading;
using System.Windows.Forms;
using MyNotesFree;

namespace MyNotesFree
{
	/// <summary>
	/// Description of MyNotesFree.
	/// </summary>
	public class MyNotesFree
	{
		public MyNotesFree()
		{
			//???
		}
	
		[STAThreadAttribute]
		public static void Main(String[] args)
		{
			bool isFirstInstance;
			using (Mutex mtx = new Mutex(true, "MyNotesFree.net", out isFirstInstance)) {
				if (isFirstInstance) {
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new frPrincipal());
				} else {
					// The application is already running
					MessageBox.Show("O MyNotesFree.net já está executando!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
	}
	
}
