using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace ClubdeConquis
{
    public class conexion
    {
        public MySqlConnection getconex()
        {


            try
            {
                MySqlConnection cnx = new MySqlConnection();
                cnx.ConnectionString = "Server=localhost; Database=mydb; Uid=root; Password='' ";
                cnx.Open();
                return cnx;
            }
            catch (Exception)
            {
                return null;
            }


        }
    }
}
