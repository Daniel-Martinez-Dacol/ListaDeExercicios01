using System;
/**
 Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
Após o aumento,desconte 8% de impostos. Imprima o salário inicial, o salário
com o aumento e o salário final. 
 */
namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salário do funcionário: ");
            double salarioInicial = double.Parse(Console.ReadLine());
            double salarioAumento = salarioInicial * 1.15;
            double salarioImposto = salarioAumento * 0.92;

            Console.WriteLine($"\n-Salario Inicial: {salarioInicial}R$\n-Salario com o aumento: {salarioAumento}R$\n-Salario final: {salarioImposto}R$");

            string saida = "";
            do
            {
                Console.WriteLine("\n-Digite (s) para sair.");
                saida = Console.ReadLine();
            } while (saida != "s");
        }
    }
}
