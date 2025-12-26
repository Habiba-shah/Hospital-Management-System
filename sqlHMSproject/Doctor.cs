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

namespace sqlHMSproject
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void btnInsert_Click(object sender, EventArgs e)
        //{
        //    int doctorid = int.Parse(textBox1.Text);
        //    string doctorname = textBox2.Text;
        //    string speciality = textBox3.Text;
        //    string phone = textBox4.Text;
        //    string department = textBox5.Text;
        //    string query =
        //   "INSERT INTO doctors (doctorid, doctorname, speciality, phone, department) " +
        //   "VALUES (@doctorid, @doctorname, @speciality, @phone, @department)";

        //    using (SqlConnection conn = new DatabaseConnection().GetConnection())
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@doctorid", doctorid);
        //            cmd.Parameters.AddWithValue("@doctorname", doctorname);
        //            cmd.Parameters.AddWithValue("@speciality", speciality);
        //            cmd.Parameters.AddWithValue("@phone", phone);
        //            cmd.Parameters.AddWithValue("@department", department);
        //            cmd.ExecuteNonQuery();
        //        }


        //}

        //    MessageBox.Show("Record inserted successfully");
        //    DoctorData();

        //}
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int doctorid = int.Parse(textBox1.Text);
                string doctorname = textBox2.Text;
                string speciality = textBox3.Text;
                string phone = textBox4.Text;
                string department = textBox5.Text;

                string query =
                    "INSERT INTO doctors (doctorid, doctorname, speciality, phone, department) " +
                    "VALUES (@doctorid, @doctorname, @speciality, @phone, @department)";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctorid", doctorid);
                        cmd.Parameters.AddWithValue("@doctorname", doctorname);
                        cmd.Parameters.AddWithValue("@speciality", speciality);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@department", department);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record inserted successfully");
                DoctorData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    int doctorid = int.Parse(textBox1.Text);
        //    string doctorname = textBox2.Text;
        //    string speciality = textBox3.Text;
        //    string phone = textBox4.Text;
        //    string department = textBox5.Text;
        //    string query =
        //   "update doctors set doctorname=@doctorname, speciality=@speciality,phone =@phone, department=@department where doctorid=@doctorid";

        //    using (SqlConnection conn = new DatabaseConnection().GetConnection())
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@doctorid", doctorid);
        //            cmd.Parameters.AddWithValue("@doctorname", doctorname);
        //            cmd.Parameters.AddWithValue("@speciality", speciality);
        //            cmd.Parameters.AddWithValue("@phone", phone);
        //            cmd.Parameters.AddWithValue("@department", department);

        //        }
        //    }

        //    MessageBox.Show("Record updated successfully");
        //    DoctorData();
        //}
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query =
                    "UPDATE doctors SET doctorname=@doctorname, speciality=@speciality, " +
                    "phone=@phone, department=@department WHERE doctorid=@doctorid";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctorid", int.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("@doctorname", textBox2.Text);
                        cmd.Parameters.AddWithValue("@speciality", textBox3.Text);
                        cmd.Parameters.AddWithValue("@phone", textBox4.Text);
                        cmd.Parameters.AddWithValue("@department", textBox5.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record updated successfully");
                DoctorData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    int doctorid = int.Parse(textBox1.Text);

        //    string query =
        //   "delete from doctors where doctorid=@doctorid";

        //    using (SqlConnection conn = new DatabaseConnection().GetConnection())
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@doctorid", doctorid);


        //            cmd.ExecuteNonQuery();
        //        }
        //    }

        //    MessageBox.Show("Record deleted successfully");
        //    DoctorData();
        //}
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM doctors WHERE doctorid=@doctorid";

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctorid", int.Parse(textBox1.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record deleted successfully");
                DoctorData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
                DoctorData();
        }
        private void DoctorData()
        {
            string query = "SELECT * FROM doctors";

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
