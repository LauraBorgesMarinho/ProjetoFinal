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
    public partial class FrmDados : Form
    {

        DadosDto atributos = new DadosDto();
        DadosBll metodos = new DadosBll();

        public FrmDados()
        {
            InitializeComponent();

            dgvListar.DataSource = metodos.Listar(); // registro dos dados no data grid view
        }

        private void linkCrudUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ui.FrmUsuario crudUsuario = new Ui.FrmUsuario(); // instância do formulário de usuário
            crudUsuario.ShowDialog(); // leva para a tela do crud de usuário
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            atributos.Lbm = txtLBM.Text; // atribuição dos valores
            atributos.L5 = txtL5.Text;
            atributos.M3 = txtM3.Text;

            metodos.Cadastrar(atributos);  // envio dos dados para o método de cadastrar

            MessageBox.Show("Dados cadastrados!"); // mensagem de sucesso

            txtLBM.Clear(); // clear das caixas de texto
            txtL5.Clear();
            txtM3.Clear();

            dgvListar.DataSource = metodos.Listar(); // registro dos dados no data grid view
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            atributos.Id = int.Parse(txtId.Text); // atribuição dos valores
            atributos.Lbm = txtLBM.Text;
            atributos.L5 = txtL5.Text;
            atributos.M3 = txtM3.Text;

            metodos.Alterar(atributos);  // envio dos dados para o método de alterar

            MessageBox.Show("Dados alterados!"); // mensagem de sucesso

            txtId.Clear(); // clear das caixas de texto
            txtLBM.Clear();
            txtL5.Clear();
            txtM3.Clear();

            dgvListar.DataSource = metodos.Listar(); // registro dos dados no data grid view
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            atributos.Id = int.Parse(txtId.Text); // atribuição dos valores

            metodos.Excluir(atributos);  // envio dos dados para o método de excluir

            MessageBox.Show("Dados excluídos!"); // mensagem de sucesso

            dgvListar.DataSource = metodos.Listar(); // registro dos dados no data grid view
        }

        private void dgvListar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLBM.Text = dgvListar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtL5.Text = dgvListar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtM3.Text = dgvListar.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
