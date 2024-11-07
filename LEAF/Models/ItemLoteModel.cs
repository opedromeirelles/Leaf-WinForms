using LEAF.DAOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.Models
{
    public class ItemLoteModel
    {
        private LoteModel _loteModel;
        public int Quantidade { get; set; }
        public int IdItemLote { get; set; }
        public int IdInsumo { get; set; }
        public string IdLote { get; set; }
        public InsumoModel Insumo { get; set; }
        public ItemLoteModel()
        {
            _loteModel = new LoteModel();            
        }
        public LoteModel ListaItens(string idlote)
        {
            return _loteModel.BuscarLotePorID(idlote);
        }
    }
}
