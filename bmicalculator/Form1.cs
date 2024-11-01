using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmicalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_frameTitle.Hide();
            pnl_calculatedBMI.Hide();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_personHeight.Text = "";
            txt_personWeight.Text = "";
            lbl_frameTitle.Hide();
            pnl_calculatedBMI.Hide();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double height = 0;
            double weight = 0;
            double bmi = 0;

            try
            {
                lbl_frameTitle.Show();
                pnl_calculatedBMI.Show();

                // Convert height
                height = Convert.ToDouble(txt_personHeight.Text) / 100;
                weight = Convert.ToDouble(txt_personWeight.Text);

                // Validate height and weight
                if (height <= 0 || weight <= 0)
                {
                    lbl_frameTitle.Hide();
                    pnl_calculatedBMI.Hide();
                    txt_personHeight.Text = "";
                    txt_personWeight.Text = "";

                    MessageBox.Show("Height and weight must be greater than zero.");
                    return;
                }

                // Calculate BMI
                bmi = weight / (height * height);

                // Display BMI value
                lbl_showBmiValue.Text = bmi.ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid values for height and weight.");
            }
        }
    }
}
