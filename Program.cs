using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Jão", "Silveira");
Pessoa p2 = new Pessoa(nome: "Maria", "Silveira");
Pessoa p3 = new Pessoa(nome: "José", "Silveira Jr.");
Pessoa p4 = new Pessoa(nome: "Amora", "Silveira");
Pessoa p5 = new Pessoa(nome: "Pedro", "Pereira");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
hospedes.Add(p5);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 8, valorDiaria: 49.90M);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
