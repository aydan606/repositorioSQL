namespace Hotel
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva()
        {
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("Erro, operação impossível.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            Console.WriteLine($"Existem {Hospedes.Count} hóspedes cadastrados no hotel.");
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = 0;
            valorTotal = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valorTotal = DiasReservados * Suite.ValorDiaria * 0.9M;
            }

            return valorTotal;
        }
    }
}
