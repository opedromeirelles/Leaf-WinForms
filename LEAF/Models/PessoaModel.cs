using LEAF.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAF.Models
{
    public class PessoaModel
    {
        private PessoaDAO _pessoaDAO;
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string Telefone1{ get; set; }
        public string Telefone2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }

        public PessoaModel()
        {
            _pessoaDAO = new PessoaDAO();
        }
        public bool CadastrarPessoa(PessoaModel pessoa)
        {
            return _pessoaDAO.CadastrarAgente(pessoa);
        }
        public bool EditarPessoa (PessoaModel pessoa)
        {
            return _pessoaDAO.EditarAgente(pessoa);
        }
        public List<PessoaModel> BuscarPessoa(string parametroSelecionado, string parametroInformado)
        {
            return _pessoaDAO.BuscarAgente(parametroSelecionado, parametroInformado);
        }
    }
}
