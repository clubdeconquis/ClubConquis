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
    public partial class Alergias : Form
    {
        public Alergias()
        {
            InitializeComponent();
        }
        private bool valida()
        {

            try
            {
                if (txtDesc.Text == "")
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


                conexion cn = new conexion();
                try
                {

                    string sql = "INSERT INTO alergias(tipo, descripcion, Integrante_idIntegrante)VALUES('" + txtTipo.Text + "','" + txtDesc.Text + "','" + txtFkRut.Text + "')";

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
                txtDesc.Focus();
                txtDesc.SelectAll();
                MessageBox.Show("faltan campos");
            }
        }
    }
}
