using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClubdeConquis
{
    public partial class pruebaconex : Form
    {
        public pruebaconex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            MessageBox.Show("ok");
        }
    }
}
