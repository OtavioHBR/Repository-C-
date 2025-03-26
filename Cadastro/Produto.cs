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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            txtIdFornAdd.Clear();
            txtNomeAdd.Clear();
            mtbValCompAdd.Clear();
            mtbValVendaAdd.Clear();
        }

        private void btnCancelDel_Click(object sender, EventArgs e)
        {
            txtIdDel.Clear();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            txtIdEdit.Clear();
            txtIdFornEdit.Clear();
            txtNomeEdit.Clear();
            mtbValVendaEdit.Clear();
            mtbValCompEdit.Clear();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtNomeAdd.Text;
            int idFornecedor;
            decimal valorCompra;
            decimal valorVenda;

            // Verificar e converter ID do Fornecedor
            if (!int.TryParse(txtIdFornAdd.Text, out idFornecedor))
            {
                MessageBox.Show("ID do Fornecedor inválido. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Remover prefixo de moeda e converter valor de compra
            string valorCompraString = mtbValCompAdd.Text.Replace("R$", "").Trim();
            if (!decimal.TryParse(valorCompraString, out valorCompra))
            {
                MessageBox.Show("Valor de Compra inválido. Por favor, insira um número decimal válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Remover prefixo de moeda e converter valor de venda
            string valorVendaString = mtbValVendaAdd.Text.Replace("R$", "").Trim();
            if (!decimal.TryParse(valorVendaString, out valorVenda))
            {
                MessageBox.Show("Valor de Venda inválido. Por favor, insira um número decimal válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProdutoController controller = new ProdutoController(dataGridView1);
            controller.AdicionarProduto(nomeProduto, idFornecedor, valorCompra, valorVenda);
        }


        private void btnConfirmDel_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdDel.Text, out int id);
            ProdutoController controller = new ProdutoController(dataGridView1);
            controller.DeletarProduto(id);
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdEdit.Text, out int id))
            {
                string nomeProduto = txtNomeEdit.Text;
                int idFornecedor;
                decimal valorCompra;
                decimal valorVenda;

                // Verificar e converter ID do Fornecedor
                if (!int.TryParse(txtIdFornEdit.Text, out idFornecedor))
                {
                    MessageBox.Show("ID do Fornecedor inválido. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Remover prefixo de moeda e converter valor de compra
                string valorCompraString = mtbValCompEdit.Text.Replace("R$", "").Trim();
                if (!decimal.TryParse(valorCompraString, out valorCompra))
                {
                    MessageBox.Show("Valor de Compra inválido. Por favor, insira um número decimal válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Remover prefixo de moeda e converter valor de venda
                string valorVendaString = mtbValVendaEdit.Text.Replace("R$", "").Trim();
                if (!decimal.TryParse(valorVendaString, out valorVenda))
                {
                    MessageBox.Show("Valor de Venda inválido. Por favor, insira um número decimal válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProdutoController controller = new ProdutoController(dataGridView1);
                controller.AtualizarProduto(id, nomeProduto, idFornecedor, valorCompra, valorVenda);

                MessageBox.Show("Produto atualizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID inválido. Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tABELADEFUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Produto produto = new Relatorios.Produto();
            produto.Show();
            this.Close();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
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
