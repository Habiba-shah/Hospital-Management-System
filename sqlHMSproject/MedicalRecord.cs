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
            textBox1.ReadOnly = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int mid = int.Parse(textBox1.Text);
                string patientname = textBox2.Text;
                string doctorname = comboBoxDoctor.Text;
                string nurse = comboBoxNurse.Text;
                string diagnosis = comboBoxDiagnosis.Text;
                string prescription = comboBoxPrescription.Text;
                string treatment = comboBoxTreatment.Text;



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
                string doctorname = comboBoxDoctor.Text;
                string nurse = comboBoxNurse.Text;
                string diagnosis = comboBoxDiagnosis.Text;
                string prescription = comboBoxPrescription.Text;
                string treatment = comboBoxTreatment.Text;



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
            GetNextMedicalRecordId();

            // Hardcode dropdown values
            // Diagnosis
            comboBoxDiagnosis.Items.Add("Flu");
            comboBoxDiagnosis.Items.Add("Infection");
            comboBoxDiagnosis.Items.Add("Hypertension");
            comboBoxDiagnosis.Items.Add("Diabetes");
            comboBoxDiagnosis.Items.Add("Covid-19");

            // Prescription
            comboBoxPrescription.Items.Add("Paracetamol");
            comboBoxPrescription.Items.Add("Antibiotics");
            comboBoxPrescription.Items.Add("Insulin");
            comboBoxPrescription.Items.Add("Cough Syrup");
            comboBoxPrescription.Items.Add("Vitamins");

            // Treatment
            comboBoxTreatment.Items.Add("Rest");
            comboBoxTreatment.Items.Add("Surgery");
            comboBoxTreatment.Items.Add("Physical Therapy");
            comboBoxTreatment.Items.Add("Dietary Changes");

            // Doctor
            comboBoxDoctor.Items.Add("Dr. John Smith");
            comboBoxDoctor.Items.Add("Dr. Sarah Wilson");
            comboBoxDoctor.Items.Add("Dr. James Brown");
            comboBoxDoctor.Items.Add("Dr. Emily Davis");
            comboBoxDoctor.Items.Add("Dr. Michael White");

            // Nurse
            comboBoxNurse.Items.Add("Nurse Joy");
            comboBoxNurse.Items.Add("Nurse Blue");
            comboBoxNurse.Items.Add("Nurse Red");
            comboBoxNurse.Items.Add("Nurse White"); // Added space for linting

            // Auto-fill event
            textBox2.Leave += TextBox2_Leave;
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text)) return;

            string patientName = textBox2.Text;

            // Fetch Doctor from Appointments
            string query = "SELECT TOP 1 doctorname FROM appointments WHERE patientname = @patientname ORDER BY aid DESC";

            using (SqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientname", patientName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string doctor = result.ToString();
                        if (comboBoxDoctor.Items.Contains(doctor))
                        {
                            comboBoxDoctor.SelectedItem = doctor;
                        }
                        else
                        {
                            // If doctor isn't in the list, just set text or add it
                            comboBoxDoctor.Text = doctor;
                        }

                        // Fake logic for Nurse
                        comboBoxNurse.SelectedItem = "Nurse Joy";
                    }
                    else
                    {
                        // Optional: Clear if no record found
                        comboBoxDoctor.SelectedIndex = -1;
                        comboBoxNurse.SelectedIndex = -1;
                    }
                }
            }
        }

        private void GetNextMedicalRecordId()
        {
            string query = "SELECT ISNULL(MAX(mid), 0) + 1 FROM record";
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
