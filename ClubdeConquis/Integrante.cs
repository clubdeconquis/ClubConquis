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
    public partial class Integrante : Form
    {
        public Integrante()
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

        //Validar que los campos no esten vacios
        
        private bool valida()
        {

            try
            {
                if (txtNomInt.Text == "")
                    return false;
                if (txtRutInt.Text == "")
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

                    string sql = "INSERT INTO integrante(rutAl,nombre, apellidoPat, apellidoMat, direccion, fechaNac, tel, activo)VALUES('" + txtRutInt.Text + "','" + txtNomInt.Text + "', '" + txtApPInt.Text + "', '" + txtApMInt.Text + "', '" + txtDom.Text + "', '" + fechNacInt.Text + "', '" + txtTelInt.Text + "', '" + txtActivo.Text + "')";
                    
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
                txtRutInt.Focus();
                txtRutInt.SelectAll();
                MessageBox.Show("faltan campos");
            }
        }
        //Funcion para modificar la fecha de DateTimePicker
        /**private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fechNacInt.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 26 Feb 2001".
            fechNacInt.CustomFormat = "yyyy MMM dd";
        }
        **/
        private void Integrante_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Llamar la función Limpiar
            Limpiar(this);
        }
    }
}
