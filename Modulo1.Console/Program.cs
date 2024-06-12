

using Modulo1.Console.Entidades;

//Usuario usuario = new Usuario();
//usuario.NovoUsuario("123", "tg", "Thamirys", TipoUsuario.Admin);

Usuario usuarioEstatico = Usuario.NovoUsuario("123", "tg", "Thamirys", TipoUsuario.Admin);

//usuarioEstatico.InativarUsuario();


DateTime DataHoraAtual = DateTime.Now;

Carro carro = new Carro();
carro.CadastrarVeiculo("AAA1234");

Ticket ticketCarro = new Ticket();
ticketCarro.CriarTicket(carro, DataHoraAtual, usuarioEstatico);

TimeSpan horaAdicionada = new TimeSpan(4, 15, 0);
ticketCarro.DataHoraSaida = DataHoraAtual.Add(horaAdicionada);

PrecoCarro precoCarro = new PrecoCarro();

var precoFinalCarro = precoCarro.CalcularPreco(ticketCarro);

ticketCarro.StatusTicket = StatusTicket.Pago;

Console.WriteLine($"O valor final do carro com placa {carro.Placa} é R$ {precoFinalCarro}.");
Console.WriteLine($"O tempo de permanência é {horaAdicionada}.");

Console.WriteLine();


Moto moto = new Moto();
moto.CadastrarVeiculo("BBB1478");

Ticket ticketMoto = new Ticket();
ticketMoto.CriarTicket(carro, DataHoraAtual, usuarioEstatico);

TimeSpan horaAdicionada2 = new TimeSpan(0, 10, 0);
ticketMoto.DataHoraSaida = DataHoraAtual.Add(horaAdicionada2);

PrecoMoto precoMoto = new PrecoMoto();

var precoFinalMoto = precoMoto.CalcularPreco(ticketMoto);

ticketMoto.StatusTicket = StatusTicket.Pago;

Console.WriteLine($"O valor final da moto com placa {moto.Placa} é R$ {precoFinalMoto}.");
Console.WriteLine($"O tempo de permanência é {horaAdicionada2}.");

Console.ReadLine();