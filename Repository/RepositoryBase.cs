using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Form_PIM.Repository
{
    public abstract class RepositoryBase<T> where T : class
    {
        protected string connectionString = "Server=Desktop_OHB\\SQLEXPRESS;Database=FazendaDB;Integrated Security=True;";

        protected abstract string TableName { get; }

        protected abstract T Map(SqlDataReader reader);

        public void Adicionar(T entity, string query, SqlParameter[] parameters)
        {
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

        public void Atualizar(T entity, string query, SqlParameter[] parameters)
        {
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

        public void Deletar(int id, string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<T> GetAll(string query)
        {
            List<T> entities = new List<T>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entities.Add(Map(reader));
                        }
                    }
                }
            }

            return entities;
        }

        public T ObterPorId(int id, string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
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
    }
}
