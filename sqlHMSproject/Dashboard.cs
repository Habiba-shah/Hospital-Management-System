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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            display1();
            display2();
            display3();
            display4();

        }
        //private void display()
        //{
        //    string connectionString =
        //       "Server=localhost;" +
        //       "Database=HospitalDB;" +
        //       "Trusted_Connection=True;TrustServerCertificate=True;";
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {

        //        try
        //        {
        //            conn.Open();
        //            string query = "select Count (*) from patients";
        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                int count = Convert.ToInt32(cmd.ExecuteScalar());
        //                lblCount1.Text = "total patients:" + count.ToString();

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error:" + ex.Message);
        //        }

        //    }
        //}
        private void display1()
        {
            string connectionString =
               "Server=localhost;" +
               "Database=HospitalDB;" +
               "Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    string query = "select Count (*) from patients";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCount1.Text = count.ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

            }

        }

        private void display2()
        {
            string connectionString =
               "Server=localhost;" +
               "Database=HospitalDB;" +
               "Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    string query = "select Count (*) from doctors";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCount2.Text = count.ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

            }
        }
        private void display3()
        {
            string connectionString =
               "Server=localhost;" +
               "Database=HospitalDB;" +
               "Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    string query = "select Count (*) from nurses";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCount3.Text = count.ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

            }
        }

        private void display4()
        {
            string connectionString =
               "Server=localhost;" +
               "Database=HospitalDB;" +
               "Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();
                    string query = "select Count (*) from appointments";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCount4.Text = count.ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

            }
        }
    }
}
