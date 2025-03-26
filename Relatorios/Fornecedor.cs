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

namespace Form_PIM.Relatorios
{
    public partial class Fornecedor : Form
    {
        FornecedorController controller;
        public Fornecedor()
        {
            InitializeComponent();
            controller = new FornecedorController(dataGridView1);
            controller.AtualizarTabela();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Fornecedor fornecedor = new Cadastro.Fornecedor();
            fornecedor.Show();
            this.Close();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.AtualizarTabela();
        }
    }
}
