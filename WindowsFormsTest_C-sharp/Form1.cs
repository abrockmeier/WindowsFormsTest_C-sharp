using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest_C_sharp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cmd_OK_Click(object sender, EventArgs e)
		{
			 //this.Close();
			lbl_AusgabeVorname.Text =  txt_Vorname.Text;
			lbl_AusgabeVorname.Visible = true;
			lbl_AusgabeNachname.Text = txt_Nachname.Text;
			lbl_AusgabeNachname.Visible = true;
		}

		private void cmd_abort_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lbl_AusgabeVorname.Visible = false;
			lbl_AusgabeNachname.Visible = false;
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
