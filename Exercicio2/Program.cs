using System;
/**
 A padaria Hotpão vende uma certa quantidade de pães franceses e uma
quantidade de broas acada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$
1,50. Ao final do dia, o dono quer saberquanto arrecadou com a venda dos pães 
e broas (juntos), e quanto deve guardar numa conta depoupança (10% do total
arrecadado). Você foi contratado para fazer os cálculos para o dono. Combase
nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e
depois calcularos dados solicitados.
 */

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Padaria HotPão ----\n");
            Console.Write("\nDigite a quantidade de broas vendidas: ");
            int broa = int.Parse(Console.ReadLine());
            Console.Write("\nDigite a quantidade de pãos vendidos: ");
            int pao = int.Parse(Console.ReadLine());

            double valorTotal = broa * 0.12 + pao * 1.5;
            double valorFinal = (broa * 0.12 + pao * 1.5) * 0.9;
            double valorPoupanca = (broa * 0.12 + pao * 1.5) * 0.1;
            Console.WriteLine($"\nO valor total foi de {valorTotal.ToString("F")}R$.\n-Valor final: {valorFinal.ToString("F")}R$ \n-Valor guardado na poupança: {valorPoupanca.ToString("F")}R$\n");

            string saida = "";
            do
            {
                Console.WriteLine("-Digite (s) para sair.");
                saida = Console.ReadLine();
            } while (saida != "s");
        }
    }
}
