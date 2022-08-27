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
    internal class ClassItemVenda
    {
        //Atributos da Classe
        int id_itemVenda;
        int id_venda;
        int id_produto;
        double valorUnitario;
        int quantidadeAdquirada;
        double valorTotal;

        //Istanciado o objeto, o construtor cria os parâmetros com essas variáveis
        public ClassItemVenda(int id_itemVenda, int id_venda, int id_produto, double valorUnitario, int quantidadeAdquirada, double valorTotal)
        {
            this.Id_ItemVenda = id_itemVenda;
            this.Id_venda = id_venda;
            this.id_produto = id_produto;
            this.ValorUnitario = valorUnitario;
            this.QuantidadeAdquirada = quantidadeAdquirada;
            this.ValorTotal = valorTotal;
        }

        //Istanciado o objeto, o construtor cria os parâmetros com essas variáveis
        public ClassItemVenda(int id_venda, int id_produto, int quantidadeAdquirada, int id_itemVenda)
        {
            this.Id_venda = id_venda;
            this.Id_ItemVenda = id_itemVenda;
            this.Id_produto = id_produto;
            this.QuantidadeAdquirada = quantidadeAdquirada;
         }

        //Istanciado o objeto, o construtor cria os parâmetros com essas variáveis
        public ClassItemVenda(int id_venda, int id_produto, int quantidadeAdquirada)
        {
            this.Id_venda = id_venda;
            this.Id_produto = id_produto;
            this.QuantidadeAdquirada = quantidadeAdquirada;
        }

        //Visibilidade - tratamento e restrições no set
        public int Id_ItemVenda { get => id_itemVenda; set => id_itemVenda = value; }

        public int Id_venda { get => id_venda; set => id_venda = value; }

        public int Id_produto { get => id_produto; set => id_produto = value; }


        public double ValorUnitario
        {
            get
            {
                return valorUnitario;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("ALERTA! " + "O valor unitário do produto não pode ser negativo!");
                }
                else
                {
                    valorUnitario = value;
                }
            }
        }

        public int QuantidadeAdquirada
        {
            get
            {
                return quantidadeAdquirada;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("ALERTA! " + "A quantidade a ser adquirida não pode ser ser negativa!");
                }
                else
                {
                    quantidadeAdquirada = value;
                }
            }
        }

        public double ValorTotal
        {
            get
            {
                return valorTotal;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("ALERTA! " + "O valor do produto não pode ser negativo!");
                }
                else
                {
                    valorTotal = value;
                }
            }
        }

        public bool CadastrarItemVenda()
        {
            //Conexão com o Banco de Dados:
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "insert into itemVenda (id_venda, id_produto, valorUnitario, quantidade, valorTotal) values (@id_venda,@id_produto, (select preco from produto where id_produto = @id_produto), @quantidade, (select preco from produto where id_produto = @id_produto) * @quantidade);"
            };
            command.Parameters.Add("@id_venda", SqlDbType.Int);
            command.Parameters.Add("@id_produto", SqlDbType.Int);
            command.Parameters.Add("@valorUnitario", SqlDbType.Real);
            command.Parameters.Add("@quantidade", SqlDbType.Int);
            command.Parameters[0].Value = id_venda;
            command.Parameters[1].Value = id_produto;
            command.Parameters[2].Value = valorUnitario;
            command.Parameters[3].Value = quantidadeAdquirada;


            SqlCommand command2 = new SqlCommand
            {
                //Update para cálculo da Venda via Banco de Dados
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "update venda set valorTotal = (select round(sum(valorTotal),2) totalVenda from itemVenda where id_venda = @id_venda) where id_venda = @id_venda;"
            };
            command2.Parameters.Add("@id_venda", SqlDbType.Int);
            command2.Parameters[0].Value = id_venda;

            try
            {
                command.ExecuteNonQuery();//Cadastrar
                command2.ExecuteNonQuery();//Update
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show("Erro Banco Cadastrar Banco! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        public bool AtualizarItemVenda()
        {
            //Conexão com o Banco de Dados:
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "update itemVenda set valorUnitario=(select preco from produto where id_produto = @id_produto), quantidade=@quantidade, valorTotal=(select preco from produto where id_produto = @id_produto) * @quantidade where id_itemVenda=@id_itemVenda;"
            };
            command.Parameters.Add("@id_venda", SqlDbType.Int);
            command.Parameters.Add("@id_produto", SqlDbType.Int);
            command.Parameters.Add("@quantidade", SqlDbType.Int);
            command.Parameters.Add("@id_itemVenda", SqlDbType.Int);
            command.Parameters[0].Value = id_venda;
            command.Parameters[1].Value = id_produto;
            command.Parameters[2].Value = quantidadeAdquirada;
            command.Parameters[3].Value = id_itemVenda;

            SqlCommand command2 = new SqlCommand
            {
                //Calculo dos valores os itens via Banco de Dados
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "update venda set valorTotal = (select round(sum(valorTotal),2) totalVenda from itemVenda where id_venda = @id_venda) where id_venda = @id_venda;"
            };
            command2.Parameters.Add("@id_venda", SqlDbType.Int);
            command2.Parameters[0].Value = id_venda;

            try
            {
                command.ExecuteNonQuery();//Atualização
                command2.ExecuteNonQuery();//Updade
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show("Erro Banco - Atualizar Item Venda! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        public bool ExcluirItemVenda()
        {
            //Conexão com o Banco de Dados:
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "delete from itemVenda where id_itemVenda=@id_itemVenda;"
            };
            command.Parameters.Add("@id_itemVenda", SqlDbType.Int);
            command.Parameters[0].Value = id_itemVenda;

            SqlCommand command2 = new SqlCommand
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "update venda set valorTotal = coalesce((select round(sum(valorTotal),2) totalVenda from itemVenda where id_venda = @id_venda),0) where id_venda = @id_venda;"
            };
            command2.Parameters.Add("@id_venda", SqlDbType.Int);
            command2.Parameters[0].Value = id_venda;

            try
            {
                command.ExecuteNonQuery();//Excluir
                command2.ExecuteNonQuery();//Update
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show("Erro Banco - Update Excluir itemVenda! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }

    }
}
