﻿namespace Modulo1.Console.Entidades
{
    internal abstract class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }
        public string? Cor { get; set; }

        public abstract void CadastrarVeiculo(string placa);

    }
}
