namespace Pousada_Luar.Modelos;

internal class Reserva
{
    private List<Pessoa> Hospedes { get; set; }
    private Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
    {
        CadastrarHospedes(hospedes);
        CadastrarSuite(suite);
        DiasReservados = diasReservados;
    }

    private void CadastrarHospedes(List<Pessoa> pessoas)
    {
        if (pessoas.Count == 0)
        {
            throw new ArgumentNullException("Não há hóspedes para serem cadastrados na reserva.");
        }
        if(pessoas.Count > Suite.Capacidade)
        {
            throw new ArgumentOutOfRangeException("Não há capacidade suficiente para esse tanto de hóspedes na suíte selecionada.");
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

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
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


}
