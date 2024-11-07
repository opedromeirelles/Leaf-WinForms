using LEAF.Models;
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
    public class PedidoDAO : ConexaoDAO
    {
        public bool CadastrarPedido(PedidoModel pedido)
        {
            string sqlStringPedido = @"INSERT INTO PEDIDO
                                        (dta_emissao, cep, end_entrega, valor_total, id_pessoa, id_vendedor)
                                    VALUES
                                        (GETDATE(), @cep, @end_entrega, @valor_total, @id_pessoa, @id_vendedor);

                                        SELECT SCOPE_IDENTITY();";

            string sqlStringItens = @"INSERT INTO ITEM_PEDIDO VALUES
                                        (@id_produto, @qtde, @sub_total, @id_pedido)";

            List<SqlParameter> parametrosPedido = new List<SqlParameter>
            {
                new SqlParameter("@cep", pedido.Cep),
                new SqlParameter("@end_entrega", pedido.EnderecoEntrega),
                new SqlParameter("valor_total", pedido.ValorTotal),
                new SqlParameter("@id_pessoa", pedido.Cliente.IdPessoa),
                new SqlParameter("@id_vendedor", SessaoUsuario.IdUsuario)
            };

            try
            {
                object obterIDPedido = executaSQLRetornaId(sqlStringPedido, parametrosPedido);

                if (obterIDPedido != null && int.TryParse(obterIDPedido.ToString(), out int idGerado))
                {
                    foreach (var item in pedido.ItensPedido)
                    {
                        List<SqlParameter> parametrosItens = new List<SqlParameter>
                        {
                            new SqlParameter("@id_produto", item.Produto.IdProduto),
                            new SqlParameter("@qtde", item.Quantidade),
                            new SqlParameter("@sub_total", item.SubTotal),
                            new SqlParameter("@id_pedido", idGerado)
                        };
                        executaSQL(sqlStringItens, parametrosItens);
                    }
                    return true;
                }
                return false;
            }

            catch
            {
                return false;
            }
        }
        public bool ExcluirPedido(int idPedido)
        {
            string sqlString = "EXEC ExcluiPedido @idPedido";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@idPedido", idPedido)
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
        public bool CancelarPedido(int idPedido)
        {
            string sqlString = "UPDATE PEDIDO SET status = 'CA', dta_cancelamento = GETDATE() WHERE IDPEDIDO = @idPedido";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@idPedido", idPedido)
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
        public PedidoModel BuscarPedidoPorId(int idPedido)
        {
            string sqlStringPedido = "SELECT * FROM fnc_ListarPedidosPorID(@idUsuario, @idPedido)";

            string sqlStringItens = "SELECT * FROM fnc_ListarItensPedido(@idPedido)";

            List<SqlParameter> parametrosPedido = new List<SqlParameter>
            {
                new SqlParameter("@idUsuario", SessaoUsuario.IdUsuario),
                new SqlParameter("@idPedido", idPedido)
            };

            PedidoModel pedido = null;

            //Consulta para listar os pedidos
            using (SqlDataReader reader = executaConsulta(sqlStringPedido, parametrosPedido))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pedido = new PedidoModel();

                        pedido.IdPedido = Convert.ToInt32(reader["idpedido"]);
                        pedido.Status = Convert.ToString(reader["status"]);
                        pedido.ValorTotal = Convert.ToDecimal(reader["valor_total"]);
                        pedido.EnderecoEntrega = Convert.ToString(reader["end_entrega"]);
                        pedido.Cep = Convert.ToString(reader["cep"]);

                        pedido.Cliente = new PessoaModel
                        {
                            Nome = Convert.ToString(reader["cliente"])
                        };

                        pedido.Vendedor = new UsuarioModel
                        {
                            Nome = Convert.ToString(reader["vendedor"])
                        };

                        pedido.Entregador = new UsuarioModel
                        {
                            Nome = Convert.ToString(reader["entregador"])
                        };
                                                        //Configurando assim as datas para aceitar valores nulos
                        pedido.DataEmissao = reader["data_emissao"] != DBNull.Value ? Convert.ToDateTime(reader["data_emissao"]) : (DateTime?)null;
                        pedido.DataSaida = reader["data_saida"] != DBNull.Value ? Convert.ToDateTime(reader["data_saida"]) : (DateTime?)null;
                        pedido.DataEntrega = reader["data_entrega"] != DBNull.Value ? Convert.ToDateTime(reader["data_entrega"]) : (DateTime?)null;
                        pedido.DataCancelamento = reader["data_cancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["data_cancelamento"]) : (DateTime?)null;                                                                                
                    }
                }
            }

            if (pedido == null)
            {
                return null;
            }

            List<SqlParameter> parametrosItens = new List<SqlParameter>
            {
                new SqlParameter("@idPedido", pedido.IdPedido)
            };

            pedido.ItensPedido = new List<ItemPedidoModel>();

            //Consulta para listar os itens do pedido
            using (SqlDataReader readerItens = executaConsulta(sqlStringItens, parametrosItens))
            {
                if (readerItens.HasRows)
                {
                    while (readerItens.Read())
                    {
                        ItemPedidoModel item = new ItemPedidoModel
                        {
                            IdItemPedido = Convert.ToInt32(readerItens["iditempedido"]),
                            Quantidade = Convert.ToInt32(readerItens["quantidade"]),
                            SubTotal = Convert.ToDecimal(readerItens["sub_total"]),

                            IdPedido = new PedidoModel
                            {
                                IdPedido = Convert.ToInt32(readerItens["nro_do_pedido"])
                            },

                            Produto = new ProdutoModel
                            {
                                Descricao = Convert.ToString(readerItens["produto"]),
                                ValorUnitario = Convert.ToDecimal(readerItens["valor_unitario"])
                            }
                        };
                        pedido.ItensPedido.Add(item);
                    }
                }
            }
            return pedido;
        }
        public List<PedidoModel> BuscarPedidoPorStatus(string status)
        {
            List<PedidoModel> listaPedido = new List<PedidoModel>();

            string sqlStringPedido = "SELECT * FROM fnc_ListarPedidosPorStatus(@idUsuario, @status)";

            string sqlStringItens = "SELECT * FROM fnc_ListarItensPedido(@idPedido)";

            List<SqlParameter> parametrosPedido = new List<SqlParameter>
            {
                new SqlParameter("@idUsuario", SessaoUsuario.IdUsuario),
                new SqlParameter("@status", status)
            };

            //Consulta para listar os pedidos
            using (SqlDataReader reader = executaConsulta(sqlStringPedido, parametrosPedido))
            {
                while (reader.Read())
                {
                    PedidoModel pedido = new PedidoModel
                    {
                        IdPedido = Convert.ToInt32(reader["idpedido"]),
                        Status = Convert.ToString(reader["status"]),
                        ValorTotal = Convert.ToDecimal(reader["valor_total"]),
                        EnderecoEntrega = Convert.ToString(reader["end_entrega"]),
                        Cep = Convert.ToString(reader["cep"]),

                        Cliente = new PessoaModel
                        {
                            Nome = Convert.ToString(reader["cliente"])
                        },

                        Vendedor = new UsuarioModel
                        {
                            Nome = Convert.ToString(reader["vendedor"])
                        },

                        Entregador = new UsuarioModel
                        {
                            Nome = Convert.ToString(reader["entregador"])
                        },

                        DataEmissao = reader["data_emissao"] != DBNull.Value ? Convert.ToDateTime(reader["data_emissao"]) : (DateTime?)null,
                        DataSaida = reader["data_saida"] != DBNull.Value ? Convert.ToDateTime(reader["data_saida"]) : (DateTime?)null,
                        DataEntrega = reader["data_entrega"] != DBNull.Value ? Convert.ToDateTime(reader["data_entrega"]) : (DateTime?)null,
                        DataCancelamento = reader["data_cancelamento"] != DBNull.Value ? Convert.ToDateTime(reader["data_cancelamento"]) : (DateTime?)null,
                        //Configurando assim as datas para aceitar valores nulos
                        ItensPedido = new List<ItemPedidoModel>()

                    };

                    List<SqlParameter> parametrosItens = new List<SqlParameter>
                    {
                        new SqlParameter("@idPedido", pedido.IdPedido)
                    };

                    //Consulta para listar os itens de cada pedido encontrado
                    using (SqlDataReader readerItens = executaConsulta(sqlStringItens, parametrosItens))
                    {
                        if (readerItens.HasRows)
                        {
                            while (readerItens.Read())
                            {
                                ItemPedidoModel item = new ItemPedidoModel
                                {
                                    IdItemPedido = Convert.ToInt32(readerItens["iditempedido"]),
                                    Quantidade = Convert.ToInt32(readerItens["quantidade"]),
                                    SubTotal = Convert.ToDecimal(readerItens["sub_total"]),

                                    IdPedido = new PedidoModel
                                    {
                                        IdPedido = Convert.ToInt32(readerItens["nro_do_pedido"])
                                    },

                                    Produto = new ProdutoModel
                                    {
                                        Descricao = Convert.ToString(readerItens["produto"]),
                                        ValorUnitario = Convert.ToDecimal(readerItens["valor_unitario"])
                                    }
                                };
                                pedido.ItensPedido.Add(item);
                            }
                        }
                    }
                    listaPedido.Add(pedido);
                }
            }
            return listaPedido;
        }
    }
}
