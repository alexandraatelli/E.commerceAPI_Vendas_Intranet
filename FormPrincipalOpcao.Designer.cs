namespace WindowsFormsVendas
{
    partial class FormOpcaoSistema
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bt_CadProdutos = new System.Windows.Forms.Button();
            this.Bt_CadCliente = new System.Windows.Forms.Button();
            this.Bt_CadVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_CadProdutos
            // 
            this.Bt_CadProdutos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Bt_CadProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_CadProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_CadProdutos.Location = new System.Drawing.Point(306, 118);
            this.Bt_CadProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_CadProdutos.Name = "Bt_CadProdutos";
            this.Bt_CadProdutos.Size = new System.Drawing.Size(94, 60);
            this.Bt_CadProdutos.TabIndex = 1;
            this.Bt_CadProdutos.Text = "Cadastrar Produtos";
            this.Bt_CadProdutos.UseVisualStyleBackColor = false;
            this.Bt_CadProdutos.Click += new System.EventHandler(this.Bt_CadProdutos_Click);
            // 
            // Bt_CadCliente
            // 
            this.Bt_CadCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Bt_CadCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_CadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_CadCliente.Location = new System.Drawing.Point(119, 118);
            this.Bt_CadCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_CadCliente.Name = "Bt_CadCliente";
            this.Bt_CadCliente.Size = new System.Drawing.Size(94, 60);
            this.Bt_CadCliente.TabIndex = 2;
            this.Bt_CadCliente.Text = "Cadastrar Cliente";
            this.Bt_CadCliente.UseVisualStyleBackColor = false;
            this.Bt_CadCliente.Click += new System.EventHandler(this.Bt_CadCliente_Click);
            // 
            // Bt_CadVenda
            // 
            this.Bt_CadVenda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Bt_CadVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_CadVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_CadVenda.Location = new System.Drawing.Point(490, 118);
            this.Bt_CadVenda.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_CadVenda.Name = "Bt_CadVenda";
            this.Bt_CadVenda.Size = new System.Drawing.Size(94, 60);
            this.Bt_CadVenda.TabIndex = 3;
            this.Bt_CadVenda.Text = "Vendas";
            this.Bt_CadVenda.UseVisualStyleBackColor = false;
            this.Bt_CadVenda.Click += new System.EventHandler(this.Bt_CadVenda_Click);
            // 
            // FormOpcaoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 300);
            this.Controls.Add(this.Bt_CadVenda);
            this.Controls.Add(this.Bt_CadCliente);
            this.Controls.Add(this.Bt_CadProdutos);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOpcaoSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOpcaoSistema_FormClosing);
            this.Load += new System.EventHandler(this.FormOpcaoSistema_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Bt_CadProdutos;
        private System.Windows.Forms.Button Bt_CadCliente;
        private System.Windows.Forms.Button Bt_CadVenda;
    }
}

