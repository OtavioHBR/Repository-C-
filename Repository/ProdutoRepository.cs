using Form_PIM.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Form_PIM.Repository
{
    public class ProdutoRepository : RepositoryBase<Produto>
    {
        protected override string TableName => "Produto";

        protected override Produto Map(SqlDataReader reader)
        {
            return new Produto
            {
                IdProduto = reader.GetInt32(reader.GetOrdinal("IdProduto")),
                NomeProduto = reader.GetString(reader.GetOrdinal("NomeProduto")),
                IdFornecedor = reader.GetInt32(reader.GetOrdinal("IdFornecedor")),
                Quantidade = reader.GetInt32(reader.GetOrdinal("Quantidade")),
                ValorCompra = reader.GetDecimal(reader.GetOrdinal("ValorCompra")),
                ValorVenda = reader.GetDecimal(reader.GetOrdinal("ValorVenda"))
            };
        }

        public void Adicionar(Produto produto)
        {
            string query = "INSERT INTO Produto (NomeProduto, IdFornecedor, Quantidade, ValorCompra, ValorVenda) " +
                           "VALUES (@NomeProduto, @IdFornecedor, 0, @ValorCompra, @ValorVenda);";

            SqlParameter[] parameters = {
                new SqlParameter("@NomeProduto", produto.NomeProduto),
                new SqlParameter("@IdFornecedor", produto.IdFornecedor),
                new SqlParameter("@ValorCompra", produto.ValorCompra),
                new SqlParameter("@ValorVenda", produto.ValorVenda)
            };

            Adicionar(produto, query, parameters);
        }

        public void Atualizar(Produto produto)
        {
            string query = "UPDATE Produto SET NomeProduto = @NomeProduto, IdFornecedor = @IdFornecedor, " +
                           "ValorCompra = @ValorCompra, ValorVenda = @ValorVenda " +
                           "WHERE IdProduto = @IdProduto;";

            SqlParameter[] parameters = {
                new SqlParameter("@IdProduto", produto.IdProduto),
                new SqlParameter("@NomeProduto", produto.NomeProduto),
                new SqlParameter("@IdFornecedor", produto.IdFornecedor),
                new SqlParameter("@ValorCompra", produto.ValorCompra),
                new SqlParameter("@ValorVenda", produto.ValorVenda)
            };

            Atualizar(produto, query, parameters);
        }

        public void Deletar(int id)
        {
            string query = "DELETE FROM Produto WHERE IdProduto = @IdProduto;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdProduto", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Produto ObterProdutoPorId(int id)
        {
            string query = "SELECT * FROM Produto WHERE IdProduto = @IdProduto;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdProduto", id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Map(reader);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public void AtualizarQuantidade(int id, int quantidade)
        {
            string query = "UPDATE Produto SET Quantidade = @Quantidade WHERE IdProduto = @IdProduto;";

            SqlParameter[] parameters = {
                new SqlParameter("@IdProduto", id),
                new SqlParameter("@Quantidade", quantidade)
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
