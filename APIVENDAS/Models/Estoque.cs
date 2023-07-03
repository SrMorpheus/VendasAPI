namespace APIVENDAS.Models
{
    public class Estoque
    {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public int UsuarioId { get; set; }
        public bool Ativo { get; set; }


    }
}
