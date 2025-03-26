using Form_PIM.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Form_PIM.Repository
{
    public class VendaRepository : RepositoryBase<Venda>
    {
        protected override string TableName => "Venda";

        protected override Venda Map(SqlDataReader reader)
        {
            return new Venda
            {
                IdVenda = reader.GetInt32(reader.GetOrdinal("IdVenda")),
                IdCliente = reader.IsDBNull(reader.GetOrdinal("IdCliente")) ? null : reader.GetString(reader.GetOrdinal("IdCliente")),
                IdFuncionario = reader.IsDBNull(reader.GetOrdinal("IdFuncionario")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdFuncionario")),
                IdProduto = reader.GetInt32(reader.GetOrdinal("IdProduto")),
                DataVenda = reader.GetDateTime(reader.GetOrdinal("DataVenda")),
                Produto = reader.GetString(reader.GetOrdinal("Produto"))
            };
        }

        public List<Venda> GetAllVendas()
        {
            string query = "SELECT * FROM Venda;";
            return GetAll(query);
        }
    }
}
