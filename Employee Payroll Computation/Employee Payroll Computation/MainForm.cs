using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Employee_Payroll_Computation
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		void BtnQuitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnClearClick(object sender, EventArgs e)
		{
			cmbEmpNum.Text = "";
			txtEmpName.Text = "";
			cmbPosCode.Text = "";
			rdbSingle.Checked = false;
			rdbMarried.Checked = false;
			rdbWidowed.Checked = false;
			nudDays.Text = "0";
			txtBasic.Text = "";
			txtSSS.Text = "";
			txtTax.Text = "";
			txtNetPay.Text = "";
		}
		
		void CmbEmpNumSelectedIndexChanged(object sender, EventArgs e)
		{
			string EmpName;
			
			if (cmbEmpNum.SelectedIndex != -1)
			{
				EmpName = cmbEmpNum.SelectedItem.ToString();
				
				switch (EmpName)
				{
					case "2021-001":
						txtEmpName.Text = "Bryan Jade Capillo";
						break;
					case "2021-002":
						txtEmpName.Text = "Bryan Capillo";
						break;
					case "2021-003":
						txtEmpName.Text = "Jade Capillo";
						break;
				}
			}
		}
		
		void BtnComputeClick(object sender, EventArgs e)
		{			
			string PosCode;			
			double Rate = 0;
			double Days;
			double SSS;
			double Tax=0;
			double NetPay;
			
			Days = Convert.ToDouble(nudDays.Text);
			
			// to Compute Rate per Day
			if (cmbPosCode.SelectedIndex != -1)
			{
				PosCode = cmbPosCode.SelectedItem.ToString();
				
				switch (PosCode)
				{
					case "A":
						Rate = 500.00;
						break;
					case "B":
						Rate = 400.00;
						break;
					case "C":
						Rate = 300.00;
						break;
				}
			}
			
			// to compute Basic Pay
			double BasicPay = Days * Rate;
			txtBasic.Text = Convert.ToString(BasicPay);			
			
			// to Compute SSS Contribution
			if (BasicPay >= 10000.00) {
				SSS = 0.07 * BasicPay;
				txtSSS.Text = Convert.ToString(SSS);
			}
			else if (BasicPay >= 5000.00) {
				SSS = 0.05 * BasicPay;
				txtSSS.Text = Convert.ToString(SSS);
			}
			else if (BasicPay >= 1000.00) {
				SSS = 0.03 * BasicPay;
				txtSSS.Text = Convert.ToString(SSS);
			}
			else {
				SSS = 0.01 * BasicPay;
				txtSSS.Text = Convert.ToString(SSS);
			}
			
			// to Compute Withholding Tax
			if (cmbPosCode.SelectedIndex != -1)
			{
				PosCode = cmbPosCode.SelectedItem.ToString();
				
				switch (PosCode)
				{
					case "A":
						Tax = 0.1 * BasicPay;
						break;
					case "B":
						Tax = 0.05 * BasicPay;
						break;
					case "C":
						Tax = 0.05 * BasicPay;
						break;
				}
				txtTax.Text = Convert.ToString(Tax);
			}
			
			// to Compute NetPay
			NetPay = BasicPay - SSS - Tax;
			txtNetPay.Text = Convert.ToString(NetPay);
		}
	}
}
