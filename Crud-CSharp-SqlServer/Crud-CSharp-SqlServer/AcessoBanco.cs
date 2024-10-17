using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Crud_CSharp_SqlServer
{
    internal class AcessoBanco
    {
        // Conectar ao banco de dados
        private static SqlConnection conexaoBanco()
        {
            // Conecta ao banco Bike com autenticação do Windows
            SqlConnection conexao = new SqlConnection(@"Data Source=JOSE-NEW\SQLEXPRESS;integrated security=SSPI;Initial Catalog=Bike");
            return conexao;
        }

        // Consulta SQL com parâmetros
        public static DataTable consulta(string sql, Dictionary<string, object> parametros)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexao = conexaoBanco())
                {
                    conexao.Open();

                    using (SqlCommand cm = new SqlCommand(sql, conexao))
                    {
                        // Adiciona os parâmetros do dicionário ao comando SQL
                        foreach (var parametro in parametros)
                        {
                            cm.Parameters.AddWithValue(parametro.Key, parametro.Value);
                        }

                        // Executa o comando e preenche o DataTable
                        using (SqlDataAdapter da = new SqlDataAdapter(cm))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar dados: " + ex.Message);
            }

            return dt;
        }

        // Executar comandos SQL (INSERT, UPDATE, DELETE)
        public static int ExecutarComando(string sql, Dictionary<string, object> parametros)
        {
            int linhasAfetadas = 0;

            try
            {
                using (SqlConnection conexao = conexaoBanco())
                {
                    conexao.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        // Adiciona os parâmetros do dicionário ao comando SQL
                        foreach (var parametro in parametros)
                        {
                            cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                        }

                        // Executa o comando
                        linhasAfetadas = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando SQL: " + ex.Message);
            }

            return linhasAfetadas;
        }
    }
}
