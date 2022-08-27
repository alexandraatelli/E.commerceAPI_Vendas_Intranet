namespace WindowsFormsVendas
{
    partial class FormCadCliente
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
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendas_dbDataSet3 = new WindowsFormsVendas.vendas_dbDataSet3();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendas_dbDataSet = new WindowsFormsVendas.vendas_dbDataSet();
            this.Bt_SairCadCliente = new System.Windows.Forms.Button();
            this.Bt_ExcluirCliente = new System.Windows.Forms.Button();
            this.Bt_CadCliente = new System.Windows.Forms.Button();
            this.Tb_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Tb_TelefoneCliente = new System.Windows.Forms.TextBox();
            this.Lbl_TelefoneCliente = new System.Windows.Forms.Label();
            this.Tb_NomeCliente = new System.Windows.Forms.TextBox();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Tb_Cpf = new System.Windows.Forms.TextBox();
            this.Lbl_Cpf = new System.Windows.Forms.Label();
            this.Bt_AtualizarCliente = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new WindowsFormsVendas.vendas_dbDataSetTableAdapters.clienteTableAdapter();
            this.lbl_Id_Cliente = new System.Windows.Forms.Label();
            this.Tb_Cod_Id_Cliente = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteTableAdapter1 = new WindowsFormsVendas.vendas_dbDataSet3TableAdapters.clienteTableAdapter();
            this.vendas_dbDataSet11 = new WindowsFormsVendas.vendas_dbDataSet1();
            this.vendas_dbDataSet21 = new WindowsFormsVendas.vendas_dbDataSet2();
            this.Dgv_CadCliente = new System.Windows.Forms.DataGridView();
            this.Dgv_id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvg_nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvg_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendas_dbDataSet1 = new WindowsFormsVendas.vendas_dbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.formCadClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CadCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCadClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "cliente";
            this.clienteBindingSource1.DataSource = this.vendas_dbDataSet3;
            // 
            // vendas_dbDataSet3
            // 
            this.vendas_dbDataSet3.DataSetName = "vendas_dbDataSet3";
            this.vendas_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.vendas_dbDataSet;
            // 
            // vendas_dbDataSet
            // 
            this.vendas_dbDataSet.DataSetName = "vendas_dbDataSet";
            this.vendas_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Bt_SairCadCliente
            // 
            this.Bt_SairCadCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_SairCadCliente.Location = new System.Drawing.Point(1012, 200);
            this.Bt_SairCadCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_SairCadCliente.Name = "Bt_SairCadCliente";
            this.Bt_SairCadCliente.Size = new System.Drawing.Size(122, 48);
            this.Bt_SairCadCliente.TabIndex = 28;
            this.Bt_SairCadCliente.Text = "Sair";
            this.Bt_SairCadCliente.UseVisualStyleBackColor = false;
            this.Bt_SairCadCliente.Click += new System.EventHandler(this.Bt_SairCadCliente_Click);
            // 
            // Bt_ExcluirCliente
            // 
            this.Bt_ExcluirCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_ExcluirCliente.Location = new System.Drawing.Point(549, 200);
            this.Bt_ExcluirCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_ExcluirCliente.Name = "Bt_ExcluirCliente";
            this.Bt_ExcluirCliente.Size = new System.Drawing.Size(122, 48);
            this.Bt_ExcluirCliente.TabIndex = 27;
            this.Bt_ExcluirCliente.Text = "Excluir";
            this.Bt_ExcluirCliente.UseVisualStyleBackColor = false;
            this.Bt_ExcluirCliente.Click += new System.EventHandler(this.Bt_ExcluirCliente_Click);
            // 
            // Bt_CadCliente
            // 
            this.Bt_CadCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_CadCliente.Location = new System.Drawing.Point(89, 200);
            this.Bt_CadCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_CadCliente.Name = "Bt_CadCliente";
            this.Bt_CadCliente.Size = new System.Drawing.Size(122, 48);
            this.Bt_CadCliente.TabIndex = 26;
            this.Bt_CadCliente.Text = "Cadastrar";
            this.Bt_CadCliente.UseVisualStyleBackColor = false;
            this.Bt_CadCliente.Click += new System.EventHandler(this.Bt_CadCliente_Click);
            // 
            // Tb_Email
            // 
            this.Tb_Email.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_Email.Location = new System.Drawing.Point(89, 147);
            this.Tb_Email.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_Email.Name = "Tb_Email";
            this.Tb_Email.Size = new System.Drawing.Size(582, 27);
            this.Tb_Email.TabIndex = 24;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(23, 154);
            this.Lbl_Email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(56, 20);
            this.Lbl_Email.TabIndex = 23;
            this.Lbl_Email.Text = "Email:";
            // 
            // Tb_TelefoneCliente
            // 
            this.Tb_TelefoneCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_TelefoneCliente.Location = new System.Drawing.Point(192, 106);
            this.Tb_TelefoneCliente.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_TelefoneCliente.Name = "Tb_TelefoneCliente";
            this.Tb_TelefoneCliente.Size = new System.Drawing.Size(326, 27);
            this.Tb_TelefoneCliente.TabIndex = 22;
            // 
            // Lbl_TelefoneCliente
            // 
            this.Lbl_TelefoneCliente.AutoSize = true;
            this.Lbl_TelefoneCliente.Location = new System.Drawing.Point(23, 113);
            this.Lbl_TelefoneCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_TelefoneCliente.Name = "Lbl_TelefoneCliente";
            this.Lbl_TelefoneCliente.Size = new System.Drawing.Size(159, 20);
            this.Lbl_TelefoneCliente.TabIndex = 21;
            this.Lbl_TelefoneCliente.Text = "Telefone com DDD:";
            // 
            // Tb_NomeCliente
            // 
            this.Tb_NomeCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_NomeCliente.Location = new System.Drawing.Point(167, 66);
            this.Tb_NomeCliente.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_NomeCliente.Name = "Tb_NomeCliente";
            this.Tb_NomeCliente.Size = new System.Drawing.Size(967, 27);
            this.Tb_NomeCliente.TabIndex = 20;
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(23, 73);
            this.Lbl_NomeCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(134, 20);
            this.Lbl_NomeCliente.TabIndex = 19;
            this.Lbl_NomeCliente.Text = "Nome Completo:";
            // 
            // Tb_Cpf
            // 
            this.Tb_Cpf.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tb_Cpf.Location = new System.Drawing.Point(856, 17);
            this.Tb_Cpf.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_Cpf.Name = "Tb_Cpf";
            this.Tb_Cpf.Size = new System.Drawing.Size(278, 27);
            this.Tb_Cpf.TabIndex = 18;
            // 
            // Lbl_Cpf
            // 
            this.Lbl_Cpf.AutoSize = true;
            this.Lbl_Cpf.Location = new System.Drawing.Point(587, 24);
            this.Lbl_Cpf.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Cpf.Name = "Lbl_Cpf";
            this.Lbl_Cpf.Size = new System.Drawing.Size(259, 20);
            this.Lbl_Cpf.TabIndex = 17;
            this.Lbl_Cpf.Text = "CPF (deve conter 11 caracteres):";
            // 
            // Bt_AtualizarCliente
            // 
            this.Bt_AtualizarCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bt_AtualizarCliente.Location = new System.Drawing.Point(322, 200);
            this.Bt_AtualizarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_AtualizarCliente.Name = "Bt_AtualizarCliente";
            this.Bt_AtualizarCliente.Size = new System.Drawing.Size(122, 48);
            this.Bt_AtualizarCliente.TabIndex = 25;
            this.Bt_AtualizarCliente.Text = "Atualizar";
            this.Bt_AtualizarCliente.UseVisualStyleBackColor = false;
            this.Bt_AtualizarCliente.Click += new System.EventHandler(this.Bt_AtualizarCliente_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_Id_Cliente
            // 
            this.lbl_Id_Cliente.AutoSize = true;
            this.lbl_Id_Cliente.Location = new System.Drawing.Point(23, 24);
            this.lbl_Id_Cliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Id_Cliente.Name = "lbl_Id_Cliente";
            this.lbl_Id_Cliente.Size = new System.Drawing.Size(289, 20);
            this.lbl_Id_Cliente.TabIndex = 31;
            this.lbl_Id_Cliente.Text = "Id_Cliente (gerado automaticamente):";
            // 
            // Tb_Cod_Id_Cliente
            // 
            this.Tb_Cod_Id_Cliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Tb_Cod_Id_Cliente.Location = new System.Drawing.Point(322, 21);
            this.Tb_Cod_Id_Cliente.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_Cod_Id_Cliente.Name = "Tb_Cod_Id_Cliente";
            this.Tb_Cod_Id_Cliente.ReadOnly = true;
            this.Tb_Cod_Id_Cliente.Size = new System.Drawing.Size(255, 27);
            this.Tb_Cod_Id_Cliente.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // vendas_dbDataSet11
            // 
            this.vendas_dbDataSet11.DataSetName = "vendas_dbDataSet1";
            this.vendas_dbDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendas_dbDataSet21
            // 
            this.vendas_dbDataSet21.DataSetName = "vendas_dbDataSet2";
            this.vendas_dbDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dgv_CadCliente
            // 
            this.Dgv_CadCliente.AllowUserToAddRows = false;
            this.Dgv_CadCliente.AllowUserToDeleteRows = false;
            this.Dgv_CadCliente.AllowUserToOrderColumns = true;
            this.Dgv_CadCliente.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Dgv_CadCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CadCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dgv_id_cliente,
            this.Dgv_cpf,
            this.Dvg_nomeCliente,
            this.Dvg_telefone,
            this.Dgv_email});
            this.Dgv_CadCliente.Location = new System.Drawing.Point(27, 312);
            this.Dgv_CadCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_CadCliente.Name = "Dgv_CadCliente";
            this.Dgv_CadCliente.ReadOnly = true;
            this.Dgv_CadCliente.RowHeadersWidth = 51;
            this.Dgv_CadCliente.RowTemplate.Height = 24;
            this.Dgv_CadCliente.Size = new System.Drawing.Size(1107, 208);
            this.Dgv_CadCliente.TabIndex = 33;
            this.Dgv_CadCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CadCliente_CellContentClick);
            // 
            // Dgv_id_cliente
            // 
            this.Dgv_id_cliente.HeaderText = "Id Cliente";
            this.Dgv_id_cliente.MinimumWidth = 6;
            this.Dgv_id_cliente.Name = "Dgv_id_cliente";
            this.Dgv_id_cliente.ReadOnly = true;
            this.Dgv_id_cliente.Width = 125;
            // 
            // Dgv_cpf
            // 
            this.Dgv_cpf.HeaderText = "CPF";
            this.Dgv_cpf.MinimumWidth = 6;
            this.Dgv_cpf.Name = "Dgv_cpf";
            this.Dgv_cpf.ReadOnly = true;
            this.Dgv_cpf.Width = 125;
            // 
            // Dvg_nomeCliente
            // 
            this.Dvg_nomeCliente.HeaderText = "Nome";
            this.Dvg_nomeCliente.MinimumWidth = 6;
            this.Dvg_nomeCliente.Name = "Dvg_nomeCliente";
            this.Dvg_nomeCliente.ReadOnly = true;
            this.Dvg_nomeCliente.Width = 300;
            // 
            // Dvg_telefone
            // 
            this.Dvg_telefone.HeaderText = "Telefone";
            this.Dvg_telefone.MinimumWidth = 6;
            this.Dvg_telefone.Name = "Dvg_telefone";
            this.Dvg_telefone.ReadOnly = true;
            this.Dvg_telefone.Width = 140;
            // 
            // Dgv_email
            // 
            this.Dgv_email.HeaderText = "Email";
            this.Dgv_email.MinimumWidth = 6;
            this.Dgv_email.Name = "Dgv_email";
            this.Dgv_email.ReadOnly = true;
            this.Dgv_email.Width = 350;
            // 
            // vendas_dbDataSet1
            // 
            this.vendas_dbDataSet1.DataSetName = "vendas_dbDataSet";
            this.vendas_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Duplo Click no item que deseja altualizar ou excluir.";
            // 
            // formCadClienteBindingSource
            // 
            this.formCadClienteBindingSource.DataSource = typeof(WindowsFormsVendas.FormCadCliente);
            // 
            // FormCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_CadCliente);
            this.Controls.Add(this.Tb_Cod_Id_Cliente);
            this.Controls.Add(this.lbl_Id_Cliente);
            this.Controls.Add(this.Bt_SairCadCliente);
            this.Controls.Add(this.Bt_ExcluirCliente);
            this.Controls.Add(this.Bt_CadCliente);
            this.Controls.Add(this.Bt_AtualizarCliente);
            this.Controls.Add(this.Tb_Email);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Tb_TelefoneCliente);
            this.Controls.Add(this.Lbl_TelefoneCliente);
            this.Controls.Add(this.Tb_NomeCliente);
            this.Controls.Add(this.Lbl_NomeCliente);
            this.Controls.Add(this.Tb_Cpf);
            this.Controls.Add(this.Lbl_Cpf);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CadCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCadClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bt_SairCadCliente;
        private System.Windows.Forms.Button Bt_ExcluirCliente;
        private System.Windows.Forms.Button Bt_CadCliente;
        private System.Windows.Forms.TextBox Tb_Email;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Tb_TelefoneCliente;
        private System.Windows.Forms.Label Lbl_TelefoneCliente;
        private System.Windows.Forms.TextBox Tb_NomeCliente;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.TextBox Tb_Cpf;
        private System.Windows.Forms.Label Lbl_Cpf;
        private System.Windows.Forms.BindingSource formCadClienteBindingSource;
        private System.Windows.Forms.Button Bt_AtualizarCliente;
        private vendas_dbDataSet vendas_dbDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private vendas_dbDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label lbl_Id_Cliente;
        private System.Windows.Forms.TextBox Tb_Cod_Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private vendas_dbDataSet3 vendas_dbDataSet3;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private vendas_dbDataSet3TableAdapters.clienteTableAdapter clienteTableAdapter1;
        private vendas_dbDataSet1 vendas_dbDataSet11;
        private vendas_dbDataSet2 vendas_dbDataSet21;
        private System.Windows.Forms.DataGridView Dgv_CadCliente;
        private vendas_dbDataSet vendas_dbDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvg_nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvg_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_email;
    }
}