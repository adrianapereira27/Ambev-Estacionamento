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
            
            if (diferenca.TotalHours >= 7 && diferenca.TotalHours <= 24 ) return 25;  // diária

            if (diferenca.TotalHours == 0 && diferenca.TotalMinutes <= 10) return 0;  // tolerância 10 min

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
                    return valorTotalHoras + valorAdicional / 60 * (decimal)diferenca.TotalMinutes;
                }
            }
            else
            {
                return valorTotalHoras + valorAdicional;
            }            
        }
    }
}
