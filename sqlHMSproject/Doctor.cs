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
            textBox1.ReadOnly = true;
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
                string doctorname = comboBoxDoctorName.Text;
                string speciality = textBox3.Text;
                string phone = textBox4.Text;
                string department = comboBoxDepartment.Text;

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
                GetNextDoctorId();
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
                        cmd.Parameters.AddWithValue("@doctorname", comboBoxDoctorName.Text);
                        cmd.Parameters.AddWithValue("@speciality", textBox3.Text);
                        cmd.Parameters.AddWithValue("@phone", textBox4.Text);
                        cmd.Parameters.AddWithValue("@department", comboBoxDepartment.Text);
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

            // Hardcoding doctor names in the dropdown
            comboBoxDoctorName.Items.Add("Dr. John Smith");
            comboBoxDoctorName.Items.Add("Dr. Sarah Wilson");
            comboBoxDoctorName.Items.Add("Dr. James Brown");
            comboBoxDoctorName.Items.Add("Dr. Emily Davis");
            comboBoxDoctorName.Items.Add("Dr. Michael White");

            // Auto-fill speciality when a doctor is selected
            comboBoxDoctorName.SelectedIndexChanged += ComboBoxDoctorName_SelectedIndexChanged;

            GetNextDoctorId();
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

        private void ComboBoxDoctorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDoctorName.SelectedItem == null) return;

            string selectedDoctor = comboBoxDoctorName.SelectedItem.ToString();

            // Clear previous department items
            comboBoxDepartment.Items.Clear();

            switch (selectedDoctor)
            {
                case "Dr. John Smith":
                    textBox3.Text = "Cardiology";
                    comboBoxDepartment.Items.Add("Cardiology Dept A");
                    comboBoxDepartment.Items.Add("Cardiology Dept B");
                    break;
                case "Dr. Sarah Wilson":
                    textBox3.Text = "Pediatrics";
                    comboBoxDepartment.Items.Add("Pediatrics Wing 1");
                    comboBoxDepartment.Items.Add("Pediatrics Wing 2");
                    break;
                case "Dr. James Brown":
                    textBox3.Text = "Neurology";
                    comboBoxDepartment.Items.Add("Neuro Center");
                    break;
                case "Dr. Emily Davis":
                    textBox3.Text = "Orthopedics";
                    comboBoxDepartment.Items.Add("Ortho Care");
                    break;
                case "Dr. Michael White":
                    textBox3.Text = "Dermatology";
                    comboBoxDepartment.Items.Add("Skin Clinic");
                    break;
                default:
                    textBox3.Text = "";
                    break;
            }
        }

        private void GetNextDoctorId()
        {
            string query = "SELECT ISNULL(MAX(doctorid), 0) + 1 FROM doctors";
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
