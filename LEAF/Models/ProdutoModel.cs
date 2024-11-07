using LEAF.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.Models
{
    public class ProdutoModel
    {
        private ProdutoDAO _produtoDAO;
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }
        public bool Status { get; set; }
        public ProdutoModel()
        {
            _produtoDAO = new ProdutoDAO();
        }
        public List<ProdutoModel> SelecionarProdutos(string descricao)
        {
            return _produtoDAO.SelecionarProdutos(descricao);
        }
        public List<ProdutoModel> ListarProdutos(string descricao, int status)
        {
            return _produtoDAO.ListarProdutos(descricao, status);
        }
    }
}
