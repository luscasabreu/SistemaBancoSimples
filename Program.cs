using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n) ");
            char escolha = char.Parse(Console.ReadLine());

            Banco bank = new Banco(numero, nome);

            if(escolha == 's')
            {
                /*caso escolha fazer o primeiro depósito*/
                Console.WriteLine();
                Console.Write("Entre com o valor do depósito inicial: ");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bank.Deposito(quantia);

                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(bank);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(bank);
            }

            /*depositar*/
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double depositar = double.Parse(Console.ReadLine());
            bank.Deposito(depositar);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(bank);

            /*sacar*/
            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double sacar = double.Parse(Console.ReadLine());
            bank.Saque(sacar);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(bank);

        }
    }
}





