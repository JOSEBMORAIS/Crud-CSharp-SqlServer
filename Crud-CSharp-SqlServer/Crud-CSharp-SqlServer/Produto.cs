using Crud_CSharp_SqlServer.Code.Classes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Crud_CSharp_SqlServer
{
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
            ConfigurarForm();
            ConfigurarDataGridView();
        }

        private enum Situacao
        {
            Inclusao,
            Alteracao
        }

        private Situacao situacaoAtual;

        private void desabilitaCampos()
        {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtPreco.Enabled = false;
            txtClassFiscal.Enabled = false;
            txtMinimo.Enabled = false;
            pnlKit.Enabled = false;

            btnAlterar.Enabled = false;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;

        }

        private void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtPreco.Enabled = true;
            txtClassFiscal.Enabled = true;
            txtMinimo.Enabled = true;
            pnlKit.Enabled = true;

            btnCancelar.Enabled = true;
            btnGravar.Enabled = true;

            btnNovo.Enabled = false;
            txtBusca.Text = "";
            dgvProduto.DataSource = null;
        }

        private void limpaCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtClassFiscal.Clear();
            txtMinimo.Clear();
            txtNome.Focus();
            txtId.Visible = false;
            txtBusca.Clear();
            dgvProduto.DataSource = null;
            lblId.Visible = false;
        }

        private void carregaCampos()
        {

            if (dgvProduto.SelectedRows.Count > 0 && dgvProduto.RowCount > 0)
            {
                txtId.Text = dgvProduto.SelectedRows[0].Cells[0].Value?.ToString();
                txtNome.Text = dgvProduto.SelectedRows[0].Cells[1].Value?.ToString();
                txtDescricao.Text = dgvProduto.SelectedRows[0].Cells[2].Value?.ToString();
                txtPreco.Text = dgvProduto.SelectedRows[0].Cells[3].Value?.ToString();
                txtClassFiscal.Text = dgvProduto.SelectedRows[0].Cells[6].Value?.ToString();
                txtMinimo.Text = dgvProduto.SelectedRows[0].Cells[7].Value?.ToString();


                if (dgvProduto.SelectedRows[0].Cells[5].Value != null)
                {
                    // Obtém o valor da célula e converte para booleano
                    bool status = Convert.ToBoolean(dgvProduto.SelectedRows[0].Cells[5].Value);

                    // Ajusta os controles com base no valor do status
                    if (status)
                    {
                        rdbKitSim.Checked = true;
                        rdbKitNao.Checked = false;
                    }
                    else
                    {
                        rdbKitSim.Checked = false;
                        rdbKitNao.Checked = true;
                    }
                }
                else
                {
                    // Tratar o caso em que não há linha selecionada ou o valor é nulo
                    MessageBox.Show("O valor está inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhum produto foi selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void prepararParaAlterarExcluir()
        {
            txtDescricao.Enabled = true;
            txtNome.Enabled = true;
            txtPreco.Enabled = true;
            txtClassFiscal.Enabled = true;
            txtMinimo.Enabled = true;
            pnlKit.Enabled = true;

            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            lblId.Visible = true;
            txtId.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Produto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Produto_Activated(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtBusca.Text != "")
                {
                    ClasseProduto produto = new ClasseProduto();
                    try
                    {
                        dgvProduto.DataSource = produto.DtaProduto(txtBusca.Text);
                        AjustarGridView();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(produto.mensagem);
                    }
                }
                else
                {
                    dgvProduto.DataSource = null;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos();
            txtNome.Focus();
            situacaoAtual = Situacao.Inclusao;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            situacaoAtual = Situacao.Alteracao;
            prepararParaAlterarExcluir();
            btnGravar.Enabled = true;
        }

        private void gravar()
        {
            ClasseProduto produto = new ClasseProduto();

            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.ClassFiscal = txtClassFiscal.Text;
            produto.EstMinimo = Convert.ToDouble(txtMinimo.Text);
            produto.Preco = Convert.ToDouble(txtPreco.Text);


            if (rdbKitSim.Checked == true) { produto.Kit = 1; }
            else { produto.Kit = 0; }

            if (situacaoAtual == Situacao.Inclusao)
            {
                try
                {
                    produto.Inclusao();
                    MessageBox.Show(produto.mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    limpaCampos();
                }

            }

            if (situacaoAtual == Situacao.Alteracao)
            {
                try
                {
                    int id = Convert.ToInt32(txtId.Text);

                    produto.Alteracao(id);
                    MessageBox.Show(produto.mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    limpaCampos();
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                gravar();
                desabilitaCampos();
            }

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
                return false;
            }

            if (!double.TryParse(txtPreco.Text, out _))
            {
                MessageBox.Show("Informe um preço válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPreco.Focus();
                return false;
            }

            if (!double.TryParse(txtMinimo.Text, out _))
            {
                MessageBox.Show("Informe um estoque mínimo válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMinimo.Focus();
                return false;
            }

            return true;
        }

        private void dgvProduto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //prepararParaAlterarExcluir();
            carregaCampos();
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            desabilitaCampos();
            btnNovo.Enabled = true;
        }

        private void ConfigurarForm()
        {
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ConfigurarDataGridView()
        {
            //modo somente leitura
            dgvProduto.ReadOnly = true;
            // Desabilita a última linha em branco
            dgvProduto.AllowUserToAddRows = false;
            //seleciona todas colunas do grid
            dgvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                       
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Não há registro a excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else
            {
                // Confirmação antes de excluir
                DialogResult confirmResult = MessageBox.Show("Tem certeza que deseja excluir este registro?",
                                                              "Confirmação",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        int id;
                        // Verifica se o ID é um número válido
                        if (int.TryParse(txtId.Text, out id))
                        {
                            ClasseProduto produto = new ClasseProduto();
                            produto.Excluir(id);
                            MessageBox.Show(produto.mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("ID inválido. Por favor, selecione um registro válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Ocorreu um erro ao tentar excluir o registro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        limpaCampos();
                    }
                }
            }
        }

        private void Produto_Load(object sender, EventArgs e)
        {
        }

        private void btnPesquisarTodos_Click(object sender, EventArgs e)
        {
            txtBusca.Text = "%";
        }

        private void AjustarGridView()
        {
            // Alinhamento da coluna para a direita
            dgvProduto.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProduto.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProduto.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Alinhamento da coluna para ao centro
            dgvProduto.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            // Definir o tamanho da coluna (coluna de índice) em pixels
            dgvProduto.Columns[0].Width = 40;
            dgvProduto.Columns[2].Width = 210;
            dgvProduto.Columns[5].Width = 40;
            dgvProduto.Columns[3].Width = 80;
            dgvProduto.Columns[6].Width = 75;
            dgvProduto.Columns[7].Width = 95;

            //Ocultar a coluna de índice
            dgvProduto.Columns[8].Visible = false;

            //Alterar o título da coluna de indice
            dgvProduto.Columns[2].HeaderText = "Descrição";
            dgvProduto.Columns[3].HeaderText = "Preço";
            dgvProduto.Columns[4].HeaderText = "Dt. Inclusão";
            dgvProduto.Columns[6].HeaderText = "Class.Fiscal";
            dgvProduto.Columns[7].HeaderText = "Est. Mínimo";


        }
    }
}
