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
	partial class Additional : MetroFramework.Forms.MetroForm
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
			this.MetroTextBox1 = new MetroFramework.Controls.MetroTextBox();
			this.MetroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			//
			//MetroTextBox1
			//
			this.MetroTextBox1.Lines = new string[] { "MetroTextBox1" };
			this.MetroTextBox1.Location = new System.Drawing.Point(23, 72);
			this.MetroTextBox1.MaxLength = 32767;
			this.MetroTextBox1.Multiline = true;
			this.MetroTextBox1.Name = "MetroTextBox1";
			this.MetroTextBox1.PasswordChar = Strings.ChrW(0);
			this.MetroTextBox1.ReadOnly = true;
			this.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.MetroTextBox1.SelectedText = "";
			this.MetroTextBox1.Size = new System.Drawing.Size(543, 366);
			this.MetroTextBox1.TabIndex = 0;
			this.MetroTextBox1.Text = "MetroTextBox1";
			this.MetroTextBox1.UseSelectable = true;
			//
			//MetroLabel1
			//
			this.MetroLabel1.AutoSize = true;
			this.MetroLabel1.Location = new System.Drawing.Point(29, 33);
			this.MetroLabel1.Name = "MetroLabel1";
			this.MetroLabel1.Size = new System.Drawing.Size(81, 19);
			this.MetroLabel1.TabIndex = 1;
			this.MetroLabel1.Text = "MetroLabel1";
			//
			//Additional
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 461);
			this.Controls.Add(this.MetroLabel1);
			this.Controls.Add(this.MetroTextBox1);
			this.Name = "Additional";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		internal MetroFramework.Controls.MetroTextBox MetroTextBox1;
		internal MetroFramework.Controls.MetroLabel MetroLabel1;
		public Additional()
		{
			InitializeComponent();
		}
	}
}
