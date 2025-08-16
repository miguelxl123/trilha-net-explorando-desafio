namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
        
            if (Suite.Capacidade >= hospedes.Count && hospedes.Count > 0)
            {
                Hospedes = hospedes;
            }
            else
            {

                throw new ArgumentException("Capacidade insuficiente para o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
          
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
           
            int ValorDiaria = DiasReservados * (int)Suite.ValorDiaria;
            decimal valor = ValorDiaria;

    
            if (DiasReservados >= 10)
            {
                valor = 0.9m * ValorDiaria; 
            }

            return valor;
        }
    }
}