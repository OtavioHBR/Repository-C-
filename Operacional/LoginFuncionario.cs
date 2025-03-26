using Form_PIM.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_PIM.Operacional
{
    public partial class LoginFuncionario : Form
    {

        LoginFuncionarioController loginFuncionarioController;
        public LoginFuncionario()
        {
            InitializeComponent();
            loginFuncionarioController = new LoginFuncionarioController(dataGridView1);
            loginFuncionarioController.AtualizarTabela();
        }

        private void gpAdd_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            txtIdFuncAdd.Clear();
            txtSenhaAdd.Clear();
        }

        private void btnCancelDel_Click(object sender, EventArgs e)
        {
            txtIdDel.Clear();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            txtIdFuncEdit.Clear();
            txtSenhaEdit.Clear();
            txtIdLoginEdit.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loginFuncionarioController = new LoginFuncionarioController(dataGridView1);
            loginFuncionarioController.AtualizarTabela();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            string idFunc = txtIdFuncAdd.Text;
            string senhaFunc = txtSenhaAdd.Text;

            loginFuncionarioController.AdicionarLoginFuncionario(idFunc, senhaFunc);
        }

        private void btnConfirmDel_Click(object sender, EventArgs e)
        {
            string idExcluir = txtIdDel.Text;
            loginFuncionarioController.DeletarLoginFuncionario(idExcluir);
        }


        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            string idEditar = txtIdLoginEdit.Text;
            string loginFuncEditar = txtIdFuncEdit.Text;
            string senhaFuncEditar = txtSenhaEdit.Text;

            loginFuncionarioController.AtualizarLoginFuncionario(idEditar, loginFuncEditar, senhaFuncEditar);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
