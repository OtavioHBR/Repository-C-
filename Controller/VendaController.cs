using Form_PIM.Repository;
using System.Collections.Generic;
using System.Windows.Forms;
using Form_PIM.Model;

namespace Form_PIM.Controller
{
    public class VendaController
    {
        private VendaRepository repository;
        private DataGridView tabela;

        public VendaController(DataGridView tabela)
        {
            this.repository = new VendaRepository();
            this.tabela = tabela;
        }

        public void AtualizarTabela()
        {
            List<Venda> vendas = repository.GetAllVendas();
            tabela.DataSource = vendas;
        }
    }
}
