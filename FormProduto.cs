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
    public partial class FormCadProduto : Form
    {
        public FormCadProduto()
        {
            InitializeComponent();
            CarregarListView();
        }

        private void CarregarListView()
        {
            Dgv_CadProduto.Rows.Clear();
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            //SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            //command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "select id_produto, codEAN, nomeProduto, preco, estoque from produto order by id_produto desc;";
            try
            {
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    Dgv_CadProduto.Rows.Add(leitor["id_produto"].ToString(), leitor["codEAN"].ToString(), leitor["nomeProduto"].ToString(), leitor["preco"].ToString(), leitor["estoque"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro Banco CarregarListView - Produto! " + e.Message.ToString());
            }
            finally
            {
                banco.FecharConexao();
                Tb_IdProduto.Text = "";
                Tb_CodEAN.Text = "";
                Tb_NomeProduto.Text = "";
                Tb_PrecoProduto.Text = "";
                Tb_EstoqueProduto.Text = "";
            }
        }

        private void Bt_CadProduto_Click(object sender, EventArgs e)
        {
            ClassProduto produto = new ClassProduto(Tb_CodEAN.Text, Tb_NomeProduto.Text,  double.Parse(Tb_PrecoProduto.Text), int.Parse(Tb_EstoqueProduto.Text));

            produto.CadastrarProduto();
            CarregarListView();
        }

        private void Bt_AtualizarProduto_Click(object sender, EventArgs e)
        {
            if (Tb_IdProduto.Text.Length > 0)
            {
                ClassProduto produto = new ClassProduto(int.Parse(Tb_IdProduto.Text), Tb_CodEAN.Text, Tb_NomeProduto.Text, double.Parse(Tb_PrecoProduto.Text), int.Parse(Tb_EstoqueProduto.Text));

                produto.AtualizarProduto();
                CarregarListView();
            }
            else
            {
                MessageBox.Show("Para atualizar ou excluir um produto é preciso " +
                    "selecionar na lista com um duplo click");
            }
        }

        private void Bt_ExcluirProduto_Click(object sender, EventArgs e)
        {
            if (Tb_IdProduto.Text.Length > 0)
            { 
             ClassProduto produto = new ClassProduto(int.Parse(Tb_IdProduto.Text), Tb_CodEAN.Text, Tb_NomeProduto.Text, double.Parse(Tb_PrecoProduto.Text), int.Parse(Tb_EstoqueProduto.Text));

            produto.ExcluirProduto();
            CarregarListView();
            }
            else
            {
              MessageBox.Show("Para atualizar ou excluir um produto é preciso " +
                         "selecionar na lista com um duplo click");
            }

        }

        private void Bt_SairCadProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_CadProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceLinha;
            DataGridViewRow linhaSelecionada = Dgv_CadProduto.CurrentRow;
            indiceLinha = linhaSelecionada.Index;

            Tb_IdProduto.Text = Dgv_CadProduto.Rows[indiceLinha].Cells[0].Value.ToString();
            Tb_CodEAN.Text = Dgv_CadProduto.Rows[indiceLinha].Cells[1].Value.ToString();
            Tb_NomeProduto.Text = Dgv_CadProduto.Rows[indiceLinha].Cells[2].Value.ToString();
            Tb_PrecoProduto.Text = Dgv_CadProduto.Rows[indiceLinha].Cells[3].Value.ToString();
            Tb_EstoqueProduto.Text = Dgv_CadProduto.Rows[indiceLinha].Cells[4].Value.ToString();
        }

        private void Tb_PrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
