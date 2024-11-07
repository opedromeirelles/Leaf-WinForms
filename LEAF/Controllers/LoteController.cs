using LEAF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAF.Controllers
{
    public class LoteController
    {
        private LoteModel _loteModel;
        public List<LoteModel> ListaLotes { get; set; } = new List<LoteModel>();
        public LoteController()
        {
            _loteModel = new LoteModel();
            ListaLotes = new List<LoteModel>();
        }
        public DataTable BuscarLotePorID(string idlote)
        {
            LoteModel lote = _loteModel.BuscarLotePorID(idlote);

            if (lote == null) { return null;}

            else
            {
                // Monta o DataTable a partir da lista de LoteModel
                DataTable tabelaLote = new DataTable();

                tabelaLote.Columns.Add("IdLote", typeof(string));
                tabelaLote.Columns.Add("Estagio", typeof (string));
                tabelaLote.Columns.Add("Produto", typeof (string));
                tabelaLote.Columns.Add("Quantidade", typeof(int));
                tabelaLote.Columns.Add("DataSemeadura", typeof(DateTime));
                tabelaLote.Columns.Add("DataCrescimento", typeof(DateTime));
                tabelaLote.Columns.Add("DataPlantio", typeof(DateTime));
                tabelaLote.Columns.Add("DataColheita", typeof(DateTime));
                tabelaLote.Columns.Add("Usuario", typeof(string));

                DataRow row = tabelaLote.NewRow();

                row["IdLote"] = lote.IdLote;
                row["Estagio"] = lote.Estagio;
                row["Produto"] = lote.Produto.Descricao;
                row["Quantidade"] = lote.Quantidade;
                row["DataSemeadura"] = lote.DataSemeadura.HasValue ? (object)lote.DataSemeadura.Value : DBNull.Value;
                row["DataCrescimento"] = lote.DataCrescimento.HasValue ? (object)lote.DataCrescimento.Value : DBNull.Value;
                row["DataPlantio"] = lote.DataPlantio.HasValue ? (object)lote.DataPlantio.Value : DBNull.Value;
                row["DataColheita"] = lote.DataColheita.HasValue ? (object)lote.DataColheita.Value : DBNull.Value;
                                                                        //Configurando as datas assim para aceitar valores nulos
                row["Usuario"] = lote.Usuario.Login;

                tabelaLote.Rows.Add(row);            

                return tabelaLote;
            }
        }
        public DataTable BuscarLotePorStatus(int parametroInformado)
        {
            List<LoteModel> listaLote = _loteModel.BuscarLotePorStatus(parametroInformado);

            DataTable tabelaLote = new DataTable();

            tabelaLote.Columns.Add("IdLote", typeof(string));
            tabelaLote.Columns.Add("Estagio", typeof(string));
            tabelaLote.Columns.Add("Produto", typeof(string));
            tabelaLote.Columns.Add("Quantidade", typeof(int));
            tabelaLote.Columns.Add("DataSemeadura", typeof(DateTime));
            tabelaLote.Columns.Add("DataCrescimento", typeof(DateTime));
            tabelaLote.Columns.Add("DataPlantio", typeof(DateTime));
            tabelaLote.Columns.Add("DataColheita", typeof(DateTime));
            tabelaLote.Columns.Add("Usuario", typeof(string));

            foreach (var lote in listaLote)
            {
                DataRow row = tabelaLote.NewRow();

                row["IdLote"] = lote.IdLote;
                row["Estagio"] = lote.Estagio;
                row["Produto"] = lote.Produto.Descricao;
                row["Quantidade"] = lote.Quantidade;
                row["DataSemeadura"] = lote.DataSemeadura.HasValue ? (object)lote.DataSemeadura.Value : DBNull.Value;
                row["DataCrescimento"] = lote.DataCrescimento.HasValue ? (object)lote.DataCrescimento.Value : DBNull.Value;
                row["DataPlantio"] = lote.DataPlantio.HasValue ? (object)lote.DataPlantio.Value : DBNull.Value;
                row["DataColheita"] = lote.DataColheita.HasValue ? (object)lote.DataColheita.Value : DBNull.Value;
                                                                //Configurando as datas assim para aceitar valores nulos
                row["Usuario"] = lote.Usuario.Login;

                tabelaLote.Rows.Add(row);
            }
            return tabelaLote;
        }
        public bool CadastrarLote(string idLote, int idProduto, int qtde, List<ItemLoteModel> itensLote)
        {
            LoteModel loteModel = new LoteModel
            {
                IdLote = idLote,
                Quantidade = qtde,
                Produto = new ProdutoModel
                {
                    IdProduto = idProduto
                },
                ItensLote = itensLote
            };

            return loteModel.CadastrarLote(loteModel);
        }
        public bool AvancarEstagio(string idLote)
        {
            return _loteModel.AvancarEstagio(idLote);
        }
        public bool AlterarQuantidadeLote(string idLote, int novaQtde)
        {
           return _loteModel.AlterarQuantidade(idLote, novaQtde);
        }
    }
}
