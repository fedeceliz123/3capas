using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class Negocio
    {
        ConsultasSQL con = new ConsultasSQL();
        
        public List<Suscriptor> Listardatos(string dni, int tipo)
        {
            return con.BuscarDatos(dni,tipo);

        }

    }
}
