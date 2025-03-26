using Form_PIM.Model;
using Form_PIM.Repository;

namespace Form_PIM.Controller
{
    public class LoginFuncionarioController
    {
        private LoginFuncionarioRepository repository;
        private DataGridView tabela;

        public LoginFuncionarioController(DataGridView tabela)
        {
            this.repository = new LoginFuncionarioRepository();
            this.tabela = tabela;
        }

        public void AdicionarLoginFuncionario(string loginFunc, string senhaFunc)
        {
            if (string.IsNullOrEmpty(loginFunc) || string.IsNullOrEmpty(senhaFunc))
            {
                MessageBox.Show("Login ou senha não foram fornecidos corretamente.");
                return;
            }

            LoginFuncionario loginFuncionario = new LoginFuncionario
            {
                IdFuncionario = int.Parse(loginFunc),
                SenhaFunc = senhaFunc
            };

            try
            {
                repository.Adicionar(loginFuncionario);
                AtualizarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AtualizarLoginFuncionario(string idEditar, string loginFuncEditar, string senhaFuncEditar)
        {
            if (string.IsNullOrEmpty(idEditar) || string.IsNullOrEmpty(loginFuncEditar) || string.IsNullOrEmpty(senhaFuncEditar))
            {
                MessageBox.Show("Um ou mais campos não foram fornecidos corretamente.");
                return;
            }

            LoginFuncionario loginFuncionario = new LoginFuncionario
            {
                IdLoginFuncionario = int.Parse(idEditar),
                IdFuncionario = int.Parse(loginFuncEditar),
                SenhaFunc = senhaFuncEditar
            };

            repository.Atualizar(loginFuncionario);
            AtualizarTabela();
        }

        public void DeletarLoginFuncionario(string idExcluir)
        {
            if (string.IsNullOrEmpty(idExcluir))
            {
                MessageBox.Show("O ID de exclusão não foi fornecido corretamente.");
                return;
            }

            int id = int.Parse(idExcluir);
            repository.Deletar(id);
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            List<LoginFuncionario> logins = repository.GetAll();
            tabela.DataSource = logins;
        }

        public bool VerificarLogin(string loginFunc, string senhaFunc)
        {
            if (string.IsNullOrEmpty(loginFunc) || string.IsNullOrEmpty(senhaFunc))
            {
                MessageBox.Show("Login ou senha não foram fornecidos corretamente.");
                return false;
            }

            if (!int.TryParse(loginFunc, out int loginFuncInt))
            {
                MessageBox.Show("Login deve ser um número válido.");
                return false;
            }

            return repository.VerificarLogin(loginFuncInt, senhaFunc);
        }
    }
}
