namespace Form_PIM.Model
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int IdFornecedor { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
    }
}
