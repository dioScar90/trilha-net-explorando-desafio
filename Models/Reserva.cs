namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public int Desconto { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Desconto = DiasReservados < 10 ? 0 : 10;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            // *IMPLEMENTE AQUI*
            if (hospedes.Count > Suite.Capacidade)
            {
                throw new ArgumentException($"Capacidade excedida: Suíte comporta apenas {Suite.Capacidade} pessoas e foi tentado inicar reserva para {hospedes.Count}.");
            }
            
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = Suite.ValorDiaria * DiasReservados;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor -= (valor * Desconto / 100);
            }

            return valor;
        }
    }
}