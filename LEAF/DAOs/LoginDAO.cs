using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEAF.Models;

namespace LEAF.DAOs
{
    public class LoginDAO : ConexaoDAO
    {
        public bool Login(string usuario, string senha)
        {
            string sqlString = "select idusuario, nome, id_dpto from USUARIO where login = @login and senha = @senha and status <> 0";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@login", SqlDbType.VarChar){Value = usuario},
                new SqlParameter("@senha", SqlDbType.VarChar){Value = senha}
            };
            
            using (SqlDataReader reader = executaConsulta(sqlString, parametros))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    SessaoUsuario.IdUsuario = (int)reader["idusuario"];
                    SessaoUsuario.Nome = reader["nome"].ToString();
                    SessaoUsuario.Departamento = (int)reader["id_dpto"];

                    return true;
                }
                else
                {
                    return false;
                }                
            }
        }
    }
}
