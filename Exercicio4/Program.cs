using System;
/**
 Alguns países medem temperaturas em graus Celsius, e outros em graus
Fahrenheit. Faça umalgoritmo para ler uma temperatura Celsius e imprimi-Ia em
Fahrenheit (pesquise como fazer estetipo de conversão).
 */
namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Fahrenheit(°F): ");
            double farh = double.Parse(Console.ReadLine());
            double farhParaCelcius = (farh - 32) * (5 / 9);
            Console.WriteLine($"\n{farh}°F equivale á {farhParaCelcius}°C.");

            string saida = "";
            do
            {
                Console.WriteLine("\n-Digite (s) para sair.");
                saida = Console.ReadLine();
            } while (saida != "s");
        }
    }
}
