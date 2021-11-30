using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1LAURA26.Code.DTO
{
    class UsuarioDto
    {
        private string _cpf;
        private string _email;
        private string _senha;
        private string _nome;
        private int _telefone;

        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int Telefone { get => _telefone; set => _telefone = value; }
    }
}
