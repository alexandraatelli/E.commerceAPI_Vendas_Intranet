using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsVendas
{
    public partial class FormOpcaoSistema : Form
    {
        public FormOpcaoSistema()
        {
            InitializeComponent();

            /// <summary>
            /// Abre o FormCadProduto por meio de uma variável formulario (variável) que pertencerá a classe FormCadProduto
            /// </summary>
        }
        private void Bt_CadProdutos_Click(object sender, EventArgs e)
        {
            FormCadProduto formularioProduto = new FormCadProduto();
            formularioProduto.Show(); //Abre o formulario
        }

        private void Bt_CadCliente_Click(object sender, EventArgs e)
        {
            FormCadCliente formularioCliente = new FormCadCliente();
            formularioCliente.Show(); //Abre o formulario Cliente
        }

        private void Bt_CadVenda_Click(object sender, EventArgs e)
        {
            FormCadVenda formularioVenda = new FormCadVenda();
            formularioVenda.Show(); //Abre o formulario Cliente
        }

        private void FormOpcaoSistema_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando o Sistema de Vendas...");
        }

        private void FormOpcaoSistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o programa? Certifique-se que todos os cadastros foram salvos.", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
            {
                e.Cancel = true; // esse e. veio do Evento - uma variável
                                 // que carrega algumas propriedades 
                                 // oriundas do método que chamou este
                                 // evento.
            }
        }
    }
}

