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
    class DadosBll
    {
        AcessoBancoDados conectar = new AcessoBancoDados(); // instância da conexão com o banco

        string tabela = "tbl_dados"; // tabela que vai ser usada

        public DataTable Listar() // método de listar os dados do banco
        {
            string sql = $"select * from {tabela};"; // comando para retornar os dados
            return conectar.ExecutarConsulta(sql);
        }

        public void Cadastrar(DadosDto atributo) // método de cadastrar os dados no banco
        {
            string inserir = $"insert into {tabela} value(null,'{atributo.Lbm}','{atributo.L5}','{atributo.M3}')"; // comando para inserir os dados
            conectar.ExecutarComando(inserir);
        }
        public void Alterar(DadosDto atributo) // método de alterar os dados do banco
        {
            string alterar = $"update {tabela} set lbm = '{atributo.Lbm}', l5 = '{atributo.L5}', m3 = '{atributo.M3}' where id = '{atributo.Id}';"; // comando para alterar os dados
            conectar.ExecutarComando(alterar);
        }
        public void Excluir(DadosDto atributo) // método de excluir os dados do banco
        {
            string excluir = $"delete from {tabela} where id = '{atributo.Id}';";// comando para excluir os dados
            conectar.ExecutarComando(excluir);
        }
    }
}
