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
    public partial class Form2 : Form
    {
        string ordb = "Data source=orcl; User Id=hr; Password=hr;";
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd2 = new OracleCommand();

            cmd.Connection = conn;
            cmd2.Connection = conn;

            cmd.CommandText = "Select passenger_id From passengers";
            cmd2.CommandText = "Select DISTINCT meal_preference From passengers";

            cmd.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            OracleDataReader dr2 = cmd2.ExecuteReader();

            while (dr.Read())
            {
                comboBox_Passengers_ID.Items.Add(dr[0]);
            }
            while (dr2.Read())
            {
                comboBox_Meal_Preference.Items.Add(dr2[0]);
            }
            conn.Dispose();
        }

        private void comboBox_Passengers_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select full_name,booking_id,passport_number,meal_preference  From passengers Where passenger_id =: p_id ";
            cmd.CommandType = CommandType.Text;
            int selected_passenger = comboBox_Passengers_ID.SelectedIndex + 1;
            cmd.Parameters.Add("p_id", selected_passenger.ToString());
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox_P_Full_Name.Text = dr[0].ToString();
                textBox_Booking_ID.Text = dr[1].ToString();
                textBox_Passport_Number.Text = dr[2].ToString();
                comboBox_Meal_Preference.Text = dr[3].ToString();
            }
            conn.Close();
        }

        private void button_Insert_Passenger_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            // Check if Passenger ID already exists
            OracleCommand checkCmd = new OracleCommand();
            checkCmd.Connection = conn;
            checkCmd.CommandText = "SELECT COUNT(*) FROM passengers WHERE passenger_id = :P_id";
            checkCmd.Parameters.Add("P_id", comboBox_Passengers_ID.Text.ToString());

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Warning: This Passenger ID already exists!");
                conn.Close();
                return;
            }


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO PASSENGERS VALUES(:P_id, :booking_id, :fulname, :Passport_Number, :meal_preference)";

            cmd.Parameters.Add("P_id", comboBox_Passengers_ID.Text.ToString());
            cmd.Parameters.Add("booking_id", textBox_Booking_ID.Text.ToString());
            cmd.Parameters.Add("fulname", textBox_P_Full_Name.Text.ToString());
            cmd.Parameters.Add("Passport_Number", textBox_Passport_Number.Text.ToString());
            cmd.Parameters.Add("meal_preference", comboBox_Meal_Preference.Text.ToString());

            cmd.CommandType = CommandType.Text;

            int exq = cmd.ExecuteNonQuery();

            if (exq > 0)
            {
                comboBox_Passengers_ID.Items.Add(comboBox_Passengers_ID.Text);
                MessageBox.Show("New Passenger is Added");
            }

            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}