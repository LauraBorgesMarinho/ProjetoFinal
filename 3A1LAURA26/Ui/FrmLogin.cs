using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3A1LAURA26.Code.DTO;
using _3A1LAURA26.Code.BLL;

namespace _3A1LAURA26
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        LoginDto atributos = new LoginDto();
        LoginBll metodos = new LoginBll();

        private void btnLogar_Click(object sender, EventArgs e)
        {
            atributos.Email = txtEmail.Text; // atribuição dos valores
            atributos.Cpf = txtCPF.Text;
            atributos.Senha = txtSenha.Text;

            if (metodos.Logar(atributos) == true) // envio dos dados para o método de Logar
            {
                Ui.FrmUsuario crudUsuario = new Ui.FrmUsuario(); // instância do formulário de usuário
                crudUsuario.ShowDialog(); // se os dados existirem no banco, leva para a tela do crud de usuário
            }
            else
            {
                MessageBox.Show("Email, cpf ou senha incorretos!!!"); // mensagem de erro
            }
        }
    }
}
