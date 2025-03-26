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

namespace Form_PIM.Estoque
{
    public partial class EntradaEstoque : Form
    {
        public EntradaEstoque()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtQtd.Clear();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                ProdutoController controller = new ProdutoController(dataGridView1);
                var produto = controller.ObterProdutoPorId(id);

                if (produto != null)
                {
                    textBox1.Text = produto.NomeProduto;
                }
                else
                {
                    textBox1.Text = "Produto não encontrado";
                }
            }
            else
            {
                MessageBox.Show("ID inválido. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void tABELADEPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Produto produto = new Relatorios.Produto();
            produto.Show();
            this.Close();
        }

        private void cADASTRODEPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Produto produto = new Cadastro.Produto();
            produto.Show();
            this.Close();
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {

            if (int.TryParse(txtId.Text, out int id) && int.TryParse(txtQtd.Text, out int quantidade))
            {
                ProdutoController controller = new ProdutoController(dataGridView1);
                controller.AdicionarQuantidade(id, quantidade);
            }
            else
            {
                MessageBox.Show("ID ou quantidade inválidos. Por favor, insira números válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
