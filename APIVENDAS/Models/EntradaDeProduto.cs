namespace APIVENDAS.Models
{
    public class EntradaDeProduto
    {

        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public int ProdutoId { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public int UsuarioId { get; set; }  



    }
}
