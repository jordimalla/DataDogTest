using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Negocio
{
    public class ClienteBLL
    {
        public List<Objetos.Cliente> ObtenerTodosLosClientes()
        {
            BaseDatos.ClienteDAL dal = new BaseDatos.ClienteDAL();
            List<Objetos.Cliente> clientes = new List<Objetos.Cliente>();
            DbDataReader reader = null;

            try
            {
                reader = dal.GetComboClientes();

                while (reader.Read())
                {
                    clientes.Add(dal.readerToObject(reader));
                }
            }
            catch (Exception ex)
            {
                SPAUtils.Log.Save.GuardarException(ex);
                throw new Exception("Error al obtener los clientes de la base de datos.");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return clientes;
        }

        public Objetos.Cliente ObtenerCliente(string codigoCliente)
        {
            BaseDatos.ClienteDAL dal = new BaseDatos.ClienteDAL();
            Objetos.Cliente cliente = new Objetos.Cliente();
            DbDataReader reader = null;

            try
            {
                reader = dal.GetComboCliente(codigoCliente);

                if (reader.Read())
                    cliente = dal.readerToObject(reader);
            }
            catch (Exception ex)
            {
                SPAUtils.Log.Save.GuardarException(ex);
                throw new Exception("Error al obtener los clientes de la base de datos.");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return cliente;
        }
    }
}
