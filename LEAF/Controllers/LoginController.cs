using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEAF.DAOs;
using LEAF.Models;

namespace LEAF.Controllers
{
    public class LoginController
    {
        private LoginModel _loginModel;
        
        public LoginController()
        {
            _loginModel = new LoginModel();
        }
        public bool autenticarUsuario(string usuario, string senha)
        {
            return _loginModel.autenticarUsuario(usuario, senha);
        }
        
    }
}
