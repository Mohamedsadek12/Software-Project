using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace SWE_Project_1
{
    public partial class Form6 : Form
    {
        
        CrystalReport5 CR;
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button_Generate_CR_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboBox1.Text);

            crystalReportViewer1.ReportSource = CR;
        }

        private void Form6_Load_1(object sender, EventArgs e)
        {
            CR = new CrystalReport5();
            foreach (ParameterDiscreteValue v in CR.ParameterFields["Payment_status"].DefaultValues)
            {
                comboBox1.Items.Add(v.Value.ToString()); 
            }

           
        }

        private void label_payment_status_Click(object sender, EventArgs e)
        {

        }
    }
}
