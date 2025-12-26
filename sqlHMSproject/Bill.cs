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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            string query =
            "INSERT INTO bills (bid, patientname, amount, statuss) " +
            "VALUES (@bid, @patientname, @amount, @statuss)";

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@bid", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@patientname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@amount", float.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@statuss", textBox4.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record inserted successfully");
            BillsData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query =
           "update  bills set patientname= @patientname,amount= @amount,statuss= @statuss where bid=@bid";

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@bid", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@patientname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@amount", float.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@statuss", textBox4.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record updated successfully");
            BillsData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM bills WHERE bid=@bid";

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@bid", int.Parse(textBox1.Text));
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record deleted successfully");
            BillsData();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            BillsData();
        }

        private void BillsData()
        {
            string query = "SELECT * FROM bills";

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
    }
}

