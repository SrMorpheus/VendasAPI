namespace APIVENDAS.Models
{
    public class Vendas
    {

        public int Id { get; set; } 
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataVenda { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public int PagamentoId { get; set; }
        public string Observcao { get; set; }



    }
}
