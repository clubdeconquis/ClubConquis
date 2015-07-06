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
    public partial class BAlergias : Form
    {
        MySqlConnection cnx;
        public BAlergias()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * FROM alergias WHERE tipo= '" + txtRut.Text + "' or Integrante_idIntegrante= '" + txtAlergia.Text + "' ", cnx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BAlergias_Load(object sender, EventArgs e)
        {
            cnx = new MySqlConnection();
            cnx.ConnectionString = "Server=localhost; Database=mydb ;User id=root;Password='' ";
            try
            {
                cnx.Open();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);

            }
            MySqlDataAdapter da = new MySqlDataAdapter("select * FROM alergias ", cnx);
        }
    }
}
