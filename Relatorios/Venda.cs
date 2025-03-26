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
    public partial class Venda : Form
    {
        Controller.VendaController controller;
        public Venda()
        {
            InitializeComponent();
            controller = new Controller.VendaController(dataGridView1);
            controller.AtualizarTabela();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.AtualizarTabela();
        }

        private void vOLTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
