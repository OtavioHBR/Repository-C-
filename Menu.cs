namespace Form_PIM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Funcionario funcionario = new Cadastro.Funcionario();

            // Exibir o formulário Menu de forma não-modal
            funcionario.Show();

            // Ocultar o formulário atual de login
            this.Hide();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exibir uma mensagem de confirmação
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmar Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar a resposta do usuário
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void funcionáriosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Relatorios.Funcionario funcionario = new Relatorios.Funcionario();
            funcionario.Show();
            this.Hide();
        }

        private void adicionarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacional.LoginFuncionario loginFuncionario = new Operacional.LoginFuncionario();
            loginFuncionario.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cliente cliente = new Cadastro.Cliente();
            cliente.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Relatorios.Cliente cliente = new Relatorios.Cliente();
            cliente.Show();
            this.Hide();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Fornecedor fornecedor = new Cadastro.Fornecedor();
            fornecedor.Show();
            this.Hide();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cadastro.Produto produto = new Cadastro.Produto();
            produto.Show();
            this.Hide();
        }

        private void fornecedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Relatorios.Fornecedor fornecedor = new Relatorios.Fornecedor();
            fornecedor.Show();
            this.Hide();
        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.Produto produto = new Relatorios.Produto();
            produto.Show();
            this.Hide();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque.EntradaEstoque estoque = new Estoque.EntradaEstoque();
            estoque.Show();
            this.Hide();
        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque.SaidaEstoque saidaEstoque = new Estoque.SaidaEstoque();
            saidaEstoque.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Venda venda = new Relatorios.Venda();
            venda.Show();
            this.Hide();
        }
    }
}
