/*
 * Created by SharpDevelop.
 * User: Thinkpad
 * Date: 7/18/2021
 * Time: 9:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Employee_Payroll_Computation
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.rdbWidowed = new System.Windows.Forms.RadioButton();
			this.rdbMarried = new System.Windows.Forms.RadioButton();
			this.rdbSingle = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEmpName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbPosCode = new System.Windows.Forms.ComboBox();
			this.cmbEmpNum = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.nudDays = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNetPay = new System.Windows.Forms.TextBox();
			this.txtTax = new System.Windows.Forms.TextBox();
			this.txtSSS = new System.Windows.Forms.TextBox();
			this.txtBasic = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnQuit = new System.Windows.Forms.Button();
			this.btnCompute = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(603, 25);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(165, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "EMPLOYEE PAYROLL COMPUTATION";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtRate);
			this.groupBox1.Controls.Add(this.rdbWidowed);
			this.groupBox1.Controls.Add(this.rdbMarried);
			this.groupBox1.Controls.Add(this.rdbSingle);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtEmpName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmbPosCode);
			this.groupBox1.Controls.Add(this.cmbEmpNum);
			this.groupBox1.Location = new System.Drawing.Point(12, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(297, 191);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Enter Data Records Here:";
			// 
			// txtRate
			// 
			this.txtRate.Location = new System.Drawing.Point(124, 122);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(100, 20);
			this.txtRate.TabIndex = 6;
			this.txtRate.Visible = false;
			// 
			// rdbWidowed
			// 
			this.rdbWidowed.Location = new System.Drawing.Point(184, 148);
			this.rdbWidowed.Name = "rdbWidowed";
			this.rdbWidowed.Size = new System.Drawing.Size(79, 24);
			this.rdbWidowed.TabIndex = 5;
			this.rdbWidowed.TabStop = true;
			this.rdbWidowed.Text = "Widowed";
			this.rdbWidowed.UseVisualStyleBackColor = true;
			// 
			// rdbMarried
			// 
			this.rdbMarried.Location = new System.Drawing.Point(117, 148);
			this.rdbMarried.Name = "rdbMarried";
			this.rdbMarried.Size = new System.Drawing.Size(61, 24);
			this.rdbMarried.TabIndex = 4;
			this.rdbMarried.TabStop = true;
			this.rdbMarried.Text = "Married";
			this.rdbMarried.UseVisualStyleBackColor = true;
			// 
			// rdbSingle
			// 
			this.rdbSingle.Location = new System.Drawing.Point(50, 148);
			this.rdbSingle.Name = "rdbSingle";
			this.rdbSingle.Size = new System.Drawing.Size(61, 24);
			this.rdbSingle.TabIndex = 3;
			this.rdbSingle.TabStop = true;
			this.rdbSingle.Text = "Single";
			this.rdbSingle.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(18, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "Civil Status:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEmpName
			// 
			this.txtEmpName.Location = new System.Drawing.Point(124, 63);
			this.txtEmpName.Name = "txtEmpName";
			this.txtEmpName.Size = new System.Drawing.Size(155, 20);
			this.txtEmpName.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(18, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Position Code:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(18, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Employee Name:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(18, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Employee Number:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbPosCode
			// 
			this.cmbPosCode.FormattingEnabled = true;
			this.cmbPosCode.Items.AddRange(new object[] {
									"A",
									"B",
									"C"});
			this.cmbPosCode.Location = new System.Drawing.Point(124, 89);
			this.cmbPosCode.Name = "cmbPosCode";
			this.cmbPosCode.Size = new System.Drawing.Size(155, 21);
			this.cmbPosCode.TabIndex = 2;
			// 
			// cmbEmpNum
			// 
			this.cmbEmpNum.FormattingEnabled = true;
			this.cmbEmpNum.Items.AddRange(new object[] {
									"2021-001",
									"2021-002",
									"2021-003"});
			this.cmbEmpNum.Location = new System.Drawing.Point(124, 36);
			this.cmbEmpNum.Name = "cmbEmpNum";
			this.cmbEmpNum.Size = new System.Drawing.Size(155, 21);
			this.cmbEmpNum.TabIndex = 0;
			this.cmbEmpNum.SelectedIndexChanged += new System.EventHandler(this.CmbEmpNumSelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.nudDays);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtNetPay);
			this.groupBox2.Controls.Add(this.txtTax);
			this.groupBox2.Controls.Add(this.txtSSS);
			this.groupBox2.Controls.Add(this.txtBasic);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(315, 31);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(276, 191);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Computations:";
			// 
			// nudDays
			// 
			this.nudDays.Location = new System.Drawing.Point(140, 37);
			this.nudDays.Name = "nudDays";
			this.nudDays.Size = new System.Drawing.Size(48, 20);
			this.nudDays.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(18, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "No. of Days Worked:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(18, 61);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 1;
			this.label7.Text = "Basic Pay:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(18, 87);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 1;
			this.label8.Text = "SSS Contribution:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNetPay
			// 
			this.txtNetPay.Location = new System.Drawing.Point(140, 151);
			this.txtNetPay.Name = "txtNetPay";
			this.txtNetPay.Size = new System.Drawing.Size(118, 20);
			this.txtNetPay.TabIndex = 10;
			// 
			// txtTax
			// 
			this.txtTax.Location = new System.Drawing.Point(140, 115);
			this.txtTax.Name = "txtTax";
			this.txtTax.Size = new System.Drawing.Size(118, 20);
			this.txtTax.TabIndex = 9;
			// 
			// txtSSS
			// 
			this.txtSSS.Location = new System.Drawing.Point(140, 89);
			this.txtSSS.Name = "txtSSS";
			this.txtSSS.Size = new System.Drawing.Size(118, 20);
			this.txtSSS.TabIndex = 8;
			// 
			// txtBasic
			// 
			this.txtBasic.Location = new System.Drawing.Point(140, 63);
			this.txtBasic.Name = "txtBasic";
			this.txtBasic.Size = new System.Drawing.Size(118, 20);
			this.txtBasic.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(18, 149);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 3;
			this.label10.Text = "Net Pay:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(18, 114);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 3;
			this.label9.Text = "Withholding Tax:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnQuit);
			this.groupBox3.Controls.Add(this.btnCompute);
			this.groupBox3.Controls.Add(this.btnClear);
			this.groupBox3.Location = new System.Drawing.Point(12, 228);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(579, 55);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			// 
			// btnQuit
			// 
			this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuit.Location = new System.Drawing.Point(380, 19);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(170, 23);
			this.btnQuit.TabIndex = 13;
			this.btnQuit.Text = "Quit";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
			// 
			// btnCompute
			// 
			this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCompute.Location = new System.Drawing.Point(204, 19);
			this.btnCompute.Name = "btnCompute";
			this.btnCompute.Size = new System.Drawing.Size(170, 23);
			this.btnCompute.TabIndex = 12;
			this.btnCompute.Text = "Compute";
			this.btnCompute.UseVisualStyleBackColor = true;
			this.btnCompute.Click += new System.EventHandler(this.BtnComputeClick);
			// 
			// btnClear
			// 
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClear.Location = new System.Drawing.Point(28, 19);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(170, 23);
			this.btnClear.TabIndex = 11;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(603, 296);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Employee Payroll Computation";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtRate;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnCompute;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtBasic;
		private System.Windows.Forms.TextBox txtSSS;
		private System.Windows.Forms.TextBox txtTax;
		private System.Windows.Forms.TextBox txtNetPay;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nudDays;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbEmpNum;
		private System.Windows.Forms.ComboBox cmbPosCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmpName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rdbSingle;
		private System.Windows.Forms.RadioButton rdbMarried;
		private System.Windows.Forms.RadioButton rdbWidowed;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
