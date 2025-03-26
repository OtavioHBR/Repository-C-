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
    public partial class Produto : Form
    {
        ProdutoController controller;
        public Produto()
        {
            InitializeComponent();
            controller = new ProdutoController(dataGridView1);
            controller.AtualizarTabela();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.AtualizarTabela();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Produto produto = new Cadastro.Produto();
            produto.Show();
            this.Close();
        }

        private void eNTRADADEPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque.EntradaEstoque estoque = new Estoque.EntradaEstoque();
            estoque.Show();
            this.Close();
        }

        private void sAÍDADEPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque.SaidaEstoque saidaEstoque = new Estoque.SaidaEstoque();
            saidaEstoque.Show();
            this.Close();
        }
    }
}
