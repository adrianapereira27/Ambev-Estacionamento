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

            if (diferenca.TotalHours >= 7 && diferenca.TotalHours <= 24) return 15;  // diária

            if (diferenca.TotalHours < 1 && diferenca.TotalMinutes <= 10) return 0;  // tolerância 10 min

            if (diferenca.TotalHours == 1)
            {
                valorTotalHoras = valorHora;
            }
            else
            {
                valorTotalHoras = valorHora + (decimal)((diferenca.TotalHours - 1) * valorAdicional);
            }

            if (diferenca.TotalMinutes <= 10)
            {
                return valorTotalHoras;
            }
            else if (diferenca.TotalMinutes <= 20)
            {
                if (diferenca.TotalHours == 1)
                {
                    return valorTotalHoras + valorHora / 60 * (decimal)diferenca.TotalMinutes;
                }
                else
                {
                    return valorTotalHoras + (decimal)valorAdicional / 60 * (decimal)diferenca.TotalMinutes;
                }
            }
            else
            {
                return (decimal)valorTotalHoras + (decimal)valorAdicional;
            }
        }
    }
}
