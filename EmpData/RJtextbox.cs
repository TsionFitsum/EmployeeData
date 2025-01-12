﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpData
{
	public partial class RJtextbox : UserControl
	{
		private Color borderColor = Color.MediumSeaGreen;
		private int borderSize = 2;
		private bool underlinedStyle = false;
		public RJtextbox()
		{
			InitializeComponent();
		}

		public Color BorderColor {
			get { return borderColor; }
			set { 
				borderColor = value;
				this.Invalidate();
			      
			}
		}

		public int BorderSize {
			get { return borderSize; }
			set { 
				borderSize = value;
				this.Invalidate();

			}
		}
		public bool UnderlinedStyle {
			get { return underlinedStyle; }
			set { 
				underlinedStyle = value;
				this.Invalidate();
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graph = e.Graphics;
			using (Pen penBorder = new Pen(borderColor, borderSize)) { penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

				if (underlinedStyle)
					graph.DrawLine(penBorder, 0, this.Height - 1, this.Width - 1, this.Height - 1);
				else
					graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
			
			}
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			UpdateControlHeight();
		}

		private void UpdateControlHeight()
		{
			if(textBox1.Multiline == false)
			{
				int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
				textBox1.Multiline = true;
				textBox1.MinimumSize = new Size(0, txtHeight);
				textBox1.Multiline = false;

				this.Height = textBox1.Height + this.Padding.Bottom;
			}
		}
	}
}
