using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace SWE_Project_1
{
    public partial class Form4 : Form
    {
        string ordb = "Data source=orcl; User Id=hr; Password=hr;";
        OracleConnection conn;
        public Form4()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select passenger_id from passengers";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox_Passenger_ID.Items.Add(dr[0]);
            }

            dr.Close();
        }

        private void comboBox_User_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            if (comboBox_Passenger_ID.SelectedItem == null)
                return;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "get_passenger_by_id";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_id", OracleDbType.Int32).Value =
        Convert.ToInt32(comboBox_Passenger_ID.SelectedItem);

            cmd.Parameters.Add("p_booking_id", OracleDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_full_name", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_passport", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_meal", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;



            cmd.ExecuteNonQuery();

            txtName.Text = cmd.Parameters["p_full_name"].Value.ToString();
            txtPassport.Text = cmd.Parameters["p_passport"].Value.ToString();
            txtMeal.Text = cmd.Parameters["p_meal"].Value.ToString();
            txtBookingID.Text = cmd.Parameters["p_booking_id"].Value.ToString();

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "get_all_passengers";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }
    }



}
