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
                MessageBox.Show("Login bem-sucedido!"); // C�digo adicional para navega��o ou opera��o p�s-login

                try
                {
                    // inst�ncia do formul�rio Menu
                    Menu menuForm = new Menu();

                    // Exibir o formul�rio Menu de forma n�o-modal
                    menuForm.Show();

                    // Ocultar o formul�rio atual de login
                    this.Hide();
                }
                catch (Exception ex)
                {
                    // Tratamento de erro caso o formul�rio Menu n�o exista ou haja outro problema
                    MessageBox.Show("Erro ao abrir o formul�rio Menu: " + ex.Message);

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

