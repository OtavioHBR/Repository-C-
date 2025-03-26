using Form_PIM.Model;
using Form_PIM.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Form_PIM.Controller
{
    public class FuncionarioController
    {
        private FuncionarioRepository repository;
        private DataGridView tabela;

        public FuncionarioController(DataGridView tabela)
        {
            this.repository = new FuncionarioRepository();
            this.tabela = tabela;
        }

        public void AdicionarFuncionario(string nome, string cargo, decimal salario, TimeSpan horaEntrada, TimeSpan horaSaida, DateTime dataContratacao)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cargo))
            {
                MessageBox.Show("Nome ou cargo não foram fornecidos corretamente.");
                return;
            }

            Funcionario funcionario = new Funcionario
            {
                Nome = nome,
                Cargo = cargo,
                Salario = salario,
                HoraEntrada = horaEntrada,
                HoraSaida = horaSaida,
                DataContratacao = dataContratacao
            };

            try
            {
                repository.Adicionar(funcionario);
                AtualizarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AtualizarFuncionario(int id, string nome, string cargo, decimal salario, TimeSpan horaEntrada, TimeSpan horaSaida, DateTime dataContratacao)
        {
            if (id <= 0 || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cargo))
            {
                MessageBox.Show("Um ou mais campos não foram fornecidos corretamente.");
                return;
            }

            Funcionario funcionario = new Funcionario
            {
                IdFuncionario = id,
                Nome = nome,
                Cargo = cargo,
                Salario = salario,
                HoraEntrada = horaEntrada,
                HoraSaida = horaSaida,
                DataContratacao = dataContratacao
            };

            repository.Atualizar(funcionario);
            AtualizarTabela();
        }

        public void DeletarFuncionario(int id)
        {
            if (id <= 0)
            {
                MessageBox.Show("O ID de exclusão não foi fornecido corretamente.");
                return;
            }

            var funcionario = repository.ObterFuncionarioPorId(id);
            if (funcionario == null)
            {
                MessageBox.Show("Funcionário com o ID fornecido não encontrado.");
                return;
            }

            DialogResult result = MessageBox.Show("Tem certeza de que deseja deletar o funcionário?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                repository.Deletar(id);
                AtualizarTabela();
                MessageBox.Show("Funcionário deletado com sucesso.");
            }
        }

        public void AtualizarTabela()
        {
            string query = "SELECT * FROM Funcionario;";
            List<Funcionario> funcionarios = repository.GetAll(query);
            tabela.DataSource = funcionarios;
        }

        public void PesquisarFuncionarioPorNome(string nome)
        {
            List<Funcionario> funcionarios = repository.PesquisarPorNome(nome);
            tabela.DataSource = funcionarios;
        }
    }
}
