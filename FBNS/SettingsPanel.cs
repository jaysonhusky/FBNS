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
namespace FBNS
{
	public partial class SettingsPanel
	{
		private void GroupBox1_Enter(object sender, EventArgs e)
		{
		}
		private void Button1_Click(object sender, EventArgs e)
		{
			//Save the users preferences
			//------------------------------------------------------------------------------
			//Refresh Rate
			// 0=30m | 1=45m | 2=60m | 3=Disabled
			FBNS.My.Settings.RecheckRate = ComboBox1.SelectedIndex;
			//Live Notify
			// 0=enabled | 1=disabled
			FBNS.My.Settings.AlertChoice = ComboBox2.SelectedIndex;


			MessageBox.Show("Settings Saved successfully." + Constants.vbCrLf + Constants.vbCrLf + "FBNS will now restart to enable your settings to take effect", "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Application.Restart();
		}
		private void SettingsPanel_Load(object sender, EventArgs e)
		{
			XLib.LoadUsersSettings();
		}
		public SettingsPanel()
		{
			Load += SettingsPanel_Load;
			InitializeComponent();
		}
	}
}
