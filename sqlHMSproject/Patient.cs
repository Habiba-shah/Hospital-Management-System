using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace sqlHMSproject
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            patientData();
        }

        private void patientData()
        {
            string query = "SELECT * FROM patients";

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            string query =
            "INSERT INTO patients (patientid, patientname, age, gender, address) " +
            "VALUES (@patientid, @patientname, @age, @gender, @address)";

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientid", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@patientname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@gender", textBox4.Text);
                    cmd.Parameters.AddWithValue("@address", textBox5.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record inserted successfully");
            patientData();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {


            string query =
            "UPDATE patients SET patientname=@patientname, age=@age, gender=@gender, address=@address " +
            "WHERE patientid=@patientid";

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientid", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@patientname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@age", int.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@gender", textBox4.Text);
                    cmd.Parameters.AddWithValue("@address", textBox5.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record updated successfully");
            patientData();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM patients WHERE patientid=@patientid";

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientid", int.Parse(textBox1.Text));
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record deleted successfully");
            patientData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


