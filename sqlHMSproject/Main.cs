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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Doctor D = new Doctor();
            D.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nurse ne = new Nurse();
            ne.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MedicalRecord me = new MedicalRecord();
            me.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard bo=new Dashboard();
            bo.Show();
        }
    }
}
