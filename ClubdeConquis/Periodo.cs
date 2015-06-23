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
    public partial class Periodo : Form
    {
        public Periodo()
        {
            InitializeComponent();
        }
        private bool valida()
        {

            try
            {
                if (txtPeriodo.Text == "")
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

                    string sql = "INSERT INTO periodo(periodo, año)VALUES('" + txtPeriodo.Text + "','" + txtAno.Text + "')";

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
                txtPeriodo.Focus();
                txtPeriodo.SelectAll();
                MessageBox.Show("faltan campos");
            }
        }
    }
}
