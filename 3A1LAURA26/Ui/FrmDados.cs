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
        public FrmDados()
        {
            InitializeComponent();
        }

        private void linkCrudUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ui.FrmUsuario crudUsuario = new Ui.FrmUsuario(); // instância do formulário de usuário
            crudUsuario.ShowDialog(); // leva para a tela do crud de usuário
        }
    }
}
