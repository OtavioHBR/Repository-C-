using Form_PIM.Model;
using Form_PIM.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Form_PIM.Controller
{
    public class FornecedorController
    {
        private FornecedorRepository repository;
        private DataGridView tabela;

        public FornecedorController(DataGridView tabela)
        {
            this.repository = new FornecedorRepository();
            this.tabela = tabela;
        }

        public void AdicionarFornecedor(string nome, string telefone, string email, string endereco, string cnpj)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(endereco) || string.IsNullOrEmpty(cnpj))
            {
                MessageBox.Show("Nome, telefone, endereço ou CNPJ não foram fornecidos corretamente.");
                return;
            }

            Fornecedor fornecedor = new Fornecedor
            {
                Nome = nome,
                Telefone = telefone,
                Email = email,
                Endereco = endereco,
                Cnpj = cnpj
            };

            try
            {
                repository.Adicionar(fornecedor);
                AtualizarTabela();
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AtualizarFornecedor(int id, string nome, string telefone, string email, string endereco, string cnpj)
        {
            if (id <= 0 || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(endereco) || string.IsNullOrEmpty(cnpj))
            {
                MessageBox.Show("Um ou mais campos não foram fornecidos corretamente.");
                return;
            }

            Fornecedor fornecedor = new Fornecedor
            {
                IdFornecedor = id,
                Nome = nome,
                Telefone = telefone,
                Email = email,
                Endereco = endereco,
                Cnpj = cnpj
            };

            repository.Atualizar(fornecedor);
            AtualizarTabela();
            MessageBox.Show("Fornecedor atualizado com sucesso!");
        }

        public void DeletarFornecedor(int id)
        {
            if (id <= 0)
            {
                MessageBox.Show("O ID de exclusão não foi fornecido corretamente.");
                return;
            }

            var fornecedor = repository.ObterFornecedorPorId(id);
            if (fornecedor == null)
            {
                MessageBox.Show("Fornecedor com o ID fornecido não encontrado.");
                return;
            }

            DialogResult result = MessageBox.Show("Tem certeza de que deseja deletar o fornecedor?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                repository.Deletar(id);
                AtualizarTabela();
                MessageBox.Show("Fornecedor deletado com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AtualizarTabela()
        {
            string query = "SELECT * FROM Fornecedor;";
            List<Fornecedor> fornecedores = repository.GetAll(query);
            tabela.DataSource = fornecedores;
        }

        public void PesquisarFornecedorPorNome(string nome)
        {
            List<Fornecedor> fornecedores = repository.PesquisarPorNome(nome);
            tabela.DataSource = fornecedores;
        }
    }
}
