using Form_PIM.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Form_PIM.Repository
{
    public class FuncionarioRepository : RepositoryBase<Funcionario>
    {
        protected override string TableName => "Funcionario";

        protected override Funcionario Map(SqlDataReader reader)
        {
            return new Funcionario
            {
                IdFuncionario = reader.GetInt32(reader.GetOrdinal("IdFuncionario")),
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Cargo = reader.GetString(reader.GetOrdinal("Cargo")),
                Salario = reader.GetDecimal(reader.GetOrdinal("Salario")),
                HoraEntrada = reader.GetTimeSpan(reader.GetOrdinal("HoraEntrada")),
                HoraSaida = reader.GetTimeSpan(reader.GetOrdinal("HoraSaida")),
                DataContratacao = reader.GetDateTime(reader.GetOrdinal("DataContratacao"))
            };
        }

        public void Adicionar(Funcionario funcionario)
        {
            string query = "INSERT INTO Funcionario (Nome, Cargo, Salario, HoraEntrada, HoraSaida, DataContratacao) " +
                           "VALUES (@Nome, @Cargo, @Salario, @HoraEntrada, @HoraSaida, @DataContratacao);";

            SqlParameter[] parameters = {
                new SqlParameter("@Nome", funcionario.Nome),
                new SqlParameter("@Cargo", funcionario.Cargo),
                new SqlParameter("@Salario", funcionario.Salario),
                new SqlParameter("@HoraEntrada", funcionario.HoraEntrada),
                new SqlParameter("@HoraSaida", funcionario.HoraSaida),
                new SqlParameter("@DataContratacao", funcionario.DataContratacao)
            };

            Adicionar(funcionario, query, parameters);
        }

        public void Atualizar(Funcionario funcionario)
        {
            string query = "UPDATE Funcionario SET Nome = @Nome, Cargo = @Cargo, Salario = @Salario, " +
                           "HoraEntrada = @HoraEntrada, HoraSaida = @HoraSaida, DataContratacao = @DataContratacao " +
                           "WHERE IdFuncionario = @IdFuncionario;";

            SqlParameter[] parameters = {
                new SqlParameter("@IdFuncionario", funcionario.IdFuncionario),
                new SqlParameter("@Nome", funcionario.Nome),
                new SqlParameter("@Cargo", funcionario.Cargo),
                new SqlParameter("@Salario", funcionario.Salario),
                new SqlParameter("@HoraEntrada", funcionario.HoraEntrada),
                new SqlParameter("@HoraSaida", funcionario.HoraSaida),
                new SqlParameter("@DataContratacao", funcionario.DataContratacao)
            };

            Atualizar(funcionario, query, parameters);
        }

        public void Deletar(int id)
        {
            string query = "DELETE FROM Funcionario WHERE IdFuncionario = @IdFuncionario;";
            Deletar(id, query);
        }

        public Funcionario ObterFuncionarioPorId(int id)
        {
            string query = "SELECT * FROM Funcionario WHERE IdFuncionario = @IdFuncionario;";
            return ObterPorId(id, query);
        }

        public List<Funcionario> PesquisarPorNome(string nome)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Funcionario WHERE Nome LIKE @nome;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            funcionarios.Add(Map(reader));
                        }
                    }
                }
            }

            return funcionarios;
        }
    }
}
