using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClubdeConquis
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        private bool valida()
        {

            try
            {
                if (txtNomUs.Text == "")
                    return false;
                if (txtRutUs.Text == "")
                    return false;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (valida())
            {

                //MySqlConnection con; 
                conexion cn = new conexion();
                try
                {

                    string sql = "INSERT INTO usuario(rutUser,nombre, apellidoPat, apellidoMat, fechaNac, tel, activo)VALUES('" + txtRutUs.Text + "','" + txtNomUs.Text + "', '" + txtApPUs.Text + "', '" + txtApMUs.Text + "', '" + fechNacUs.Text + "', '" + txtTelUs.Text + "', '" + txtActivo.Text + "')";

                    MySqlCommand cmd = new MySqlCommand(sql, cn.getconex());
                    int N = cmd.ExecuteNonQuery();

                    if (N > 0)
                    {
                        MessageBox.Show("El Ingreso de datos ha sido insertado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El Ingreso de datos ha sido insertado como las weas");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Esta enviando dos veces los mismos datos");
                    throw;
                }
            }
            else
            {
                txtRutUs.Focus();
                txtRutUs.SelectAll();
                MessageBox.Show("faltan campos");
            }
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
        private void button2_Click(object sender, EventArgs e)
        {
            // Llamar la función Limpiar
            Limpiar(this);
        }
    }
}
