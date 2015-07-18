using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting.Pwd
{
    public partial class Recuperacion2 : Form
    {
        String cad;
        Recuperacion1 Rec;
        public Recuperacion2(String cad, Recuperacion1 Rec)
        {
            InitializeComponent();
            this.cad = cad;
            this.Rec = Rec;
        }

        private void Recuperacion2_Load(object sender, EventArgs e)
        {
            MetodosPwd m = new MetodosPwd();
            textBox1.Enabled = false;

            m.setData(cad, textBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodosPwd m = new MetodosPwd();
            m.CompararRespuesta(this, textBox1.Text, textBox2.Text);
        }
    }
}
