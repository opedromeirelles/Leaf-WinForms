using LEAF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.Controllers
{
    public class ProdutoController
    {
        private ProdutoModel _produtoModel;

        public ProdutoController()
        {
            _produtoModel = new ProdutoModel();
        }
        public DataTable SelecionarProdutos(string descricao)
        {
            List<ProdutoModel> listaProdutos = _produtoModel.SelecionarProdutos(descricao);

            DataTable tabelaProdutos = new DataTable();

            tabelaProdutos.Columns.Add("ID", typeof(string));
            tabelaProdutos.Columns.Add("Descrição", typeof(string));
            tabelaProdutos.Columns.Add("Valor Unitário", typeof(decimal));
            tabelaProdutos.Columns.Add("Qtde em estoque", typeof(Int32));

            foreach(var  produto in listaProdutos)
            {
                DataRow row = tabelaProdutos.NewRow();

                row["ID"] = produto.IdProduto;
                row["Descrição"] = produto.Descricao;
                row["Valor Unitário"] = produto.ValorUnitario;
                row["Qtde em estoque"] = produto.QuantidadeEstoque;

                tabelaProdutos.Rows.Add(row);
            }
            return tabelaProdutos;
        }
        public DataTable ListarProdutos(string descricao, int status)
        {
            List<ProdutoModel> listaProdutos = _produtoModel.ListarProdutos(descricao, status);

            DataTable tabelaProdutos = new DataTable();

            tabelaProdutos.Columns.Add("IdProduto", typeof(string));
            tabelaProdutos.Columns.Add("Descricao", typeof(string));
            tabelaProdutos.Columns.Add("ValorUnitario", typeof(decimal));
            tabelaProdutos.Columns.Add("QuantidadeEstoque", typeof(Int32));
            tabelaProdutos.Columns.Add("Status", typeof(bool));

            foreach (var produto in listaProdutos)
            {
                DataRow row = tabelaProdutos.NewRow();

                row["IdProduto"] = produto.IdProduto;
                row["Descricao"] = produto.Descricao;
                row["ValorUnitario"] = produto.ValorUnitario;
                row["QuantidadeEstoque"] = produto.QuantidadeEstoque;
                row["status"] = produto.Status;

                tabelaProdutos.Rows.Add(row);
            }
            return tabelaProdutos;
        }
    }
}
