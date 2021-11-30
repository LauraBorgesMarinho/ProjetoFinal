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
    class UsuarioBll
    {
        AcessoBancoDados conectar = new AcessoBancoDados(); // instância da conexão com o banco

        string tabela = "tbl_usuario"; // tabela que vai ser usada

        public DataTable Listar() // método de listar os dados do banco
        {
            string sql = $"select * from {tabela};"; // comando para retornar os dados
            return conectar.ExecutarConsulta(sql);
        }

        public void Cadastrar(UsuarioDto atributo) // método de cadastrar os dados no banco
        {
            string inserir = $"insert into {tabela} value('{atributo.Cpf}','{atributo.Email}','{atributo.Senha}','{atributo.Nome}','{atributo.Telefone}')"; // comando para inserir os dados
            conectar.ExecutarComando(inserir);
        }
        public void Alterar(UsuarioDto atributo) // método de alterar os dados do banco
        {
            string alterar = $"update {tabela} set email = '{atributo.Email}', senha = '{atributo.Senha}', nome = '{atributo.Nome}', telefone = '{atributo.Telefone}' where cpf = '{atributo.Cpf}';"; // comando para alterar os dados
            conectar.ExecutarComando(alterar);
        }
        public void Excluir(UsuarioDto atributo) // método de excluir os dados do banco
        {
            string excluir = $"delete from {tabela} where cpf = '{atributo.Cpf}';";// comando para excluir os dados
            conectar.ExecutarComando(excluir);
        }
    }
}
