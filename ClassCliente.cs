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
    internal class ClassCliente
    {
        //propriedades da classe
        int id_cliente;
        string cpf;
        string nomeCliente;
        string telefone;
        string email;

        //Istanciado o objeto, o construtor cria os parâmetros com essas variáveis.
        public ClassCliente(int id_cliente, string cpf, string nomeCliente, string telefone, string email)
        {
            this.id_cliente = id_cliente;
            this.Cpf = cpf;
            this.NomeCliente = nomeCliente;
            this.Telefone = telefone;
            this.Email = email;
        }

        //Istanciado o objeto, o construtor cria os parâmetros com essas variáveis.
        public ClassCliente(string cpf, string nomeCliente, string telefone, string email)
        {
            
                this.Cpf = cpf;
                this.NomeCliente = nomeCliente;
                this.Telefone = telefone;
                this.Email = email;
            
           
        }

        // Método de Visibilidade - Tratamento de erros e retrições no Set.
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                if (value.Length == 11)
                {
                    cpf = value;
                }
                else
                {
                    throw new Exception("ALERTA! " + "O Cpf deve conter exatamente 11 caracteres!");
                }
            }
        }

        public string NomeCliente
        {
            get
            {
                return nomeCliente;
            }
            set
            {
                if (value.Length > 100 || value.Length == 0)
                {
                    throw new Exception("ALERTA! " + "O nome do cliente deve conter no " +
                        "máximo 100 caracteres e não pode ser vazio!");
                }
                else
                {
                    nomeCliente = value;
                }
            }
        }
             
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length >= 3 && value.Length != 0)
                {
                    telefone = value;
                }
                else
                {                    
                    throw new Exception("ALERTA! " + "O número do telefone deve conter mais que 3 caracteres e não pode ser vazio!");
                }
            }
        }
       
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (!(value.Length > 5 && value.Length <= 100))
                {
                    throw new Exception("ALERTA! " + "O email deve conter no mínimo 6 caracteres e no máximo 100 e não pode ser vazio!");
                }
                else
                {
                    email = value;
                }
            }
        }

        // Método de conexão com banco de dados
        public bool CadastrarCliente()
        {
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into cliente (cpf, nomeCliente, telefone, email) values (@cpf, @nomeCliente, substring(@telefone,1,15), @email);"; 
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@nomeCliente", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters[0].Value = cpf;
            command.Parameters[1].Value = nomeCliente;
            command.Parameters[2].Value = telefone;
            command.Parameters[3].Value = email;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show("Erro Banco Cadastrar Cliente! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        public bool AtualizarCliente()
        {
            //Conexão com o Banco de Dados:
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "update cliente set cpf=@cpf, nomeCliente=@nomeCliente, telefone=@telefone, email=@email where id_cliente=@id_cliente;";
            command.Parameters.Add("@id_cliente", SqlDbType.Int);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@nomeCliente", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters[0].Value = id_cliente;
            command.Parameters[1].Value = cpf;
            command.Parameters[2].Value = nomeCliente;
            command.Parameters[3].Value = telefone;
            command.Parameters[4].Value = email;
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                MessageBox.Show("Erro Banco Atualizar Cliente! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        public bool ExcluirCliente()
        {
            //Conexão com o Banco de Dados:
            ConexaoBD banco = new ConexaoBD();//instancia classe banco - ConexãoBD
            SqlConnection cn = banco.AbrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from cliente where id_cliente=@id_cliente;";
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
                MessageBox.Show("Erro Banco Excluir Cliente! " + e.Message.ToString());
                return false;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
    }
}
