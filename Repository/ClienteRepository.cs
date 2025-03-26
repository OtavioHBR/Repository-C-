using Form_PIM.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Form_PIM.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>
    {
        protected override string TableName => "Cliente";

        protected override Cliente Map(SqlDataReader reader)
        {
            return new Cliente
            {
                Cpf = reader.GetString(reader.GetOrdinal("Cpf")),
                Nome = reader.GetString(reader.GetOrdinal("Nome")), // Adicionado
                Telefone = reader.GetString(reader.GetOrdinal("Telefone")),
                Email = reader.GetString(reader.GetOrdinal("Email")),
                Endereco = reader.GetString(reader.GetOrdinal("Endereco"))
            };
        }

        public void Adicionar(Cliente cliente)
        {
            string query = "INSERT INTO Cliente (Cpf, Nome, Telefone, Email, Endereco) " +
                           "VALUES (@Cpf, @Nome, @Telefone, @Email, @Endereco);";

            SqlParameter[] parameters = {
                new SqlParameter("@Cpf", cliente.Cpf),
                new SqlParameter("@Nome", cliente.Nome), // Adicionado
                new SqlParameter("@Telefone", cliente.Telefone),
                new SqlParameter("@Email", cliente.Email),
                new SqlParameter("@Endereco", cliente.Endereco)
            };

            Adicionar(cliente, query, parameters);
        }

        public void Atualizar(Cliente cliente)
        {
            string query = "UPDATE Cliente SET Nome = @Nome, Telefone = @Telefone, Email = @Email, Endereco = @Endereco " +
                           "WHERE Cpf = @Cpf;";

            SqlParameter[] parameters = {
                new SqlParameter("@Cpf", cliente.Cpf),
                new SqlParameter("@Nome", cliente.Nome), // Adicionado
                new SqlParameter("@Telefone", cliente.Telefone),
                new SqlParameter("@Email", cliente.Email),
                new SqlParameter("@Endereco", cliente.Endereco)
            };

            Atualizar(cliente, query, parameters);
        }

        public void Deletar(string cpf)
        {
            string query = "DELETE FROM Cliente WHERE Cpf = @Cpf;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cpf", cpf);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Cliente ObterClientePorId(string cpf)
        {
            string query = "SELECT * FROM Cliente WHERE Cpf = @Cpf;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cpf", cpf);
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

        public List<Cliente> PesquisarPorNome(string nome)
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cliente WHERE Nome LIKE @nome;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientes.Add(Map(reader));
                        }
                    }
                }
            }

            return clientes;
        }
    }
}
