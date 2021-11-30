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

namespace _3A1LAURA26.Ui
{
    public partial class FrmUsuario : Form
    {

        UsuarioDto atributos = new UsuarioDto();
        UsuarioBll metodos = new UsuarioBll();

        public FrmUsuario()
        {
            InitializeComponent();

            dgvListar.DataSource = metodos.Listar(); // registro dos dados no data grid view
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkCrudDados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ui.FrmDados crudDados = new Ui.FrmDados(); // instância do formulário de dados
            crudDados.ShowDialog(); // leva para a tela do crud de dados
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            atributos.Cpf = txtCPF.Text; // atribuição dos valores
            atributos.Email = txtEmail.Text;
            atributos.Senha = txtSenha.Text;
            atributos.Nome = txtNome.Text;
            atributos.Telefone = int.Parse(txtTelefone.Text);

            metodos.Cadastrar(atributos);  // envio dos dados para o método de cadastrar

            MessageBox.Show("Dados cadastrados!"); // mensagem de sucesso

            txtCPF.Clear(); // clear das caixas de texto
            txtEmail.Clear();
            txtSenha.Clear();
            txtNome.Clear();
            txtTelefone.Clear();

            dgvListar.DataSource = metodos.Listar(); // registro dos dados no data grid view
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            atributos.Cpf = txtCPF.Text; // atribuição dos valores
            atributos.Email = txtEmail.Text;
            atributos.Senha = txtSenha.Text;
            atributos.Nome = txtNome.Text;
            atributos.Telefone = int.Parse(txtTelefone.Text);

            metodos.Alterar(atributos);  // envio dos dados para o método de alterar

            MessageBox.Show("Dados alterados!"); // mensagem de sucesso

            txtCPF.Clear(); // clear das caixas de texto
            txtEmail.Clear();
            txtSenha.Clear();
            txtNome.Clear();
            txtTelefone.Clear();

            dgvListar.DataSource = metodos.Listar(); // registro dos dados no data grid view
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            atributos.Cpf = txtCPF.Text; // atribuição dos valores

            metodos.Excluir(atributos);  // envio dos dados para o método de excluir

            MessageBox.Show("Dados excluídos!"); // mensagem de sucesso

            dgvListar.DataSource = metodos.Listar(); // registro dos dados no data grid view
        }

        private void dgvListar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCPF.Text = dgvListar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEmail.Text = dgvListar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSenha.Text = dgvListar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNome.Text = dgvListar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTelefone.Text = dgvListar.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
