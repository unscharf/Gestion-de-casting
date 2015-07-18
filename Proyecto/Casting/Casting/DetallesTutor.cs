using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting
{
    public partial class DetallesTutor : Form
    {
        int ID;
        DetallesCandidato Dtc;


        public DetallesTutor(int ID, DetallesCandidato Dtc)
        {
            InitializeComponent();
            this.ID = ID;
            this.Dtc = Dtc;
        }

        public DetallesTutor(){}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;

            }
            else { textBox1.Enabled = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;

            }
            else { textBox2.Enabled = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;

            }
            else { textBox3.Enabled = false; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                maskedTextBox1.Enabled = true;

            }
            else { maskedTextBox1.Enabled = false; }
        }

        private void DetallesTutor_Load(object sender, EventArgs e)
        {
            MetodosComunes m = new MetodosComunes();
            m.DetallesTutor(ID, textBox1, textBox2, textBox3, maskedTextBox1, textBox5);
            tbxOnLoad();
        }

        public void tbxOnLoad() {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            maskedTextBox1.Enabled = false;
            textBox5.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodosComunes m = new MetodosComunes();
            m.ActualizarTutor(this, ID, textBox1.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text);

        }

    }
}
