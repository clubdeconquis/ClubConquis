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
    public partial class Apoderado : Form
    {
        public Apoderado()
        {
            InitializeComponent();
        }
        private bool valida()
        {

            try
            {
                if (txtRutAp.Text == "")
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

                    string sql = "INSERT INTO apoderadop(rutApP,nombre, apellidoPat, apellidoMat,fechaNac , direccion,cantHijos, tel, ocupacion, NivelEd, ciudadPro, nacionalidad, vinculofam)VALUES('" + txtRutInt.Text + "','" + txtNomInt.Text + "', '" + txtApPInt.Text + "', '" + txtApMInt.Text + "', '" + txtDom.Text + "', '" + fechNacInt.Text + "', '" + txtTelInt.Text + "', '" + txtActivo.Text + "')";

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
    }
}
