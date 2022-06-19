namespace Aula06
{

    public class Nascimento
    {
        public string nome = "";
        public int idade;
        public const int anoAtual = 2022;
        public int anoNascimento;


        public int CalcularAnoNascimento()
        {
            anoNascimento = anoAtual - idade;
            return anoNascimento;
        }
        public void ApresentarUsuario()
        {
            Console.WriteLine($"Olá {nome}, você nasceu em {anoNascimento}");
        }

        public void pegarInput()
        {
            Console.Write("Digite seu Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Nascimento nasc = new();
            nasc.pegarInput();
            nasc.CalcularAnoNascimento();
            nasc.ApresentarUsuario();
        }
    }
}