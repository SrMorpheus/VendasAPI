using Pomelo.EntityFrameworkCore.MySql.Query.ExpressionTranslators.Internal;

namespace APIVENDAS.Models
{
    public class Produto
    {

        public int Id { get ; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get ; set; }
        public int CategoriaId { get; set; }
        public int UsuarioId { get ; set; }

        public List<EntradaDeProduto> EntradasDeProduto { get; set; }
        public List<Vendas> VendasProduto { get; set; }
        public List<Historico> historicoPrdoduto { get; set; }
        public List<Estoque> EstoqueDeProduto { get; set; }




    }

    
}
