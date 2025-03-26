using Form_PIM.Model;
using Form_PIM.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Form_PIM.Controller
{
    public class ProdutoController
    {
        private ProdutoRepository repository;
        private DataGridView tabela;

        public ProdutoController(DataGridView tabela)
        {
            this.repository = new ProdutoRepository();
            this.tabela = tabela;
        }

        public void AdicionarProduto(string nomeProduto, int idFornecedor, decimal valorCompra, decimal valorVenda)
        {
            if (string.IsNullOrEmpty(nomeProduto) || idFornecedor <= 0 || valorCompra < 0 || valorVenda < 0)
            {
                MessageBox.Show("Um ou mais campos não foram fornecidos corretamente.");
                return;
            }

            Produto produto = new Produto
            {
                NomeProduto = nomeProduto,
                IdFornecedor = idFornecedor,
                Quantidade = 0, // Quantidade definida como 0
                ValorCompra = valorCompra,
                ValorVenda = valorVenda
            };

            try
            {
                repository.Adicionar(produto);
                AtualizarTabela();
                MessageBox.Show("Produto cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AtualizarProduto(int id, string nomeProduto, int idFornecedor, decimal valorCompra, decimal valorVenda)
        {
            if (id <= 0 || string.IsNullOrEmpty(nomeProduto) || idFornecedor <= 0 || valorCompra < 0 || valorVenda < 0)
            {
                MessageBox.Show("Um ou mais campos não foram fornecidos corretamente.");
                return;
            }

            Produto produto = new Produto
            {
                IdProduto = id,
                NomeProduto = nomeProduto,
                IdFornecedor = idFornecedor,
                ValorCompra = valorCompra,
                ValorVenda = valorVenda
            };

            try
            {
                repository.Atualizar(produto);
                AtualizarTabela();
                MessageBox.Show("Produto atualizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeletarProduto(int id)
        {
            if (id <= 0)
            {
                MessageBox.Show("O ID de exclusão não foi fornecido corretamente.");
                return;
            }

            var produto = repository.ObterProdutoPorId(id);
            if (produto == null)
            {
                MessageBox.Show("Produto com o ID fornecido não encontrado.");
                return;
            }

            DialogResult result = MessageBox.Show("Tem certeza de que deseja deletar o produto?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                repository.Deletar(id);
                AtualizarTabela();
                MessageBox.Show("Produto deletado com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AdicionarQuantidade(int id, int quantidade)
        {
            if (id <= 0 || quantidade <= 0)
            {
                MessageBox.Show("ID ou quantidade inválidos.");
                return;
            }

            var produto = repository.ObterProdutoPorId(id);
            if (produto == null)
            {
                MessageBox.Show("Produto com o ID fornecido não encontrado.");
                return;
            }

            int novaQuantidade = produto.Quantidade + quantidade;

            try
            {
                repository.AtualizarQuantidade(id, novaQuantidade);
                AtualizarTabela();
                MessageBox.Show($"Quantidade do produto {produto.NomeProduto} adicionada com sucesso! Nova quantidade: {novaQuantidade}", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DiminuirQuantidade(int id, int quantidade)
        {
            if (id <= 0 || quantidade <= 0)
            {
                MessageBox.Show("ID ou quantidade inválidos.");
                return;
            }

            var produto = repository.ObterProdutoPorId(id);
            if (produto == null)
            {
                MessageBox.Show("Produto com o ID fornecido não encontrado.");
                return;
            }

            int novaQuantidade = produto.Quantidade - quantidade;

            if (novaQuantidade < 0)
            {
                MessageBox.Show("Quantidade não pode ser negativa.");
                return;
            }

            try
            {
                repository.AtualizarQuantidade(id, novaQuantidade);
                AtualizarTabela();
                MessageBox.Show("Quantidade diminuída com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Produto ObterProdutoPorId(int id)
        {
            return repository.ObterProdutoPorId(id);
        }

        public void AtualizarTabela()
        {
            string query = "SELECT * FROM Produto;";
            List<Produto> produtos = repository.GetAll(query);
            tabela.DataSource = produtos;
        }
    }
}
