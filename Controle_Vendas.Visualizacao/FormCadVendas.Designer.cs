﻿
namespace Controle_Vendas.Visualizacao
{
    partial class FormCadVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoVendedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastroClientes = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.GridVendas = new System.Windows.Forms.DataGridView();
            this.codigoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embalagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditoLoja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmbalagem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCreditoLoja = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.btnControleEstoque = new System.Windows.Forms.Button();
            this.btnCadastroProdutos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Venda";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Location = new System.Drawing.Point(35, 25);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(71, 20);
            this.txtCodigoVenda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(770, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tamanho do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome do Cliente";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(35, 319);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 35;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(36, 358);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnVendaSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(36, 436);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 38;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnVendaExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(36, 397);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnVendaEditar_Click);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(374, 25);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(71, 20);
            this.txtCodigoProduto.TabIndex = 6;
            this.txtCodigoProduto.Leave += new System.EventHandler(this.txtCodigoProduto_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID Produto *";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(35, 86);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(71, 20);
            this.txtCodigoCliente.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID Cliente";
            // 
            // txtCodigoVendedor
            // 
            this.txtCodigoVendedor.Location = new System.Drawing.Point(509, 25);
            this.txtCodigoVendedor.Name = "txtCodigoVendedor";
            this.txtCodigoVendedor.Size = new System.Drawing.Size(71, 20);
            this.txtCodigoVendedor.TabIndex = 8;
            this.txtCodigoVendedor.Leave += new System.EventHandler(this.txtCodigoVendedor_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(601, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Embalagem do Produto";
            // 
            // btnCadastroClientes
            // 
            this.btnCadastroClientes.Location = new System.Drawing.Point(138, 244);
            this.btnCadastroClientes.Name = "btnCadastroClientes";
            this.btnCadastroClientes.Size = new System.Drawing.Size(125, 27);
            this.btnCadastroClientes.TabIndex = 31;
            this.btnCadastroClientes.Text = "Cadastro de Clientes";
            this.btnCadastroClientes.UseVisualStyleBackColor = true;
            this.btnCadastroClientes.Click += new System.EventHandler(this.btnCadastroClientes_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(772, 26);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(124, 20);
            this.txtQuantidade.TabIndex = 12;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(769, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Quantidade *";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(35, 185);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(119, 20);
            this.txtPreco.TabIndex = 28;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Preço";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(792, 251);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(104, 20);
            this.txtPesquisar.TabIndex = 34;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(789, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Pesquisar";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(166, 87);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(319, 20);
            this.txtNomeCliente.TabIndex = 16;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(35, 134);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(319, 20);
            this.txtNomeProduto.TabIndex = 20;
            // 
            // GridVendas
            // 
            this.GridVendas.AllowUserToAddRows = false;
            this.GridVendas.AllowUserToDeleteRows = false;
            this.GridVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoVenda,
            this.codigoCliente,
            this.nomeCliente,
            this.codigoProduto,
            this.nomeProduto,
            this.embalagem,
            this.tamanho,
            this.sabor,
            this.quantidade,
            this.preco,
            this.precoTotal,
            this.creditoLoja,
            this.codigoVendedor,
            this.nomeVendedor,
            this.dataHora});
            this.GridVendas.Location = new System.Drawing.Point(138, 277);
            this.GridVendas.Name = "GridVendas";
            this.GridVendas.ReadOnly = true;
            this.GridVendas.Size = new System.Drawing.Size(758, 227);
            this.GridVendas.TabIndex = 39;
            this.GridVendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVendas_CellDoubleClick);
            // 
            // codigoVenda
            // 
            this.codigoVenda.DataPropertyName = "CodigoVenda";
            this.codigoVenda.HeaderText = "ID da Venda";
            this.codigoVenda.Name = "codigoVenda";
            this.codigoVenda.ReadOnly = true;
            this.codigoVenda.Width = 50;
            // 
            // codigoCliente
            // 
            this.codigoCliente.DataPropertyName = "CodigoCliente";
            this.codigoCliente.HeaderText = "ID do Cliente";
            this.codigoCliente.Name = "codigoCliente";
            this.codigoCliente.ReadOnly = true;
            // 
            // nomeCliente
            // 
            this.nomeCliente.DataPropertyName = "NomeCliente";
            this.nomeCliente.HeaderText = "Nome do Cliente";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            this.nomeCliente.Width = 200;
            // 
            // codigoProduto
            // 
            this.codigoProduto.DataPropertyName = "CodigoProduto";
            this.codigoProduto.HeaderText = "ID do Produto";
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.ReadOnly = true;
            this.codigoProduto.Width = 50;
            // 
            // nomeProduto
            // 
            this.nomeProduto.DataPropertyName = "NomeProduto";
            this.nomeProduto.HeaderText = "Nome do Produto";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            // 
            // embalagem
            // 
            this.embalagem.DataPropertyName = "Embalagem";
            this.embalagem.HeaderText = "Embalagem";
            this.embalagem.Name = "embalagem";
            this.embalagem.ReadOnly = true;
            // 
            // tamanho
            // 
            this.tamanho.DataPropertyName = "Tamanho";
            this.tamanho.HeaderText = "Tamanho";
            this.tamanho.Name = "tamanho";
            this.tamanho.ReadOnly = true;
            // 
            // sabor
            // 
            this.sabor.DataPropertyName = "Sabor";
            this.sabor.HeaderText = "Sabor";
            this.sabor.Name = "sabor";
            this.sabor.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "Quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "Preco";
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // precoTotal
            // 
            this.precoTotal.DataPropertyName = "PrecoTotal";
            this.precoTotal.HeaderText = "Preço Total";
            this.precoTotal.Name = "precoTotal";
            this.precoTotal.ReadOnly = true;
            // 
            // creditoLoja
            // 
            this.creditoLoja.DataPropertyName = "CreditoLoja";
            this.creditoLoja.HeaderText = "Crédito da Loja";
            this.creditoLoja.Name = "creditoLoja";
            this.creditoLoja.ReadOnly = true;
            this.creditoLoja.Width = 50;
            // 
            // codigoVendedor
            // 
            this.codigoVendedor.DataPropertyName = "CodigoVendedor";
            this.codigoVendedor.HeaderText = "ID do Vendedor";
            this.codigoVendedor.Name = "codigoVendedor";
            this.codigoVendedor.ReadOnly = true;
            this.codigoVendedor.Width = 50;
            // 
            // nomeVendedor
            // 
            this.nomeVendedor.DataPropertyName = "NomeVendedor";
            this.nomeVendedor.HeaderText = "Nome do Vendedor";
            this.nomeVendedor.Name = "nomeVendedor";
            this.nomeVendedor.ReadOnly = true;
            // 
            // dataHora
            // 
            this.dataHora.DataPropertyName = "DataHora";
            this.dataHora.HeaderText = "Data/Hora";
            this.dataHora.Name = "dataHora";
            this.dataHora.ReadOnly = true;
            this.dataHora.Width = 200;
            // 
            // txtBuscaCliente
            // 
            this.txtBuscaCliente.Location = new System.Drawing.Point(166, 25);
            this.txtBuscaCliente.Name = "txtBuscaCliente";
            this.txtBuscaCliente.Size = new System.Drawing.Size(107, 20);
            this.txtBuscaCliente.TabIndex = 3;
            this.txtBuscaCliente.Enter += new System.EventHandler(this.txtBuscaCliente_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Busca Cliente *";
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaCliente.Image = global::Controle_Vendas.Visualizacao.Properties.Resources.IconePesquisa;
            this.btnBuscaCliente.Location = new System.Drawing.Point(279, 24);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(31, 23);
            this.btnBuscaCliente.TabIndex = 4;
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.Location = new System.Drawing.Point(235, 185);
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.Size = new System.Drawing.Size(119, 20);
            this.txtPrecoTotal.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(396, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Sabor do Produto";
            // 
            // txtSabor
            // 
            this.txtSabor.Location = new System.Drawing.Point(399, 134);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Size = new System.Drawing.Size(160, 20);
            this.txtSabor.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Preço Total";
            // 
            // txtEmbalagem
            // 
            this.txtEmbalagem.Location = new System.Drawing.Point(604, 134);
            this.txtEmbalagem.Name = "txtEmbalagem";
            this.txtEmbalagem.Size = new System.Drawing.Size(123, 20);
            this.txtEmbalagem.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(506, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "ID Vendedor *";
            // 
            // txtCreditoLoja
            // 
            this.txtCreditoLoja.Location = new System.Drawing.Point(645, 25);
            this.txtCreditoLoja.Name = "txtCreditoLoja";
            this.txtCreditoLoja.Size = new System.Drawing.Size(63, 20);
            this.txtCreditoLoja.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(642, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Crédito loja *";
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(578, 86);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(256, 20);
            this.txtNomeVendedor.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(575, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Nome do Vendedor";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(773, 134);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(123, 20);
            this.txtTamanho.TabIndex = 26;
            // 
            // btnControleEstoque
            // 
            this.btnControleEstoque.Location = new System.Drawing.Point(279, 244);
            this.btnControleEstoque.Name = "btnControleEstoque";
            this.btnControleEstoque.Size = new System.Drawing.Size(125, 27);
            this.btnControleEstoque.TabIndex = 32;
            this.btnControleEstoque.Text = "Controle de Estoque";
            this.btnControleEstoque.UseVisualStyleBackColor = true;
            this.btnControleEstoque.Click += new System.EventHandler(this.btnControleEstoque_Click);
            // 
            // btnCadastroProdutos
            // 
            this.btnCadastroProdutos.Location = new System.Drawing.Point(421, 244);
            this.btnCadastroProdutos.Name = "btnCadastroProdutos";
            this.btnCadastroProdutos.Size = new System.Drawing.Size(125, 27);
            this.btnCadastroProdutos.TabIndex = 33;
            this.btnCadastroProdutos.Text = "Cadastro de Produtos";
            this.btnCadastroProdutos.UseVisualStyleBackColor = true;
            // 
            // FormCadVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 510);
            this.Controls.Add(this.btnCadastroProdutos);
            this.Controls.Add(this.btnControleEstoque);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.txtSabor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmbalagem);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCreditoLoja);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNomeVendedor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPrecoTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.txtBuscaCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCadastroClientes);
            this.Controls.Add(this.txtCodigoVendedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridVendas);
            this.Name = "FormCadVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vendas";
            this.Load += new System.EventHandler(this.FormCadVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoVendedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadastroClientes;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.DataGridView GridVendas;
        private System.Windows.Forms.TextBox txtBuscaCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.TextBox txtPrecoTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSabor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmbalagem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCreditoLoja;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Button btnControleEstoque;
        private System.Windows.Forms.Button btnCadastroProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn embalagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditoLoja;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHora;
    }
}