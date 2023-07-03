using APIVENDAS.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace APIVENDAS.Models
{
    public class Historico
    {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public int UsuarioId { get ; set; }
        [DataType(DataType.Text)]
        public TiposDeMovimentacao TipoDeHistorico { get; set; }

    }
}
