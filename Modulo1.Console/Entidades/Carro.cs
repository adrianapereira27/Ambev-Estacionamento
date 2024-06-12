namespace Modulo1.Console.Entidades
{
    internal class Carro : Veiculo
    {
        public override void CadastrarVeiculo(string placa)
        {
            Placa = placa;
            TipoVeiculo = TipoVeiculo.Carro;
        }
    }
}
