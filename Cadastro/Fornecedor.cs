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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            txtEmailAdd.Clear();
            txtEndAdd.Clear();
            txtNomeAdd.Clear();
            mtbCnpjAdd.Clear();
            mtbTelAdd.Clear();
        }

        private void btnCancelDel_Click(object sender, EventArgs e)
        {
            txtIdDel.Clear();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            txtEmailEdit.Clear();
            txtIdEdit.Clear();
            txtEndEdit.Clear();
            txtNomeEdit.Clear();
            mtbTelEdit.Clear();
            mtbCnpjEdit.Clear();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAdd.Text; // Nome do fornecedor
            string telefone = mtbTelAdd.Text; // Telefone do fornecedor
            string email = txtEmailAdd.Text; // Email do fornecedor
            string endereco = txtEndAdd.Text; // Endereço do fornecedor
            string cnpj = mtbCnpjAdd.Text; // CNPJ do fornecedor

            FornecedorController controller = new FornecedorController(dataGridView1); // DataGridView onde os dados serão exibidos
            controller.AdicionarFornecedor(nome, telefone, email, endereco, cnpj);

        }

        private void btnConfirmDel_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdDel.Text, out int id))
            {
                FornecedorController controller = new FornecedorController(dataGridView1);
                controller.DeletarFornecedor(id);
            }
            else
            {
                MessageBox.Show("ID inválido. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdEdit.Text, out int id))
            {
                string nome = txtNomeEdit.Text;
                string telefone = mtbTelEdit.Text;
                string email = txtEmailEdit.Text;
                string endereco = txtEndEdit.Text;
                string cnpj = mtbCnpjEdit.Text;

                FornecedorController controller = new FornecedorController(dataGridView1);
                controller.AtualizarFornecedor(id, nome, telefone, email, endereco, cnpj);
            }
            else
            {
                MessageBox.Show("ID inválido. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tABELADEFUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Fornecedor fornecedor = new Relatorios.Fornecedor();
            fornecedor.Show();
            this.Close();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
