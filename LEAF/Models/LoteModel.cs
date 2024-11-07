using LEAF.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.Models
{
    public class LoteModel
    {
        private LoteDAO _loteDAO;

        public List<ItemLoteModel> ItensLote { get; set; } = new List<ItemLoteModel>();
        public string IdLote { get; set; }
        public string Estagio { get; set; }
        public ProdutoModel Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime? DataSemeadura { get; set; }
        public DateTime? DataCrescimento { get; set; }
        public DateTime? DataPlantio { get; set; }
        public DateTime? DataColheita { get; set; }
        public UsuarioModel Usuario { get; set; }

        public LoteModel()
        {
            _loteDAO = new LoteDAO();
            ItensLote = new List<ItemLoteModel>();
        }
        public LoteModel BuscarLotePorID(string idLote)
        {
            return _loteDAO.BuscarLotePorID(idLote);
        }
        public List<LoteModel> BuscarLotePorStatus(int parametroInformado)
        {
            return _loteDAO.BuscarLotePorStatus(parametroInformado);
        }
        public bool CadastrarLote(LoteModel lote)
        {
            return _loteDAO.CadastrarLote(lote);
        }
        public bool AvancarEstagio(string idLote)
        {
            return _loteDAO.AvancarEstagio(idLote);
        }
        public bool AlterarQuantidade(string idLote, int novaQtde)
        {
            return _loteDAO.AlterarQuantidade(idLote, novaQtde);
        }
    }
}
