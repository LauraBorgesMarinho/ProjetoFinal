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
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkCrudDados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ui.FrmDados crudDados = new Ui.FrmDados(); // instância do formulário de dados
            crudDados.ShowDialog(); // leva para a tela do crud de dados
        }
    }
}
