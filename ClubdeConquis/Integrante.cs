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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechNacInt.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 26 Feb 2001".
            fechNacInt.CustomFormat = "yyyy MMM dd";
        }
        //Validar que los campos no esten vacios
        private bool valida()
        {

            try
            {
                if (txtNomInt.Text == "")
                    return false;
                if (maskTxtRutInt.Text == "")
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

                    string sql = "INSERT INTO integrante(rutAl,nombre, apellidoPat, apellidoMat, direccion, fechaNac, tel, cantAtrasos ,activo)VALUES('" + txtRutInt.Text + "','" + txtNomInt.Text + "', '" + txtApPInt.Text + "', '" + txtApMInt.Text + "', '" + txtDom.Text + "', '" + .Value + "', '" + telInt.Text + "', " + txtActivo.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, cn.getconex());
                    int N = cmd.ExecuteNonQuery();

                    if (N > 0)
                    {
                        MessageBox.Show("OK");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                maskTxtRutInt.Focus();
                maskTxtRutInt.SelectAll();
                MessageBox.Show("faltan campos");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fechNacInt.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 26 Feb 2001".
            fechNacInt.CustomFormat = "yyyy MMM dd";
        }

        private void Integrante_Load(object sender, EventArgs e)
        {

        }
    }
}
