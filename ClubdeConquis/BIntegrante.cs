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
    public partial class BIntegrante : Form
    {
        MySqlConnection cnx;
        public BIntegrante()

        {
            InitializeComponent();
        }

        private void BIntegrante_Load(object sender, EventArgs e)
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
            MySqlDataAdapter da = new MySqlDataAdapter("select * FROM integrante ", cnx);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * FROM integrante WHERE nombre= '" + txtNom.Text + "' or rutAl= '" + txtRut.Text + "' ", cnx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {

        }
    }
}
