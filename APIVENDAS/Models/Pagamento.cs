using APIVENDAS.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace APIVENDAS.Models
{
    public class Pagamento
    {

        public int Id { get; set; }
        [DataType(DataType.Text)]
        public TiposDePagamentos TiposDePagamentos { get; set; }

        public List<Vendas> VendasPagamento { get; set; }

    }
}
