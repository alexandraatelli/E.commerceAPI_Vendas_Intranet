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
    public class ConexaoBD
    {
        /// <summary>
        /// armazena o nome do banco ou do catálogo para usar no sistema
        /// </summary>
        private string conexaoString = "Data Source=127.0.0.1; Initial Catalog=vendas_db; User ID=sa; password='1q2w3e4r@#$';language=Portuguese";

        /// <summary>  
        /// objeto de conexao com o banco de dados
        /// </summary>
        private SqlConnection conexao;

        /// <summary>
        /// método para conectar ao banco, tendo como referência a conexaoString
        /// </summary>
        private void Conectar()
        {
            conexao = new SqlConnection(conexaoString);
        }

        /// <summary>
        /// método que abre a conexão com o banco de dados
        /// </summary>
        /// <returns>retorna um objeto que representa a conexao</returns>
        public SqlConnection AbrirConexao()
        {
            //this.vendas_db = vendas_db;
            try
            {
                
                Conectar();
                conexao.Open();

                return conexao;
            }
            catch (Exception)
            {
                return null;
            }

        }
        /// <summary>
        /// método que encerra a conexao com o banco de dados
        /// </summary>
        public void FecharConexao()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        public SqlDataReader ExecutarConsulta(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conexao);

            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }


        /// <summary>
        /// método que recebe uma string contendo comandos sql e os executa no banco conectado
        /// </summary>
        /// <param name="sql">string contendo comando sql</param>
        /// <returns>retorna uma tabela com as respostas do comando usados no parâmetro</returns>
        public DataTable ExecutarConsultaGenerica(string sql)
        {
            try
            {
                AbrirConexao();

                SqlCommand command = new SqlCommand(sql, conexao);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adapter preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
