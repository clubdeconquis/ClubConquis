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
    public partial class Login : Form
    {
        //creacion de conexion con bd
        conexion cnx = new conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxLogin_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dt = new DataTable();
                string sql = "select * FROM inspector where nombre = '" + txtNombre.Text + "' and clave =  '" + txtClave.Text + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cnx.getconex());
                int n = da.Fill(dt);
                // dt.Rows[0].ToString();

                if (n == 0)
                {
                    MessageBox.Show("Usuario No Existe");
                }

                else
                {

                    //  if (dt.Rows[0].ToString() == "1")

                    {
                        // else (colocar tipos de de formularios)


                    }

                    MessageBox.Show("Bienvenido a School Manager");
                    this.Hide();
                    //Eventos f1 = new Eventos();

                   // f1.ShowDialog();


                }




            }
            catch (Exception)
            {
            }
        }
    }
}
