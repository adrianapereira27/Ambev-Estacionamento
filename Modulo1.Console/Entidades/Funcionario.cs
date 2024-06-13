namespace Modulo1.Console.Entidades
{
    internal class Funcionario : Usuario
    {
        public bool Ativo { get; protected set; }
        public string DataAdmissao { get; protected set; }
        public string? DataDemissao { get; protected set; }

        public void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }
    }
}
