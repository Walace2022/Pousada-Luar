
using Pousada_Luar.Modelos;

Suite basica = new Suite("Basica", 2, 70.00M);
Suite dupla = new Suite("Dupla", 4, 140.70M);
Suite premium = new Suite("Premium", 8, 261.62M);

Pessoa paulo = new Pessoa("Paulo", "Almeida");
Pessoa andre = new Pessoa("Andre", "Barros");
Pessoa maria = new Pessoa("Maria", "Freitas");

List<Pessoa> hospedes = new List<Pessoa>() { paulo , andre ,maria};

try
{   
    Reserva reservaFevereiro = new Reserva(hospedes, dupla, 7);
    reservaFevereiro.DetalhesReserva();
    Reserva reservaMarço = new Reserva(hospedes, premium, 10);
    reservaMarço.DetalhesReserva();

    //Teste de capacidade 
    //Reserva reservaJaneiro = new Reserva(hospedes, basica, 5);

    //Teste 0 hóspedes
    //Reserva reservaJaneiro = new Reserva(new List<Pessoa>(), basica, 5);

}
catch (Exception e)
{
    Console.WriteLine($"Aconteceu um erro: {e.Message}");
}
