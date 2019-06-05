namespace BaseDatos.SQL
{
    public class ClienteSQL
    {
        public virtual string GetSQL(string valor)
        {
            string sql = "";

            switch (valor)
            {
                case "ClientesGetCombo":
                    sql = "SELECT * FROM dbo.View_ClientesCombo";
                    break;
                case "ClienteGetCombo":
                    sql = "SELECT * FROM dbo.View_ClientesCombo WHERE Codigo = @codigoCliente";
                    break;
            }

            return sql;
        }
    }
}