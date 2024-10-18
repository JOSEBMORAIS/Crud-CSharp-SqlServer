namespace Crud_CSharp_SqlServer
{
    partial class Produto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlProduto = new Panel();
            pnlCampos = new Panel();
            txtMinimo = new MaskedTextBox();
            txtPreco = new MaskedTextBox();
            pnlKit = new Panel();
            rdbKitSim = new RadioButton();
            rdbKitNao = new RadioButton();
            lblKit = new Label();
            txtClassFiscal = new TextBox();
            lblEstMinimo = new Label();
            lblClassFiscal = new Label();
            lblPrecoCusto = new Label();
            lblDescricao = new Label();
            Nome = new Label();
            lblId = new Label();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            grbPesquisa = new GroupBox();
            txtBusca = new TextBox();
            grbBotoes = new GroupBox();
            btnSair = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnGravar = new Button();
            btnAlterar = new Button();
            btnNovo = new Button();
            dgvProduto = new DataGridView();
            btnPesquisarTodos = new Button();
            pnlProduto.SuspendLayout();
            pnlCampos.SuspendLayout();
            pnlKit.SuspendLayout();
            grbPesquisa.SuspendLayout();
            grbBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            SuspendLayout();
            // 
            // pnlProduto
            // 
            pnlProduto.Controls.Add(pnlCampos);
            pnlProduto.Controls.Add(grbPesquisa);
            pnlProduto.Controls.Add(grbBotoes);
            pnlProduto.Controls.Add(dgvProduto);
            pnlProduto.Dock = DockStyle.Fill;
            pnlProduto.Location = new Point(0, 0);
            pnlProduto.Name = "pnlProduto";
            pnlProduto.Size = new Size(800, 491);
            pnlProduto.TabIndex = 0;
            // 
            // pnlCampos
            // 
            pnlCampos.Controls.Add(txtMinimo);
            pnlCampos.Controls.Add(txtPreco);
            pnlCampos.Controls.Add(pnlKit);
            pnlCampos.Controls.Add(lblKit);
            pnlCampos.Controls.Add(txtClassFiscal);
            pnlCampos.Controls.Add(lblEstMinimo);
            pnlCampos.Controls.Add(lblClassFiscal);
            pnlCampos.Controls.Add(lblPrecoCusto);
            pnlCampos.Controls.Add(lblDescricao);
            pnlCampos.Controls.Add(Nome);
            pnlCampos.Controls.Add(lblId);
            pnlCampos.Controls.Add(txtDescricao);
            pnlCampos.Controls.Add(txtNome);
            pnlCampos.Controls.Add(txtId);
            pnlCampos.Dock = DockStyle.Fill;
            pnlCampos.Location = new Point(0, 0);
            pnlCampos.Name = "pnlCampos";
            pnlCampos.Size = new Size(610, 253);
            pnlCampos.TabIndex = 3;
            // 
            // txtMinimo
            // 
            txtMinimo.Location = new Point(115, 173);
            txtMinimo.Name = "txtMinimo";
            txtMinimo.Size = new Size(100, 23);
            txtMinimo.TabIndex = 15;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(114, 110);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(125, 23);
            txtPreco.TabIndex = 14;
            // 
            // pnlKit
            // 
            pnlKit.Controls.Add(rdbKitSim);
            pnlKit.Controls.Add(rdbKitNao);
            pnlKit.Location = new Point(113, 204);
            pnlKit.Name = "pnlKit";
            pnlKit.Size = new Size(113, 38);
            pnlKit.TabIndex = 13;
            // 
            // rdbKitSim
            // 
            rdbKitSim.AutoSize = true;
            rdbKitSim.Location = new Point(60, 8);
            rdbKitSim.Name = "rdbKitSim";
            rdbKitSim.Size = new Size(45, 19);
            rdbKitSim.TabIndex = 1;
            rdbKitSim.TabStop = true;
            rdbKitSim.Text = "Sim";
            rdbKitSim.UseVisualStyleBackColor = true;
            // 
            // rdbKitNao
            // 
            rdbKitNao.AutoSize = true;
            rdbKitNao.Location = new Point(9, 8);
            rdbKitNao.Name = "rdbKitNao";
            rdbKitNao.Size = new Size(47, 19);
            rdbKitNao.TabIndex = 0;
            rdbKitNao.TabStop = true;
            rdbKitNao.Text = "Não";
            rdbKitNao.UseVisualStyleBackColor = true;
            // 
            // lblKit
            // 
            lblKit.AutoSize = true;
            lblKit.Location = new Point(86, 214);
            lblKit.Name = "lblKit";
            lblKit.Size = new Size(21, 15);
            lblKit.TabIndex = 12;
            lblKit.Text = "Kit";
            lblKit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClassFiscal
            // 
            txtClassFiscal.Location = new Point(113, 142);
            txtClassFiscal.Name = "txtClassFiscal";
            txtClassFiscal.Size = new Size(144, 23);
            txtClassFiscal.TabIndex = 10;
            // 
            // lblEstMinimo
            // 
            lblEstMinimo.AutoSize = true;
            lblEstMinimo.Location = new Point(41, 179);
            lblEstMinimo.Name = "lblEstMinimo";
            lblEstMinimo.Size = new Size(67, 15);
            lblEstMinimo.TabIndex = 8;
            lblEstMinimo.Text = "Est.Minimo";
            lblEstMinimo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClassFiscal
            // 
            lblClassFiscal.AutoSize = true;
            lblClassFiscal.Location = new Point(42, 147);
            lblClassFiscal.Name = "lblClassFiscal";
            lblClassFiscal.Size = new Size(66, 15);
            lblClassFiscal.TabIndex = 7;
            lblClassFiscal.Text = "Class.Fiscal";
            lblClassFiscal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrecoCusto
            // 
            lblPrecoCusto.AutoSize = true;
            lblPrecoCusto.Location = new Point(37, 115);
            lblPrecoCusto.Name = "lblPrecoCusto";
            lblPrecoCusto.Size = new Size(71, 15);
            lblPrecoCusto.TabIndex = 6;
            lblPrecoCusto.Text = "Preco Custo";
            lblPrecoCusto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(50, 81);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Descrição";
            lblDescricao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(68, 50);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 4;
            Nome.Text = "Nome";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(91, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 3;
            lblId.Text = "Id";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(113, 78);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(451, 23);
            txtDescricao.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(113, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(113, 14);
            txtId.Name = "txtId";
            txtId.Size = new Size(37, 23);
            txtId.TabIndex = 0;
            // 
            // grbPesquisa
            // 
            grbPesquisa.Controls.Add(btnPesquisarTodos);
            grbPesquisa.Controls.Add(txtBusca);
            grbPesquisa.Dock = DockStyle.Bottom;
            grbPesquisa.Location = new Point(0, 253);
            grbPesquisa.Name = "grbPesquisa";
            grbPesquisa.Size = new Size(610, 74);
            grbPesquisa.TabIndex = 2;
            grbPesquisa.TabStop = false;
            grbPesquisa.Text = "Pesquisar";
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(41, 22);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(478, 23);
            txtBusca.TabIndex = 0;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // grbBotoes
            // 
            grbBotoes.Controls.Add(btnSair);
            grbBotoes.Controls.Add(btnCancelar);
            grbBotoes.Controls.Add(btnExcluir);
            grbBotoes.Controls.Add(btnGravar);
            grbBotoes.Controls.Add(btnAlterar);
            grbBotoes.Controls.Add(btnNovo);
            grbBotoes.Dock = DockStyle.Right;
            grbBotoes.Location = new Point(610, 0);
            grbBotoes.Name = "grbBotoes";
            grbBotoes.Size = new Size(190, 327);
            grbBotoes.TabIndex = 1;
            grbBotoes.TabStop = false;
            grbBotoes.Text = "Opções";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(25, 281);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(137, 34);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += button6_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(25, 186);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(25, 146);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(137, 34);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(25, 105);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(137, 34);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(25, 62);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(137, 34);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(25, 22);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(137, 34);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Incluir";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // dgvProduto
            // 
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Dock = DockStyle.Bottom;
            dgvProduto.Location = new Point(0, 327);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.ReadOnly = true;
            dgvProduto.RowTemplate.Height = 25;
            dgvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduto.Size = new Size(800, 164);
            dgvProduto.TabIndex = 0;
            dgvProduto.MouseDoubleClick += dgvProduto_MouseDoubleClick;
            // 
            // btnPesquisarTodos
            // 
            btnPesquisarTodos.Location = new Point(525, 22);
            btnPesquisarTodos.Name = "btnPesquisarTodos";
            btnPesquisarTodos.Size = new Size(75, 23);
            btnPesquisarTodos.TabIndex = 1;
            btnPesquisarTodos.Text = "Todos";
            btnPesquisarTodos.UseVisualStyleBackColor = true;
            btnPesquisarTodos.Click += btnPesquisarTodos_Click;
            // 
            // Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(pnlProduto);
            Name = "Produto";
            Text = "Produtos";
            Activated += Produto_Activated;
            Load += Produto_Load;
            MouseDoubleClick += Produto_MouseDoubleClick;
            pnlProduto.ResumeLayout(false);
            pnlCampos.ResumeLayout(false);
            pnlCampos.PerformLayout();
            pnlKit.ResumeLayout(false);
            pnlKit.PerformLayout();
            grbPesquisa.ResumeLayout(false);
            grbPesquisa.PerformLayout();
            grbBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlProduto;
        private GroupBox grbPesquisa;
        private GroupBox grbBotoes;
        private DataGridView dgvProduto;
        private Panel pnlCampos;
        private Label lblDescricao;
        private Label Nome;
        private Label lblId;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private TextBox txtId;
        private Label lblEstMinimo;
        private Label lblClassFiscal;
        private Label lblPrecoCusto;
        private TextBox txtClassFiscal;
        private Panel pnlKit;
        private Label lblKit;
        private RadioButton rdbKitSim;
        private RadioButton rdbKitNao;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnGravar;
        private Button btnAlterar;
        private Button btnNovo;
        private MaskedTextBox txtMinimo;
        private MaskedTextBox txtPreco;
        private Button btnSair;
        private TextBox txtBusca;
        private Button btnPesquisarTodos;
    }
}
