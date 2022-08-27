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
    public partial class FormCadVenda : Form
    {
        public FormCadVenda()
        {
            InitializeComponent();

            //Inicializa dados para quando interface abre
            CarregarListView();
            CarregarIdCliente(); //Atualiza clientes na combo
            CarregarIdProduto(); //Atualiza produtos na combo
            //Limpa combos de clientes e dados
            Cb_IdCliente.SelectedIndex = -1;
            Cb_IdProduto.SelectedIndex = -1;
        }

        private void CarregarListView()
        {
            Dgv_CadVenda.Rows.Clear();
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            //SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            //command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "select id_venda, cast(cliente.id_cliente as varchar)" +
                " + ' - ' + cliente.nomeCliente as descCliente, valorTotal from venda" +
                " inner join cliente on cliente.id_cliente = venda.id_cliente order by" +
                " id_venda desc;";

            try
            {
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    Dgv_CadVenda.Rows.Add(leitor["id_venda"].ToString(), leitor["descCliente"].ToString(), leitor["valorTotal"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro Banco CarregarListView Venda! " + e.Message.ToString());
            }
            finally
            {
                banco.FecharConexao();
                Tb_ValorTotal.Text = "";
            }
        }

        private void CarregarListViewItem()
        {
            Dgv_ItemVenda.Rows.Clear();
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.CommandType = CommandType.Text;
            command.CommandText = "select id_itemVenda, id_venda, cast(itemVenda.id_produto as varchar) + ' - ' + produto.nomeProduto as descProduto, valorUnitario, quantidade, valorTotal from itemVenda inner join produto on produto.id_produto = itemVenda.id_produto where itemVenda.id_venda = @id_venda;";
            command.Parameters.Add("@id_venda", SqlDbType.Int);
            command.Parameters[0].Value = Tb_IdVenda.Text;

            try
            {
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    Dgv_ItemVenda.Rows.Add(leitor["id_itemVenda"].ToString(), leitor["id_venda"].ToString(), leitor["descProduto"].ToString(), leitor["valorUnitario"].ToString(), leitor["quantidade"].ToString(), leitor["valorTotal"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro Banco CarregarList View - Dgv_ItemVenda! " + e.Message.ToString());
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        private void RetornaValorTotalVenda(int Id_Venda)
        {
            double auxiliar = 0;

            ConexaoBD banco = new ConexaoBD();
            SqlConnection cn = banco.AbrirConexao();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;

            command.CommandType = CommandType.Text;
            command.CommandText = "select coalesce(round(sum(valorTotal),2),0) totalVenda from itemVenda where id_venda = " + Id_Venda.ToString();
            
            try
            {
                SqlDataReader leitor = command.ExecuteReader();
               
                while (leitor.Read())
                {
                    auxiliar = (double)leitor["totalVenda"];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro Banco. Retorna o Valor Total Venda! " + e.Message.ToString());
            }
            finally
            {
                banco.FecharConexao();
                Tb_ValorTotal.Text = auxiliar.ToString();

            }
        }

        private void CarregarIdCliente()
        {
            ConexaoBD banco = new ConexaoBD();
            SqlConnection cn = banco.AbrirConexao();
          
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            
            command.CommandType = CommandType.Text;
            command.CommandText = "select id_cliente, cast(id_cliente as varchar) + ' - ' + nomeCliente AS descCliente from cliente order by nomeCliente;";

            try
            {
                SqlDataReader leitor = command.ExecuteReader();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                
                while (leitor.Read())
                {
                    dic.Add(leitor["id_cliente"].ToString(), leitor["descCliente"].ToString());
                }
                Cb_IdCliente.DataSource = new BindingSource(dic, null);
                Cb_IdCliente.DisplayMember = "Value";
                Cb_IdCliente.ValueMember = "Key";
               
              
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro Banco - Retorna IdCliente! " + e.Message.ToString());
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        private void CarregarIdProduto()
        {
            ConexaoBD banco = new ConexaoBD();
            SqlConnection cn = banco.AbrirConexao();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;

            command.CommandType = CommandType.Text;
            command.CommandText = "select id_produto, cast(id_produto as varchar) + ' - ' + nomeProduto + ' (' + cast(estoque as varchar) + ' em Estoque)' AS descProduto from produto where estoque > 0 order by nomeProduto;";

            try
            {
                SqlDataReader leitor = command.ExecuteReader();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                
                while (leitor.Read())
                {
                    dic.Add(leitor["id_produto"].ToString(), leitor["descProduto"].ToString());
                }
                Cb_IdProduto.DataSource = new BindingSource(dic, null);
                Cb_IdProduto.DisplayMember = "Value";
                Cb_IdProduto.ValueMember = "Key";

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro Banco - Retorna IdProduto! " + e.Message.ToString());
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        private void Bt_CadVenda_Click(object sender, EventArgs e)
        {

            try
            {
                ClassVenda venda = new ClassVenda(int.Parse((string)Cb_IdCliente.SelectedValue));

                venda.CadastrarVenda();
                CarregarListView();
                CarregarIdCliente(); //atualiza combo de clientes
            }
            catch (Exception c)
            {
                MessageBox.Show("Erro no Bt_CadVenda! " + c.Message);
            }
        }

        private void Bt_AtualizarVenda_Click(object sender, EventArgs e)
        {
            if (Tb_IdVenda.Text.Length > 0)
            {
                ClassVenda venda = new ClassVenda(int.Parse(Tb_IdVenda.Text), int.Parse((string)Cb_IdCliente.SelectedValue));

                venda.AtualizarVenda();
                CarregarListView();
            }
            else
            {
                MessageBox.Show("Para atualizar a Venda é preciso selecioná-lo na lista Venda " +
                    "com duplo click!");
            }
        }

        private void Bt_ExcluirVenda_Click(object sender, EventArgs e)
        {
            if (Tb_IdVenda.Text.Length > 0)
            {
                ClassVenda venda = new ClassVenda(int.Parse(Tb_IdVenda.Text), int.Parse((string)Cb_IdCliente.SelectedValue));

                venda.ExcluirVenda();
                CarregarListView();
                Tb_IdVenda.Text = "";
                Cb_IdCliente.SelectedIndex = -1;
                Tb_ValorTotal.Text = "";
                Dgv_ItemVenda.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Para excluir a venda é preciso selecioná-lo a na lista Venda " +
                    "com duplo click!");
            }
        }   

        private void Bt_SairCadVenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Formata a inclusão do valor numérico com utilização da vírgula
        private void Tb_ValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Outra Opção: Mask do textBox - tratamento com ExcludPromptAndLiterals.
        }

        private void Bt_CadItemVenda_Click(object sender, EventArgs e)
        {
            if (Tb_IdVenda.Text.Length > 0)
            {
                try
                {
                    ClassItemVenda itemVenda = new ClassItemVenda(int.Parse(Tb_IdVenda.Text), int.Parse((string)Cb_IdProduto.SelectedValue), int.Parse(Tb_QuantAdquirida.Text));

                    itemVenda.CadastrarItemVenda();
                    Tb_ItemVenda.Text = "";
                    Tb_QuantAdquirida.Text = "";
                    Tb_ValorTotalItem.Text = "";

                    CarregarListView();
                    CarregarIdCliente(); //Atualiza dados combo cliente
                    CarregarIdProduto(); //Atualiza dados combo produto
                    CarregarListViewItem();
                    RetornaValorTotalVenda(int.Parse(Tb_IdVenda.Text));

                }
                catch (Exception c)
                {
                    MessageBox.Show("Erro no Bt_CadItemVenda " + c.Message);
                }
            }
            else
            {
                MessageBox.Show("Para cadastrar itemVenda é preciso selecionar uma Venda " +
                    "(na lista Venda) com duplo click, e preencher os campos necessários no " +
                    "itemVenda");
            }
        }

        private void Dgv_ItemVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceLinha;
            DataGridViewRow linhaSelecionada = Dgv_ItemVenda.CurrentRow;
            indiceLinha = linhaSelecionada.Index;

            
            Tb_ItemVenda.Text = Dgv_ItemVenda.Rows[indiceLinha].Cells[0].Value.ToString();
            Cb_IdProduto.Text = Dgv_ItemVenda.Rows[indiceLinha].Cells[2].Value.ToString();
            Tb_QuantAdquirida.Text = Dgv_ItemVenda.Rows[indiceLinha].Cells[4].Value.ToString();
            Tb_ValorTotalItem.Text = Dgv_ItemVenda.Rows[indiceLinha].Cells[5].Value.ToString();
        }

        private void Dgv_CadVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceLinha;
            DataGridViewRow linhaSelecionada = Dgv_CadVenda.CurrentRow;
            indiceLinha = linhaSelecionada.Index;

            //Preenche os campos da sessão vendas quando duplo clicar em uma venda
            Tb_IdVenda.Text = Dgv_CadVenda.Rows[indiceLinha].Cells[0].Value.ToString();
            Cb_IdCliente.Text = Dgv_CadVenda.Rows[indiceLinha].Cells[1].Value.ToString();
            Tb_ValorTotal.Text = Dgv_CadVenda.Rows[indiceLinha].Cells[2].Value.ToString();
     
            CarregarListViewItem();
        }

        private void Bt_AtualizarItemVenda_Click(object sender, EventArgs e)
        {
            if (Tb_ItemVenda.Text.Length > 0)
            {
                ClassItemVenda itemVenda = new ClassItemVenda(int.Parse(Tb_IdVenda.Text), int.Parse((string)Cb_IdProduto.SelectedValue), int.Parse(Tb_QuantAdquirida.Text), int.Parse(Tb_ItemVenda.Text));

                itemVenda.AtualizarItemVenda();
                CarregarListView();
                CarregarListViewItem();
                Tb_ItemVenda.Text = "";
                Cb_IdProduto.SelectedIndex = -1;
                Tb_QuantAdquirida.Text = "";
                Tb_ValorTotalItem.Text = "";
                CarregarIdProduto();
                RetornaValorTotalVenda(int.Parse(Tb_IdVenda.Text));
            }
            else
            {
                MessageBox.Show("Para atualizar o itemVenda é preciso selecioná-lo na " +
                    "lista itemVenda com duplo click");
            }
        }

        private void Bt_ExcluirItemVenda_Click(object sender, EventArgs e)
        {
            if (Tb_ItemVenda.Text.Length > 0)
            {
                ClassItemVenda itemVenda = new ClassItemVenda(int.Parse(Tb_IdVenda.Text), -1, int.Parse(Tb_QuantAdquirida.Text), int.Parse(Tb_ItemVenda.Text));

                itemVenda.ExcluirItemVenda();
                CarregarListView();
                CarregarListViewItem();
                Tb_ItemVenda.Text = "";
                Cb_IdProduto.SelectedIndex = -1;
                Tb_QuantAdquirida.Text = "";
                Tb_ValorTotalItem.Text = "";
                CarregarIdProduto();
                RetornaValorTotalVenda(int.Parse(Tb_IdVenda.Text));
            }
            else
            {
                MessageBox.Show("Para atualizar o itemVenda é preciso selecioná-lo na " +
                    "lista itemVenda com duplo click");
            }
        }

        private void Bt_SairItemVenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
