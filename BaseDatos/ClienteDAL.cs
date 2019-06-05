using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace BaseDatos
{
    public class ClienteDAL
    {
        protected bool useSQL = true;
        protected SQL.ClienteSQL getConsultas = new SQL.ClienteSQL();

        public DbDataReader GetComboClientes()
        {
            List<DbParameter> lista = new List<DbParameter>();

            return Utilidades.AccesoSQL.RunConsulta(getConsultas.GetSQL("ClientesGetCombo"), lista, System.Data.CommandType.Text);
        }

        public DbDataReader GetComboCliente(string codigoCliente)
        {
            List<DbParameter> lista = new List<DbParameter>();
            lista.Add(new SqlParameter("@codigoCliente", codigoCliente));

            return Utilidades.AccesoSQL.RunConsulta(getConsultas.GetSQL("ClienteGetCombo"), lista, System.Data.CommandType.Text);
        }

        public Objetos.Cliente readerToObject(DbDataReader reader)
        {
            Objetos.Cliente obj = new Objetos.Cliente();

            obj.Alias = (reader["Alias"] is System.DBNull ? string.Empty : (string)reader["Alias"]);
            obj.At = (reader["AT"] is System.DBNull ? false : (int)reader["AT"] == 1 ? true : false);
            obj.Cif = (reader["CIF"] is System.DBNull ? string.Empty : (string)reader["CIF"]);
            obj.Codigo = (reader["Codigo"] is System.DBNull ? string.Empty : (string)reader["Codigo"]);
            obj.Nombre = (reader["Nombre"] is System.DBNull ? string.Empty : (string)reader["Nombre"]);
            obj.TipoCliente = (reader["TipoClient"] is System.DBNull ? string.Empty : (string)reader["TipoClient"]);
            obj.Vs = (reader["VS"] is System.DBNull ? false : (int)reader["VS"] == 1 ? true : false);
            obj.Idioma = (reader["idioma"] is System.DBNull ? string.Empty : (string)reader["idioma"]);

            return obj;
        }
    }
}