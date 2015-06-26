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
    public partial class Responsable : Form
    {
        public Responsable()
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
                if (txtNomRes.Text == "")
                    return false;

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (valida())
            {

                //MySqlConnection con; 
                conexion cn = new conexion();
                try
                {

                    string sql = "INSERT INTO responsable(rutRes,nombreRes, apellidoPRes,tipoResponsabilidad,Descripcion)VALUES('" + txtRutRes.Text + "','" + txtNomRes.Text + "','" + txtApPRes.Text + "', '" + txtTipoRes.Text + "', '" + txtDesc.Text + "')";

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
                    MessageBox.Show("Error de Sistema");
                    throw;
                }
            }
            else
            {
                txtNomRes.Focus();
                txtNomRes.SelectAll();
                MessageBox.Show("faltan campos");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            // Llamar la función Limpiar
            Limpiar(this);
        }
    }
}
