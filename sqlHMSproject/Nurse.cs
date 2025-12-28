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
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                int nurseid = int.Parse(textBox1.Text);
                string nursename = textBox2.Text;

                string phone = textBox4.Text;
                string department = textBox5.Text;

                string query =
                    "INSERT INTO nurses (nurseid, nursename, phone, department) " +
                    "VALUES (@nurseid, @nursename, @phone, @department)";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nurseid", nurseid);
                        cmd.Parameters.AddWithValue("@nursename", nursename);

                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@department", department);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record inserted successfully");
                NurseData();
                GetNextNurseId();
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
                int nurseid = int.Parse(textBox1.Text);
                string nursename = textBox2.Text;

                string phone = textBox4.Text;
                string department = textBox5.Text;

                string query =
                  " update nurses set nursename=@nursename,phone= @phone, department=@department where nurseid=@nurseid";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nurseid", nurseid);
                        cmd.Parameters.AddWithValue("@nursename", nursename);

                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@department", department);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record updated successfully");
                NurseData();
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
                string query = "DELETE FROM nurses WHERE nurseid=@nurseid";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nurseid", int.Parse(textBox1.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record deleted successfully");
                NurseData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NurseData()
        {
            string query = "SELECT * FROM nurses";

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

        private void Nurse_Load(object sender, EventArgs e)
        {
            NurseData();
            GetNextNurseId();
        }

        private void GetNextNurseId()
        {
            string query = "SELECT ISNULL(MAX(nurseid), 0) + 1 FROM nurses";
            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    textBox1.Text = result.ToString();
                }
            }
        }
    }
}
