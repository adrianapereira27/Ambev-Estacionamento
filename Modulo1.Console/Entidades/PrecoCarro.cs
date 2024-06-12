namespace Modulo1.Console.Entidades
{
    internal class PrecoCarro : Preco
    {
        public override decimal CalcularPreco(Ticket ticket)
        {
            var valorHora = 10;
            var valorAdicional = 2;
            decimal valorTotalHoras = 0;

            TimeSpan diferenca = (TimeSpan)(ticket.DataHoraSaida - ticket.DataHoraEntrada);

            if (ticket.DataHoraEntrada.Hour >= 21) return 15;  // pernoite

            if (diferenca.Hours >= 7 && diferenca.Hours <= 24) return 25;  // diária

            if (diferenca.Hours == 0 && diferenca.Minutes <= 10) return 0;  // tolerância 10 min

            if (diferenca.Hours == 1)
            {
                valorTotalHoras = valorHora;
            }
            else
            {
                valorTotalHoras = Math.Round(valorHora + (decimal)((diferenca.Hours - 1) * valorAdicional), 2);
            }

            if (diferenca.Minutes <= 10)
            {
                return valorTotalHoras;
            }
            else if (diferenca.Minutes <= 20)
            {
                if (diferenca.Hours == 1)
                {
                    return Math.Round(valorTotalHoras + valorHora / 60 * (decimal)diferenca.Minutes, 2);
                }
                else
                {
                    return Math.Round(valorTotalHoras + valorAdicional / 60 * (decimal)diferenca.Minutes, 2);
                }
            }
            else
            {
                return Math.Round(valorTotalHoras + valorAdicional, 2);
            }
        }
    }
}
