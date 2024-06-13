namespace Modulo1.Console.Entidades
{
    internal class Admin : Usuario
    {

        public void InativarUsuario(Funcionario funcionario)
        {
            funcionario.SetAtivo(false);
        }
    }
}
