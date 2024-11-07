using LEAF.DAOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.Models
{
    public class ItemPedidoModel
    {
        private PedidoModel _pedidoModel;
        public int IdItemPedido { get; set; }
        public ProdutoModel Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal SubTotal { get; set; }
        public PedidoModel IdPedido { get; set; }
        public ItemPedidoModel()
        {
            _pedidoModel = new PedidoModel();
        }
        public PedidoModel ListaItens(int idPedido)
        {
            return _pedidoModel.BuscarPedidoPorId(idPedido);
        }
    }
}
