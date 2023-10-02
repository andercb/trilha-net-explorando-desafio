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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // ok - *IMPLEMENTE AQUI*

            int capacidade = Suite.Capacidade;
        
            if (capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
             else
             {
                 // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                 // ok - *IMPLEMENTE AQUI*
                 throw new Exception("\n\nATENCAO: CAPACIDADE DA SUITE INFERIOR AO NUMERO DE HOSPEDES!\n\n");
             }
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // ok - *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // ok - *IMPLEMENTE AQUI*            
            decimal valor = DiasReservados * Suite.ValorDiaria;           

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // ok - *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {

                Console.WriteLine($">> Desconto: {valor - (valor * 0.9M):C}");
                return valor * (0.9M);
            }
           return valor;
        }
    }
}