using LEAF.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.Models
{
    public class PedidoModel
    {
        private PedidoDAO _pedidoDAO;
        public List<ItemPedidoModel> ItensPedido { get; set; } = new List<ItemPedidoModel>();
        public int IdPedido { get; set; }
        public string Status { get; set; }
        public decimal ValorTotal { get; set; }
        public string EnderecoEntrega { get; set; }
        public string Cep { get; set; }
        public PessoaModel Cliente { get; set; }
        public UsuarioModel Vendedor { get; set; }
        public UsuarioModel Entregador { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataSaida { get; set; }
        public DateTime? DataEntrega { get; set; }
        public DateTime? DataCancelamento { get; set; }

        public PedidoModel()
        {
            _pedidoDAO = new PedidoDAO();
            ItensPedido = new List<ItemPedidoModel>();
        }
        public bool CadastrarPedido(PedidoModel pedido)
        {
            return _pedidoDAO.CadastrarPedido(pedido);
        }
        public bool ExcluirPedido(int idPedido)
        {
            return _pedidoDAO.ExcluirPedido(idPedido);
        }
        public bool CancelarPedido(int idPedido)
        {
            return _pedidoDAO.CancelarPedido(idPedido);
        }
        public PedidoModel BuscarPedidoPorId(int idPedido)
        {
            return _pedidoDAO.BuscarPedidoPorId(idPedido);
        }
        public List<PedidoModel> BuscarPedidoPorStatus(string status)
        {
            return _pedidoDAO.BuscarPedidoPorStatus(status);
        }
    }
    
}
