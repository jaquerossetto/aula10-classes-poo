namespace Aula07
{
    public class CompraDolar
    {
        // Atributos da classe
        public double cotacaoDoDolarHoje = 4.97;
        public const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
        public const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;

        //Metodos da classe
        public string converterRealParaDolar(double valorDaCompraEmReais)
        {

            double valorDaCompraEmDolar = valorDaCompraEmReais / cotacaoDoDolarHoje;
            string mensagem = "";
            if (valorDaCompraEmDolar < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
            {
                mensagem = $"A compra mínima permitida é de ${VALOR_MINIMO_DE_COMPRA_EM_DOLAR}";

            }
            else if (valorDaCompraEmDolar > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
            {
                mensagem = $"A compra máxima permitida é de ${VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}";
            }
            else
            {
                mensagem = $"Você pode comprar ${Math.Round(valorDaCompraEmDolar, 2)}";
            }
            return mensagem;
        }

        public string valorParaConverter()
        {
            string mensagem = "";
            Console.WriteLine("Quanto deseja converter para dolares?");
            double.TryParse(Console.ReadLine(), out double valorDaCompraEmReais);
            mensagem = (converterRealParaDolar(valorDaCompraEmReais));
            Console.WriteLine(converterRealParaDolar(valorDaCompraEmReais));
            return mensagem;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            CompraDolar dolar = new();
            dolar.valorParaConverter();

        }
    }
}