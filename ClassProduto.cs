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
    internal class ClassProduto
    {
        //atributos da classe
        int id_produto;
        string codEAN;
        string nomeProduto;
        double preco;
        int estoque;

        //Istanciado o objeto, o construtor cria os parâmetros com essas variáveis.
        public ClassProduto(int id_produto, string codEAN, string nomeProduto, double preco, int estoque)
        {
            this.Id_produto = id_produto;
            this.CodEAN = codEAN;
            this.NomeProduto = nomeProduto;
            this.Preco = preco;
            this.Estoque = estoque;
        }

        //Istanciado o objeto, o construtor cria os parâmetros com essas variáveis
        public ClassProduto(string codEAN, string nomeProduto, double preco, int estoque)
        {
            this.CodEAN = codEAN;
            this.NomeProduto = nomeProduto;
            this.Preco = preco;
            this.Estoque = estoque;
        }

        // Visibilidade - tratamento e restrições no Set
        public int Id_produto { get => id_produto; set => id_produto = value; }

        public string CodEAN
        {
            get
            {
                return codEAN;
            }
            set
            {
                if (value.Length == 13)
                {
                    codEAN = value;
                }
                else
                {
                    throw new Exception("ALERTA! " + "O codEAN deve conter exatamente 13 caracteres e não pode ser vazio!");
                }
            }
        }

        public string NomeProduto 
        {
            get
            {
                return nomeProduto;
            }
            set
            {
                if (value.Length < 150 || value.Length != 0)
                {
                    nomeProduto = value;
                }
                else
                {
                    
                    throw new Exception("ALERTA! " + "O nome do produto deve conter no máximo 150 caracteres e não pode ser vazio!");
                }
            }
        }
                          
        public double Preco 
        {
            get
            {
                return preco;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("ALERTA! " + "O valor do produto não pode ser negativo!");
                }
                else
                {
                    preco = value;
                }
            }
        }
        
        public int Estoque
        {
            get
            {
                return estoque;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("ALERTA! " + "A quantidade do produto em estoque não pode ser negativa!");
                }
                else
                {
                    estoque = value;
                }
            }
        }

        // Método para conexão com banco de dados

        public bool CadastrarProduto()
        {
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into produto (codEAN, nomeProduto, preco, estoque) values (@codEAN, @nomeProduto, @preco, @estoque);";
            command.Parameters.Add("@codEAN", SqlDbType.Char);
            command.Parameters.Add("@nomeProduto", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Real);
            command.Parameters.Add("@estoque", SqlDbType.Int);
            command.Parameters[0].Value = codEAN;
            command.Parameters[1].Value = nomeProduto;
            command.Parameters[2].Value = preco;
            command.Parameters[3].Value = estoque;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show("Erro Banco Cadastrar Produto! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
        public bool AtualizarProduto()
        {
            //Conexão com o Banco de Dados:
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "update produto set codEan=@codEAN, nomeProduto=@nomeProduto, preco=@preco, estoque=@estoque where id_produto=@id_produto;";
            command.Parameters.Add("@id_produto", SqlDbType.Int);
            command.Parameters.Add("@codEAN", SqlDbType.Char);
            command.Parameters.Add("@nomeProduto", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Real);
            command.Parameters.Add("@estoque", SqlDbType.Int);
            command.Parameters[0].Value = id_produto;
            command.Parameters[1].Value = codEAN;
            command.Parameters[2].Value = nomeProduto;
            command.Parameters[3].Value = preco;
            command.Parameters[4].Value = estoque;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show("Erro Banco Atualizar Produto! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        public bool ExcluirProduto()
        {
            //Conexão com o Banco de Dados:
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from produto where id_produto=@id_produto;";
            command.Parameters.Add("@id_produto", SqlDbType.Int);
            command.Parameters[0].Value = id_produto;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show("Erro Banco Excluir Produto! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
    }
}
