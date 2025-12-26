using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sqlHMSproject
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            AppointData();
        }
        private void AppointData()
        {
            string query = "SELECT * FROM appointments";

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
            try
            {
                int aid = int.Parse(textBox1.Text);
                string patientname = textBox2.Text;
                string doctorname = textBox3.Text;
                string date_created = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string status = textBox4.Text;

                string query =
                    "INSERT INTO Appointments (aid, patientname, doctorname, date_created, status) " +
                    "VALUES (@aid, @patientname, @doctorname, @date_created, @status)";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@aid", aid);
                        cmd.Parameters.AddWithValue("@patientname", patientname);
                        cmd.Parameters.AddWithValue("@doctorname", doctorname);
                        cmd.Parameters.AddWithValue("@date_created", date_created);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record inserted successfully");
                AppointData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int aid = int.Parse(textBox1.Text);
                string patientname = textBox2.Text;
                string doctorname = textBox3.Text;
                string date_created = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string status = textBox4.Text;

                string query =
                    "Update appointments set patientname = @patientname,doctorname= @doctorname, date_created = @date_created, status = @status WHERE aid = @aid";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@aid", aid);
                        cmd.Parameters.AddWithValue("@patientname", patientname);
                        cmd.Parameters.AddWithValue("@doctorname", doctorname);
                        cmd.Parameters.AddWithValue("@date_created", date_created);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record inserted successfully");
                AppointData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM appointments WHERE aid=@aid";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@aid", int.Parse(textBox1.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record deleted successfully");
                AppointData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
