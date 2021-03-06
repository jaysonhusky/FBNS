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
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace FBNS.My
{

	[System.Runtime.CompilerServices.CompilerGeneratedAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"), System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : global::System.Configuration.ApplicationSettingsBase
	{

		private static MySettings defaultInstance = (MySettings)global::System.Configuration.ApplicationSettingsBase.Synchronized(new MySettings());

		#region "My.Settings Auto-Save Functionality"

		private static bool addedHandler;

		private static object addedHandlerLockObject = new object();
		[System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(global::System.Object sender, global::System.EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit) {
				FBNS.My.Settings.Save();
			}
		}
		#endregion

		public static MySettings Default {
			get {

				if (!addedHandler) {
					lock (addedHandlerLockObject) {
						if (!addedHandler) {
							MyProject.Application.Shutdown += AutoSaveSettings;
							addedHandler = true;
						}
					}
				}
				return defaultInstance;
			}
		}

		[System.Configuration.ApplicationScopedSettingAttribute(), System.Diagnostics.DebuggerNonUserCodeAttribute(), System.Configuration.DefaultSettingValueAttribute("http://jthstudios.byethost12.com/tools/fbns/latest.xml")]
		public string ListURL {
			get { return Convert.ToString(this["ListURL"]); }
		}

		[System.Configuration.UserScopedSettingAttribute(), System.Diagnostics.DebuggerNonUserCodeAttribute(), System.Configuration.DefaultSettingValueAttribute("0")]
		public string AlertChoice {
			get { return Convert.ToString(this["AlertChoice"]); }
			set { this["AlertChoice"] = value; }
		}

		[System.Configuration.UserScopedSettingAttribute(), System.Diagnostics.DebuggerNonUserCodeAttribute(), System.Configuration.DefaultSettingValueAttribute("0")]
		public string RecheckRate {
			get { return Convert.ToString(this["RecheckRate"]); }
			set { this["RecheckRate"] = value; }
		}
	}
}

namespace FBNS.My
{

	[Microsoft.VisualBasic.HideModuleNameAttribute(), System.Diagnostics.DebuggerNonUserCodeAttribute(), System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	static internal class MySettingsProperty
	{

		[System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")]
		static internal global::FBNS.My.MySettings Settings {
			get { return global::FBNS.My.MySettings.Default; }
		}
	}
}
