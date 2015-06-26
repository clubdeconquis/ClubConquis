using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using MySql.Data;


namespace ClubdeConquis
{
    public partial class Asistencias : Form
    {
        MySqlConnection cnx;
        public Asistencias()
        {
            InitializeComponent();
        }

        private void Asistencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mydbDataSet.integrante' Puede moverla o quitarla según sea necesario.
            this.integranteTableAdapter.Fill(this.mydbDataSet.integrante);
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; database=mydb; uid=root; password='' ";
            cn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = cn;
            command.CommandText = "select nombre from unidad";
            MySqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            comboBoxUnidad.DisplayMember = "nombre";
            comboBoxUnidad.DataSource = dt;



            // TODO: esta línea de código carga datos en la tabla 'mydbDataSet.unidad' Puede moverla o quitarla según sea necesario.
            //this.unidadTableAdapter.Fill(this.mydbDataSet.unidad);
            // this.unidadTableAdapter.Fill(this.mydbDataSet.unidad);
            // TODO: esta línea de código carga datos en la tabla 'mydbDataSet.integrante' Puede moverla o quitarla según sea necesario.
            // this.integranteTableAdapter.Fill(this.mydbDataSet.integrante);

        }

        private void cargarCBUnidad(MySqlConnection conn)
        {
            try
            {
                string query = "select nombre from unidad";
                MySqlDataAdapter DaRec2 = new MySqlDataAdapter(query, conn);

                DataTable DtUnidad = new DataTable();
                DaRec2.Fill(DtUnidad);

                DataRow row = DtUnidad.NewRow();
                row["idCurso"] = 0;
                row["nombre"] = "Seleccione...";
                DtUnidad.Rows.InsertAt(row, 0);

                //Este Combobox es una prueba
                comboBoxUnidad.DataSource = DtUnidad;
                comboBoxUnidad.DisplayMember = "Nombre";
                comboBoxUnidad.ValueMember = "idCurso";
                #region
                //System.Data.DataTable tabla = new System.Data.DataTable();
                //foreach (System.Data.DataRow linea in DtComercio.Rows)
                //{


                //    string valor1 = linea.ItemArray[0].ToString();
                //    string valor2 = linea.ItemArray[1].ToString();
                //    string concatenado = valor1 + valor2;
                //    cbtest.Items.Add(concatenado);
                //}
                #endregion
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gBAs_Enter(object sender, EventArgs e)
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


            MySqlDataAdapter da = new MySqlDataAdapter("select * FROM unidad ", cnx);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string a = comboBoxUnidad.SelectedValue.ToString();
            MySqlDataAdapter da;
            if (comboBoxUnidad.SelectedValue.ToString() != "0")
            {
               /** da = new MySqlDataAdapter("SELECT * FROM integrante WHERE fkUnidad= '"++"' "), cnx);
                DataSet ds = new DataSet();
                da.Fill(ds);
                /dGV.DataSource = ds.Tables[0];
                **/
            }
                
                
        }
    }
}
