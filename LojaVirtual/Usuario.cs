namespace ProjetoHeranca.LojaVirtual
{
    public class Usuario
    {
        public string Nome {get;}
        public string Email {get;set;}

        public Usuario(string nomeDoUsuario, string emailDoUsuario)
        {
            Nome = nomeDoUsuario;
            Email = emailDoUsuario;
        }
    }
}

//
 