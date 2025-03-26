using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_PIM.Model
{
    public class Venda 
    { 
        public int IdVenda { get; set; } 
        public string IdCliente { get; set; } 
        public int IdFuncionario { get; set; } 
        public int IdProduto { get; set; } 
        public DateTime DataVenda { get; set; } 
        public string Produto { get; set; } 
    }
}
