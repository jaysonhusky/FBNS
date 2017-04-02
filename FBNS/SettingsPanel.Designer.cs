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
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	//Inherits System.Windows.Forms.Form
	partial class SettingsPanel : MetroFramework.Forms.MetroForm
	{


		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.ComboBox2 = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.ComboBox2);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Location = new System.Drawing.Point(12, 57);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(295, 126);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "FBNS Settings";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(191, 80);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Save";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//ComboBox2
			//
			this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Items.AddRange(new object[] {
				"Enabled",
				"Disabled"
			});
			this.ComboBox2.Location = new System.Drawing.Point(79, 53);
			this.ComboBox2.Name = "ComboBox2";
			this.ComboBox2.Size = new System.Drawing.Size(187, 21);
			this.ComboBox2.TabIndex = 3;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(6, 56);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(60, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Live Notify:";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(6, 25);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(67, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Check Rate:";
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] {
				"Every 30 Minutes",
				"Every 45 Minutes",
				"Every Hour",
				"Never (Updates only on launch)"
			});
			this.ComboBox1.Location = new System.Drawing.Point(79, 22);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(187, 21);
			this.ComboBox1.TabIndex = 0;
			//
			//SettingsPanel
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 193);
			this.Controls.Add(this.GroupBox1);
			this.Name = "SettingsPanel";
			this.Resizable = false;
			this.Text = "Settings";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		private GroupBox withEventsField_GroupBox1;
		internal GroupBox GroupBox1 {
			get { return withEventsField_GroupBox1; }
			set {
				if (withEventsField_GroupBox1 != null) {
					withEventsField_GroupBox1.Enter -= GroupBox1_Enter;
				}
				withEventsField_GroupBox1 = value;
				if (withEventsField_GroupBox1 != null) {
					withEventsField_GroupBox1.Enter += GroupBox1_Enter;
				}
			}
		}
		internal Label Label1;
		internal Label Label2;
		private Button withEventsField_Button1;
		internal Button Button1 {
			get { return withEventsField_Button1; }
			set {
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click -= Button1_Click;
				}
				withEventsField_Button1 = value;
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click += Button1_Click;
				}
			}
		}
		internal ComboBox ComboBox2;
		internal ComboBox ComboBox1;
	}
}
