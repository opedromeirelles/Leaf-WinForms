using LEAF.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.DAOs
{
    public class ProdutoDAO : ConexaoDAO
    {
        public List<ProdutoModel> SelecionarProdutos(string descricao)
        {
            string sqlString = "select * from PRODUTO where descricao like @descricao and status = 1";

            List<ProdutoModel> listaProdutos = new List<ProdutoModel>();

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@descricao", "%" + descricao + "%")
            };

            using (SqlDataReader reader = executaConsulta(sqlString, parametros))
            {
                while (reader.Read())
                {
                    ProdutoModel produto = new ProdutoModel
                    {
                        IdProduto = Convert.ToInt32(reader["idproduto"]),
                        Descricao = Convert.ToString(reader["descricao"]),
                        ValorUnitario = Convert.ToDecimal(reader["valor_unitario"]),
                        QuantidadeEstoque = Convert.ToInt32(reader["qtde_estoque"])
                    };
                    listaProdutos.Add(produto);
                }
            }
            return listaProdutos;
        }

        public List<ProdutoModel> ListarProdutos(string descricao, int status)
        {
            string sqlString = "select * from PRODUTO where descricao like @descricao and status <> @status";

            List<ProdutoModel> listaProdutos = new List<ProdutoModel>();

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@descricao", "%" + descricao + "%"),
                new SqlParameter("@status", status)
            };
            using (SqlDataReader reader = executaConsulta(sqlString, parametros))
            {
                while (reader.Read())
                {
                    ProdutoModel produto = new ProdutoModel
                    {
                        IdProduto = Convert.ToInt32(reader["idproduto"]),
                        Descricao = Convert.ToString(reader["descricao"]),
                        ValorUnitario = Convert.ToDecimal(reader["valor_unitario"]),
                        QuantidadeEstoque = Convert.ToInt32(reader["qtde_estoque"]),
                        Status = Convert.ToBoolean(reader["status"])
                    };
                    listaProdutos.Add(produto);
                }
            }
            return listaProdutos;
        }
    }
}
