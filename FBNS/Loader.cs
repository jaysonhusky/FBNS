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
using System.Drawing.Drawing2D;
namespace FBNS
{

	public partial class Loader
	{
		int DV = 0;

		private void Loader_Load(object sender, EventArgs e)
		{
			//Timer1.Start()
			My.MyProject.Forms.Form1.Show();
			this.Close();

		}


		private void Loader_Paint(object sender, PaintEventArgs e)
		{
			// HQ Setting!
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			// Draw
			DrawProgress(e.Graphics, new Rectangle(5, 5, 300, 300), 0);
			//DrawProgress(e.Graphics, New Rectangle(80, 5, 60, 60), 80)
			//DrawProgress(e.Graphics, New Rectangle(155, 5, 60, 60), 57)
		}

		// Loader Information
		private void DrawProgress(Graphics g, Rectangle rect, float percentage)
		{
			//work out the angles for each arc
			var progressAngle = Convert.ToSingle(360 / 100 * percentage);
			var remainderAngle = 360 - progressAngle;
			//create pens to use for the arcs
			using (Pen progressPen = new Pen(Color.LightSeaGreen, 2)) {
				using (Pen remainderPen = new Pen(Color.LightGray, 2)) {
					//set the smoothing to high quality for better output
					g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
					//draw the blue and white arcs
					g.DrawArc(progressPen, rect, -90, progressAngle);
					g.DrawArc(remainderPen, rect, progressAngle - 90, remainderAngle);
				}
			}
			//draw the text in the centre by working out how big it is and adjusting the co-ordinates accordingly
			using (Font fnt = new Font(this.Font.FontFamily, 14)) {
				string text = percentage.ToString() + "%";
				var textSize = g.MeasureString(text, fnt);
				Point textPoint = new Point(Convert.ToInt32(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), Convert.ToInt32(rect.Top + (rect.Height / 2) - (textSize.Height / 2)));
				//now we have all the values draw the text
				g.DrawString(text, fnt, Brushes.Black, textPoint);
			}
		}

		private void Timer1_Tick(object sender, PaintEventArgs e)
		{
			//DV += 1
			//DrawProgress(sender.Graphics, New Rectangle(5, 5, 300, 300), DV)

		}
		public Loader()
		{
			Paint += Loader_Paint;
			Load += Loader_Load;
			InitializeComponent();
		}
	}
}
