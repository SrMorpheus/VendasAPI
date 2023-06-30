namespace APIVENDAS.Models
{
    public class Login
    {

        public int Id { get; set; }
        public string CPF { get ; set; }
        public string LoginUsuario { get; set; }
        public string Senha { get; set; }
        public string UsuarioId { get; set; }
        public Usuario UsuarioLogin { get; set; }


    }
}
