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
            textBox1.ReadOnly = true;
            dateTimePicker1.Enabled = false;
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
            LoadDoctors();
            GetNextAppointmentId();

            comboBoxDoctor.SelectedIndexChanged += ComboBoxDoctor_SelectedIndexChanged;
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
                string doctorname = comboBoxDoctor.Text;
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
                GetNextAppointmentId();
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
                string doctorname = comboBoxDoctor.Text;
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
        private void LoadDoctors()
        {
            // Hardcoding doctor names to match Doctor form
            comboBoxDoctor.Items.Add("Dr. John Smith");
            comboBoxDoctor.Items.Add("Dr. Sarah Wilson");
            comboBoxDoctor.Items.Add("Dr. James Brown");
            comboBoxDoctor.Items.Add("Dr. Emily Davis");
            comboBoxDoctor.Items.Add("Dr. Michael White");
        }

        private void GetNextAppointmentId()
        {
            string query = "SELECT ISNULL(MAX(aid), 0) + 1 FROM appointments";
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

        private void ComboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDoctor.SelectedItem == null) return;

            string selectedDoctor = comboBoxDoctor.SelectedItem.ToString();
            panelAvailability.Visible = true;
            dateTimePicker1.Enabled = true;

            // Mock availability logic. In a real app, strict dates would be fetched from DB.
            switch (selectedDoctor)
            {
                case "Dr. John Smith":
                    lblAvailability.Text = "Available: Mon, Wed, Fri (9AM - 2PM)";
                    break;
                case "Dr. Sarah Wilson":
                    lblAvailability.Text = "Available: Tue, Thu (10AM - 4PM)";
                    break;
                case "Dr. James Brown":
                    lblAvailability.Text = "Available: Mon-Fri (8AM - 12PM)";
                    break;
                case "Dr. Emily Davis":
                    lblAvailability.Text = "Available: Weekends (11AM - 5PM)";
                    break;
                default:
                    lblAvailability.Text = "Available: Please call to confirm.";
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
