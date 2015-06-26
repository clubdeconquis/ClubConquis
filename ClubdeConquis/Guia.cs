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
    public partial class Guia : Form
    {
        public Guia()
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
                if (txtNomG.Text == "")
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

                    string sql = "INSERT INTO guia(rutGuia,nombre, apellidoPat, apellidoMat, fechaNac, direccion, tel, activo)VALUES('" + masktxtRutG.MaskedTextProvider+ "','" + txtNomG.Text + "', '" + txtApPG.Text + "', '" + txtApMG.Text + "', '" + txtDomG.Text + "', '" + dTPFecNacG.Text+ "', '" + txtTelG.Text + "', '" + txtActivoG.Text + "')";
                    
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
                txtNomG.Focus();
                txtNomG.SelectAll();
                MessageBox.Show("faltan campos");
            }
        }

        private void masktxtRutG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Llamar la función Limpiar
            Limpiar(this);
        }
        }
    }

