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
	partial class Form1 : MetroFramework.Forms.MetroForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.PanelContainer = new System.Windows.Forms.Panel();
			this.TabControlPanel = new System.Windows.Forms.TabControl();
			this.TabPageHTML = new System.Windows.Forms.TabPage();
			this.dgViewPreview = new MetroFramework.Controls.MetroGrid();
			this.LabelHTMLSource = new System.Windows.Forms.Label();
			this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FBNSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LegalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.InformationStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PanelHeader = new System.Windows.Forms.Panel();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.NotifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
			this.PanelContainer.SuspendLayout();
			this.TabControlPanel.SuspendLayout();
			this.TabPageHTML.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgViewPreview).BeginInit();
			this.MenuStrip1.SuspendLayout();
			this.PanelHeader.SuspendLayout();
			this.SuspendLayout();
			//
			//PanelContainer
			//
			this.PanelContainer.Controls.Add(this.TabControlPanel);
			this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelContainer.Location = new System.Drawing.Point(20, 93);
			this.PanelContainer.Name = "PanelContainer";
			this.PanelContainer.Size = new System.Drawing.Size(608, 293);
			this.PanelContainer.TabIndex = 1;
			//
			//TabControlPanel
			//
			this.TabControlPanel.Controls.Add(this.TabPageHTML);
			this.TabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControlPanel.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.TabControlPanel.Location = new System.Drawing.Point(0, 0);
			this.TabControlPanel.Name = "TabControlPanel";
			this.TabControlPanel.SelectedIndex = 0;
			this.TabControlPanel.Size = new System.Drawing.Size(608, 293);
			this.TabControlPanel.TabIndex = 1;
			//
			//TabPageHTML
			//
			this.TabPageHTML.Controls.Add(this.dgViewPreview);
			this.TabPageHTML.Controls.Add(this.LabelHTMLSource);
			this.TabPageHTML.Location = new System.Drawing.Point(4, 22);
			this.TabPageHTML.Name = "TabPageHTML";
			this.TabPageHTML.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageHTML.Size = new System.Drawing.Size(600, 267);
			this.TabPageHTML.TabIndex = 0;
			this.TabPageHTML.Text = "Live History";
			this.TabPageHTML.UseVisualStyleBackColor = true;
			//
			//dgViewPreview
			//
			this.dgViewPreview.AllowUserToAddRows = false;
			this.dgViewPreview.AllowUserToDeleteRows = false;
			this.dgViewPreview.AllowUserToResizeColumns = false;
			this.dgViewPreview.AllowUserToResizeRows = false;
			this.dgViewPreview.BackgroundColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(17)), Convert.ToInt32(Convert.ToByte(17)), Convert.ToInt32(Convert.ToByte(17)));
			this.dgViewPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgViewPreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgViewPreview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(174)), Convert.ToInt32(Convert.ToByte(219)));
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(17)), Convert.ToInt32(Convert.ToByte(17)), Convert.ToInt32(Convert.ToByte(17)));
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(174)), Convert.ToInt32(Convert.ToByte(219)));
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(255)));
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgViewPreview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgViewPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(17)), Convert.ToInt32(Convert.ToByte(17)), Convert.ToInt32(Convert.ToByte(17)));
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(109)), Convert.ToInt32(Convert.ToByte(109)), Convert.ToInt32(Convert.ToByte(109)));
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(174)), Convert.ToInt32(Convert.ToByte(219)));
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(255)));
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgViewPreview.DefaultCellStyle = DataGridViewCellStyle2;
			this.dgViewPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgViewPreview.EnableHeadersVisualStyles = false;
			this.dgViewPreview.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.dgViewPreview.GridColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(17)), Convert.ToInt32(Convert.ToByte(17)), Convert.ToInt32(Convert.ToByte(17)));
			this.dgViewPreview.Location = new System.Drawing.Point(3, 3);
			this.dgViewPreview.Name = "dgViewPreview";
			this.dgViewPreview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(174)), Convert.ToInt32(Convert.ToByte(219)));
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(17)), Convert.ToInt32(Convert.ToByte(17)), Convert.ToInt32(Convert.ToByte(17)));
			DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(174)), Convert.ToInt32(Convert.ToByte(219)));
			DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(255)));
			DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgViewPreview.RowHeadersDefaultCellStyle = DataGridViewCellStyle3;
			this.dgViewPreview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgViewPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgViewPreview.Size = new System.Drawing.Size(594, 261);
			this.dgViewPreview.Style = MetroFramework.MetroColorStyle.Blue;
			this.dgViewPreview.TabIndex = 2;
			this.dgViewPreview.Theme = MetroFramework.MetroThemeStyle.Dark;
			//
			//LabelHTMLSource
			//
			this.LabelHTMLSource.AutoSize = true;
			this.LabelHTMLSource.Location = new System.Drawing.Point(4, 4);
			this.LabelHTMLSource.Name = "LabelHTMLSource";
			this.LabelHTMLSource.Size = new System.Drawing.Size(45, 13);
			this.LabelHTMLSource.TabIndex = 1;
			this.LabelHTMLSource.Text = "Reasult";
			//
			//NotifyIcon1
			//
			this.NotifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon1.Icon");
			this.NotifyIcon1.Text = "Fursuit Builder Notification Service (v0.2a)";
			this.NotifyIcon1.Visible = true;
			//
			//MenuStrip1
			//
			this.MenuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.FBNSToolStripMenuItem });
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(608, 24);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//FBNSToolStripMenuItem
			//
			this.FBNSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.ConfigToolStripMenuItem,
				this.LegalToolStripMenuItem
			});
			this.FBNSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FBNSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FBNSToolStripMenuItem.Name = "FBNSToolStripMenuItem";
			this.FBNSToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.FBNSToolStripMenuItem.Text = "Menu";
			//
			//ConfigToolStripMenuItem
			//
			this.ConfigToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.ConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.SettingsToolStripMenuItem });
			this.ConfigToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
			this.ConfigToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.ConfigToolStripMenuItem.Text = "Config";
			//
			//SettingsToolStripMenuItem
			//
			this.SettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
			this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.SettingsToolStripMenuItem.Text = "Settings";
			//
			//LegalToolStripMenuItem
			//
			this.LegalToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.LegalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.AboutToolStripMenuItem1,
				this.InformationStorageToolStripMenuItem
			});
			this.LegalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.LegalToolStripMenuItem.Name = "LegalToolStripMenuItem";
			this.LegalToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.LegalToolStripMenuItem.Text = "Legal";
			//
			//AboutToolStripMenuItem1
			//
			this.AboutToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
			this.AboutToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1";
			this.AboutToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
			this.AboutToolStripMenuItem1.Text = "About";
			//
			//InformationStorageToolStripMenuItem
			//
			this.InformationStorageToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.InformationStorageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.InformationStorageToolStripMenuItem.Name = "InformationStorageToolStripMenuItem";
			this.InformationStorageToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.InformationStorageToolStripMenuItem.Text = "Information Storage";
			//
			//PanelHeader
			//
			this.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PanelHeader.Controls.Add(this.Label2);
			this.PanelHeader.Controls.Add(this.Label1);
			this.PanelHeader.Controls.Add(this.MenuStrip1);
			this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelHeader.Location = new System.Drawing.Point(20, 60);
			this.PanelHeader.Name = "PanelHeader";
			this.PanelHeader.Size = new System.Drawing.Size(608, 33);
			this.PanelHeader.TabIndex = 0;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Label2.Location = new System.Drawing.Point(461, 8);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(40, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Label2";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Label1.Location = new System.Drawing.Point(366, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(91, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Next Check Due:";
			//
			//Timer1
			//
			this.Timer1.Interval = 1000;
			//
			//NotifyIcon2
			//
			this.NotifyIcon2.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon2.Icon");
			this.NotifyIcon2.Text = "Fursuit Builder Notification Service (v0.2a)";
			this.NotifyIcon2.Visible = true;
			//
			//Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 406);
			this.Controls.Add(this.PanelContainer);
			this.Controls.Add(this.PanelHeader);
			this.MainMenuStrip = this.MenuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Resizable = false;
			this.Text = "FBNS :: Home";
			this.PanelContainer.ResumeLayout(false);
			this.TabControlPanel.ResumeLayout(false);
			this.TabPageHTML.ResumeLayout(false);
			this.TabPageHTML.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgViewPreview).EndInit();
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.PanelHeader.ResumeLayout(false);
			this.PanelHeader.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Panel PanelContainer;

		internal TabControl TabControlPanel;
		internal TabPage TabPageHTML;
		internal Label LabelHTMLSource;
		private NotifyIcon withEventsField_NotifyIcon1;
		internal NotifyIcon NotifyIcon1 {
			get { return withEventsField_NotifyIcon1; }
			set {
				if (withEventsField_NotifyIcon1 != null) {
					withEventsField_NotifyIcon1.DoubleClick -= NotifyIcon1_DoubleClick;
				}
				withEventsField_NotifyIcon1 = value;
				if (withEventsField_NotifyIcon1 != null) {
					withEventsField_NotifyIcon1.DoubleClick += NotifyIcon1_DoubleClick;
				}
			}
		}
		internal MenuStrip MenuStrip1;
		internal ToolStripMenuItem FBNSToolStripMenuItem;
		internal ToolStripMenuItem ConfigToolStripMenuItem;
		private ToolStripMenuItem withEventsField_SettingsToolStripMenuItem;
		internal ToolStripMenuItem SettingsToolStripMenuItem {
			get { return withEventsField_SettingsToolStripMenuItem; }
			set {
				if (withEventsField_SettingsToolStripMenuItem != null) {
					withEventsField_SettingsToolStripMenuItem.Click -= SettingsToolStripMenuItem_Click;
				}
				withEventsField_SettingsToolStripMenuItem = value;
				if (withEventsField_SettingsToolStripMenuItem != null) {
					withEventsField_SettingsToolStripMenuItem.Click += SettingsToolStripMenuItem_Click;
				}
			}
		}
		internal ToolStripMenuItem LegalToolStripMenuItem;
		private ToolStripMenuItem withEventsField_AboutToolStripMenuItem1;
		internal ToolStripMenuItem AboutToolStripMenuItem1 {
			get { return withEventsField_AboutToolStripMenuItem1; }
			set {
				if (withEventsField_AboutToolStripMenuItem1 != null) {
					withEventsField_AboutToolStripMenuItem1.Click -= AboutToolStripMenuItem1_Click;
				}
				withEventsField_AboutToolStripMenuItem1 = value;
				if (withEventsField_AboutToolStripMenuItem1 != null) {
					withEventsField_AboutToolStripMenuItem1.Click += AboutToolStripMenuItem1_Click;
				}
			}
		}
		private ToolStripMenuItem withEventsField_InformationStorageToolStripMenuItem;
		internal ToolStripMenuItem InformationStorageToolStripMenuItem {
			get { return withEventsField_InformationStorageToolStripMenuItem; }
			set {
				if (withEventsField_InformationStorageToolStripMenuItem != null) {
					withEventsField_InformationStorageToolStripMenuItem.Click -= InformationStorageToolStripMenuItem_Click;
				}
				withEventsField_InformationStorageToolStripMenuItem = value;
				if (withEventsField_InformationStorageToolStripMenuItem != null) {
					withEventsField_InformationStorageToolStripMenuItem.Click += InformationStorageToolStripMenuItem_Click;
				}
			}
		}
		internal Panel PanelHeader;
		private Timer withEventsField_Timer1;
		internal Timer Timer1 {
			get { return withEventsField_Timer1; }
			set {
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick -= Timer1_Tick;
				}
				withEventsField_Timer1 = value;
				if (withEventsField_Timer1 != null) {
					withEventsField_Timer1.Tick += Timer1_Tick;
				}
			}
		}
		internal Label Label2;
		internal Label Label1;
		private NotifyIcon withEventsField_NotifyIcon2;
		internal NotifyIcon NotifyIcon2 {
			get { return withEventsField_NotifyIcon2; }
			set {
				if (withEventsField_NotifyIcon2 != null) {
					withEventsField_NotifyIcon2.BalloonTipClicked -= NotifyIcon2_BalloonTipClicked;
				}
				withEventsField_NotifyIcon2 = value;
				if (withEventsField_NotifyIcon2 != null) {
					withEventsField_NotifyIcon2.BalloonTipClicked += NotifyIcon2_BalloonTipClicked;
				}
			}
		}
		internal MetroFramework.Controls.MetroGrid dgViewPreview;
		public Form1()
		{
			FormClosing += Form1_FormClosing;
			Resize += Form1_Resize;
			Load += Form1_Load;
			InitializeComponent();
		}
	}
}
