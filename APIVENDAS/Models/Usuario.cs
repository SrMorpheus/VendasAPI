namespace APIVENDAS.Models
{
    public class Usuario
    {
        public int Id { get ; set; }
        public string Nome { get; set; }
        public string NomeEmpresa { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; } 
        public string Email { get; set; }
        public int RuaId { get; set; }
        public string ComplementoEndereco { get; set; }
        public bool Ativo { get; set; }
        public List<TelefoneUsuario> TelefonesUsuario { get; set; }
        public List <Produto> Produtos { get; set; }
        public List<EntradaDeProduto> EntradaDeProdutos { get; set;}

        public List<Vendas> VendasUsuario { get; set; }

        public List<Estoque> EstoqueUsuario { get; set; }

        public List<Historico> HistoricoUsuario { get; set; }

    }
}
