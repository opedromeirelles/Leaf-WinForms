using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAF.DAOs
{
    public class ConexaoDAO
    {
        protected SqlConnection conexao;

        private void conectaBD()
        {
            conexao = new SqlConnection(@"Data Source=localhost;Initial Catalog=Leaf;Integrated Security=True");
            try
            {
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void desconectaBD()
        {
            conexao.Close();
        }
        public void executaSQL(string sqlString, List<SqlParameter> parametros)
        {
            try
            {
                conectaBD();                                                // Conecta no banco
                SqlCommand comando = new SqlCommand(sqlString, conexao);    // Cria o comando SQL utilizando a string passada
                comando.Parameters.AddRange(parametros.ToArray());          // Adiciona os parametros passados
                comando.ExecuteNonQuery();                                  // Executa o comando
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            finally
            {
                desconectaBD();
            }
        }
        public object executaSQLRetornaId(string sqlString, List<SqlParameter> parametros)
        {
            try
            {
                conectaBD();
                SqlCommand comando = new SqlCommand(sqlString, conexao);
                comando.Parameters.AddRange(parametros.ToArray());
                object idRetornado = comando.ExecuteScalar();

                return idRetornado;
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            finally 
            { 
                desconectaBD(); 
            }
        }
        public SqlDataReader executaConsulta(string sqlString, List<SqlParameter> parametros)
        {
            try
            {
                conectaBD();
                SqlCommand comando = new SqlCommand(sqlString, conexao);
                comando.Parameters.AddRange(parametros.ToArray());

                return comando.ExecuteReader(CommandBehavior.CloseConnection); // A conexão é fechada logo após a leitura
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                desconectaBD();
                return null;                
            }
        }
    }
}
