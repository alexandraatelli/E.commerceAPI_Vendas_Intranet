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
     public partial class FormCadCliente : Form
    {
        public FormCadCliente()
        {
            InitializeComponent();
            CarregarListView();
        }

        private void CarregarListView()
        {
            Dgv_CadCliente.Rows.Clear();
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            //SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            //command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "select id_cliente, cpf, nomeCliente, telefone, email from cliente order by id_cliente desc;";
            
            try
            {
                SqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    Dgv_CadCliente.Rows.Add(leitor["id_cliente"].ToString(), leitor["cpf"].ToString(), leitor["nomeCliente"].ToString(), leitor["telefone"].ToString(), leitor["email"].ToString());
                }
            }
            catch (Exception e)
            {
               MessageBox.Show("Erro Banco - CarregarListView em Cliente! " + e.Message.ToString());
            }
            finally
            {
                banco.FecharConexao();
                Tb_Cod_Id_Cliente.Text = "";
                Tb_Cpf.Text = "";
                Tb_NomeCliente.Text = "";
                Tb_TelefoneCliente.Text = "";
                Tb_Email.Text = "";
            }
        }

        private void Bt_CadCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCliente cliente = new ClassCliente(Tb_Cpf.Text, Tb_NomeCliente.Text, Tb_TelefoneCliente.Text, Tb_Email.Text);

                    cliente.CadastrarCliente();
                    CarregarListView();
            }
            catch (Exception c)
            {
                    MessageBox.Show("Erro no Bt_CadCliente! " + c.Message);
            }
        }

        private void Bt_AtualizarCliente_Click(object sender, EventArgs e)
        {
            if (Tb_Cod_Id_Cliente.Text.Length > 0)
            {
                ClassCliente cliente = new ClassCliente(int.Parse(Tb_Cod_Id_Cliente.Text), Tb_Cpf.Text, Tb_NomeCliente.Text, Tb_TelefoneCliente.Text, Tb_Email.Text);

                cliente.AtualizarCliente();
                CarregarListView();
            }
            else
            {
                MessageBox.Show("Para alterar ou excluir, antes, você deve selecionar na lista com um duplo click");
            }
        }

        private void Bt_ExcluirCliente_Click(object sender, EventArgs e)
        {
            if (Tb_Cod_Id_Cliente.Text.Length > 0)
            {
                ClassCliente cliente = new ClassCliente(int.Parse(Tb_Cod_Id_Cliente.Text), Tb_Cpf.Text, Tb_NomeCliente.Text, Tb_TelefoneCliente.Text, Tb_Email.Text);

                cliente.ExcluirCliente();
                CarregarListView();
            }
            else
            {
                MessageBox.Show("Para alterar ou excluir, antes, você deve selecionar na lista com um duplo click");
            }
        }

        private void Bt_SairCadCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_CadCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceLinha;
            DataGridViewRow linhaSelecionada = Dgv_CadCliente.CurrentRow;
            indiceLinha = linhaSelecionada.Index;

             Tb_Cod_Id_Cliente.Text = Dgv_CadCliente.Rows[indiceLinha].Cells[0].Value.ToString();
            Tb_Cpf.Text = Dgv_CadCliente.Rows[indiceLinha].Cells[1].Value.ToString();
            Tb_NomeCliente.Text = Dgv_CadCliente.Rows[indiceLinha].Cells[2].Value.ToString();
            Tb_TelefoneCliente.Text = Dgv_CadCliente.Rows[indiceLinha].Cells[3].Value.ToString();
            Tb_Email.Text = Dgv_CadCliente.Rows[indiceLinha].Cells[4].Value.ToString();
        }
    }
}
