﻿
namespace Controle_Vendas.Visualizacao
{
    partial class FormCadProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCadastroVendas = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.txtEmbalagem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidadeEstoqueInicial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnControleEstoque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMedida = new System.Windows.Forms.ComboBox();
            this.codigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.embalagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concatTamanhoMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoqueInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDeLista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastroVendas
            // 
            this.btnCadastroVendas.Location = new System.Drawing.Point(131, 214);
            this.btnCadastroVendas.Name = "btnCadastroVendas";
            this.btnCadastroVendas.Size = new System.Drawing.Size(124, 28);
            this.btnCadastroVendas.TabIndex = 94;
            this.btnCadastroVendas.Text = "Cadastro de Vendas";
            this.btnCadastroVendas.UseVisualStyleBackColor = true;
            this.btnCadastroVendas.Click += new System.EventHandler(this.btnCadastroVendas_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(23, 388);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 83;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(23, 350);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 82;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(23, 312);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 81;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(23, 274);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 80;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(764, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(823, 222);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(116, 20);
            this.txtPesquisar.TabIndex = 78;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // GridProdutos
            // 
            this.GridProdutos.AllowUserToAddRows = false;
            this.GridProdutos.AllowUserToDeleteRows = false;
            this.GridProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProduto,
            this.nomeProduto,
            this.sabor,
            this.embalagem,
            this.tamanho,
            this.concatTamanhoMedida,
            this.unidadeMedida,
            this.quantidadeEstoqueInicial,
            this.precoDeLista});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridProdutos.Location = new System.Drawing.Point(131, 248);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridProdutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutos.Size = new System.Drawing.Size(808, 185);
            this.GridProdutos.TabIndex = 77;
            this.GridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProdutos_CellDoubleClick);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(753, 96);
            this.txtTamanho.MaxLength = 10;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(123, 20);
            this.txtTamanho.TabIndex = 121;
            this.txtTamanho.TextChanged += new System.EventHandler(this.txtTamanho_TextChanged);
            this.txtTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamanho_KeyPress);
            // 
            // txtSabor
            // 
            this.txtSabor.Location = new System.Drawing.Point(379, 96);
            this.txtSabor.MaxLength = 20;
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Size = new System.Drawing.Size(160, 20);
            this.txtSabor.TabIndex = 117;
            this.txtSabor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSabor_KeyPress);
            // 
            // txtEmbalagem
            // 
            this.txtEmbalagem.Location = new System.Drawing.Point(584, 96);
            this.txtEmbalagem.MaxLength = 20;
            this.txtEmbalagem.Name = "txtEmbalagem";
            this.txtEmbalagem.Size = new System.Drawing.Size(123, 20);
            this.txtEmbalagem.TabIndex = 119;
            this.txtEmbalagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmbalagem_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(376, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 116;
            this.label14.Text = "Sabor *";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(23, 96);
            this.txtNomeProduto.MaxLength = 50;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(319, 20);
            this.txtNomeProduto.TabIndex = 111;
            this.txtNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeProduto_KeyPress);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(223, 153);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(119, 20);
            this.txtPreco.TabIndex = 123;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 122;
            this.label11.Text = "Preço *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "Embalagem *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 120;
            this.label3.Text = "Tamanho *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 110;
            this.label4.Text = "Nome *";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(23, 35);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.ReadOnly = true;
            this.txtCodigoProduto.Size = new System.Drawing.Size(71, 20);
            this.txtCodigoProduto.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "ID Produto";
            // 
            // txtQuantidadeEstoqueInicial
            // 
            this.txtQuantidadeEstoqueInicial.Location = new System.Drawing.Point(23, 153);
            this.txtQuantidadeEstoqueInicial.MaxLength = 10;
            this.txtQuantidadeEstoqueInicial.Name = "txtQuantidadeEstoqueInicial";
            this.txtQuantidadeEstoqueInicial.Size = new System.Drawing.Size(124, 20);
            this.txtQuantidadeEstoqueInicial.TabIndex = 127;
            this.txtQuantidadeEstoqueInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeEstoqueInicial_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 126;
            this.label10.Text = "Quantidade Inicial";
            // 
            // btnControleEstoque
            // 
            this.btnControleEstoque.Location = new System.Drawing.Point(271, 214);
            this.btnControleEstoque.Name = "btnControleEstoque";
            this.btnControleEstoque.Size = new System.Drawing.Size(124, 28);
            this.btnControleEstoque.TabIndex = 128;
            this.btnControleEstoque.Text = "Controle de Estoque";
            this.btnControleEstoque.UseVisualStyleBackColor = true;
            this.btnControleEstoque.Click += new System.EventHandler(this.btnControleEstoque_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(879, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "Medida *";
            // 
            // cmbMedida
            // 
            this.cmbMedida.Enabled = false;
            this.cmbMedida.FormattingEnabled = true;
            this.cmbMedida.Location = new System.Drawing.Point(882, 95);
            this.cmbMedida.Name = "cmbMedida";
            this.cmbMedida.Size = new System.Drawing.Size(57, 21);
            this.cmbMedida.TabIndex = 131;
            // 
            // codigoProduto
            // 
            this.codigoProduto.DataPropertyName = "CodigoProduto";
            this.codigoProduto.FillWeight = 248.731F;
            this.codigoProduto.Frozen = true;
            this.codigoProduto.HeaderText = "ID Produto";
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.ReadOnly = true;
            this.codigoProduto.Width = 50;
            // 
            // nomeProduto
            // 
            this.nomeProduto.DataPropertyName = "NomeProduto";
            this.nomeProduto.FillWeight = 75.21151F;
            this.nomeProduto.Frozen = true;
            this.nomeProduto.HeaderText = "Nome";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            this.nomeProduto.Width = 170;
            // 
            // sabor
            // 
            this.sabor.DataPropertyName = "Sabor";
            this.sabor.FillWeight = 75.21151F;
            this.sabor.Frozen = true;
            this.sabor.HeaderText = "Sabor";
            this.sabor.Name = "sabor";
            this.sabor.ReadOnly = true;
            this.sabor.Width = 130;
            // 
            // embalagem
            // 
            this.embalagem.DataPropertyName = "Embalagem";
            this.embalagem.FillWeight = 75.21151F;
            this.embalagem.Frozen = true;
            this.embalagem.HeaderText = "Embalagem";
            this.embalagem.Name = "embalagem";
            this.embalagem.ReadOnly = true;
            this.embalagem.Width = 120;
            // 
            // tamanho
            // 
            this.tamanho.DataPropertyName = "Tamanho";
            this.tamanho.HeaderText = "Tamanho(Oculto)";
            this.tamanho.Name = "tamanho";
            this.tamanho.ReadOnly = true;
            this.tamanho.Visible = false;
            // 
            // concatTamanhoMedida
            // 
            this.concatTamanhoMedida.DataPropertyName = "ConcatTamanhoMedida";
            this.concatTamanhoMedida.FillWeight = 75.21151F;
            this.concatTamanhoMedida.HeaderText = "Tamanho";
            this.concatTamanhoMedida.Name = "concatTamanhoMedida";
            this.concatTamanhoMedida.ReadOnly = true;
            // 
            // unidadeMedida
            // 
            this.unidadeMedida.DataPropertyName = "UnidadeMedida";
            this.unidadeMedida.HeaderText = "Unida de Medida(Oculto)";
            this.unidadeMedida.Name = "unidadeMedida";
            this.unidadeMedida.ReadOnly = true;
            this.unidadeMedida.Visible = false;
            // 
            // quantidadeEstoqueInicial
            // 
            this.quantidadeEstoqueInicial.DataPropertyName = "QuantidadeEstoqueInicial";
            this.quantidadeEstoqueInicial.FillWeight = 75.21151F;
            this.quantidadeEstoqueInicial.HeaderText = "Quantidade Inicial";
            this.quantidadeEstoqueInicial.Name = "quantidadeEstoqueInicial";
            this.quantidadeEstoqueInicial.ReadOnly = true;
            // 
            // precoDeLista
            // 
            this.precoDeLista.DataPropertyName = "PrecoDeLista";
            this.precoDeLista.FillWeight = 75.21151F;
            this.precoDeLista.HeaderText = "Preço";
            this.precoDeLista.Name = "precoDeLista";
            this.precoDeLista.ReadOnly = true;
            // 
            // FormCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 445);
            this.Controls.Add(this.cmbMedida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnControleEstoque);
            this.Controls.Add(this.txtQuantidadeEstoqueInicial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.txtSabor);
            this.Controls.Add(this.txtEmbalagem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCadastroVendas);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.GridProdutos);
            this.Name = "FormCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FormCadProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroVendas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.TextBox txtSabor;
        private System.Windows.Forms.TextBox txtEmbalagem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidadeEstoqueInicial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnControleEstoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn embalagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn concatTamanhoMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoqueInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDeLista;
    }
}