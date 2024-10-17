using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_CSharp_SqlServer.Code.Classes
{
    class ClasseProduto
    {

        private string nome;
        private string descricao;
        private double preco;
        private DateTime dataCadastro;
        private int kit;
        private double estMinimo;
        private string classFiscal;
        private DateTime dataMovto;

        public string mensagem;

        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public int Kit { get => kit; set => kit = value; }
        public double EstMinimo { get => estMinimo; set => estMinimo = value; }
        public string ClassFiscal { get => classFiscal; set => classFiscal = value; }
        public DateTime DataMovto { get => dataMovto; set => dataMovto = value; }


        public void Inclusao()
        {
            try
            {

                string sql = "insert into produtos (nome,descricao,preco,Kit,classFiscal,estMinimo) " +
                             "Values (@nome,@descricao,@preco,@Kit,@classFiscal,@Minimo)";

                // Preenche o dicionário com os parâmetros e seus respectivos valores
                Dictionary<string, object> parametros = new Dictionary<string, object>
                        {
                            {"@nome", nome },
                            {"@descricao", descricao },
                            {"@preco", preco },
                            {"@Minimo", estMinimo },
                            {"@kit", kit },
                            {"@classFiscal", classFiscal }
                        };

                // Executa o comando
                int linhasAfetadas = AcessoBanco.ExecutarComando(sql, parametros);

                this.mensagem = "Dados gravados com sucesso, linhas afetadas: " + linhasAfetadas;

            }
            catch (Exception erro)
            {
                this.mensagem = "Erro ao incluir dados " + erro.Message;
            }

        }

        public void Alteracao(int id)
        {
            try
            {
                string sql = "update Produtos set " +
                             "nome = @nome, " +
                             "descricao = @descricao, " +
                             "preco = @preco, " +
                             "estMinimo = @Minimo, " +
                             "kit = @kit, " +
                             "classFiscal = @classFiscal " +
                             "where id = @Idat";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    {"@Idat", id },
                    {"@nome", Nome },
                    {"@preco", preco },
                    {"@Minimo", estMinimo },
                    {"@descricao", descricao },
                    {"@classFiscal", classFiscal },
                    {"@kit", kit }
                };

                int linhasAfetadas = AcessoBanco.ExecutarComando(sql, parametros);

                this.mensagem = "Dados atualizados com sucesso, linhas afetadas: " + linhasAfetadas;
            }
            catch (Exception erro)
            {
                this.mensagem = "Erro ao alterar dados: " + erro.Message;
            }
        }


        public void Excluir(int id)
        {
            try
            {

                string sql = "delete from Produtos where id = @Idat";

                // Preenche o dicionário com os parâmetros e seus respectivos valores
                Dictionary<string, object> parametros = new Dictionary<string, object>
                    {
                        {"@Idat", id }
                    };

                // Executa o comando
                int linhasAfetadas = AcessoBanco.ExecutarComando(sql, parametros);

                this.mensagem = "Registro excluído com sucesso, linhas afetadas: " + linhasAfetadas;

            }
            catch (Exception erro)
            {
                this.mensagem = "Erro ao excluir dados " + erro.Message;
            }


        }

        // Popular dados
        public DataTable DtaProduto(string nome)
        {
            DataTable dta = new DataTable();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                try
                {
                    string sql = "Select * from Produtos where Nome like @Nome";

                    // Definindo os parâmetros
                    Dictionary<string, object> parametros = new Dictionary<string, object>
                    {
                         {"@Nome", "%" + nome + "%" }
                    };

                    // Consulta com parâmetros
                    dta = AcessoBanco.consulta(sql, parametros);
                }
                catch (Exception erro)
                {
                    this.mensagem = "Erro ao buscar produto: " + erro.Message;
                }
            }
            else
            {
                this.mensagem = "Nome do produto não pode ser vazio.";
            }

            return dta;
        }


    }
}
