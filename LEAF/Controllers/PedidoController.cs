using LEAF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAF.Controllers
{
    public class PedidoController
    {
        private PedidoModel _pedidoModel;
        public List<ItemPedidoModel> ListaItensPedido {  get; set; } = new List<ItemPedidoModel>();
        public List<ProdutoModel> ListaProduto { get; set; } = new List<ProdutoModel>();
        public PedidoController()
        {
            _pedidoModel = new PedidoModel();
            ListaProduto = new List<ProdutoModel>();
        }
        public bool CadastrarPedido(string cep, string enderecoEntrega, int idCliente, decimal valorTotal, List<ItemPedidoModel> itensPedido)
        {
            PedidoModel pedido = new PedidoModel
            {
                Cep = cep,
                EnderecoEntrega = enderecoEntrega,
                ValorTotal = valorTotal,
                Cliente = new PessoaModel
                {
                    IdPessoa = idCliente,
                },
                ItensPedido = itensPedido
            };
            return _pedidoModel.CadastrarPedido(pedido);
        }
        public bool ExcluirPedido(int idPedido)
        {
            return _pedidoModel.ExcluirPedido(idPedido);
        }
        public bool CancelarPedido(int idPedido)
        {
            return _pedidoModel.CancelarPedido(idPedido);
        }
        public DataTable BuscarPedidoPorId(int idPedido)
        {
            PedidoModel pedido = _pedidoModel.BuscarPedidoPorId(idPedido);

            if (pedido == null)
            {                
                return null;
            }
            else
            {
                DataTable tabelaPedido = new DataTable();

                tabelaPedido.Columns.Add("N°", typeof(string));
                tabelaPedido.Columns.Add("Status", typeof(string));
                tabelaPedido.Columns.Add("Total", typeof(decimal));
                tabelaPedido.Columns.Add("Cliente", typeof(string));
                tabelaPedido.Columns.Add("Vendedor", typeof(string));
                tabelaPedido.Columns.Add("Data Emissão", typeof(DateTime));
                tabelaPedido.Columns.Add("Data Saída", typeof(DateTime));
                tabelaPedido.Columns.Add("Data Entrega", typeof(DateTime));
                tabelaPedido.Columns.Add("Data Cancelamento", typeof(DateTime));
                tabelaPedido.Columns.Add("Endereço", typeof(string));
                tabelaPedido.Columns.Add("CEP", typeof(string));
                tabelaPedido.Columns.Add("Entregador", typeof(string));

                DataRow row = tabelaPedido.NewRow();

                row["N°"] = pedido.IdPedido;
                row["Status"] = pedido.Status;
                row["Total"] = pedido.ValorTotal;
                row["Cliente"] = pedido.Cliente.Nome;
                row["Vendedor"] = pedido.Vendedor.Nome;
                row["Data Emissão"] = pedido.DataEmissao.HasValue ? (object)pedido.DataEmissao.Value : DBNull.Value;
                row["Data Saída"] = pedido.DataSaida.HasValue ? (object)pedido.DataSaida.Value : DBNull.Value;
                row["Data Entrega"] = pedido.DataEntrega.HasValue ? (object)pedido.DataEntrega.Value : DBNull.Value;
                row["Data Cancelamento"] = pedido.DataCancelamento.HasValue ? (object)pedido.DataCancelamento.Value : DBNull.Value;
                row["Endereço"] = pedido.EnderecoEntrega;
                row["CEP"] = pedido.Cep;
                row["Entregador"] = pedido.Entregador.Nome;

                tabelaPedido.Rows.Add(row);

                return tabelaPedido;
            }
        }
        public DataTable BuscarPedidoPorStatus(string status)
        {
            List<PedidoModel> listaPedido = _pedidoModel.BuscarPedidoPorStatus(status);

            DataTable tabelaPedido = new DataTable();

            tabelaPedido.Columns.Add("N°", typeof(string));
            tabelaPedido.Columns.Add("Status", typeof(string));
            tabelaPedido.Columns.Add("Total", typeof(decimal));
            tabelaPedido.Columns.Add("Cliente", typeof(string));
            tabelaPedido.Columns.Add("Vendedor", typeof(string));
            tabelaPedido.Columns.Add("Data Emissão", typeof(DateTime));
            tabelaPedido.Columns.Add("Data Saída", typeof(DateTime));
            tabelaPedido.Columns.Add("Data Entrega", typeof(DateTime));
            tabelaPedido.Columns.Add("Data Cancelamento", typeof(DateTime));
            tabelaPedido.Columns.Add("Endereço", typeof(string));
            tabelaPedido.Columns.Add("CEP", typeof(string));
            tabelaPedido.Columns.Add("Entregador", typeof(string));

            foreach (var pedido in listaPedido)
            {
                DataRow row = tabelaPedido.NewRow();

                row["N°"] = pedido.IdPedido;
                row["Status"] = pedido.Status;
                row["Total"] = pedido.ValorTotal;
                row["Cliente"] = pedido.Cliente.Nome;
                row["Vendedor"] = pedido.Vendedor.Nome;
                row["Data Emissão"] = pedido.DataEmissao.HasValue ? (object)pedido.DataEmissao.Value : DBNull.Value;
                row["Data Saída"] = pedido.DataSaida.HasValue ? (object)pedido.DataSaida.Value : DBNull.Value;
                row["Data Entrega"] = pedido.DataEntrega.HasValue ? (object)pedido.DataEntrega.Value : DBNull.Value;
                row["Data Cancelamento"] = pedido.DataCancelamento.HasValue ? (object)pedido.DataCancelamento.Value : DBNull.Value;
                row["Endereço"] = pedido.EnderecoEntrega;
                row["CEP"] = pedido.Cep;
                row["Entregador"] = pedido.Entregador.Nome;

                tabelaPedido.Rows.Add(row);
            }
            return tabelaPedido;
        }
    }
}
