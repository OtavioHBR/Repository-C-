using Form_PIM.Controller;
using System.Globalization;

namespace Form_PIM.Cadastro
{
    public partial class Funcionario : Form
    {
        private FuncionarioController funcionarioController;
        public Funcionario()
        {
            InitializeComponent();
            funcionarioController = new FuncionarioController(dataGridView1); // Certifique-se de passar o DataGridView correto                  
            funcionarioController.AtualizarTabela(); // Inicializa a tabela com os dados existentes }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            funcionarioController.AtualizarTabela();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAdd.Text; // Assumindo que o TextBox para o nome do funcionário é chamado txtNome
            string cargo = txtCargoAdd.Text; // Assumindo que o TextBox para o cargo do funcionário é chamado txtCargo

            decimal salario;
            if (!decimal.TryParse(mtbSalAdd.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out salario))
            {
                MessageBox.Show("Salário inválido.");
                return;
            }

            TimeSpan horaEntrada;
            if (!TimeSpan.TryParse(mtbHEAdd.Text, out horaEntrada)) // Assumindo que o MaskedTextBox para hora de entrada é chamado mtxtHoraEntrada
            {
                MessageBox.Show("Hora de entrada inválida.");
                return;
            }

            TimeSpan horaSaida;
            if (!TimeSpan.TryParse(mtbHSAdd.Text, out horaSaida)) // Assumindo que o MaskedTextBox para hora de saída é chamado mtxtHoraSaida
            {
                MessageBox.Show("Hora de saída inválida.");
                return;
            }

            DateTime dataContratacao = dateTimePickerAdd.Value; // Assumindo que o DateTimePicker para data de contratação é chamado dtpDataContratacao

            FuncionarioController controller = new FuncionarioController(dataGridView1);
            controller.AdicionarFuncionario(nome, cargo, salario, horaEntrada, horaSaida, dataContratacao);

            // Mensagem de confirmação
            MessageBox.Show("Funcionário adicionado com sucesso!");
        }



        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            txtNomeAdd.Clear();
            txtCargoAdd.Clear();
            mtbHEAdd.Clear();
            mtbHSAdd.Clear();
            mtbSalAdd.Clear();
        }

        private void tABELADEFUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Funcionario funcionario = new Relatorios.Funcionario();
            funcionario.Show();
            this.Close();
        }

        private void btnCancelDel_Click(object sender, EventArgs e)
        {
            txtIdDel.Clear();
        }

        private void btnConfirmDel_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdDel.Text, out int funcionarioId))
            {
                FuncionarioController controller = new FuncionarioController(dataGridView1);
                controller.DeletarFuncionario(funcionarioId);
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de funcionário válido.");
            }
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            funcionarioController = new FuncionarioController(dataGridView1);

            try
            {
                int id = int.Parse(txtIdEdit.Text);
                string nome = txtNomeEdit.Text;
                string cargo = txtProfEdit.Text;

                decimal salario;
                if (!decimal.TryParse(mtbSalEdit.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out salario))
                {
                    MessageBox.Show("Salário inválido.");
                    return;
                }

                TimeSpan horaEntrada = TimeSpan.Parse(mtbHEEdit.Text);
                TimeSpan horaSaida = TimeSpan.Parse(mtbHSEdit.Text);
                DateTime dataContratacao = DateTime.Parse(dateTimePickerEdit.Text);

                funcionarioController.AtualizarFuncionario(id, nome, cargo, salario, horaEntrada, horaSaida, dataContratacao);
                MessageBox.Show("Funcionário atualizado com sucesso.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos em todos os campos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }


        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            txtIdEdit.Clear();
            txtNomeEdit.Clear();
            txtProfEdit.Clear();
            mtbHSEdit.Clear();
            mtbHEEdit.Clear();
            mtbSalEdit.Clear();
        }
    }
}
