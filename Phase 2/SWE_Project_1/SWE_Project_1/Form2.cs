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

            cmd.CommandText = "Select user_id From users";
            cmd2.CommandText = "Select DISTINCT role From users";

            cmd.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            OracleDataReader dr2 = cmd2.ExecuteReader();

            while (dr.Read())
            {
                comboBox_user_ID.Items.Add(dr[0]);
            }
            while (dr2.Read())
            {
                comboBox_Role.Items.Add(dr2[0]);
            }
            conn.Dispose();
        }

        private void comboBox_Passengers_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select name,email,phone_number,date_of_birth,password_hash,role,created_at  From users Where user_id =: U_id ";
            cmd.CommandType = CommandType.Text;
            int selected_passenger = comboBox_user_ID.SelectedIndex + 1;
            cmd.Parameters.Add("U_id", selected_passenger.ToString());
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox_U_Name.Text = dr[0].ToString();
                textBox_Email.Text = dr[1].ToString();
                textBox_phonenumber.Text = dr[2].ToString();
                textBox_date_of_birth.Text = dr[3].ToString();
                textBox_password.Text = dr[4].ToString();
                comboBox_Role.Text = dr[5].ToString();
                textBox_Created_date.Text = dr[6].ToString();
                
            }
            conn.Close();
        }

        private void button_Insert_Passenger_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            // Check if User ID already exists
            OracleCommand checkCmd = new OracleCommand();
            checkCmd.Connection = conn;
            checkCmd.CommandText = "SELECT COUNT(*) FROM users WHERE user_id = :U_id";
            checkCmd.Parameters.Add("U_id", comboBox_user_ID.Text.ToString());

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Warning: This User ID already exists!");
                conn.Close();
                return;
            }

            // Check if User Email already exists
            OracleCommand checkEmailCmd = new OracleCommand();
            checkEmailCmd.Connection = conn;
            checkEmailCmd.CommandText = "SELECT COUNT(*) FROM users WHERE email = :email";
            checkEmailCmd.Parameters.Add("email", textBox_Email.Text);

            int emailCount = Convert.ToInt32(checkEmailCmd.ExecuteScalar());

            if (emailCount > 0)
            {
                MessageBox.Show("Warning: This email already exists!");
                conn.Close();
                return;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO users VALUES(:U_id, :name, :email, :password, :phone, :DOB, :role, :create_data)";

            cmd.Parameters.Add("U_id", comboBox_user_ID.Text.ToString());
            cmd.Parameters.Add("name", textBox_U_Name.Text.ToString());
            cmd.Parameters.Add("email", textBox_Email.Text.ToString());
            cmd.Parameters.Add("password", textBox_password.Text.ToString());
            cmd.Parameters.Add("phone", textBox_phonenumber.Text.ToString());
            cmd.Parameters.Add("DOB", OracleDbType.Date).Value = DateTime.Parse(textBox_date_of_birth.Text);
            cmd.Parameters.Add("role", comboBox_Role.Text.ToString());
            cmd.Parameters.Add("create_data", OracleDbType.TimeStamp).Value = DateTime.Now;


            cmd.CommandType = CommandType.Text;

            int exq = cmd.ExecuteNonQuery();

            if (exq > 0)
            {
                comboBox_user_ID.Items.Add(comboBox_user_ID.Text);
                MessageBox.Show("New User is Added");
            }

            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_P_Full_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}