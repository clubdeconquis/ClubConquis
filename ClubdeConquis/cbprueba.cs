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
    public partial class cbprueba : Form
    {
        public cbprueba()
        {
            InitializeComponent();
        }

        private void cbprueba_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString =  "server=localhost; database=mydb; uid=root; password='' ";
            cn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = cn;
            command.CommandText = "select nombre from unidad";
            MySqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = dt;

        }
    }
}
