using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClubdeConquis
{
    class IntegranteDal
    {
       /** public static int Agregar(IntegranteClass pCliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into clientes (Nombre, Apellido, Fecha_Nacimiento, Direccion) values ('{0}','{1}','{2}', '{3}')",
                pCliente.Nombre, pCliente.Apellido, pCliente.Fecha_Nac, pCliente.Direccion),  cn.getconex());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }//**/
    }
}
