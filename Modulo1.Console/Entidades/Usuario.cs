namespace Modulo1.Console.Entidades
{
    internal class Usuario
    {
        public int Id { get; protected set; }
        public string Senha { get; protected set; }
        public string Login { get; protected set; }
        public string Nome { get; protected set; }        
        public TipoUsuario TipoUsuario { get; protected set; }
       
        protected Usuario()
        {

        }

        public static Usuario NovoUsuario(string senha, string login, string nome, TipoUsuario tipoUsuario)
        {
            Funcionario usuario = new Funcionario();
            usuario.Senha = senha;
            usuario.Login = login;
            usuario.Nome = nome;
            usuario.SetAtivo(true);
            usuario.TipoUsuario = tipoUsuario;

            return usuario;
        }
        

        public void AlterarSenha(string senha)
        {
            Senha = senha;
        }        
    }
}
