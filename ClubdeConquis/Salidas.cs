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
    public partial class Salidas : Form
    {
        public Salidas()
        {
            InitializeComponent();
        }

        public static void Limpiar(Form ofrm)
        {
            // Checar todos los textbox del formulario
            foreach (Control oControls in ofrm.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Llamar la función Limpiar
            Limpiar(this);
        }
    }
}
