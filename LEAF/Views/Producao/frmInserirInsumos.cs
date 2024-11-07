using LEAF.Controllers;
using LEAF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAF.Views
{
    public partial class frmInserirInsumos : Form
    {
        public List<ItemLoteModel> ItensSelecionados { get; private set; }
        public frmInserirInsumos()
        {
            InitializeComponent();

            ItensSelecionados = new List<ItemLoteModel>();

            grdInsumosDisponiveis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdInsumosSelecionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void AtualizaGridInsumosDisponiveis()
        {
            InsumoController insumoController = new InsumoController();

            DataTable tabelaInsumosDisponiveis = insumoController.SelecionarInsumos(txtDescInsumo.Text);

            grdInsumosDisponiveis.DataSource = tabelaInsumosDisponiveis;

            FormataGridInsumosDisponiveis();
        }
        private void btnBuscarInsumos_Click(object sender, EventArgs e)
        {
            AtualizaGridInsumosDisponiveis();
        }
        private void btnAddInsumo_Click(object sender, EventArgs e)
        {
            AddInsumoSelecionado();
        }
        private void AddInsumoSelecionado()
        {
            if (grdInsumosDisponiveis.SelectedRows.Count > 0)
            {
                DataTable insumoSelecionado = AtualizaGridInsumosSelecionados();

                foreach (DataGridViewRow linhaSelecionada in grdInsumosDisponiveis.SelectedRows)
                {
                    int idInsumo = Convert.ToInt32(linhaSelecionada.Cells["ID"].Value);
                    string descricao = linhaSelecionada.Cells["Descrição"].Value.ToString();
                    string unidadeMedida = linhaSelecionada.Cells["Un. de Medida"].Value.ToString();
                    int quantidadeEmEstoque = Convert.ToInt32(linhaSelecionada.Cells["Qtde em Estoque"].Value);

                    DataRow[] insumosExistente = insumoSelecionado.Select($"ID = {idInsumo}");

                    if (insumosExistente.Length > 0)
                    {
                        // Se o insumo já existe, adiciona a quantidade
                        DataRow linhaExistente = insumosExistente[0];

                        int qtdeAdicionada = Convert.ToInt32(linhaExistente["Qtde Inserida"]);

                        // Validação se a quantidade adicionada ultrapassa o estoque
                        if (qtdeAdicionada + 1 > quantidadeEmEstoque)
                        {
                            MessageBox.Show($"Quantidade selecionada para o insumo '{descricao}' excede o estoque disponível.\n\nEstoque atual: {quantidadeEmEstoque}.",
                                            "Erro de Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            linhaExistente["Qtde Inserida"] = qtdeAdicionada + 1;
                        }
                    }

                    else
                    {
                        AddInsumoNaTabela(insumoSelecionado, idInsumo, descricao, unidadeMedida, 1);
                    }
                }
                grdInsumosSelecionados.DataSource = insumoSelecionado;
            }

            else
            {
                MessageBox.Show("Selecione ao menos um insumo da lista para inserir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private DataTable AtualizaGridInsumosSelecionados()
        {
            DataTable tabelaSelecionados;

            if (grdInsumosSelecionados.DataSource == null)
            {
                tabelaSelecionados = new DataTable();

                tabelaSelecionados.Columns.Add("ID", typeof(int));
                tabelaSelecionados.Columns.Add("Descrição", typeof(string));
                tabelaSelecionados.Columns.Add("Un. de Medida", typeof(string));
                tabelaSelecionados.Columns.Add("Qtde Inserida", typeof(int));

                grdInsumosSelecionados.DataSource = tabelaSelecionados;

                FormataGridInsumosSelecionados();
            }

            else
            {
                tabelaSelecionados = (DataTable)grdInsumosSelecionados.DataSource;
            }
            return tabelaSelecionados;
        }
        private void AddInsumoNaTabela(DataTable tabela, int idInsumo, string descricao, string unidadeMedida, int quantidade)
        {
            DataRow novoInsumo = tabela.NewRow();

            novoInsumo["ID"] = idInsumo;
            novoInsumo["Descrição"] = descricao;
            novoInsumo["Un. de Medida"] = unidadeMedida;
            novoInsumo["Qtde Inserida"] = 1;

            tabela.Rows.Add(novoInsumo);
        }
        private void FormataGridInsumosDisponiveis()
        {
            grdInsumosDisponiveis.RowHeadersVisible = false;

            grdInsumosDisponiveis.Columns["ID"].Width = 30;
            grdInsumosDisponiveis.Columns["Descrição"].Width = 312;
            grdInsumosDisponiveis.Columns["Un. de Medida"].Width = 60;
            grdInsumosDisponiveis.Columns["Qtde em Estoque"].Width = 70;
        }
        private void FormataGridInsumosSelecionados()
        {
            grdInsumosSelecionados.RowHeadersVisible = false;

            grdInsumosSelecionados.Columns["ID"].Width = 30;
            grdInsumosSelecionados.Columns["Descrição"].Width = 312;
            grdInsumosSelecionados.Columns["Un. de Medida"].Width = 60;
            grdInsumosSelecionados.Columns["Qtde Inserida"].Width = 70;
        }
        private void RemoveInsumoSelecionado()
        {
            if (grdInsumosSelecionados.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow linhaSelecionada in grdInsumosSelecionados.SelectedRows)
                {
                    grdInsumosSelecionados.Rows.Remove(linhaSelecionada);
                }
            }

            else
            {
                MessageBox.Show("Selecione ao menos um insumo da lista para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnRemoveInsumo_Click(object sender, EventArgs e)
        {
            RemoveInsumoSelecionado();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show("Confirma insumos utilizados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                List<ItemLoteModel> listaItensLote = new List<ItemLoteModel>();

                if (grdInsumosSelecionados.Rows.Count > 0)
                {
                    ItensSelecionados.Clear();

                    foreach (DataGridViewRow linha in grdInsumosSelecionados.Rows)
                    {
                        if (linha.Cells["ID"].Value != null)
                        {
                            int idInsumo = Convert.ToInt32(linha.Cells["ID"].Value);
                            string descricao = linha.Cells["Descrição"].Value.ToString();
                            string unidadeMedida = linha.Cells["Un. de Medida"].Value.ToString();
                            int qtdeAdicionada = Convert.ToInt32(linha.Cells["Qtde Inserida"].Value);

                            ItemLoteModel itemExistente = listaItensLote.FirstOrDefault(item => item.IdInsumo == idInsumo);

                            if (itemExistente != null)
                            {
                                itemExistente.Quantidade += 1;
                            }

                            else
                            {
                                ItemLoteModel itemLote = new ItemLoteModel
                                {
                                    IdInsumo = idInsumo,
                                    Quantidade = qtdeAdicionada,
                                    Insumo = new InsumoModel
                                    {
                                        IdInsumo = idInsumo,
                                        Descricao = descricao,
                                        UnidadeMedida = unidadeMedida
                                    }
                                };
                                listaItensLote.Add(itemLote);
                            }
                        }
                    }
                    ItensSelecionados.AddRange(listaItensLote);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Nenhum insumo selecionado para salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
