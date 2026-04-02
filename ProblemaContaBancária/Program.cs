using System;
using System.Globalization;

namespace ProblemaContaBancária
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor = 0;
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string bol = Console.ReadLine();
            
            ContaBancaria dadosconta = new ContaBancaria(conta, nome, valor);

            if (bol == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dadosconta = new ContaBancaria(conta, nome, valor);
            }
            else
            {
                dadosconta = new ContaBancaria(conta, nome);
            }


            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"{dadosconta}");


            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dadosconta.AdicionarDeposito(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"{dadosconta}");

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dadosconta.RemoverSaque(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"{dadosconta}");
        }
    }
}