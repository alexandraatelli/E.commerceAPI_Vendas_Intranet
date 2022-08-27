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
    internal class ClassVenda
    {
        //Atributos da classe
        int id_venda;
        int id_cliente;
        double valorTotal;

        //Istanciado o objeto, o construtor cria os parâmetros com essas variáveis
        public ClassVenda(int id_venda, int id_cliente)
        {
            this.Id_venda = id_venda;
            this.Id_cliente = id_cliente;
        }

        //Istanciado o objeto, o construtor cria os parâmetros com essas variáveis
        public ClassVenda(int id_cliente)
        {
            this.Id_cliente = id_cliente;
        }

        //Istanciado o objeto, o construtor cria os parâmetros com essas variáveis
        public ClassVenda( double valorTotal)
        {
            this.ValorTotal = valorTotal;
        }

        // Visibilidade - tratamento e restrições no set
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }

        public int Id_venda { get => id_venda; set => id_venda = value; }

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
                    throw new Exception("ALERTA! " + "O valor total do produto não pode ser negativo!");
                }
                else
                {
                    valorTotal = value;
                }
            }
        }
    
        public bool CadastrarVenda()
        {
            //Conexão com o Banco de Dados:
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into venda (id_cliente) values (@id_cliente);";
            command.Parameters.Add("@id_cliente", SqlDbType.Int);
            command.Parameters[0].Value = id_cliente;
        
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show("Erro Banco Cadastrar Venda! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
        public bool AtualizarVenda()
        {
            //Conexão com o Banco de Dados:
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "update venda set id_cliente=@id_cliente where id_venda=@id_venda;";
            command.Parameters.Add("@id_venda", SqlDbType.Int);
            command.Parameters.Add("@id_cliente", SqlDbType.Int);
            command.Parameters[0].Value = id_venda;
            command.Parameters[1].Value = id_cliente;
           
            //MessageBox.Show("Problema venda!" + id_venda + "  " + id_cliente);
            
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show("Erro Banco Atualizar Venda! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
        public bool ExcluirVenda()
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
                CommandText = "delete from venda where id_venda=@id_venda;"
            };
            command.Parameters.Add("@id_venda", SqlDbType.Int);
            command.Parameters[0].Value = id_venda;

            SqlCommand command2 = new SqlCommand
            {
                Connection = cn,
                Transaction = tran,
                CommandType = CommandType.Text,
                CommandText = "delete from itemVenda where id_venda=@id_venda;"
            };
            command2.Parameters.Add("@id_venda", SqlDbType.Int);
            command2.Parameters[0].Value = id_venda;

            try
            {
                command2.ExecuteNonQuery();
                command.ExecuteNonQuery();
                tran.Commit();
                
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show("Erro Banco Excluir Venda! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
    }
}
