using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_PIM.Relatorios
{
    public partial class Cliente : Form
    {
        Controller.ClienteController controller;
        public Cliente()
        {
            InitializeComponent();
            controller = new Controller.ClienteController(dataGridView1);
            controller.AtualizarTabela();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro.Cliente cliente = new Cadastro.Cliente();
            cliente.Show();
            this.Close();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.AtualizarTabela();
        }
    }
}
