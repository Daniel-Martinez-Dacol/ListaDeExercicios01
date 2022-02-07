using System;
/**
 Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir 
quantos dias de vidaela possui. Considere sempre anos completos, e que um 
ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja
um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
*/
namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n-Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("\n-Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            int conversor = idade * 365;
            Console.WriteLine($"\n{nome.ToUpper()}, VOCE JA VIVEU {conversor} DIAS. ");

            string saida = "";
            do
            {
                Console.WriteLine("\n-Digite (s) para sair.");
                saida = Console.ReadLine();
            } while (saida != "s");
        }
    }
}
