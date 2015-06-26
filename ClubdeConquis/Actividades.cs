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
    public partial class Actividades : Form
    {
        public Actividades()
        {
            InitializeComponent();
        }

        private void inasistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inasistencia In = new Inasistencia();
            In.MdiParent = this;
            In.Show();
        }

        private void suspensionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suspensiones In = new Suspensiones();
            In.MdiParent = this;
            In.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha cerrado Qadoshim Manager");
            this.Close();
            Application.Exit();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integrante In= new Integrante();
            In.MdiParent = this;
            In.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guia In = new Guia();
            In.MdiParent = this;
            In.Show();
        }

        private void apoderadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unidad In = new Unidad();
            In.MdiParent = this;
            In.Show();
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salidas In = new Salidas();
            In.MdiParent = this;
            In.Show();
        }

        private void alergiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alergias In = new Alergias();
            In.MdiParent = this;
            In.Show();
        }

        private void apoderadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Apoderado In = new Apoderado();
            In.MdiParent = this;
            In.Show();
        }

        private void aporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void capacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void periodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Periodo In = new Periodo();
            In.MdiParent = this;
            In.Show();
        }

        private void responsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Responsable In = new Responsable();
            In.MdiParent = this;
            In.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario In = new Usuario();
            In.MdiParent = this;
            In.Show();
        }
    }
}
