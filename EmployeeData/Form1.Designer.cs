namespace EmployeeData
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			customTextBox1 = new EmpData.CustomTextBox();
			customTextBox2 = new EmpData.CustomTextBox();
			SuspendLayout();
			// 
			// customTextBox1
			// 
			customTextBox1.BorderStyle = BorderStyle.None;
			customTextBox1.BottomBorderColor = Color.Green;
			customTextBox1.BottomBorderOnFocusColor = Color.Green;
			customTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			customTextBox1.Location = new Point(182, 59);
			customTextBox1.Name = "customTextBox1";
			customTextBox1.Size = new Size(100, 23);
			customTextBox1.TabIndex = 0;
			customTextBox1.Text = "Some Text";
			// 
			// customTextBox2
			// 
			customTextBox2.BorderStyle = BorderStyle.None;
			customTextBox2.BottomBorderColor = Color.Green;
			customTextBox2.BottomBorderOnFocusColor = Color.Green;
			customTextBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			customTextBox2.Location = new Point(182, 116);
			customTextBox2.Name = "customTextBox2";
			customTextBox2.Size = new Size(100, 23);
			customTextBox2.TabIndex = 1;
			customTextBox2.Text = "Another Text";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(customTextBox2);
			Controls.Add(customTextBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private EmpData.CustomTextBox customTextBox1;
		private EmpData.CustomTextBox customTextBox2;
	}
}
