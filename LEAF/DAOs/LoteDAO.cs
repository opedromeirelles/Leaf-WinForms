using LEAF.Models;
using LEAF.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.DAOs
{
    public class LoteDAO : ConexaoDAO
    {
        public LoteModel BuscarLotePorID(string idLote)
        {
            string sqlStringLote = "SELECT * FROM fnc_MostrarLote(@idlote)";

            string sqlStringItens = "SELECT * FROM fnc_ListarItensLote(@idlote)";

            List<SqlParameter> parametrosLote = new List<SqlParameter>
            {
                new SqlParameter("@idlote", idLote)
            };

            LoteModel lote = null;

            //Consulta para listar o lote
            using (SqlDataReader reader = executaConsulta(sqlStringLote, parametrosLote))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lote = new LoteModel();

                        lote.IdLote = Convert.ToString(reader["lote"]);
                        lote.Estagio = Convert.ToString(reader["estagio"]);
                        lote.Quantidade = Convert.ToInt32(reader["quantidade"]);
                        lote.DataSemeadura = Convert.ToDateTime(reader["data_semeadura"]);
                        lote.DataCrescimento = reader["data_crescimento"] != DBNull.Value ? Convert.ToDateTime(reader["data_crescimento"]) : (DateTime?)null;
                        lote.DataPlantio = reader["data_plantio"] != DBNull.Value ? Convert.ToDateTime(reader["data_plantio"]) : (DateTime?)null;
                        lote.DataColheita = reader["data_colheita"] != DBNull.Value ? Convert.ToDateTime(reader["data_colheita"]) : (DateTime?)null;
                                                                                    //Configurando assim as datas para aceitar valores nulos
                        lote.Produto = new ProdutoModel
                        {
                            Descricao = Convert.ToString(reader["produto"]),
                        };

                        lote.Usuario = new UsuarioModel
                        {
                            Login = Convert.ToString(reader["usuario"])
                        };
                    }
                }
            }

            if (lote == null)
            {
                return null;
            }

            List<SqlParameter> parametrosItens = new List<SqlParameter>
            {
                new SqlParameter("@idlote", idLote)
            };

            lote.ItensLote = new List<ItemLoteModel>();

            //Consulta para listar os itens do lote
            using (SqlDataReader readerItens = executaConsulta(sqlStringItens, parametrosItens))
            {
                if (readerItens.HasRows)
                {
                    while (readerItens.Read())
                    {
                        ItemLoteModel item = new ItemLoteModel
                        {
                            Quantidade = Convert.ToInt32(readerItens["qtde"]),
                            IdItemLote = Convert.ToInt32(readerItens["iditemlote"]),
                            IdInsumo = Convert.ToInt32(readerItens["id_insumo"]),
                            Insumo = new InsumoModel
                            {
                                IdInsumo = Convert.ToInt32(readerItens["id_insumo"]),
                                Descricao = Convert.ToString(readerItens["descricao"]),
                                UnidadeMedida = Convert.ToString(readerItens["unidade_medida"])
                            }
                        };
                        lote.ItensLote.Add(item);
                    }
                }
            }
        return lote;
        }
        public List<LoteModel> BuscarLotePorStatus(int parametroInformado)
        {
            List<LoteModel> listaLote = new List<LoteModel>();

            string sqlStringLote = "SELECT * FROM fnc_ListarLotes(@parametroInformado)";

            string sqlStringItens = "SELECT * FROM fnc_ListarItensLote(@idlote)";

            List<SqlParameter> parametrosLote = new List<SqlParameter>
            {
                new SqlParameter("@parametroInformado", parametroInformado)
            };

            //Consulta para listar os Lotes
            using (SqlDataReader reader = executaConsulta(sqlStringLote, parametrosLote))
            {
                while (reader.Read())
                {
                    LoteModel lote = new LoteModel
                    {
                        IdLote = Convert.ToString(reader["lote"]),
                        Estagio = Convert.ToString(reader["estagio"]),
                        Quantidade = Convert.ToInt32(reader["quantidade"]),
                        DataSemeadura = reader["data_semeadura"] != DBNull.Value ? Convert.ToDateTime(reader["data_semeadura"]) : (DateTime?)null,
                        DataCrescimento = reader["data_crescimento"] != DBNull.Value ? Convert.ToDateTime(reader["data_crescimento"]) : (DateTime?)null,
                        DataPlantio = reader["data_plantio"] != DBNull.Value ? Convert.ToDateTime(reader["data_plantio"]) : (DateTime?)null,
                        DataColheita = reader["data_colheita"] != DBNull.Value ? Convert.ToDateTime(reader["data_colheita"]) : (DateTime?)null,
                                                                                                 //Configurando assim as datas para aceitar valores nulos
                        ItensLote = new List<ItemLoteModel>(),

                        Produto = new ProdutoModel
                        {
                            Descricao = Convert.ToString(reader["produto"])
                        },

                        Usuario = new UsuarioModel
                        {
                            Login = Convert.ToString(reader["usuario"])
                        }

                    };

                    List<SqlParameter> parametrosItens = new List<SqlParameter>
                    {
                        new SqlParameter("@idlote", lote.IdLote)
                    };

                    //Consulta para listar os itens de cada lote encontrado
                    using (SqlDataReader readerItens = executaConsulta(sqlStringItens, parametrosItens))
                    {
                        if (readerItens.HasRows)
                        {
                            while (readerItens.Read())
                            {
                                ItemLoteModel item = new ItemLoteModel
                                {
                                    Quantidade = Convert.ToInt32(readerItens["qtde"]),
                                    IdItemLote = Convert.ToInt32(readerItens["iditemlote"]),
                                    IdInsumo = Convert.ToInt32(readerItens["id_insumo"]),
                                    Insumo = new InsumoModel
                                    {
                                        IdInsumo = Convert.ToInt32(readerItens["id_insumo"]),
                                        Descricao = Convert.ToString(readerItens["descricao"]),
                                        UnidadeMedida = Convert.ToString(readerItens["unidade_medida"])
                                    }
                                };
                                lote.ItensLote.Add(item);
                            }
                        }
                    }
                    listaLote.Add(lote);
                }
            }
            return listaLote;
        }
        public bool CadastrarLote(LoteModel lote)
        {
            string sqlStringLote = @"INSERT INTO LOTE_PRODUCAO 
                                        (idlote, id_produto, qtde, dta_semeadura, id_usuario) 
                                    VALUES
                                        (@idlote, @id_produto, @qtde, GETDATE(), @id_usuario)";

            string sqlStringItens = @"INSERT INTO ITEM_LOTE 
                                        (id_insumo, qtde, id_lote) 
                                    VALUES
                                        (@id_insumo, @qtde, @id_lote)";

            List<SqlParameter> parametrosLote = new List<SqlParameter>
            {
                new SqlParameter("@idlote", lote.IdLote),
                new SqlParameter("@id_produto", lote.Produto.IdProduto),
                new SqlParameter("@qtde", lote.Quantidade),
                new SqlParameter("@id_usuario", SessaoUsuario.IdUsuario)
            };

            try
            {
                executaSQL(sqlStringLote, parametrosLote);

                foreach (var item in lote.ItensLote)
                {
                    List<SqlParameter> parametrosItens = new List<SqlParameter>
                    {
                        new SqlParameter("@id_insumo", item.IdInsumo),
                        new SqlParameter("@qtde", item.Quantidade),
                        new SqlParameter("@id_lote", lote.IdLote)
                    };
                    executaSQL(sqlStringItens, parametrosItens);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AvancarEstagio(string idLote)
        {
            string sqlString = "EXEC AvancarEstagio @idlote";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@idlote", idLote)
            };

            try
            {
                executaSQL(sqlString, parametros);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AlterarQuantidade (string idLote, int novaQtde)
        {
            string sqlString = "UPDATE LOTE_PRODUCAO SET QTDE = @novaQtde WHERE IDLOTE = @idLote";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@idLote", idLote),
                new SqlParameter("@novaQtde", novaQtde)
            };

            try
            {
                executaSQL(sqlString, parametros);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
