using Form_PIM.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Form_PIM.Repository
{
    public class LoginFuncionarioRepository : RepositoryBase<LoginFuncionario>
    {
        protected override string TableName => "LoginFuncionario";

        protected override LoginFuncionario Map(SqlDataReader reader)
        {
            return new LoginFuncionario
            {
                IdLoginFuncionario = reader.GetInt32(reader.GetOrdinal("IdLoginFuncionario")),
                IdFuncionario = reader.GetInt32(reader.GetOrdinal("LoginFunc")),
                SenhaFunc = reader.GetString(reader.GetOrdinal("SenhaFunc")),
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Cargo = reader.GetString(reader.GetOrdinal("Cargo")),
                Salario = reader.GetDecimal(reader.GetOrdinal("Salario")),
                HoraEntrada = reader.GetTimeSpan(reader.GetOrdinal("HoraEntrada")),
                HoraSaida = reader.GetTimeSpan(reader.GetOrdinal("HoraSaida")),
                DataContratacao = reader.GetDateTime(reader.GetOrdinal("DataContratacao"))
            };
        }

        public bool VerificarLogin(int idFuncionario, string senhaFunc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM LoginFuncionario WHERE LoginFunc = @IdFuncionario AND SenhaFunc = @SenhaFunc;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdFuncionario", idFuncionario);
                    cmd.Parameters.AddWithValue("@SenhaFunc", senhaFunc);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void Adicionar(LoginFuncionario loginFuncionario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Verificar se o funcionário existe
                string checkFuncionarioQuery = "SELECT COUNT(*) FROM Funcionario WHERE IdFuncionario = @IdFuncionario;";
                using (SqlCommand checkCmd = new SqlCommand(checkFuncionarioQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@IdFuncionario", loginFuncionario.IdFuncionario);

                    conn.Open();
                    int count = (int)checkCmd.ExecuteScalar();
                    conn.Close();

                    if (count == 0)
                    {
                        throw new Exception("Funcionário não encontrado.");
                    }
                }

                // Adicionar login do funcionário
                string query = "INSERT INTO LoginFuncionario (LoginFunc, SenhaFunc) VALUES (@IdFuncionario, @SenhaFunc);";

                SqlParameter[] parameters = {
                    new SqlParameter("@IdFuncionario", loginFuncionario.IdFuncionario),
                    new SqlParameter("@SenhaFunc", loginFuncionario.SenhaFunc)
                };

                Adicionar(loginFuncionario, query, parameters);
            }
        }

        public void Atualizar(LoginFuncionario loginFuncionario)
        {
            string query = "UPDATE LoginFuncionario SET SenhaFunc = @SenhaFunc WHERE IdLoginFuncionario = @IdLoginFuncionario;";

            SqlParameter[] parameters = {
                new SqlParameter("@IdLoginFuncionario", loginFuncionario.IdLoginFuncionario),
                new SqlParameter("@SenhaFunc", loginFuncionario.SenhaFunc)
            };

            Atualizar(loginFuncionario, query, parameters);
        }

        public void Deletar(int id)
        {
            string query = "DELETE FROM LoginFuncionario WHERE IdLoginFuncionario = @IdLoginFuncionario;";
            Deletar(id, query);
        }

        public List<LoginFuncionario> GetAll()
        {
            string query = "SELECT lf.IdLoginFuncionario, lf.LoginFunc, lf.SenhaFunc, f.Nome, f.Cargo, f.Salario, f.HoraEntrada, f.HoraSaida, f.DataContratacao " +
                           "FROM LoginFuncionario lf " +
                           "JOIN Funcionario f ON lf.LoginFunc = f.IdFuncionario;";
            return GetAll(query);
        }
    }
}
