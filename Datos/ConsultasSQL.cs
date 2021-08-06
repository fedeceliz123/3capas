using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class ConsultasSQL:ConexionDB
    {   
        

        public List<Suscriptor> BuscarDatos(string dni, int tipo)
        {
            var dt = new DataTable();
            string consulta = "select * from Suscriptor where NumeroDocumento=" + dni + " and TipoDocumento=" + tipo;

            SqlDataAdapter da = new SqlDataAdapter(consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];

            List<Suscriptor> Listar = new List<Suscriptor>();

            Listar.Add(new Suscriptor
            {
                IdSuscriptor1 = int.Parse(dt.Rows[0]["IdSuscriptor"].ToString()),
                Nombre1= dt.Rows[0]["Nombre"].ToString(),
                Apellido1= dt.Rows[0]["Apellido"].ToString(),
                NumeroDocumento1= long.Parse(dt.Rows[0]["NumeroDocumento"].ToString()),
                TipoDocumento1= int.Parse(dt.Rows[0]["TipoDocumento"].ToString()),
                Direccion1= dt.Rows[0]["Direccion"].ToString(),
                Telefono1= dt.Rows[0]["Telefono"].ToString(),
                Email1= dt.Rows[0]["Email"].ToString(),
                NombreUsuario1= dt.Rows[0]["NombreUsuario"].ToString(),
                Password1= dt.Rows[0]["Password"].ToString(),

            }) ;


            return Listar;

        } 


    }
}
