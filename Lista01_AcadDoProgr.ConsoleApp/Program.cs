using System;
/**A imobiliária Imóbilis vende apenas terrenos retangulares. 
Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
*/

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a largura do terreno: ");
            double largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a comprimento do terreno: ");
            double comprimento = double.Parse(Console.ReadLine());

            double area = largura * comprimento;

            Console.WriteLine($"A area do terreno é de {area}m²");
            string saida = "";
            do
            {
                Console.Write("Digite (s) para sair: ");
                saida = Console.ReadLine();

            } while (saida != "s");

        }
    }
}
