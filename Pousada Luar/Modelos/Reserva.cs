namespace Pousada_Luar.Modelos;

internal class Reserva
{
    private List<Pessoa> Hospedes { get; set; }
    private Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
    {
        CadastrarSuite(suite);
        CadastrarHospedes(hospedes);
        DiasReservados = diasReservados;
    }

    private void CadastrarHospedes(List<Pessoa> pessoas)
    {
        if (pessoas.Count == 0)
        {
            throw new Exception("Não há hóspedes para serem cadastrados na reserva.");
        }
        if(pessoas.Count > Suite.Capacidade)
        {
            throw new Exception($"A suíte {Suite.TipoSuite} não tem capacidade para {pessoas.Count} hóspedes.");
        }
        Hospedes = pessoas;
    }

    private void CadastrarSuite(Suite suite)
    {
        if (suite == null)
        {
            throw new ArgumentNullException("Suite inválida ou não cadastrada.");
        }
        Suite = suite;

    }

    public decimal CalcularValorDiaria()
    {
        decimal valorTotal = DiasReservados * Suite.ValorDiaria;
        if (DiasReservados >= 10)
        {
            return valorTotal * 0.9M;
        }
        return valorTotal;
    }

    public void DetalhesReserva()
    {
        Console.WriteLine($"Os {Hospedes.Count} hóspedes:");
        foreach(Pessoa p in Hospedes)
        {
            Console.WriteLine($" - {p.Nome} {p.Sobrenome}");
        }
        Console.WriteLine($"Estão em uma suíte {Suite.TipoSuite}.");
        Console.WriteLine($"Com reserva para {DiasReservados} dias no valor de {CalcularValorDiaria():C2}.");
    }


}
