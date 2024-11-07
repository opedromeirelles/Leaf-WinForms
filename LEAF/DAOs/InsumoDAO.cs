using LEAF.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.DAOs
{
    public class InsumoDAO : ConexaoDAO
    {
        public List<InsumoModel> ListarInsumos(string descricao, int status)
        {
            string sqlString = @"SELECT
	                                i.idinsumo,
	                                i.cod_barras,
	                                i.descricao,
	                                i.unidade_medida,
	                                i.valor_unitario,
	                                i.qtde_estoque,
                                    i.status,
	                                p.idpessoa,
                                    p.nome
                                FROM
	                                INSUMO I
	                                INNER JOIN PESSOA p ON p.idpessoa = i.id_pessoa
                                WHERE
	                                i.status <> @status
	                                and i.descricao like @descricao";

            List<InsumoModel> listaInsumo = new List<InsumoModel>();

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@descricao", "%" + descricao + "%"),
                new SqlParameter("@status", status)
            };

            using (SqlDataReader reader = executaConsulta(sqlString, parametros))
            {
                while (reader.Read())
                {
                    InsumoModel insumo = new InsumoModel
                    {
                        IdInsumo = Convert.ToInt32(reader["idinsumo"]),
                        CodBarras = Convert.ToString(reader["cod_barras"]),
                        Descricao = Convert.ToString(reader["descricao"]),
                        UnidadeMedida = Convert.ToString(reader["unidade_medida"]),
                        ValorUnitario = Convert.ToDecimal(reader["valor_unitario"]),
                        QuantidadeEstoque = Convert.ToInt32(reader["qtde_estoque"]),
                        Status = Convert.ToBoolean(reader["status"]),

                        Fornecedor = new PessoaModel
                        {
                            IdPessoa = Convert.ToInt32(reader["idpessoa"]),
                            Nome = Convert.ToString(reader["nome"])
                        }
                    };
                    listaInsumo.Add(insumo);
                }
            }
            return listaInsumo;
        }
        public List<InsumoModel> SelecionarInsumos(string descricao)
        {
            List<InsumoModel> listaInsumo = new List<InsumoModel>();

            string sqlString = @"SELECT
	                                i.idinsumo,
	                                i.cod_barras,
	                                i.descricao,
	                                i.unidade_medida,
	                                i.valor_unitario,
	                                i.qtde_estoque,
                                    i.status,
	                                p.idpessoa,
                                    p.nome
                                FROM
	                                INSUMO I
	                                INNER JOIN PESSOA p ON p.idpessoa = i.id_pessoa
                                WHERE
	                                i.status = 1
                                    and i.qtde_estoque > 0
	                                and i.descricao like @descricao";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@descricao", "%" + descricao + "%")
            };

            using (SqlDataReader reader = executaConsulta(sqlString, parametros))
            {
                while (reader.Read())
                {
                    InsumoModel insumo = new InsumoModel
                    {
                        IdInsumo = Convert.ToInt32(reader["idinsumo"]),
                        Descricao = Convert.ToString(reader["descricao"]),
                        UnidadeMedida = Convert.ToString(reader["unidade_medida"]),
                        QuantidadeEstoque = Convert.ToInt32(reader["qtde_estoque"])
                    };

                    listaInsumo.Add(insumo);
                }
            }
            return listaInsumo;
        }
    }
}
