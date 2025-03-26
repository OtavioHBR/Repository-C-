using Form_PIM.Controller;
using System.Data.SqlClient;

namespace Form_PIM
{

    public partial class Login : Form
    {
        LoginFuncionarioController loginFuncionarioController;
        public Login()
        {


            InitializeComponent();
            SqlConnection sqlConnection = new SqlConnection();
        }
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            DataGridView dataGridView = new DataGridView();
            loginFuncionarioController = new LoginFuncionarioController(dataGridView);

            bool resultado = loginFuncionarioController.VerificarLogin(txtLogin.Text, mtxtPassword.Text);

            if (resultado)
            {
                MessageBox.Show("Login bem-sucedido!"); // Código adicional para navegação ou operação pós-login

                try
                {
                    // instância do formulário Menu
                    Menu menuForm = new Menu();

                    // Exibir o formulário Menu de forma não-modal
                    menuForm.Show();

                    // Ocultar o formulário atual de login
                    this.Hide();
                }
                catch (Exception ex)
                {
                    // Tratamento de erro caso o formulário Menu não exista ou haja outro problema
                    MessageBox.Show("Erro ao abrir o formulário Menu: " + ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Login falhou. Verifique suas credenciais.");
                mtxtPassword.Focus();
            }
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtLogin.Clear();
            mtxtPassword.Clear();

        }
    }
}

