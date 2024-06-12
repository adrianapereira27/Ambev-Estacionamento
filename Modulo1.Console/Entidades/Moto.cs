namespace Modulo1.Console.Entidades
{
    internal class Moto : Veiculo
    {
        public override void CadastrarVeiculo(string placa)
        {
            Placa = placa;
            TipoVeiculo = TipoVeiculo.Moto;
        }
    }
}
