namespace WindowsFormsVendas
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_IdProduto = new System.Windows.Forms.Label();
            this.Tb_IdProduto = new System.Windows.Forms.TextBox();
            this.Lbl_CodEAN = new System.Windows.Forms.Label();
            this.Tb_CodEAN = new System.Windows.Forms.TextBox();
            this.Lbl_NomeProduto = new System.Windows.Forms.Label();
            this.Tb_NomeProduto = new System.Windows.Forms.TextBox();
            this.Lbl_PrecoProduto = new System.Windows.Forms.Label();
            this.Lbl_EstoqueProduto = new System.Windows.Forms.Label();
            this.Tb_EstoqueProduto = new System.Windows.Forms.TextBox();
            this.Bt_CadProduto = new System.Windows.Forms.Button();
            this.Bt_ExcluirProduto = new System.Windows.Forms.Button();
            this.Bt_SairCadProduto = new System.Windows.Forms.Button();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendas_dbDataSet1 = new WindowsFormsVendas.vendas_dbDataSet1();
            this.produtoTableAdapter = new WindowsFormsVendas.vendas_dbDataSet1TableAdapters.produtoTableAdapter();
            this.Bt_AtualizarProduto = new System.Windows.Forms.Button();
            this.Dgv_CadProduto = new System.Windows.Forms.DataGridView();
            this.Dgv_Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_CodEAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvg_Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tb_PrecoProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CadProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_IdProduto
            // 
            this.Lbl_IdProduto.AutoSize = true;
            this.Lbl_IdProduto.Location = new System.Drawing.Point(36, 20);
            this.Lbl_IdProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IdProduto.Name = "Lbl_IdProduto";
            this.Lbl_IdProduto.Size = new System.Drawing.Size(291, 20);
            this.Lbl_IdProduto.TabIndex = 0;
            this.Lbl_IdProduto.Text = "Id Produto (gerado automaticamente):";
            // 
            // Tb_IdProduto
            // 
            this.Tb_IdProduto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Tb_IdProduto.Enabled = false;
            this.Tb_IdProduto.Location = new System.Drawing.Point(335, 13);
            this.Tb_IdProduto.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_IdProduto.Name = "Tb_IdProduto";
            this.Tb_IdProduto.Size = new System.Drawing.Size(145, 27);
            this.Tb_IdProduto.TabIndex = 1;
            // 
            // Lbl_CodEAN
            // 
            this.Lbl_CodEAN.AutoSize = true;
            this.Lbl_CodEAN.Location = new System.Drawing.Point(510, 20);
            this.Lbl_CodEAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_CodEAN.Name = "Lbl_CodEAN";
            this.Lbl_CodEAN.Size = new System.Drawing.Size(290, 20);
            this.Lbl_CodEAN.TabIndex = 2;
            this.Lbl_CodEAN.Text = "CodEAN (deve conter 13 caracteres):";
            // 
            // Tb_CodEAN
            // 
            this.Tb_CodEAN.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_CodEAN.Location = new System.Drawing.Point(808, 17);
            this.Tb_CodEAN.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_CodEAN.Name = "Tb_CodEAN";
            this.Tb_CodEAN.Size = new System.Drawing.Size(216, 27);
            this.Tb_CodEAN.TabIndex = 3;
            // 
            // Lbl_NomeProduto
            // 
            this.Lbl_NomeProduto.AutoSize = true;
            this.Lbl_NomeProduto.Location = new System.Drawing.Point(36, 58);
            this.Lbl_NomeProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_NomeProduto.Name = "Lbl_NomeProduto";
            this.Lbl_NomeProduto.Size = new System.Drawing.Size(121, 20);
            this.Lbl_NomeProduto.TabIndex = 4;
            this.Lbl_NomeProduto.Text = "Nome Produto:";
            // 
            // Tb_NomeProduto
            // 
            this.Tb_NomeProduto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_NomeProduto.Location = new System.Drawing.Point(179, 51);
            this.Tb_NomeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_NomeProduto.Name = "Tb_NomeProduto";
            this.Tb_NomeProduto.Size = new System.Drawing.Size(845, 27);
            this.Tb_NomeProduto.TabIndex = 5;
            // 
            // Lbl_PrecoProduto
            // 
            this.Lbl_PrecoProduto.AutoSize = true;
            this.Lbl_PrecoProduto.Location = new System.Drawing.Point(36, 93);
            this.Lbl_PrecoProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_PrecoProduto.Name = "Lbl_PrecoProduto";
            this.Lbl_PrecoProduto.Size = new System.Drawing.Size(179, 20);
            this.Lbl_PrecoProduto.TabIndex = 6;
            this.Lbl_PrecoProduto.Text = "Valor Unitário Produto:";
            // 
            // Lbl_EstoqueProduto
            // 
            this.Lbl_EstoqueProduto.AutoSize = true;
            this.Lbl_EstoqueProduto.Location = new System.Drawing.Point(36, 133);
            this.Lbl_EstoqueProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_EstoqueProduto.Name = "Lbl_EstoqueProduto";
            this.Lbl_EstoqueProduto.Size = new System.Drawing.Size(193, 20);
            this.Lbl_EstoqueProduto.TabIndex = 8;
            this.Lbl_EstoqueProduto.Text = "Quantidade em Estoque:";
            // 
            // Tb_EstoqueProduto
            // 
            this.Tb_EstoqueProduto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_EstoqueProduto.Location = new System.Drawing.Point(237, 126);
            this.Tb_EstoqueProduto.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_EstoqueProduto.Name = "Tb_EstoqueProduto";
            this.Tb_EstoqueProduto.Size = new System.Drawing.Size(345, 27);
            this.Tb_EstoqueProduto.TabIndex = 9;
            // 
            // Bt_CadProduto
            // 
            this.Bt_CadProduto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_CadProduto.Location = new System.Drawing.Point(40, 194);
            this.Bt_CadProduto.Name = "Bt_CadProduto";
            this.Bt_CadProduto.Size = new System.Drawing.Size(114, 47);
            this.Bt_CadProduto.TabIndex = 11;
            this.Bt_CadProduto.Text = "Cadastrar";
            this.Bt_CadProduto.UseVisualStyleBackColor = false;
            this.Bt_CadProduto.Click += new System.EventHandler(this.Bt_CadProduto_Click);
            // 
            // Bt_ExcluirProduto
            // 
            this.Bt_ExcluirProduto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_ExcluirProduto.Location = new System.Drawing.Point(468, 194);
            this.Bt_ExcluirProduto.Name = "Bt_ExcluirProduto";
            this.Bt_ExcluirProduto.Size = new System.Drawing.Size(114, 47);
            this.Bt_ExcluirProduto.TabIndex = 12;
            this.Bt_ExcluirProduto.Text = "Excluir";
            this.Bt_ExcluirProduto.UseVisualStyleBackColor = false;
            this.Bt_ExcluirProduto.Click += new System.EventHandler(this.Bt_ExcluirProduto_Click);
            // 
            // Bt_SairCadProduto
            // 
            this.Bt_SairCadProduto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_SairCadProduto.Location = new System.Drawing.Point(910, 207);
            this.Bt_SairCadProduto.Name = "Bt_SairCadProduto";
            this.Bt_SairCadProduto.Size = new System.Drawing.Size(114, 47);
            this.Bt_SairCadProduto.TabIndex = 13;
            this.Bt_SairCadProduto.Text = "Sair";
            this.Bt_SairCadProduto.UseVisualStyleBackColor = false;
            this.Bt_SairCadProduto.Click += new System.EventHandler(this.Bt_SairCadProduto_Click);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.vendas_dbDataSet1;
            // 
            // vendas_dbDataSet1
            // 
            this.vendas_dbDataSet1.DataSetName = "vendas_dbDataSet1";
            this.vendas_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // Bt_AtualizarProduto
            // 
            this.Bt_AtualizarProduto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_AtualizarProduto.Location = new System.Drawing.Point(255, 194);
            this.Bt_AtualizarProduto.Name = "Bt_AtualizarProduto";
            this.Bt_AtualizarProduto.Size = new System.Drawing.Size(114, 47);
            this.Bt_AtualizarProduto.TabIndex = 10;
            this.Bt_AtualizarProduto.Text = "Atualizar";
            this.Bt_AtualizarProduto.UseVisualStyleBackColor = false;
            this.Bt_AtualizarProduto.Click += new System.EventHandler(this.Bt_AtualizarProduto_Click);
            // 
            // Dgv_CadProduto
            // 
            this.Dgv_CadProduto.AllowUserToAddRows = false;
            this.Dgv_CadProduto.AllowUserToDeleteRows = false;
            this.Dgv_CadProduto.AllowUserToOrderColumns = true;
            this.Dgv_CadProduto.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Dgv_CadProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CadProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dgv_Id_Produto,
            this.Dgv_CodEAN,
            this.Dgv_NomeProduto,
            this.Dgv_Preco,
            this.Dvg_Estoque});
            this.Dgv_CadProduto.Location = new System.Drawing.Point(40, 307);
            this.Dgv_CadProduto.Name = "Dgv_CadProduto";
            this.Dgv_CadProduto.ReadOnly = true;
            this.Dgv_CadProduto.RowHeadersWidth = 51;
            this.Dgv_CadProduto.RowTemplate.Height = 24;
            this.Dgv_CadProduto.Size = new System.Drawing.Size(984, 227);
            this.Dgv_CadProduto.TabIndex = 14;
            this.Dgv_CadProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CadProduto_CellContentClick);
            // 
            // Dgv_Id_Produto
            // 
            this.Dgv_Id_Produto.HeaderText = "id_produto";
            this.Dgv_Id_Produto.MinimumWidth = 6;
            this.Dgv_Id_Produto.Name = "Dgv_Id_Produto";
            this.Dgv_Id_Produto.ReadOnly = true;
            this.Dgv_Id_Produto.Width = 125;
            // 
            // Dgv_CodEAN
            // 
            this.Dgv_CodEAN.HeaderText = "codEAN";
            this.Dgv_CodEAN.MinimumWidth = 6;
            this.Dgv_CodEAN.Name = "Dgv_CodEAN";
            this.Dgv_CodEAN.ReadOnly = true;
            this.Dgv_CodEAN.Width = 125;
            // 
            // Dgv_NomeProduto
            // 
            this.Dgv_NomeProduto.HeaderText = "nomeProduto";
            this.Dgv_NomeProduto.MinimumWidth = 6;
            this.Dgv_NomeProduto.Name = "Dgv_NomeProduto";
            this.Dgv_NomeProduto.ReadOnly = true;
            this.Dgv_NomeProduto.Width = 350;
            // 
            // Dgv_Preco
            // 
            this.Dgv_Preco.HeaderText = "preco";
            this.Dgv_Preco.MinimumWidth = 6;
            this.Dgv_Preco.Name = "Dgv_Preco";
            this.Dgv_Preco.ReadOnly = true;
            this.Dgv_Preco.Width = 125;
            // 
            // Dvg_Estoque
            // 
            this.Dvg_Estoque.HeaderText = "estoque";
            this.Dvg_Estoque.MinimumWidth = 6;
            this.Dvg_Estoque.Name = "Dvg_Estoque";
            this.Dvg_Estoque.ReadOnly = true;
            this.Dvg_Estoque.Width = 125;
            // 
            // Tb_PrecoProduto
            // 
            this.Tb_PrecoProduto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_PrecoProduto.Location = new System.Drawing.Point(222, 86);
            this.Tb_PrecoProduto.Name = "Tb_PrecoProduto";
            this.Tb_PrecoProduto.Size = new System.Drawing.Size(345, 27);
            this.Tb_PrecoProduto.TabIndex = 15;
            this.Tb_PrecoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_PrecoProduto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(574, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Somente digitar números e separar decimal com vírgula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(622, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Click duas vezes no item para popular os dados no caso de alteração ou exclusão";
            // 
            // FormCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_PrecoProduto);
            this.Controls.Add(this.Dgv_CadProduto);
            this.Controls.Add(this.Bt_SairCadProduto);
            this.Controls.Add(this.Bt_ExcluirProduto);
            this.Controls.Add(this.Bt_CadProduto);
            this.Controls.Add(this.Bt_AtualizarProduto);
            this.Controls.Add(this.Tb_EstoqueProduto);
            this.Controls.Add(this.Lbl_EstoqueProduto);
            this.Controls.Add(this.Lbl_PrecoProduto);
            this.Controls.Add(this.Tb_NomeProduto);
            this.Controls.Add(this.Lbl_NomeProduto);
            this.Controls.Add(this.Tb_CodEAN);
            this.Controls.Add(this.Lbl_CodEAN);
            this.Controls.Add(this.Tb_IdProduto);
            this.Controls.Add(this.Lbl_IdProduto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CadProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_IdProduto;
        private System.Windows.Forms.TextBox Tb_IdProduto;
        private System.Windows.Forms.Label Lbl_CodEAN;
        private System.Windows.Forms.TextBox Tb_CodEAN;
        private System.Windows.Forms.Label Lbl_NomeProduto;
        private System.Windows.Forms.TextBox Tb_NomeProduto;
        private System.Windows.Forms.Label Lbl_PrecoProduto;
        private System.Windows.Forms.Label Lbl_EstoqueProduto;
        private System.Windows.Forms.TextBox Tb_EstoqueProduto;
        private System.Windows.Forms.Button Bt_CadProduto;
        private System.Windows.Forms.Button Bt_ExcluirProduto;
        private System.Windows.Forms.Button Bt_SairCadProduto;
        private vendas_dbDataSet1 vendas_dbDataSet1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private vendas_dbDataSet1TableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Button Bt_AtualizarProduto;
        private System.Windows.Forms.DataGridView Dgv_CadProduto;
        private System.Windows.Forms.TextBox Tb_PrecoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_CodEAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvg_Estoque;
    }
}