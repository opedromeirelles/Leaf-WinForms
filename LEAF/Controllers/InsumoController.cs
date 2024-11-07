using LEAF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.Controllers
{
    public class InsumoController
    {
        private InsumoModel _insumoModel;
        public InsumoController()
        {
            _insumoModel = new InsumoModel();
        }
        public DataTable SelecionarInsumos(string descricao)
        {
            List<InsumoModel> listaInsumo = _insumoModel.SelecionarInsumos(descricao);

            DataTable tabelaInsumo = new DataTable();

            tabelaInsumo.Columns.Add("ID", typeof(int));
            tabelaInsumo.Columns.Add("Descrição", typeof(string));
            tabelaInsumo.Columns.Add("Un. de medida", typeof(string));
            tabelaInsumo.Columns.Add("Qtde em estoque", typeof(int));

            foreach (var insumo in  listaInsumo)
            {
                DataRow row = tabelaInsumo.NewRow();

                row["Id"] = insumo.IdInsumo;
                row["Descrição"] = insumo.Descricao;
                row["Un. de medida"] = insumo.UnidadeMedida;
                row["Qtde em estoque"] = insumo.QuantidadeEstoque;

                tabelaInsumo.Rows.Add(row);
            }            
            return tabelaInsumo;
        }
        public DataTable ListarInsumos(string descricao, int status)
        {
            List<InsumoModel> listaInsumo = _insumoModel.ListarInsumos(descricao, status);

            DataTable tabelaInsumo = new DataTable();

            tabelaInsumo.Columns.Add("ID", typeof(int));
            tabelaInsumo.Columns.Add("Cod. de barras", typeof(string));
            tabelaInsumo.Columns.Add("Descrição", typeof(string));
            tabelaInsumo.Columns.Add("Un. de medida", typeof(string));
            tabelaInsumo.Columns.Add("Valor unitário", typeof(decimal));
            tabelaInsumo.Columns.Add("Qtde em estoque", typeof(int));
            tabelaInsumo.Columns.Add("Status", typeof(bool));
            tabelaInsumo.Columns.Add("Fornecedor", typeof(string));


            foreach (var insumo in listaInsumo)
            {
                DataRow row = tabelaInsumo.NewRow();

                row["Id"] = insumo.IdInsumo;
                row["Cod. de barras"] = insumo.CodBarras;
                row["Descrição"] = insumo.Descricao;
                row["Un. de medida"] = insumo.UnidadeMedida;
                row["Valor unitário"] = insumo.ValorUnitario;
                row["Qtde em estoque"] = insumo.QuantidadeEstoque;
                row["Status"] = insumo.Status;
                row["Fornecedor"] = insumo.Fornecedor.Nome;

                tabelaInsumo.Rows.Add(row);
            }
            return tabelaInsumo;
        }
    }
}
