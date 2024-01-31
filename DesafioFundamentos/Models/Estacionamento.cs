using System.Reflection.PortableExecutable;

namespace DesafioFundamentos.Models
{
        //A classe estacionamento.
    public class Estacionamento
    {
        //Aqui são as variaveis declaradas.
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        //Aqui é o construtor que nasce junto com a classe.
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        //O método Adicionarveiculos.
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.Write($"Veículo com a placa {placa} adicionado com sucesso!");
        }

        //O método RemoverVeiculo.
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Coleta a informação que foi digitada
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Se o veiculo existe, vai executar o codigo abaixo
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //Declarando Variaveis.
                int horas = 0;
                decimal valorTotal = 0; 

                //Coleta a hora e converte para int
                horas = Convert.ToInt32(Console.ReadLine());

                // Realizando o calculo do valor total
                valorTotal = precoInicial + precoPorHora * (horas-1);

                //Aqui é removido o veiculo
                 veiculos.Remove(placa);

                Console.Write($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                // Se o veiculo não existe, vai executar o codigo abaixo
                Console.Write("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        // O método ListarVeiculos.
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Implementado!!!
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }

            }
            else
            {
                Console.Write("Não há veículos estacionados.");
            }
        }
    }
}
