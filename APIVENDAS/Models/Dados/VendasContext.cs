using Microsoft.EntityFrameworkCore;

namespace APIVENDAS.Models.Dados
{
    public class VendasContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Bloco> Blocos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<EntradaDeProduto> EntradaDeProdutos { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Historico> Historicos { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Rua> Ruas { get; set; }
        public DbSet<TelefoneCliente> TelefoneClientes {get; set;}
        public DbSet<TelefoneUsuario> telefoneUsuarios { get; set; }
        public DbSet<Vendas> Vendass { get; set; }


        public VendasContext(DbContextOptions<VendasContext> options):base(options)
        {

        }


    }
}
