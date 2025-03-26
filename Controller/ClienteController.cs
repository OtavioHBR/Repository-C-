using Form_PIM.Model;
using Form_PIM.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Form_PIM.Controller
{
    public class ClienteController
    {
        private ClienteRepository repository;
        private DataGridView tabela;

        public ClienteController(DataGridView tabela)
        {
            this.repository = new ClienteRepository();
            this.tabela = tabela;
        }

        public void AdicionarCliente(string cpf, string nome, string telefone, string email, string endereco)
        {
            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("CPF, nome, telefone ou endereço não foram fornecidos corretamente.");
                return;
            }

            Cliente cliente = new Cliente
            {
                Cpf = cpf,
                Nome = nome,
                Telefone = telefone,
                Email = email,
                Endereco = endereco
            };

            try
            {
                repository.Adicionar(cliente);
                AtualizarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AtualizarCliente(string cpf, string nome, string telefone, string email, string endereco)
        {
            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("Um ou mais campos não foram fornecidos corretamente.");
                return;
            }

            Cliente cliente = new Cliente
            {
                Cpf = cpf,
                Nome = nome,
                Telefone = telefone,
                Email = email,
                Endereco = endereco
            };

            repository.Atualizar(cliente);
            AtualizarTabela();
        }

        public void DeletarCliente(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("O CPF de exclusão não foi fornecido corretamente.");
                return;
            }

            var cliente = repository.ObterClientePorId(cpf);
            if (cliente == null)
            {
                MessageBox.Show("Cliente com o CPF fornecido não encontrado.");
                return;
            }

            DialogResult result = MessageBox.Show("Tem certeza de que deseja deletar o cliente?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                repository.Deletar(cpf);
                AtualizarTabela();
                MessageBox.Show("Cliente deletado com sucesso.");
            }
        }

        public void AtualizarTabela()
        {
            string query = "SELECT * FROM Cliente;";
            List<Cliente> clientes = repository.GetAll(query);
            tabela.DataSource = clientes;
        }

        public void PesquisarClientePorNome(string nome)
        {
            List<Cliente> clientes = repository.PesquisarPorNome(nome);
            tabela.DataSource = clientes;
        }
    }
}
