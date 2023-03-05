using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double gasolina = 0.0, alcool = 0.0;
        double rentabilidade = 0.0;
        string combustivel;

        void Entrada()
        {
            Console.WriteLine("Digite o preço da gasolina:");
            gasolina = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o preço do alcool:");
            alcool = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        void CalculoRentabilidade()
        {
            rentabilidade = alcool / gasolina;
        }

        void Verificacao()
        {
            if (rentabilidade > 0.72)
            {
                combustivel = "gasolina";
                Saida();
            }
            else
            {
                combustivel = "alcool";
                Saida();
            }
        }

        void Saida()
        {
            Console.WriteLine("Deve abastecer com " + combustivel);
        }

        Entrada();
        CalculoRentabilidade();
        Verificacao();
    }
}