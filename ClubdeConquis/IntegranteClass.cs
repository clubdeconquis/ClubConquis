using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClubdeConquis
{
    class IntegranteClass
    {
       public int rutAl {get;set;}
       public string Nombre { get; set; }
       public string Apellido { get; set; }
       public string Fecha_Nac { get; set; }
       public string Direccion { get; set; }

       public IntegranteClass() { }

       public IntegranteClass(int pId, string pNombre, string pApellido, string pFecha_Nac, string pDireccion)

       {
           this.rutAl = pId;
           this.Nombre = pNombre;
           this.Apellido = pApellido;
           this.Fecha_Nac = pFecha_Nac;
           this.Direccion = pDireccion;       
       }
    }
}
