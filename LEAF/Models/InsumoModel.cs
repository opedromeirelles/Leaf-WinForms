using LEAF.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.Models
{
    public class InsumoModel
    {
        private InsumoDAO _insumoDAO;
        public string Descricao { get; set; }
        public string UnidadeMedida { get; set; }
        public int IdInsumo { get; set; }
        public string CodBarras { get; set; }
        public decimal ValorUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }
        public PessoaModel Fornecedor { get; set; }
        public bool Status { get; set; }
        public InsumoModel()
        {
            _insumoDAO = new InsumoDAO();
        }
        public List<InsumoModel> SelecionarInsumos(string descricao)
        {
            return _insumoDAO.SelecionarInsumos(descricao);
        }
        public List<InsumoModel> ListarInsumos(string descricao, int status)
        {
            return _insumoDAO.ListarInsumos(descricao, status);
        }
    }    
}
