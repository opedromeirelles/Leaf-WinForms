using LEAF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.Controllers
{
    public class PessoaController
    {
        private PessoaModel _pessoaModel;
        public PessoaController()
        {
            _pessoaModel = new PessoaModel();
        }
        public bool CadastrarPessoa(string nome, string tipoPessoa, string cpf, string cnpj, string telefone1, string telefone2, string email1, string email2)
        {
            _pessoaModel.Nome = nome;
            _pessoaModel.Tipo = tipoPessoa;
            _pessoaModel.CPF = cpf;
            _pessoaModel.CNPJ = cnpj;
            _pessoaModel.Telefone1 = telefone1;
            _pessoaModel.Telefone2 = telefone2;
            _pessoaModel.Email1 = email1;
            _pessoaModel.Email2 = email2;

            return _pessoaModel.CadastrarPessoa(_pessoaModel);
        }
        public bool EditarPessoa(int id, string nome, string tipoPessoa, string cpf, string cnpj, string telefone1, string telefone2, string email1, string email2)
        {
            _pessoaModel.IdPessoa = id;
            _pessoaModel.Nome = nome;
            _pessoaModel.Tipo = tipoPessoa;
            _pessoaModel.CPF = cpf;
            _pessoaModel.CNPJ = cnpj;
            _pessoaModel.Telefone1 = telefone1;
            _pessoaModel.Telefone2 = telefone2;
            _pessoaModel.Email1 = email1;
            _pessoaModel.Email2 = email2;

            return _pessoaModel.EditarPessoa(_pessoaModel);
        }
        public DataTable BuscarPessoa(string parametroSelecionado, string parametroInformado)
        {
            List<PessoaModel> listaPessoa = _pessoaModel.BuscarPessoa(parametroSelecionado, parametroInformado);

            // Monta o DataTable a partir da lista da PessoaModel
            DataTable tabelaAgente = new DataTable();

            tabelaAgente.Columns.Add("IdPessoa", typeof(int));
            tabelaAgente.Columns.Add("Nome", typeof(string));
            tabelaAgente.Columns.Add("CPF", typeof(string));
            tabelaAgente.Columns.Add("CNPJ", typeof(string));
            tabelaAgente.Columns.Add("TipoPessoa", typeof(string));
            tabelaAgente.Columns.Add("Telefone1", typeof(string));
            tabelaAgente.Columns.Add("Telefone2", typeof(string));
            tabelaAgente.Columns.Add("Email1", typeof(string));
            tabelaAgente.Columns.Add("Email2", typeof(string));

            foreach (var pessoa in listaPessoa)
            {
                DataRow row = tabelaAgente.NewRow();

                row["IdPessoa"] = pessoa.IdPessoa;
                row["Nome"] = pessoa.Nome;
                row["CPF"] = pessoa.CPF;
                row["CNPJ"] = pessoa.CNPJ;
                row["TipoPessoa"] = pessoa.Tipo;
                row["Telefone1"] = pessoa.Telefone1;
                row["Telefone2"] = pessoa.Telefone2;
                row["Email1"] = pessoa.Email1;
                row["Email2"] = pessoa.Email2;

                tabelaAgente.Rows.Add(row);
            }
            return tabelaAgente;
        }

    }
}
