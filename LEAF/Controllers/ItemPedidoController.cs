using LEAF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.Controllers
{
    public class ItemPedidoController
    {
        private ItemPedidoModel _itemPedidoModel;
        public ItemPedidoController()
        {
            _itemPedidoModel = new ItemPedidoModel();
        }
        public DataTable ListaItens(int idPedido)
        {
            PedidoModel pedido = _itemPedidoModel.ListaItens(idPedido);

            DataTable tabelaItens = new DataTable();

            tabelaItens.Columns.Add("Descrição", typeof(string));
            tabelaItens.Columns.Add("Valor Unitário", typeof(decimal));
            tabelaItens.Columns.Add("Quantidade", typeof(Int32));
            tabelaItens.Columns.Add("Subtotal", typeof(decimal));

            foreach (var itens in pedido.ItensPedido)
            {
                DataRow row = tabelaItens.NewRow();

                row["Descrição"] = itens.Produto.Descricao;
                row["Valor Unitário"] = itens.Produto.ValorUnitario;
                row["Quantidade"] = itens.Quantidade;
                row["Subtotal"] = itens.SubTotal;

                tabelaItens.Rows.Add(row);
            }
            return tabelaItens;
        }
    }
}
