using System.ComponentModel;

namespace APIVENDAS.Models
{
    public class Bloco
    {

        public int Id { get; set; }

        public string NomeBloco { get; set; }
        public List<Rua> Ruas { get; set; }


    }
}
