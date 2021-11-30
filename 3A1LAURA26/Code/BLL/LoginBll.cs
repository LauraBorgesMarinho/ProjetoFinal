using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using _3A1LAURA26.Code.DTO;
using _3A1LAURA26.Code.DAL;

namespace _3A1LAURA26.Code.BLL
{
    class LoginBll
    {
        AcessoBancoDados conectar = new AcessoBancoDados(); // instância da conexão com o banco

        string tabela = "tbl_usuario"; // tabela que vai ser usada

        public bool Logar(LoginDto atributo) // método para verificar se os dados inseridos existem no banco
        {
            string sql = $"select * from {tabela} where cpf = '{atributo.Cpf}' and email = '{atributo.Email}' and senha = '{atributo.Senha}';"; // select que será feito no banco
            
            DataTable dt = conectar.ExecutarConsulta(sql); // envio do o comando
            
            if (dt.Rows.Count > 0) // teste do retorno de linhas do select
            {
                return true; // se obteve resultados o método retorna verdadeiro
            }
            else
            {
                return false; // se não o método retorna falso
            }
        }
    }
}
