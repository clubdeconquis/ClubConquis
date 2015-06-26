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
    public partial class Suspensiones : Form
    {
        public Suspensiones()
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


        private bool valida()
        {

            try
            {
                if (txtDescripcion.Text == "")
                    return false;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (valida())
            {


                conexion cn = new conexion();
                try
                {

                    string sql = "INSERT INTO suspensiones(descripcion, fecha, rutAl)VALUES('" + txtDescripcion.Text + "','" + txtFecha.Text + "','" + txtRutInt.Text + "')";

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
                    //Puede que los datos se envien dos veces, a lo que entraria en este catch
                    MessageBox.Show("Esta enviando dos veces los mismos datos o existe otro error");
                    throw;
                }
            }
            else
            {
                txtDescripcion.Focus();
                txtDescripcion.SelectAll();
                MessageBox.Show("faltan campos");
            }
        }

        private void txtRutInt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Llamar la función Limpiar
            Limpiar(this);
        }
    }
}
