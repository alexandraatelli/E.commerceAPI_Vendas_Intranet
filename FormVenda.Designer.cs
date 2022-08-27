namespace WindowsFormsVendas
{
    partial class FormCadVenda
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
            this.Dgv_CadVenda = new System.Windows.Forms.DataGridView();
            this.CodVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendas_dbDataSet2 = new WindowsFormsVendas.vendas_dbDataSet2();
            this.Bt_ExcluirVenda = new System.Windows.Forms.Button();
            this.Bt_CadVenda = new System.Windows.Forms.Button();
            this.Bt_AtualizarVenda = new System.Windows.Forms.Button();
            this.Tb_ValorTotal = new System.Windows.Forms.TextBox();
            this.Lbl_ValorTotal = new System.Windows.Forms.Label();
            this.Tb_IdCliente = new System.Windows.Forms.TextBox();
            this.Lbl_IdProduto = new System.Windows.Forms.Label();
            this.vendaTableAdapter = new WindowsFormsVendas.vendas_dbDataSet2TableAdapters.vendaTableAdapter();
            this.Lbl_IdCliente = new System.Windows.Forms.Label();
            this.Lbl_Venda = new System.Windows.Forms.Label();
            this.Tb_IdVenda = new System.Windows.Forms.TextBox();
            this.Cb_IdCliente = new System.Windows.Forms.ComboBox();
            this.Bt_SairItemVenda = new System.Windows.Forms.Button();
            this.Bt_ExcluirItemVenda = new System.Windows.Forms.Button();
            this.Bt_AtualizarItemVenda = new System.Windows.Forms.Button();
            this.Bt_CadItemVenda = new System.Windows.Forms.Button();
            this.Dgv_ItemVenda = new System.Windows.Forms.DataGridView();
            this.id_itemVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantAdquirida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tb_ValorTotalItem = new System.Windows.Forms.TextBox();
            this.Tb_QuantAdquirida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Quant_Adquirida = new System.Windows.Forms.Label();
            this.Lbl_Id_Produto = new System.Windows.Forms.Label();
            this.Cb_IdProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_ItemVenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CadVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_CadVenda
            // 
            this.Dgv_CadVenda.AllowUserToAddRows = false;
            this.Dgv_CadVenda.AllowUserToDeleteRows = false;
            this.Dgv_CadVenda.AllowUserToOrderColumns = true;
            this.Dgv_CadVenda.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Dgv_CadVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CadVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodVenda,
            this.id_cliente,
            this.valortotal});
            this.Dgv_CadVenda.Location = new System.Drawing.Point(35, 288);
            this.Dgv_CadVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_CadVenda.Name = "Dgv_CadVenda";
            this.Dgv_CadVenda.ReadOnly = true;
            this.Dgv_CadVenda.RowHeadersWidth = 51;
            this.Dgv_CadVenda.RowTemplate.Height = 24;
            this.Dgv_CadVenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_CadVenda.Size = new System.Drawing.Size(470, 288);
            this.Dgv_CadVenda.TabIndex = 44;
            this.Dgv_CadVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CadVenda_CellDoubleClick);
            // 
            // CodVenda
            // 
            this.CodVenda.HeaderText = "Id_Cod. Venda";
            this.CodVenda.MinimumWidth = 6;
            this.CodVenda.Name = "CodVenda";
            this.CodVenda.ReadOnly = true;
            this.CodVenda.Width = 80;
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "Id Cliente";
            this.id_cliente.MinimumWidth = 6;
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Width = 200;
            // 
            // valortotal
            // 
            this.valortotal.HeaderText = "Valor Total Venda";
            this.valortotal.MinimumWidth = 6;
            this.valortotal.Name = "valortotal";
            this.valortotal.ReadOnly = true;
            this.valortotal.Width = 125;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.vendas_dbDataSet2;
            // 
            // vendas_dbDataSet2
            // 
            this.vendas_dbDataSet2.DataSetName = "vendas_dbDataSet2";
            this.vendas_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Bt_ExcluirVenda
            // 
            this.Bt_ExcluirVenda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_ExcluirVenda.Location = new System.Drawing.Point(354, 181);
            this.Bt_ExcluirVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_ExcluirVenda.Name = "Bt_ExcluirVenda";
            this.Bt_ExcluirVenda.Size = new System.Drawing.Size(122, 56);
            this.Bt_ExcluirVenda.TabIndex = 42;
            this.Bt_ExcluirVenda.Text = "Excluir";
            this.Bt_ExcluirVenda.UseVisualStyleBackColor = false;
            this.Bt_ExcluirVenda.Click += new System.EventHandler(this.Bt_ExcluirVenda_Click);
            // 
            // Bt_CadVenda
            // 
            this.Bt_CadVenda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_CadVenda.Location = new System.Drawing.Point(35, 181);
            this.Bt_CadVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_CadVenda.Name = "Bt_CadVenda";
            this.Bt_CadVenda.Size = new System.Drawing.Size(122, 56);
            this.Bt_CadVenda.TabIndex = 41;
            this.Bt_CadVenda.Text = "Cadastrar";
            this.Bt_CadVenda.UseVisualStyleBackColor = false;
            this.Bt_CadVenda.Click += new System.EventHandler(this.Bt_CadVenda_Click);
            // 
            // Bt_AtualizarVenda
            // 
            this.Bt_AtualizarVenda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_AtualizarVenda.Location = new System.Drawing.Point(196, 181);
            this.Bt_AtualizarVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_AtualizarVenda.Name = "Bt_AtualizarVenda";
            this.Bt_AtualizarVenda.Size = new System.Drawing.Size(122, 56);
            this.Bt_AtualizarVenda.TabIndex = 40;
            this.Bt_AtualizarVenda.Text = "Atualizar";
            this.Bt_AtualizarVenda.UseVisualStyleBackColor = false;
            this.Bt_AtualizarVenda.Click += new System.EventHandler(this.Bt_AtualizarVenda_Click);
            // 
            // Tb_ValorTotal
            // 
            this.Tb_ValorTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Tb_ValorTotal.Location = new System.Drawing.Point(150, 98);
            this.Tb_ValorTotal.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_ValorTotal.Name = "Tb_ValorTotal";
            this.Tb_ValorTotal.ReadOnly = true;
            this.Tb_ValorTotal.Size = new System.Drawing.Size(326, 27);
            this.Tb_ValorTotal.TabIndex = 35;
            this.Tb_ValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_ValorTotal_KeyPress);
            // 
            // Lbl_ValorTotal
            // 
            this.Lbl_ValorTotal.AutoSize = true;
            this.Lbl_ValorTotal.Location = new System.Drawing.Point(31, 105);
            this.Lbl_ValorTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_ValorTotal.Name = "Lbl_ValorTotal";
            this.Lbl_ValorTotal.Size = new System.Drawing.Size(95, 20);
            this.Lbl_ValorTotal.TabIndex = 34;
            this.Lbl_ValorTotal.Text = "Valor Total:";
            // 
            // Tb_IdCliente
            // 
            this.Tb_IdCliente.Location = new System.Drawing.Point(131, -31);
            this.Tb_IdCliente.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_IdCliente.Name = "Tb_IdCliente";
            this.Tb_IdCliente.Size = new System.Drawing.Size(289, 27);
            this.Tb_IdCliente.TabIndex = 31;
            // 
            // Lbl_IdProduto
            // 
            this.Lbl_IdProduto.AutoSize = true;
            this.Lbl_IdProduto.Location = new System.Drawing.Point(40, -24);
            this.Lbl_IdProduto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_IdProduto.Name = "Lbl_IdProduto";
            this.Lbl_IdProduto.Size = new System.Drawing.Size(84, 20);
            this.Lbl_IdProduto.TabIndex = 30;
            this.Lbl_IdProduto.Text = "Id Cliente:";
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // Lbl_IdCliente
            // 
            this.Lbl_IdCliente.AutoSize = true;
            this.Lbl_IdCliente.Location = new System.Drawing.Point(31, 66);
            this.Lbl_IdCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_IdCliente.Name = "Lbl_IdCliente";
            this.Lbl_IdCliente.Size = new System.Drawing.Size(164, 20);
            this.Lbl_IdCliente.TabIndex = 45;
            this.Lbl_IdCliente.Text = "Selecionar o Cliente:";
            // 
            // Lbl_Venda
            // 
            this.Lbl_Venda.AutoSize = true;
            this.Lbl_Venda.Location = new System.Drawing.Point(31, 22);
            this.Lbl_Venda.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Venda.Name = "Lbl_Venda";
            this.Lbl_Venda.Size = new System.Drawing.Size(168, 20);
            this.Lbl_Venda.TabIndex = 47;
            this.Lbl_Venda.Text = "Id Venda Automático:";
            // 
            // Tb_IdVenda
            // 
            this.Tb_IdVenda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Tb_IdVenda.Location = new System.Drawing.Point(233, 15);
            this.Tb_IdVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_IdVenda.Name = "Tb_IdVenda";
            this.Tb_IdVenda.ReadOnly = true;
            this.Tb_IdVenda.Size = new System.Drawing.Size(243, 27);
            this.Tb_IdVenda.TabIndex = 48;
            // 
            // Cb_IdCliente
            // 
            this.Cb_IdCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Cb_IdCliente.FormattingEnabled = true;
            this.Cb_IdCliente.Location = new System.Drawing.Point(232, 58);
            this.Cb_IdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_IdCliente.Name = "Cb_IdCliente";
            this.Cb_IdCliente.Size = new System.Drawing.Size(244, 28);
            this.Cb_IdCliente.TabIndex = 49;
            // 
            // Bt_SairItemVenda
            // 
            this.Bt_SairItemVenda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_SairItemVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_SairItemVenda.Location = new System.Drawing.Point(1184, 130);
            this.Bt_SairItemVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_SairItemVenda.Name = "Bt_SairItemVenda";
            this.Bt_SairItemVenda.Size = new System.Drawing.Size(132, 64);
            this.Bt_SairItemVenda.TabIndex = 66;
            this.Bt_SairItemVenda.Text = "Sair da Venda";
            this.Bt_SairItemVenda.UseVisualStyleBackColor = false;
            this.Bt_SairItemVenda.Click += new System.EventHandler(this.Bt_SairItemVenda_Click);
            // 
            // Bt_ExcluirItemVenda
            // 
            this.Bt_ExcluirItemVenda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_ExcluirItemVenda.Location = new System.Drawing.Point(889, 181);
            this.Bt_ExcluirItemVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_ExcluirItemVenda.Name = "Bt_ExcluirItemVenda";
            this.Bt_ExcluirItemVenda.Size = new System.Drawing.Size(120, 56);
            this.Bt_ExcluirItemVenda.TabIndex = 65;
            this.Bt_ExcluirItemVenda.Text = "Excluir";
            this.Bt_ExcluirItemVenda.UseVisualStyleBackColor = false;
            this.Bt_ExcluirItemVenda.Click += new System.EventHandler(this.Bt_ExcluirItemVenda_Click);
            // 
            // Bt_AtualizarItemVenda
            // 
            this.Bt_AtualizarItemVenda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_AtualizarItemVenda.Location = new System.Drawing.Point(718, 181);
            this.Bt_AtualizarItemVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_AtualizarItemVenda.Name = "Bt_AtualizarItemVenda";
            this.Bt_AtualizarItemVenda.Size = new System.Drawing.Size(120, 56);
            this.Bt_AtualizarItemVenda.TabIndex = 64;
            this.Bt_AtualizarItemVenda.Text = "Atualizar";
            this.Bt_AtualizarItemVenda.UseVisualStyleBackColor = false;
            this.Bt_AtualizarItemVenda.Click += new System.EventHandler(this.Bt_AtualizarItemVenda_Click);
            // 
            // Bt_CadItemVenda
            // 
            this.Bt_CadItemVenda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_CadItemVenda.Location = new System.Drawing.Point(542, 181);
            this.Bt_CadItemVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_CadItemVenda.Name = "Bt_CadItemVenda";
            this.Bt_CadItemVenda.Size = new System.Drawing.Size(120, 56);
            this.Bt_CadItemVenda.TabIndex = 63;
            this.Bt_CadItemVenda.Text = "Cadastrar";
            this.Bt_CadItemVenda.UseVisualStyleBackColor = false;
            this.Bt_CadItemVenda.Click += new System.EventHandler(this.Bt_CadItemVenda_Click);
            // 
            // Dgv_ItemVenda
            // 
            this.Dgv_ItemVenda.AllowUserToAddRows = false;
            this.Dgv_ItemVenda.AllowUserToDeleteRows = false;
            this.Dgv_ItemVenda.AllowUserToOrderColumns = true;
            this.Dgv_ItemVenda.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Dgv_ItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_itemVenda,
            this.id_Venda,
            this.id_Produto,
            this.valorUnitario,
            this.quantAdquirida,
            this.valorTotalProd});
            this.Dgv_ItemVenda.Location = new System.Drawing.Point(542, 288);
            this.Dgv_ItemVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_ItemVenda.Name = "Dgv_ItemVenda";
            this.Dgv_ItemVenda.ReadOnly = true;
            this.Dgv_ItemVenda.RowHeadersWidth = 51;
            this.Dgv_ItemVenda.RowTemplate.Height = 24;
            this.Dgv_ItemVenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_ItemVenda.Size = new System.Drawing.Size(774, 288);
            this.Dgv_ItemVenda.TabIndex = 62;
            this.Dgv_ItemVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ItemVenda_CellDoubleClick);
            // 
            // id_itemVenda
            // 
            this.id_itemVenda.HeaderText = "id_item Venda";
            this.id_itemVenda.MinimumWidth = 6;
            this.id_itemVenda.Name = "id_itemVenda";
            this.id_itemVenda.ReadOnly = true;
            this.id_itemVenda.Width = 70;
            // 
            // id_Venda
            // 
            this.id_Venda.HeaderText = "id_Venda";
            this.id_Venda.MinimumWidth = 6;
            this.id_Venda.Name = "id_Venda";
            this.id_Venda.ReadOnly = true;
            this.id_Venda.Width = 80;
            // 
            // id_Produto
            // 
            this.id_Produto.HeaderText = "id_Produto";
            this.id_Produto.MinimumWidth = 6;
            this.id_Produto.Name = "id_Produto";
            this.id_Produto.ReadOnly = true;
            this.id_Produto.Width = 200;
            // 
            // valorUnitario
            // 
            this.valorUnitario.HeaderText = "V. Unitario";
            this.valorUnitario.MinimumWidth = 6;
            this.valorUnitario.Name = "valorUnitario";
            this.valorUnitario.ReadOnly = true;
            this.valorUnitario.Width = 85;
            // 
            // quantAdquirida
            // 
            this.quantAdquirida.HeaderText = "Quantid.";
            this.quantAdquirida.MinimumWidth = 6;
            this.quantAdquirida.Name = "quantAdquirida";
            this.quantAdquirida.ReadOnly = true;
            this.quantAdquirida.Width = 80;
            // 
            // valorTotalProd
            // 
            this.valorTotalProd.HeaderText = "Vr.T.Item";
            this.valorTotalProd.MinimumWidth = 6;
            this.valorTotalProd.Name = "valorTotalProd";
            this.valorTotalProd.ReadOnly = true;
            this.valorTotalProd.Width = 120;
            // 
            // Tb_ValorTotalItem
            // 
            this.Tb_ValorTotalItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Tb_ValorTotalItem.Location = new System.Drawing.Point(684, 130);
            this.Tb_ValorTotalItem.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_ValorTotalItem.Name = "Tb_ValorTotalItem";
            this.Tb_ValorTotalItem.ReadOnly = true;
            this.Tb_ValorTotalItem.Size = new System.Drawing.Size(295, 27);
            this.Tb_ValorTotalItem.TabIndex = 61;
            // 
            // Tb_QuantAdquirida
            // 
            this.Tb_QuantAdquirida.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_QuantAdquirida.Location = new System.Drawing.Point(684, 91);
            this.Tb_QuantAdquirida.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_QuantAdquirida.Name = "Tb_QuantAdquirida";
            this.Tb_QuantAdquirida.Size = new System.Drawing.Size(165, 27);
            this.Tb_QuantAdquirida.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Valor Total Item:";
            // 
            // Lbl_Quant_Adquirida
            // 
            this.Lbl_Quant_Adquirida.AutoSize = true;
            this.Lbl_Quant_Adquirida.Location = new System.Drawing.Point(538, 98);
            this.Lbl_Quant_Adquirida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Quant_Adquirida.Name = "Lbl_Quant_Adquirida";
            this.Lbl_Quant_Adquirida.Size = new System.Drawing.Size(138, 20);
            this.Lbl_Quant_Adquirida.TabIndex = 54;
            this.Lbl_Quant_Adquirida.Text = "Quant. Adquirida:";
            // 
            // Lbl_Id_Produto
            // 
            this.Lbl_Id_Produto.AutoSize = true;
            this.Lbl_Id_Produto.Location = new System.Drawing.Point(538, 62);
            this.Lbl_Id_Produto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Produto.Name = "Lbl_Id_Produto";
            this.Lbl_Id_Produto.Size = new System.Drawing.Size(179, 20);
            this.Lbl_Id_Produto.TabIndex = 52;
            this.Lbl_Id_Produto.Text = "Selecionaro o Produto:";
            // 
            // Cb_IdProduto
            // 
            this.Cb_IdProduto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Cb_IdProduto.FormattingEnabled = true;
            this.Cb_IdProduto.Location = new System.Drawing.Point(718, 54);
            this.Cb_IdProduto.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_IdProduto.Name = "Cb_IdProduto";
            this.Cb_IdProduto.Size = new System.Drawing.Size(365, 28);
            this.Cb_IdProduto.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "id_ItemVenda:";
            // 
            // Tb_ItemVenda
            // 
            this.Tb_ItemVenda.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Tb_ItemVenda.Location = new System.Drawing.Point(684, 11);
            this.Tb_ItemVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_ItemVenda.Name = "Tb_ItemVenda";
            this.Tb_ItemVenda.ReadOnly = true;
            this.Tb_ItemVenda.Size = new System.Drawing.Size(211, 27);
            this.Tb_ItemVenda.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Duplo Click na lista para atualizar ou excluir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(778, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Duplo Click na lista para atualizar ou excluir. Se novo cadastro, selecione o ite" +
    "m na lista Venda ao lado";
            // 
            // FormCadVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_ItemVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_IdProduto);
            this.Controls.Add(this.Bt_SairItemVenda);
            this.Controls.Add(this.Bt_ExcluirItemVenda);
            this.Controls.Add(this.Bt_AtualizarItemVenda);
            this.Controls.Add(this.Bt_CadItemVenda);
            this.Controls.Add(this.Dgv_ItemVenda);
            this.Controls.Add(this.Tb_ValorTotalItem);
            this.Controls.Add(this.Tb_QuantAdquirida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Quant_Adquirida);
            this.Controls.Add(this.Lbl_Id_Produto);
            this.Controls.Add(this.Cb_IdCliente);
            this.Controls.Add(this.Tb_IdVenda);
            this.Controls.Add(this.Lbl_Venda);
            this.Controls.Add(this.Lbl_IdCliente);
            this.Controls.Add(this.Dgv_CadVenda);
            this.Controls.Add(this.Bt_ExcluirVenda);
            this.Controls.Add(this.Bt_CadVenda);
            this.Controls.Add(this.Bt_AtualizarVenda);
            this.Controls.Add(this.Tb_ValorTotal);
            this.Controls.Add(this.Lbl_ValorTotal);
            this.Controls.Add(this.Tb_IdCliente);
            this.Controls.Add(this.Lbl_IdProduto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVenda";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CadVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ItemVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_CadVenda;
        private System.Windows.Forms.Button Bt_ExcluirVenda;
        private System.Windows.Forms.Button Bt_CadVenda;
        private System.Windows.Forms.Button Bt_AtualizarVenda;
        private System.Windows.Forms.TextBox Tb_ValorTotal;
        private System.Windows.Forms.Label Lbl_ValorTotal;
        private System.Windows.Forms.TextBox Tb_IdCliente;
        private System.Windows.Forms.Label Lbl_IdProduto;
        private vendas_dbDataSet2 vendas_dbDataSet2;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private vendas_dbDataSet2TableAdapters.vendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.Label Lbl_IdCliente;
        private System.Windows.Forms.Label Lbl_Venda;
        private System.Windows.Forms.TextBox Tb_IdVenda;
        private System.Windows.Forms.ComboBox Cb_IdCliente;
        private System.Windows.Forms.Button Bt_SairItemVenda;
        private System.Windows.Forms.Button Bt_ExcluirItemVenda;
        private System.Windows.Forms.Button Bt_AtualizarItemVenda;
        private System.Windows.Forms.Button Bt_CadItemVenda;
        private System.Windows.Forms.DataGridView Dgv_ItemVenda;
        private System.Windows.Forms.TextBox Tb_ValorTotalItem;
        private System.Windows.Forms.TextBox Tb_QuantAdquirida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Quant_Adquirida;
        private System.Windows.Forms.Label Lbl_Id_Produto;
        private System.Windows.Forms.ComboBox Cb_IdProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_ItemVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_itemVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantAdquirida;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotal;
    }
}