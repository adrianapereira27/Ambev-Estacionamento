namespace Modulo1.Console.Entidades
{
    internal class PrecoMoto : Preco
    {
        public override decimal CalcularPreco(Ticket ticket)
        {
            var valorHora = 7;
            var valorAdicional = 0.5;
            decimal valorTotalHoras = 0;

            TimeSpan diferenca = (TimeSpan)(ticket.DataHoraSaida - ticket.DataHoraEntrada);

            if (ticket.DataHoraEntrada.Hour >= 21) return 10;  // pernoite

            if (diferenca.Hours >= 7 && diferenca.Hours <= 24) return 15;  // diária

            if (diferenca.Hours == 1 && diferenca.Minutes <= 10) return 0;  // tolerância 10 min

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
                    return Math.Round(valorTotalHoras + (decimal)valorAdicional / 60 * (decimal)diferenca.Minutes, 2);
                }
            }
            else
            {
                return Math.Round((decimal)valorTotalHoras + (decimal)valorAdicional, 2);
            }
        }
    }
}
