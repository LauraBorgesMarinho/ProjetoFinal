using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1LAURA26.Code.DTO
{
    class LoginDto
    {
        private string _email;
        private string _cpf;
        private string _senha;

        public string Email { get => _email; set => _email = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Senha { get => _senha; set => _senha = value; }
    }
}
