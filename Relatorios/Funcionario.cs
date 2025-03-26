using Form_PIM.Controller;

namespace Form_PIM.Relatorios
{
    public partial class Funcionario : Form
    {

        private FuncionarioController controller;
        public Funcionario()
        {
            InitializeComponent();
            controller = new FuncionarioController(dataGridView1); // Certifique-se de passar o DataGridView correto                  
            controller.AtualizarTabela(); // Inicializa a tabela com os dados existentes }
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instância do formulário do menu inicial
            Menu menuInicialForm = new Menu();

            // Exibir o formulário do menu inicial de forma não-modal
            menuInicialForm.Show();

            // Fechar o formulário atual
            this.Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Funcionario funcionario = new Cadastro.Funcionario();
            funcionario.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.AtualizarTabela();
        }
    }
}
