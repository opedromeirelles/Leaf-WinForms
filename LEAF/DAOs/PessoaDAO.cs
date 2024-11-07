using LEAF.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAF.DAOs
{
    public class PessoaDAO : ConexaoDAO
    {
        public bool VerificaCPF(PessoaModel pessoa)
        {
            int validaID = 0; //Necessário este validador para casos em que o CPF do agente não é alterado

            string validaCPF = string.Empty;

            string sqlString = "select * from pessoa where cpf = @cpf";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@cpf", pessoa.CPF)
            };

            using (SqlDataReader reader = executaConsulta(sqlString, parametros))
            {
                if (reader.Read())
                {
                    validaID = Convert.ToInt32(reader["idpessoa"]);
                    validaCPF = Convert.ToString(reader["cpf"]);
                }
            }

            if (validaCPF == pessoa.CPF && validaID != pessoa.IdPessoa)
            {
                MessageBox.Show("Já existe um cadastro com este CPF.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        public bool VerificaCNPJ(PessoaModel pessoa)
        {
            int validaID = 0; //Necessário este validador para casos em que o CNPJ do agente não é alterado

            string validaCNPJ = string.Empty;

            string sqlString = "select * from pessoa where cnpj = @cnpj";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@cnpj", pessoa.CNPJ)
            };

            using (SqlDataReader reader = executaConsulta(sqlString, parametros))
            {
                if (reader.Read())
                {
                    validaID = Convert.ToInt32(reader["idpessoa"]);
                    validaCNPJ = Convert.ToString(reader["cnpj"]);
                }
            }

            if (validaCNPJ == pessoa.CNPJ && validaID != pessoa.IdPessoa)
            {
                MessageBox.Show("Já existe um cadastro com este CNPJ.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        public bool VerificaRegistroDuplicado(PessoaModel pessoa)
        {
            if (pessoa.CPF != "")
            {
                bool verificacaoCPF = VerificaCPF(pessoa);

                if (verificacaoCPF == true) return true;
            }

            if (pessoa.CNPJ != "")
            {
                bool verificacaoCNPJ = VerificaCNPJ(pessoa);

                if (verificacaoCNPJ == true) return true;
            }
            return false; ;
        }
        public bool CadastrarAgente(PessoaModel pessoa)
        {
            bool verificacao = VerificaRegistroDuplicado(pessoa);

            if (verificacao == true) return false; // Se a validar que já existe um cadastro com o mesmo CPF/CNPJ, retorna false 

            string sqlString = @"INSERT INTO PESSOA
                                    (nome, tipo, cpf, cnpj, telefone1, telefone2, email1, email2)
                                VALUES
                                    (@nome, @tipo, @cpf, @cnpj, @telefone1, @telefone2, @email1, @email2)";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@nome", pessoa.Nome),
                new SqlParameter("@tipo", pessoa.Tipo),
                new SqlParameter("@cpf", pessoa.CPF),
                new SqlParameter("@cnpj", pessoa.CNPJ),
                new SqlParameter("@telefone1", pessoa.Telefone1),
                new SqlParameter("@telefone2", pessoa.Telefone2),
                new SqlParameter("@email1", pessoa.Email1),
                new SqlParameter("@email2", pessoa.Email2),
            };

            try
            {
                executaSQL(sqlString, parametros);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditarAgente(PessoaModel pessoa)
        {
            bool verificacao = VerificaRegistroDuplicado(pessoa);

            if (verificacao == true) return false;

            string sqlString = @"UPDATE PESSOA SET 
                                    nome = @nome, 
                                    tipo = @tipo, 
                                    cpf = @cpf, 
                                    cnpj = @cnpj, 
                                    telefone1 = @telefone1, 
                                    telefone2 = @telefone2, 
                                    email1 = @email1, 
                                    email2 = @email2 
                                WHERE 
                                    idpessoa = @idpessoa";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@idpessoa", pessoa.IdPessoa),
                new SqlParameter("@nome", pessoa.Nome),
                new SqlParameter("@tipo", pessoa.Tipo),
                new SqlParameter("@cpf", pessoa.CPF),
                new SqlParameter("@cnpj", pessoa.CNPJ),
                new SqlParameter("@telefone1", pessoa.Telefone1),
                new SqlParameter("@telefone2", pessoa.Telefone2),
                new SqlParameter("@email1", pessoa.Email1),
                new SqlParameter("@email2", pessoa.Email2)
            };

            try
            {
                executaSQL(sqlString, parametros);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<PessoaModel> BuscarAgente(string parametroSelecionado, string parametroInformado)
        {
            List<PessoaModel> listaPessoa = new List<PessoaModel>();

            // Aqui tive que concatenar o parâmetro selecionado para que não fosse utilizado apóstrofos na query "...where 'Nome' like..."
            string sqlString = $"select * from PESSOA where {parametroSelecionado} like @parametroInformado";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                // Aqui tive que utilizar essa formatação para que a query não ficasse "... where nome like '%'parametroSelecionado'%'"
                new SqlParameter("@parametroInformado", "%" + parametroInformado + "%")
            };

            using (SqlDataReader reader = executaConsulta(sqlString, parametros))
            {
                while (reader.Read())
                {
                    PessoaModel pessoa = new PessoaModel();

                    pessoa.IdPessoa = Convert.ToInt32(reader["idpessoa"]);
                    pessoa.Nome = Convert.ToString(reader["nome"]);
                    pessoa.Tipo = Convert.ToString(reader["tipo"]);
                    pessoa.CPF = Convert.ToString(reader["cpf"]);
                    pessoa.CNPJ = Convert.ToString(reader["cnpj"]);
                    pessoa.Telefone1 = Convert.ToString(reader["telefone1"]);
                    pessoa.Telefone2 = Convert.ToString(reader["telefone2"]);
                    pessoa.Email1 = Convert.ToString(reader["email1"]);
                    pessoa.Email2 = Convert.ToString(reader["email2"]);

                    listaPessoa.Add(pessoa);
                }
            }
            return listaPessoa;
        }
    }
}
