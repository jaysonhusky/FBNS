using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Data.DataSet;
using System.IO;
using System.Web;
using System.Xml;
using System.Net;
namespace FBNS
{
	public partial class Form1
	{
		int TimerValue = 0;
		public DataSet objDataset = new DataSet();
		
		//Dim URL_InfoStamp = "" // not yet configured
		 URL_InfoStamp = "info.xml";
		 testurl = FBNS.My.Settings.ListURL;
		private void ButtonClose_Click(System.Object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			// Always obtain new version (regardless of updates when app loads)
			XLib.ObtainNewList();
			// Set to Default metro theme (helps stop UI issues in XP/Vista
			this.Theme = MetroFramework.MetroThemeStyle.Default;
			dgViewPreview.Theme = MetroFramework.MetroThemeStyle.Default;
			// AutoSize cells ready for use
			dgViewPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			// Load data
			this.dgViewPreview.DataSource = null;
			objDataset.ReadXml(URL_InfoStamp.ToString.Trim, XmlReadMode.Auto);
			dgViewPreview.DataSource = objDataset.Tables[2];
			XLib.DetermineNextUpdate();
			XLib.Check_AlertStatus();
		}
		private void Form1_Resize(object sender, System.EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized) {
				NotifyIcon1.Visible = true;
				this.Hide();
				NotifyIcon1.BalloonTipText = "FBNS will now run in the background.";
				NotifyIcon1.ShowBalloonTip(500);
			}
		}
		private void NotifyIcon1_DoubleClick(object sender, System.EventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			NotifyIcon1.Visible = false;
			//dgViewPreview.Sort(dgViewPreview.Columns(2), ListSortDirection.Ascending)
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if ((NotifyIcon1.Visible == true)) {
				NotifyIcon1.Visible = false;
			}
		}
		private void Timer1_Tick(object sender, EventArgs e)
		{
			XLib.CheckFormStatus(this);
			TimerValue += 1;
			if ((TimerValue == XLib.Check_RefreshRate())) {
				TimerValue = 0;
				XLib.Check_hash_of_list();
				XLib.DetermineNextUpdate();
			}
		}
		private void NotifyIcon2_BalloonTipClicked(object sender, EventArgs e)
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			NotifyIcon1.Visible = false;
		}
		private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			My.MyProject.Forms.SettingsPanel.Show();
		}
		private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			XLib.LoadPanel("About");
			My.MyProject.Forms.Additional.Show();
		}
		private void InformationStorageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			XLib.LoadPanel("InformationStorage");
			My.MyProject.Forms.Additional.Show();
		}
	}
}
