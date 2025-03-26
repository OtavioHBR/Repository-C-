using Form_PIM.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Form_PIM.Repository
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>
    {
        protected override string TableName => "Fornecedor";

        protected override Fornecedor Map(SqlDataReader reader)
        {
            return new Fornecedor
            {
                IdFornecedor = reader.GetInt32(reader.GetOrdinal("IdFornecedor")),
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Telefone = reader.GetString(reader.GetOrdinal("Telefone")),
                Email = reader.GetString(reader.GetOrdinal("Email")),
                Endereco = reader.GetString(reader.GetOrdinal("Endereco")),
                Cnpj = reader.GetString(reader.GetOrdinal("Cnpj"))
            };
        }

        public void Adicionar(Fornecedor fornecedor)
        {
            string query = "INSERT INTO Fornecedor (Nome, Telefone, Email, Endereco, Cnpj) " +
                           "VALUES (@Nome, @Telefone, @Email, @Endereco, @Cnpj);";

            SqlParameter[] parameters = {
                new SqlParameter("@Nome", fornecedor.Nome),
                new SqlParameter("@Telefone", fornecedor.Telefone),
                new SqlParameter("@Email", fornecedor.Email),
                new SqlParameter("@Endereco", fornecedor.Endereco),
                new SqlParameter("@Cnpj", fornecedor.Cnpj)
            };

            Adicionar(fornecedor, query, parameters);
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            string query = "UPDATE Fornecedor SET Nome = @Nome, Telefone = @Telefone, Email = @Email, Endereco = @Endereco, Cnpj = @Cnpj " +
                           "WHERE IdFornecedor = @IdFornecedor;";

            SqlParameter[] parameters = {
                new SqlParameter("@IdFornecedor", fornecedor.IdFornecedor),
                new SqlParameter("@Nome", fornecedor.Nome),
                new SqlParameter("@Telefone", fornecedor.Telefone),
                new SqlParameter("@Email", fornecedor.Email),
                new SqlParameter("@Endereco", fornecedor.Endereco),
                new SqlParameter("@Cnpj", fornecedor.Cnpj)
            };

            Atualizar(fornecedor, query, parameters);
        }

        public void Deletar(int id)
        {
            string query = "DELETE FROM Fornecedor WHERE IdFornecedor = @IdFornecedor;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdFornecedor", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Fornecedor ObterFornecedorPorId(int id)
        {
            string query = "SELECT * FROM Fornecedor WHERE IdFornecedor = @IdFornecedor;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdFornecedor", id);
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

        public List<Fornecedor> PesquisarPorNome(string nome)
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Fornecedor WHERE Nome LIKE @nome;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fornecedores.Add(Map(reader));
                        }
                    }
                }
            }

            return fornecedores;
        }
    }
}
