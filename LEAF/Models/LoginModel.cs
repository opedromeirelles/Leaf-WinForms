using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LEAF.DAOs;



namespace LEAF.Models
{
    public class LoginModel
    {
        private LoginDAO _loginDAO;

        public LoginModel()
        {
            _loginDAO = new LoginDAO();
        }
        public bool autenticarUsuario(string usuario, string senha)
        {
            return _loginDAO.Login(usuario, senha);
        }
    }
}
