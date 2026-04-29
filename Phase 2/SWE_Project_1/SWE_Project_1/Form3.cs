using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Project_1
{
    public partial class Form3 : Form
    {
        string ordb = "Data source=orcl; User Id=hr; Password=hr;";
        OracleDataAdapter adapter;
        DataSet ds;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("pending");
            comboBox1.Items.Add("confirmed");
            comboBox1.Items.Add("cancelled");
            comboBox1.Items.Add("checked_in");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a status first");
                return;
            }

            OracleConnection conn = new OracleConnection(ordb);

            string query = @"select booking_id, user_id, flight_id, seat_id, pnr_number, status
                from BOOKINGS where status = :p_status";

            string selectedStatus = comboBox1.SelectedItem.ToString();

            adapter = new OracleDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.Add("p_status", selectedStatus);

            OracleCommandBuilder cb = new OracleCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "BOOKINGS");

            dataGridView1.DataSource = ds.Tables["BOOKINGS"];
            label3.Text = "Records found: " + ds.Tables["BOOKINGS"].Rows.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ds == null || ds.Tables["BOOKINGS"] == null)
            {
                MessageBox.Show("Please search for records first");
                return;
            }


            int rowsAffected = adapter.Update(ds.Tables["BOOKINGS"]);

            try
            {
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update successful! " + rowsAffected + " row(s) saved");
                }
                else
                {
                    MessageBox.Show("No changes to save");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            adapter = null;
            ds = null;
            label3.Text = "Records found: 0";
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
