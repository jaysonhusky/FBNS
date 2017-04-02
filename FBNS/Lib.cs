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
using System.IO;
using System.Security.Cryptography;
namespace FBNS
{
	static class XLib
	{
		private static  SERVER_URL = ""; // Not yet configured
		private static string fileToCheck = "";
		private static string newfileToCheck = "";
		private static byte[] fileHash;
		public static object CheckFormStatus(form)
		{
			dynamic input = null;
			input = form.WindowState;
			if ((input == FormWindowState.Normal)) {
				return 1;
			}
			return null;
		}
		public static object LoadUsersSettings()
		{
			var Setting_Alert_User_Set = FBNS.My.Settings.AlertChoice;
			var Setting_Refresh_User_Set = FBNS.My.Settings.RecheckRate;
			My.MyProject.Forms.SettingsPanel.ComboBox2.SelectedIndex = Setting_Alert_User_Set;
			My.MyProject.Forms.SettingsPanel.ComboBox1.SelectedIndex = Setting_Refresh_User_Set;
			return null;
		}
		public static object Check_AlertStatus()
		{
			dynamic userchoice_alert_setting = null;
			userchoice_alert_setting = FBNS.My.Settings.AlertChoice;
			if ((userchoice_alert_setting == 0)) {
				// Alerts are enabled
				My.MyProject.Forms.Form1.Timer1.Start();
			} else if ((userchoice_alert_setting == 1)) {
				// Alerts are disabled
			} else {
				// Do Nothing!
			}
			return null;
		}
		public static object DetermineNextUpdate()
		{
			dynamic userchoice_refreshrate_setting = null;
			userchoice_refreshrate_setting = FBNS.My.Settings.RecheckRate;
			dynamic TTNC = null;
			if ((userchoice_refreshrate_setting == 0)) {
				TTNC = 30.0;
			} else if ((userchoice_refreshrate_setting == 1)) {
				// 45m
				TTNC = 45.0;
			} else if ((userchoice_refreshrate_setting == 2)) {
				// 60m
				TTNC = 60.0;
			} else if ((userchoice_refreshrate_setting == 3)) {
				// 60m
				TTNC = 0.0;
			} else {
				TTNC = 30.0;
			}
			My.MyProject.Forms.Form1.Label2.Text = DateTime.Now.AddMinutes(TTNC).ToString();
			return null;
		}
		public static object Check_RefreshRate()
		{
			dynamic userchoice_refreshrate_setting = null;
			dynamic apprefreshrate = null;
			userchoice_refreshrate_setting = FBNS.My.Settings.RecheckRate;
			if ((userchoice_refreshrate_setting == 0)) {
				// 30m
				apprefreshrate = 1800;
			} else if ((userchoice_refreshrate_setting == 1)) {
				// 45m
				apprefreshrate = 2700;
			} else if ((userchoice_refreshrate_setting == 2)) {
				// 60m
				apprefreshrate = 3600;
			} else if ((userchoice_refreshrate_setting == 3)) {
				// NEVER
				apprefreshrate = 1000000;
			} else {
				apprefreshrate = 1800;
			}
			return apprefreshrate;
		}
		public static object LoadPanel(input)
		{
			if ((input == "About")) {
				My.MyProject.Forms.Additional.MetroLabel1.Text = "About: FBNS";
				My.MyProject.Forms.Additional.MetroTextBox1.Text = "FBNS is (C) JaysonHusky)";
			} else if ((input == "InformationStorage")) {
				My.MyProject.Forms.Additional.MetroLabel1.Text = "About: Information Storage";
				My.MyProject.Forms.Additional.MetroTextBox1.Text = "FBNS stores 2 files on your device for the sake of functionality, one contains your settings which are set within the app, and the other contains the offline version of the list.";
			} else {
				// Do Nothing
			}
			return null;
		}
		private static byte[] ComputeFileHash(string fileName)
		{
			byte[] ourHash = new byte[1];
			// If file exists, create a HashAlgorithm instance based off of MD5 encryption
			// You could use a variant of SHA or RIPEMD160 if you like with larger hash bit sizes.
			if (File.Exists(fileName)) {
				try {
					HashAlgorithm ourHashAlg = HashAlgorithm.Create("MD5");
					FileStream fileToHash = new FileStream(fileName, FileMode.Open, FileAccess.Read);
					//Compute the hash to return using the Stream we created.
					ourHash = ourHashAlg.ComputeHash(fileToHash);
					fileToHash.Close();
				} catch (IOException ex) {
					MessageBox.Show("There was an error opening the file: " + ex.Message);
				}
			}
			return ourHash;
		}
		// Return true/false if the two hashes are the same.
		private static bool CompareByteHashes(byte[] newHash, byte[] oldHash)
		{
			// If any of these conditions are true, the hashes are definitely not the same.
			if (newHash == null | oldHash == null | newHash.Length != oldHash.Length) {
				return false;
			}
			// Compare each byte of the two hashes. Any time they are not the same, we know there was a change.
			for (int i = 0; i <= newHash.Length - 1; i++) {
				if (newHash[i] != oldHash[i]) {
					return false;
				}
			}
			return true;
		}
		public static object Check_hash_of_list()
		{
			fileToCheck = Application.StartupPath + "/loc.info.xml";
			newfileToCheck = Application.StartupPath + "/net.info.xml";
			fileHash = ComputeFileHash(fileToCheck);
			if (!string.IsNullOrEmpty(fileToCheck)) {
				byte[] newFileHash = ComputeFileHash(newfileToCheck);
				if (CompareByteHashes(newFileHash, fileHash)) {
					// No Changes were made, so no need to update the toast system
				} else {
					My.MyProject.Forms.Form1.TabPageHTML.Text = "Live History" + " (Updated)";
					My.MyProject.Forms.Form1.Label2.Text = DateTime.Now.AddMinutes(10.0).ToString();
					My.MyProject.Forms.Form1.NotifyIcon2.BalloonTipTitle = "FBNS - Live Update";
					My.MyProject.Forms.Form1.NotifyIcon2.BalloonTipText = "A company has changed its commission status! (Click to view)";
					//NotifyIcon1.
					My.MyProject.Forms.Form1.NotifyIcon2.ShowBalloonTip(2000);
				}
			} else {
				Interaction.MsgBox("Failed");
			}
			return null;
		}
		public static object ObtainNewList()
		{
			string LPath = Application.StartupPath;
			if ((File.Exists(LPath + "/net.info.xml"))) {
				File.Delete(LPath + "/loc.info.xml");
				FBNS.My.MyProject.Computer.FileSystem.RenameFile(LPath + "/net.info.xml", "loc.info.xml");
				FBNS.My.MyProject.Computer.Network.DownloadFile("" + SERVER_URL + "/tools/fbns/latest.xml", Application.StartupPath + "/net.info.xml");
			} else {
				FBNS.My.MyProject.Computer.Network.DownloadFile("" + SERVER_URL + "/tools/fbns/latest.xml", Application.StartupPath + "/net.info.xml");
			}
			return null;
		}
	}
}
