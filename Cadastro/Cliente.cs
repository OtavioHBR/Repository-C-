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

namespace Form_PIM.Cadastro
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            txtEmailAdd.Clear();
            txtNomeAdd.Clear();
            txtEndAdd.Clear();
            mtbCpfAdd.Clear();
            mtbTelAdd.Clear();
        }

        private void btnCancelDel_Click(object sender, EventArgs e)
        {
            mtbCpfDel.Clear();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            txtNomeEdit.Clear();
            txtEndEdit.Clear();
            txtEmailEdit.Clear();
            mtbCpfEdit.Clear();
            mtbTelEdit.Clear();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            string cpf = mtbCpfAdd.Text;
            string nome = txtNomeAdd.Text; // Campo Nome
            string telefone = mtbTelAdd.Text;
            string email = txtEmailAdd.Text;
            string endereco = txtEndAdd.Text;

            ClienteController controller = new ClienteController(dataGridView1);
            controller.AdicionarCliente(cpf, nome, telefone, email, endereco);

            MessageBox.Show("Cliente cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            string cpf = mtbCpfEdit.Text;
            string nome = txtNomeEdit.Text; // Campo Nome
            string telefone = mtbTelEdit.Text;
            string email = txtEmailEdit.Text;
            string endereco = txtEndEdit.Text;

            ClienteController controller = new ClienteController(dataGridView1);
            controller.AtualizarCliente(cpf, nome, telefone, email, endereco);

            MessageBox.Show("Cliente editado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfirmDel_Click(object sender, EventArgs e)
        {
            string cpf = mtbCpfDel.Text; // Supondo que o TextBox para CPF é chamado txtCpfDel

            ClienteController controller = new ClienteController(dataGridView1); // Supondo que o DataGridView é chamado dataGridView1
            controller.DeletarCliente(cpf);

        }

        private void tABELADEFUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Cliente cliente = new Relatorios.Cliente();
            cliente.Show();
            this.Close();
        }
    }
}
