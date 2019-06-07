using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace Utilidades
{
    public class AccesoSQL
    {
        public static DbDataReader RunConsulta(string consulta, List<DbParameter> lista, System.Data.CommandType tipo)
        {
            DbDataReader r = null;
            DbCommand command = new SqlCommand();

            command.Connection = Utilidades.AccesoSQL.getConnection(Configuracion.CadenaConexion);
            command.CommandType = tipo;
            command.CommandText = consulta;

            command.Parameters.AddRange(lista.ToArray<IDataParameter>());
            command.CommandTimeout = 60;

            try
            {
                r = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                command.Connection.Dispose();
                throw ex;
            }

            return r;
        }

        public static DbConnection getConnection(string cs)
        {
            DbConnection conexion;
            string stringConnection = Configuracion.CadenaConexion;

            conexion = new SqlConnection(stringConnection);
            conexion.Open();

            return conexion;
        }
    }
}