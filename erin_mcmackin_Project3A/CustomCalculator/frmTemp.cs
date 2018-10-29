using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCalculator
{
    public partial class frmTemp : Form
    {
        public frmTemp()
        {
            InitializeComponent();
        }

        private void frmTemp_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // ==========
            // ORIGINAL CODE WITH IF-ELSE
            // ==========

            // Found validation method on page 203 (Chapter 7) of Murach's C#2015
            /*
            decimal checkTemp;
            if (!(Decimal.TryParse(txtOrigTemp.Text, out checkTemp)))
            {
                MessageBox.Show("Temperature must be a numeric value", "Entry Error");
                txtOrigTemp.Focus();
            }
            else
            {
                decimal origTemp = Convert.ToDecimal(txtOrigTemp.Text);
                decimal calcTemp = 0;

                if (radioCel1.Checked == true)
                {
                    if (radioCel2.Checked == true)
                    {
                        calcTemp = origTemp;
                    }
                    else if (radioFahr2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp * 1.8m) + 32);
                    }
                    else if (radioKel2.Checked == true)
                    {
                        calcTemp = Math.Round(origTemp + 273m);
                    }
                }
                else if (radioFahr1.Checked == true)
                {
                    if (radioCel2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp - 32) * .5556m);
                    }
                    else if (radioFahr2.Checked == true)
                    {
                        calcTemp = origTemp;
                    }
                    else if (radioKel2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp + 459.67m) * .5556m);
                    }
                }
                else if (radioKel1.Checked == true)
                {
                    if (radioCel2.Checked == true)
                    {
                        calcTemp = Math.Round(origTemp - 273m);
                    }
                    else if (radioFahr2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp * 1.8m) - 459.67m);
                    }
                    else if (radioKel2.Checked == true)
                    {
                        calcTemp = origTemp;
                    }
                }

                // Insert calculated new teperature into Converted Temp field
                txtConvTemp.Text = calcTemp.ToString();
                // Move cursor back to Original Temp fied
                txtOrigTemp.Focus();
            }
            */

            // ==========
            // USING TRY PARSE METHOD
            // ==========


            try
            {
                decimal checkTemp;
                Decimal.TryParse(txtOrigTemp.Text, out checkTemp);

                decimal origTemp = Convert.ToDecimal(txtOrigTemp.Text);
                decimal calcTemp = 0;

                if (radioCel1.Checked == true)
                {
                    if (radioCel2.Checked == true)
                    {
                        calcTemp = origTemp;
                    }
                    else if (radioFahr2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp * 1.8m) + 32);
                    }
                    else if (radioKel2.Checked == true)
                    {
                        calcTemp = Math.Round(origTemp + 273m);
                    }
                }
                else if (radioFahr1.Checked == true)
                {
                    if (radioCel2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp - 32) * .5556m);
                    }
                    else if (radioFahr2.Checked == true)
                    {
                        calcTemp = origTemp;
                    }
                    else if (radioKel2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp + 459.67m) * .5556m);
                    }
                }
                else if (radioKel1.Checked == true)
                {
                    if (radioCel2.Checked == true)
                    {
                        calcTemp = Math.Round(origTemp - 273m);
                    }
                    else if (radioFahr2.Checked == true)
                    {
                        calcTemp = Math.Round((origTemp * 1.8m) - 459.67m);
                    }
                    else if (radioKel2.Checked == true)
                    {
                        calcTemp = origTemp;
                    }
                }

                // Insert calculated new teperature into Converted Temp field
                txtConvTemp.Text = calcTemp.ToString();
                // Move cursor back to Original Temp fied
                txtOrigTemp.Focus();

            }
            catch (FormatException)
            {
                MessageBox.Show("Temperature must be a numeric value", "Entry Error");
                txtOrigTemp.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("An overflow exception has occurred. Please enter a smaller value.");
                txtOrigTemp.Focus();
            }

        }

        private void btnMenuReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal resultNum = 0;

            try
            {
                decimal divNum = Convert.ToDecimal(txtDivide.Text);
                decimal byNum = Convert.ToDecimal(txtBy.Text);

                resultNum = Math.Round(divNum / byNum);
            }
            catch (FormatException)
            {
                MessageBox.Show("Must be a numeric value", "Entry Error");
                txtOrigTemp.Focus();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by 0", "Entry Error");
            }

            // Insert divided number into result field / prevent 0 if By is 0
            if (resultNum != 0)
            {
                txtDivideResult.Text = resultNum.ToString();
            }
            else
            {
                txtDivideResult.Text = "";
            }
            
            // Move cursor back to divide by fied
            txtDivide.Focus();
        }
    }
}
