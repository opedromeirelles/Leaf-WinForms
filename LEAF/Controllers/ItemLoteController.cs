using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEAF.Models;

namespace LEAF.Controllers
{
    public class ItemLoteController
    {
        private ItemLoteModel _itemLoteModel;

        public ItemLoteController()
        {
            _itemLoteModel = new ItemLoteModel();
        }
        public DataTable ListaItens(string idlote)
        {
            LoteModel lote = _itemLoteModel.ListaItens(idlote);

            DataTable tabelaItens = new DataTable();

            tabelaItens.Columns.Add("ID", typeof(int));
            tabelaItens.Columns.Add("Descricao", typeof(string));
            tabelaItens.Columns.Add("UnidadeMedida", typeof(string));
            tabelaItens.Columns.Add("Quantidade", typeof(Int32));

            foreach (var itens in lote.ItensLote)
            {
                DataRow row = tabelaItens.NewRow();

                row["ID"] = itens.Insumo.IdInsumo;
                row["Descricao"] = itens.Insumo.Descricao;
                row["UnidadeMedida"] = itens.Insumo.UnidadeMedida;
                row["Quantidade"] = itens.Quantidade;

                tabelaItens.Rows.Add(row);
            }
            return tabelaItens;
        }
    }
}
