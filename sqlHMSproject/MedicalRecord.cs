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
    public partial class MedicalRecord : Form
    {
        public MedicalRecord()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = int.Parse(textBox1.Text);
                string patientname = textBox2.Text;
                string doctorname = textBox3.Text;
                string nurse = textBox4.Text;
                string diagnosis = textBox5.Text;
                string prescription = textBox6.Text;
                string treatment = textBox7.Text;



                string query =
                    "INSERT INTO record (mid, patientname, doctorname,nurse, diagnosis, prescription, treatment) " +
                    "VALUES (@mid, @patientname, @doctorname,@nurse, @diagnosis, @prescription, @treatment)";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mid", mid);
                        cmd.Parameters.AddWithValue("@patientname", patientname);
                        cmd.Parameters.AddWithValue("@doctorname", doctorname);
                        cmd.Parameters.AddWithValue("@nurse", nurse);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@prescription", prescription);

                        cmd.Parameters.AddWithValue("@treatment", treatment);


                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record inserted successfully");
                RecordData();
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
                int mid = int.Parse(textBox1.Text);
                string patientname = textBox2.Text;
                string doctorname = textBox3.Text;
                string nurse = textBox4.Text;
                string diagnosis = textBox5.Text;
                string prescription = textBox6.Text;
                string treatment = textBox7.Text;



                string query =
                    "UPDATE record SET patientname = @patientname, doctorname = @doctorname, nurse = @nurse, diagnosis = @diagnosis, prescription =  @prescription,treatment =  @treatment where mid = @mid";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mid", mid);
                        cmd.Parameters.AddWithValue("@patientname", patientname);
                        cmd.Parameters.AddWithValue("@doctorname", doctorname);
                        cmd.Parameters.AddWithValue("@nurse", nurse);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@prescription", prescription);

                        cmd.Parameters.AddWithValue("@treatment", treatment);


                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record updated successfully");
                RecordData();
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
                string query = "DELETE FROM record WHERE mid=@mid";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mid", int.Parse(textBox1.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record deleted successfully");
                RecordData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MedicalRecord_Load(object sender, EventArgs e)
        {
            RecordData();
        }
        private void RecordData()
        {
            string query = "SELECT * FROM record";

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
