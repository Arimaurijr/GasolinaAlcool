using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double gasolina = 0.0, alcool = 0.0;
        double rentabilidade = 0.0;

        Console.WriteLine("Digite o preço da gasolina:");
        gasolina = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o preço do alcool:");
        alcool = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        rentabilidade = alcool / gasolina;

        if (rentabilidade > 0.72)
        {
            Console.WriteLine("Deve abastecer com GASOLINA !");
        }
        else
        {
            Console.WriteLine("Deve abastecer com ALCOOL !");
        }
    }
}